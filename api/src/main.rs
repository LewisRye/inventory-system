mod models;

use std::net::SocketAddr;
use std::env;

use chrono::{Utc};
use http_body_util::{combinators::BoxBody, BodyExt, Full, Empty};
use hyper::body::{Bytes};
use hyper::server::conn::http1;
use hyper::service::service_fn;
use hyper::{Request, Response, Method, StatusCode};
use hyper_util::rt::TokioIo;
use models::Product;
use tokio::net::TcpListener;
use dotenv::dotenv;

#[tokio::main]
async fn main() -> Result<(), Box<dyn std::error::Error + Send + Sync>> {
    dotenv().ok();

    let addr = SocketAddr::from(([127, 0, 0, 1], 3000));

    // We create a TcpListener and bind it to 127.0.0.1:3000
    let listener = TcpListener::bind(addr).await?;

    println!("Server online at: {}", Utc::now());

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
                eprintln!("Error serving connection: {:?}", err);
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

            println!("Requested Product ID: {}", id);

            // Create a JSON value
            let product = get_product(&id);

            // Convert JSON to bytes
            let json = serde_json::to_string(&product).unwrap();

            // Build the HTTP response
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
            println!("Found: {}, {}, {}, {}, {}, {}", id, name, cid, nis, bp, disc); // for debugging
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
    return None
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