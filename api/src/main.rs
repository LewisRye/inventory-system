mod models;

use std::net::SocketAddr;
use std::env;

use chrono::Utc;
use dotenv::dotenv;
use http_body_util::{combinators::BoxBody, BodyExt, Full, Empty};
use hyper::body::Bytes;
use hyper::server::conn::http1;
use hyper::service::service_fn;
use hyper::{Method, Request, Response, StatusCode};
use hyper_util::rt::TokioIo;
use models::Product;
use rusqlite::{params, Connection, Result};
use tokio::net::TcpListener;

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error + Send + Sync>> {
    dotenv().ok();

    let addr = SocketAddr::from(([127, 0, 0, 1], 3000));

    // We create a TcpListener and bind it to 127.0.0.1:3000
    let listener = TcpListener::bind(addr).await?;

    println!("{}: Server Online", Utc::now());

    // We start a loop to continuously accept incoming connections
    loop {
        let (stream, _) = listener.accept().await?;

        // Use an adapter to access something implementing `tokio::io` traits as if they implement
        // `hyper::rt` IO traits.
        let io = TokioIo::new(stream);

        // Spawn a tokio task to serve multiple connections concurrently
        tokio::task::spawn(async move {
            // Finally, we bind the incoming connection to our `hello` service
            if let Err(err) = http1::Builder::new()
                // `service_fn` converts our function in a `Service`
                .serve_connection(io, service_fn(handle_request))
                .await
            {
                eprintln!("{}: Error serving connection: {:?}", Utc::now(), err);
            }
        });
    }
}

/* METHODS TO HANDLE HTTP REQUESTS */

async fn handle_request(
    req: Request<hyper::body::Incoming>,
) -> Result<Response<BoxBody<Bytes, hyper::Error>>, hyper::Error> {
    match (req.method(), req.uri().path().split("/").nth(1)) {
        (&Method::POST, Some("echo")) => {
            println!("{}: POST echo", Utc::now());
            Ok(Response::new(req.into_body().boxed()))
        }

        (&Method::POST, Some("login")) => {
            let user_header = req.headers().get("user"); // Get the header value for "user"
            let user_str: Option<&str> = user_header.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>
            
            let pass_header = req.headers().get("pass"); // Get the header value for "pass"
            let pass_str: Option<&str> = pass_header.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>

            println!("{}: POST login: {} {}", Utc::now(), user_str.unwrap_or_default(), pass_str.unwrap_or_default());

            if login(user_str.as_deref(), pass_str.as_deref()).unwrap_or(false) {
                // Construct a 200 OK response
                let response = Response::builder()
                .status(StatusCode::OK)
                .body(empty())
                .unwrap();
                return Ok(response);
            } else {
                // Construct a 401 Unauthorized response
                let response = Response::builder()
                .status(StatusCode::UNAUTHORIZED)
                .body(empty())
                .unwrap();
                return Ok(response);
            }
        },

        (&Method::POST, Some("create_account")) => {
            let level_header = req.headers().get("level"); // Get the header value for "user"
            let level_str: Option<&str> = level_header.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>

            let user_header = req.headers().get("user"); // Get the header value for "user"
            let user_str: Option<&str> = user_header.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>
            
            let pass_header = req.headers().get("pass"); // Get the header value for "pass"
            let pass_str: Option<&str> = pass_header.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>

            println!("{}: POST create_account: {} {} {}", Utc::now(), level_str.unwrap_or_default(), user_str.unwrap_or_default(), pass_str.unwrap_or_default());

            if create_account(level_str.as_deref(), user_str.as_deref(), pass_str.as_deref()) == true {
                // Construct a 200 OK response
                let response = Response::builder()
                .status(StatusCode::OK)
                .body(empty())
                .unwrap();
                return Ok(response);
            } else {
                // Construct a 400 Bad Request response
                let response = Response::builder()
                .status(StatusCode::BAD_REQUEST)
                .body(empty())
                .unwrap();
                return Ok(response);
            }
        },

        (&Method::GET, Some("product")) => {
            let id = req.headers().get("id");
            let id_str: Option<&str> = id.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>
            let id_int: i64 = id_str.unwrap_or_default().parse().unwrap();

            println!("{}: GET product: {}", Utc::now(), id_str.unwrap_or_default());

            let result = &get_product(&id_int).unwrap(); // this approach currently assumes that the product exists

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("all_product")) => {
            println!("{}: GET all_product", Utc::now());

            let result = &get_all_product().unwrap_or(Vec::new());

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("search_product")) => {
            let search = req.headers().get("search");
            let search_str: Option<&str> = search.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>

            println!("{}: GET search_product: {}", Utc::now(), search_str.unwrap_or_default());

            let result = &get_search_product(&search_str.unwrap_or_default()).unwrap_or(Vec::new());

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("all_category")) => {
            println!("{}: GET all_category", Utc::now());

            let result = &get_all_category().unwrap_or(Vec::new());

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("access_level")) => {
            let user = req.headers().get("user");
            let user_str: Option<&str> = user.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>

            println!("{}: GET access_level: {}", Utc::now(), user_str.unwrap_or_default());
            
            let result = &get_access_level(&user_str.unwrap_or_default()).unwrap_or(-1);

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("all_access_level")) => {
            println!("{}: GET all_access_level", Utc::now());

            let result = &get_all_access_level().unwrap_or(Vec::new());

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("all_username")) => {
            println!("{}: GET all_username", Utc::now());

            let result = &get_all_username().unwrap_or(Vec::new());

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("notification")) => {
            let threshold = req.headers().get("threshold");
            let threshold_str: Option<&str> = threshold.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>
            let threshold_int: i64 = threshold_str.unwrap_or_default().parse().unwrap();

            println!("{}: GET notification", Utc::now());
            
            let result = &get_notification(&threshold_int).unwrap_or(-1);

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_stock_type")) => {
            println!("{}: GET dashboard_stock_type", Utc::now());
            
            let result = &get_dashboard_stock_by_type().unwrap_or(Vec::new());

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_daily_orders")) => {
            println!("{}: GET dashboard_daily_orders", Utc::now());
            
            let result = &get_dashboard_daily_orders().unwrap();

            // Convert JSON to bytes
            let json = serde_json::to_string(result).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_best_sellers")) => {
            println!("{}: GET dashboard_best_sellers", Utc::now());

            let result = &get_dashboard_best_sellers().unwrap_or(Vec::new());
            let json = serde_json::to_string(result).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_stock")) => {
            println!("{}: GET dashboard_stock", Utc::now());

            let result = &get_dashboard_stock().unwrap_or(-1);
            let json = serde_json::to_string(result).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_profit")) => {
            println!("{}: GET dashboard_profit", Utc::now());

            let result = &get_dashboard_profit().unwrap_or(-1.0);
            let json = serde_json::to_string(result).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_orders")) => {
            println!("{}: GET dashboard_orders", Utc::now());

            let result = &get_dashboard_orders().unwrap_or(-1);
            let json = serde_json::to_string(result).unwrap();

            Ok(Response::new(full(json)))
        },

        // Return 404 Not Found for other routes.
        _ => {
            let mut not_found = Response::new(empty());
            *not_found.status_mut() = StatusCode::NOT_FOUND;
            Ok(not_found)
        }
    }
}

/* LOGIN METHODS */

fn login(user: Option<&str>, pass: Option<&str>) -> Result<bool> {
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let result: Result<i64> = conn.query_row(
        "SELECT count(account_id) FROM account WHERE account.username = ?1 AND account.passhash = ?2;",
        params![user, pass],
        |row| row.get(0),
    );

    result.map(|count| count > 0)
}

fn create_account(_level: Option<&str>, _user: Option<&str>, _pass: Option<&str>) -> bool{
    return true;
}

fn get_access_level(user: &str) -> Result<i64> {
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let result: Result<i64> = conn.query_row(
        "SELECT level_id AS id FROM account WHERE username = ?1;",
        params![user],
        |row| row.get(0),
    );

    result.map(|id| id)
}

fn get_all_access_level() -> Result<Vec<models::AccessLevel>> {
    let mut output: Vec<models::AccessLevel> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT * FROM access_level;")?;
    let level_iter = stmt.query_map([], |row| {
        Ok(models::AccessLevel {
            level_id: row.get(0)?,
            level_name: row.get(1)?,
        })
    })?;

    for level in level_iter {
        output.push(level?)
    }

    Ok(output)
}

fn get_all_username() -> Result<Vec<String>> {
    let mut output: Vec<String> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT username FROM account;")?;
    let username_iter = stmt.query_map([], |row| {
        Ok(row.get(0)?)
    })?;

    for username in username_iter {
        output.push(username?)
    }

    Ok(output)
}

/* DATA METHODS */

fn get_product(id: &i64) -> Result<Product> {
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let result: Result<Product, rusqlite::Error> = conn.query_row(
        "SELECT * FROM product WHERE product_id = ?1;",
        params![id],
        |row| {
            Ok(Product {
                product_id: row.get(0)?,
                product_name: row.get(1)?,
                category_id: row.get(2)?,
                number_in_stock: row.get(3)?,
                buy_price: row.get(4)?,
                discontinued: row.get(5)?,
            })
        }
    );

    result.map(|product| product)
}

fn get_all_product() -> Result<Vec<models::Product>> {
    let mut output: Vec<models::Product> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT * FROM product;")?;
    let product_iter = stmt.query_map([], |row| {
        Ok(models::Product {
            product_id: row.get(0)?,
            product_name: row.get(1)?,
            category_id: row.get(2)?,
            number_in_stock: row.get(3)?,
            buy_price: row.get(4)?,
            discontinued: row.get(5)?,
        })
    })?;

    for product in product_iter {
        output.push(product?)
    }

    Ok(output)
}

fn get_search_product(search: &str) -> Result<Vec<models::Product>> {
    let mut output: Vec<models::Product> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT * FROM product 
        INNER JOIN category ON product.category_id = category.category_id 
        WHERE product_name LIKE ?1 OR category.category_name LIKE ?2;")?;
    let product_iter = stmt.query_map([format!("%{}%", search), format!("{}", search)], |row| {
        Ok(models::Product {
            product_id: row.get(0)?,
            product_name: row.get(1)?,
            category_id: row.get(2)?,
            number_in_stock: row.get(3)?,
            buy_price: row.get(4)?,
            discontinued: row.get(5)?,
        })
    })?;

    for product in product_iter {
        output.push(product?)
    }

    Ok(output)
}

fn get_all_category() -> Result<Vec<models::Category>> {
    let mut output: Vec<models::Category> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT * FROM category;")?;
    let category_iter = stmt.query_map([], |row| {
        Ok(models::Category {
            category_id: row.get(0)?,
            category_name: row.get(1)?,
        })
    })?;

    for category in category_iter {
        output.push(category?)
    }

    Ok(output)
}

fn get_notification(threshold: &i64) -> Result<i64> {
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let result: Result<i64> = conn.query_row(
        "SELECT COUNT(product_id) FROM product WHERE number_in_stock <= ?1;",
        [threshold], 
        |row| row.get(0),
    );

    result.map(|id| id)
}

/* DASHBOARD METHODS */

fn get_dashboard_stock_by_type() -> Result<Vec<models::StockType>> {
    let mut output: Vec<models::StockType> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT category.category_name AS c, SUM(number_in_stock) AS s 
        FROM product, category 
        WHERE product.category_id = category.category_id 
        GROUP BY category.category_name;
    ")?;
    let stocktype_iter = stmt.query_map([], |row| {
        Ok(models::StockType {
            c: row.get(0)?,
            s: row.get(1)?,
        })
    })?;

    for stocktype in stocktype_iter {
        output.push(stocktype?)
    }

    Ok(output)
}

fn get_dashboard_daily_orders() -> Result<Vec<models::DailyOrder>> {
    let mut output: Vec<models::DailyOrder> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT order_date AS date, COUNT(order_id) AS orders 
        FROM customer_orders 
        WHERE order_date >= date('now', '-7 days') 
        GROUP BY order_date ORDER BY order_date;
    ")?;
    let dailyorder_iter = stmt.query_map([], |row| {
        Ok(models::DailyOrder {
            date: row.get(0)?,
            orders: row.get(1)?,
        })
    })?;

    for dailyorder in dailyorder_iter {
        output.push(dailyorder?)
    }

    Ok(output)
}

fn get_dashboard_best_sellers() -> Result<Vec<models::BestSeller>> {
    let mut output: Vec<models::BestSeller> = Vec::new();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let mut stmt = conn.prepare("SELECT product.product_name AS name, SUM(customer_order_details.quantity_ordered) AS quantity FROM customer_order_details
        INNER JOIN product ON product.product_id = customer_order_details.product_id
        GROUP BY customer_order_details.product_id, product_name
        ORDER BY SUM(quantity_ordered) DESC LIMIT 5;")?;
    let bestseller_iter = stmt.query_map([], |row| {
        Ok(models::BestSeller {
            name: row.get(0)?,
            quantity: row.get(1)?,
        })
    })?;

    for bestseller in bestseller_iter {
        output.push(bestseller?)
    }

    Ok(output)
}

fn get_dashboard_stock() -> Result<i64> {
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let result: Result<i64> = conn.query_row(
        "SELECT SUM(number_in_stock) FROM product;",
        [], 
        |row| row.get(0),
    );

    result.map(|id| id)
}

fn get_dashboard_profit() -> Result<f64> {
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let result: Result<f64> = conn.query_row(
        "SELECT SUM((1.2 * product.buy_price) * customer_order_details.quantity_ordered) 
        FROM customer_order_details, product, customer_orders
        WHERE product.product_id = customer_order_details.product_id
        AND customer_orders.order_id = customer_order_details.order_id
        AND customer_orders.order_date BETWEEN DATE('now') - 7 AND DATE('now');",
        [], 
        |row| row.get(0),
    );

    result.map(|id| id)
}

fn get_dashboard_orders() -> Result<i64> {
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let conn = Connection::open(database_url)?;

    let result: Result<i64> = conn.query_row(
        "SELECT COUNT(order_id) FROM customer_orders
        WHERE order_date BETWEEN DATE('now') - 7 and DATE('now');",
        [], 
        |row| row.get(0),
    );

    result.map(|id| id)
}

fn empty() -> BoxBody<Bytes, hyper::Error> {
    Empty::<Bytes>::new()
        .map_err(|never| match never {})
        .boxed()
}
fn full<T: Into<Bytes>>(chunk: T) -> BoxBody<Bytes, hyper::Error> {
    Full::new(chunk.into())
        .map_err(|never| match never {})
        .boxed()
}