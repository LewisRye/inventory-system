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

            if login(user_str.as_deref(), pass_str.as_deref()) == true {
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

            println!("{}: GET product: {}", Utc::now(), id_str.unwrap_or_default());
            
            // Convert JSON to bytes
            let id_int: i64 = id_str.unwrap_or_default().parse().unwrap();
            let json = serde_json::to_string(&get_product(&id_int)).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("access_level")) => {
            let user = req.headers().get("user");
            let user_str: Option<&str> = user.and_then(|hv| hv.to_str().ok()); // Convert Option<&HeaderValue> to Option<&str>

            println!("{}: GET access_level: {}", Utc::now(), user_str.unwrap_or_default());
            
            // Convert JSON to bytes
            let json = serde_json::to_string(&get_access_level(&user_str.unwrap_or_default())).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("all_product")) => {
            println!("{}: GET all_product", Utc::now());

            // Convert JSON to bytes
            let json = serde_json::to_string(&get_all_product()).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("all_access_level")) => {
            println!("{}: GET all_access_level", Utc::now());

            // Convert JSON to bytes
            let json = serde_json::to_string(&get_all_access_level()).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_stock_type")) => {
            println!("{}: GET dashboard_stock_type", Utc::now());
            
            let json = serde_json::to_string(&get_dashboard_stock_by_type()).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_daily_orders")) => {
            println!("{}: GET dashboard_daily_orders", Utc::now());
            
            //let json = serde_json::to_string(&get_dashboard_daily_orders()).unwrap();

            //Ok(Response::new(full(json)))
            Ok(Response::new(empty()))
        },

        (&Method::GET, Some("dashboard_best_sellers")) => {
            println!("{}: GET dashboard_best_sellers", Utc::now());

            let json = serde_json::to_string(&get_dashboard_best_sellers()).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_stock")) => {
            println!("{}: GET dashboard_stock", Utc::now());

            let json = serde_json::to_string(&get_dashboard_stock()).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_profit")) => {
            println!("{}: GET dashboard_profit", Utc::now());

            let json = serde_json::to_string(&get_dashboard_profit()).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_orders")) => {
            println!("{}: GET dashboard_orders", Utc::now());

            let json = serde_json::to_string(&get_dashboard_orders()).unwrap();

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

/* METHODS TO GET SQL DATA */

fn login(user: Option<&str>, pass: Option<&str>) -> bool {
    let mut uname = String::new();

    let query = "SELECT username FROM account WHERE account.passhash = ?;";
    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .bind((1, pass))
        .unwrap()
        .map(|row| row.unwrap())
    {
        uname = row.read::<&str, _>("username").to_string();
    }

    return uname == user.unwrap_or_default();
}

fn create_account(level: Option<&str>, user: Option<&str>, pass: Option<&str>) -> bool{
    return true;
}

fn get_product(id: &i64) -> Option<Product> {
    if *id > 0 {
        let query = "SELECT * FROM product WHERE product.product_id = ?;";

        let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
        let connection = sqlite::open(database_url).unwrap();
        for row in connection
            .prepare(query)
            .unwrap()
            .into_iter()
            .bind((1, *id))
            .unwrap()
            .map(|row| row.unwrap())
        {
            let id: i64 = row.read("product_id");
            let name: String = row.read::<&str, _>("product_name").to_string();
            let cid: i64 = row.read("category_id");
            let nis: i64 = row.read("number_in_stock");
            let bp: i64 = row.read("buy_price");
            let disc: i64 = row.read("discontinued");
            let product = models::Product {
                product_id: id,
                product_name: name,
                category_id: cid,
                number_in_stock: nis,
                buy_price: bp,
                discontinued: disc,
            };

            return Some(product);
        }
    }
    return None;
}

fn get_access_level(id: &str) -> Option<i64> {
    let query = "SELECT level_id AS id FROM account WHERE username = ?;";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .bind((1, id))
        .unwrap()
        .map(|row| row.unwrap())
    {
        return row.read("id");
    }
    return None;
}

fn get_all_product() -> Vec<Product> {
    let mut output: Vec<Product> = Vec::new();

    let query = "SELECT * FROM product;";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {
        let id: i64 = row.read("product_id");
        let name: String = row.read::<&str, _>("product_name").to_string();
        let cid: i64 = row.read("category_id");
        let nis: i64 = row.read("number_in_stock");
        let bp: i64 = row.read("buy_price");
        let disc: i64 = row.read("discontinued");
        let product = models::Product {
            product_id: id,
            product_name: name,
            category_id: cid,
            number_in_stock: nis,
            buy_price: bp,
            discontinued: disc,
        };
        output.push(product);
    }
    return output;
}

fn get_all_access_level() -> Vec<models::AccessLevel> {
    let mut output: Vec<models::AccessLevel> = Vec::new();

    let query = "SELECT * FROM access_level;";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {
        let id: i64 = row.read("level_id");
        let name: String = row.read::<&str, _>("level_name").to_string();
        let level = models::AccessLevel {
            level_id: id,
            level_name: name,
        };
        output.push(level);
    }
    return output;
}

fn get_dashboard_stock_by_type() -> Vec<models::StockType> {
    let mut output = Vec::new();

    let query = "SELECT SUM(number_in_stock) AS s, category.category_name AS c
        FROM product, category WHERE product.category_id = category.category_id
        GROUP BY category.category_name;";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {
        let category: String = row.read::<&str, _>("c").to_string();
        let quantity: i64 = row.read("s");
        
        let stock_type = models::StockType {
            c: category,
            s: quantity,
        };

        output.push(stock_type);
    }
    return output;
}

/*
fn get_dashboard_daily_orders() -> Vec<models::DailyOrder> {
    let mut output = Vec::new();

    let query = "WITH RECURSIVE date_range(date) AS (
        SELECT DATE('now', '-7 days')
        UNION ALL
        SELECT DATE(date_range.date, '+1 day')
        FROM date_range
        WHERE date_range.date < DATE('now')
    )
    SELECT
        CASE
            WHEN date_range.date = DATE('now', '-7 days') THEN '-7.0'
            ELSE '-' || (julianday(DATE('now')) - julianday(date_range.date))
        END AS date,
        COALESCE(COUNT(customer_orders.order_date), 0) AS orders
    FROM
        date_range
    LEFT JOIN
        customer_orders ON date_range.date = customer_orders.order_date
    GROUP BY
        date_range.date;";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {
        let day_f64: f64 = row.read("date");
        let orders: i64 = row.read("orders");
        
        let daily_order = models::DailyOrder {
            day: day_f64 as i64,
            orders: orders,
        };

        output.push(daily_order);
    }
    return output;
}
*/

fn get_dashboard_best_sellers() -> Vec<models::BestSeller> {
    let mut output = Vec::new();

    let query = "SELECT SUM(customer_order_details.quantity_ordered) AS quantity, product.product_name AS name FROM customer_order_details
        INNER JOIN product ON product.product_id = customer_order_details.product_id
        GROUP BY customer_order_details.product_id, product_name
        ORDER BY SUM(quantity_ordered) DESC LIMIT 5;";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {
        let name: String = row.read::<&str, _>("name").to_string();
        let quantity: i64 = row.read("quantity");
        
        let best_seller = models::BestSeller {
            name: name,
            quantity: quantity,
        };

        output.push(best_seller);
    }
    return output;
}

fn get_dashboard_stock() -> i64 {
    let query = "SELECT SUM(number_in_stock) AS x FROM product;";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {
        return row.read("x");
    }
    return 0;
}

fn get_dashboard_profit() -> f64 {
    let query = "SELECT SUM((1.2 * product.buy_price) * customer_order_details.quantity_ordered) AS x 
        FROM customer_order_details, product, customer_orders
        WHERE product.product_id = customer_order_details.product_id
        AND customer_orders.order_id = customer_order_details.order_id
        AND customer_orders.order_date BETWEEN DATE('now') - 7 AND DATE('now');";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {        
        return row.read("x");
    }
    return 0.0;
}

fn get_dashboard_orders() -> i64 {
    let query = "SELECT COUNT(order_id) AS x FROM customer_orders
        WHERE order_date BETWEEN DATE('now') - 7 and DATE('now');";

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let connection = sqlite::open(database_url).unwrap();
    for row in connection
        .prepare(query)
        .unwrap()
        .into_iter()
        .map(|row| row.unwrap())
    {        
        return row.read("x");
    }
    return 0;
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