mod models;

use std::net::SocketAddr;
use std::env;

use chrono::Utc;
use dotenv::dotenv;
use http_body_util::{combinators::BoxBody, BodyExt, Full, Empty};
use hyper::body::Bytes;
use hyper::server::conn::http1;
use hyper::service::service_fn;
use hyper::{Request, Response, Method, StatusCode};
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

async fn handle_request(
    req: Request<hyper::body::Incoming>,
) -> Result<Response<BoxBody<Bytes, hyper::Error>>, hyper::Error> {
    match (req.method(), req.uri().path().split("/").nth(1)) {
        (&Method::POST, Some("echo")) => Ok(Response::new(req.into_body().boxed())),

        (&Method::GET, Some("product")) => {
            let parts: Vec<&str> = req.uri().path().split("/product/").collect();
            let mut id: i64 = 0;

            // Extract the path parameters
            if let Some(product_id_str) = parts.get(1) {
                if let Ok(product_id) = product_id_str.parse::<i64>() {
                    id = product_id;
                }
            }

            println!("{}: Requested Product ID: {}", Utc::now(), id);

            // Create a JSON value
            let product = get_product(&id);

            // Convert JSON to bytes
            let json = serde_json::to_string(&product).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("all_product")) => {
            println!("{}: Requested All Products", Utc::now());

            // Create a JSON value
            let products = get_all_product();

            // Convert JSON to bytes
            let json = serde_json::to_string(&products).unwrap();

            // Build the HTTP response
            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_stock_type")) => {
            println!("{}: Requested Dashboard Stock Types", Utc::now());

            let stock = get_dashboard_stock_by_type();

            let json = serde_json::to_string(&stock).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_daily_orders")) => {
            println!("{}: Requested Dashboard Daily Orders", Utc::now());

            //let orders = get_dashboard_daily_orders();

            //let json = serde_json::to_string(&orders).unwrap();

            //Ok(Response::new(full(json)))
            Ok(Response::new(empty()))
        },

        (&Method::GET, Some("dashboard_best_sellers")) => {
            println!("{}: Requested Dashboard Best Sellers", Utc::now());

            let best = get_dashboard_best_sellers();

            let json = serde_json::to_string(&best).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_stock")) => {
            println!("{}: Requested Dashboard Stock", Utc::now());

            let stock = get_dashboard_stock();

            let json = serde_json::to_string(&stock).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_profit")) => {
            println!("{}: Requested Dashboard Profit", Utc::now());

            let profit = get_dashboard_profit();

            let json = serde_json::to_string(&profit).unwrap();

            Ok(Response::new(full(json)))
        },

        (&Method::GET, Some("dashboard_orders")) => {
            println!("{}: Requested Dashboard Orders", Utc::now());

            let orders = get_dashboard_orders();

            let json = serde_json::to_string(&orders).unwrap();

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

fn get_dashboard_stock_by_type() -> Vec<(i64, String)> {
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
        let row = (row.read::<i64, _>("s"), row.read::<&str, _>("c").into());
        output.push(row);
    }
    return output;
}

/*
fn get_dashboard_daily_orders() -> Vec<(i64, i64)> {
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
        let row = (row.read("date"), row.read("orders"));
        output.push(row);
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