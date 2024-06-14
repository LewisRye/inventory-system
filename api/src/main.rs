use diesel::prelude::*;
use diesel::Connection;
use diesel::SqliteConnection;
use dotenv::dotenv;
use std::env;

pub mod schema;
pub mod models;

use self::models::*;
use self::schema::access_level::dsl::access_level;
use self::schema::account::dsl::account;
use self::schema::category::dsl::category;
use self::schema::customer::dsl::customer;
use self::schema::customer_order_details::dsl::customer_order_details;
use self::schema::customer_orders::dsl::customer_orders;
use self::schema::product::dsl::product;

fn main() {
    dotenv().ok();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let mut connection = SqliteConnection::establish(&database_url)
        .expect(&format!("Error connecting to {}", database_url));
    
    // Query the database
    let results = product
        .limit(5)
        .load::<Product>(&mut connection)
        .expect("Error loading products");

    // Print the results
    println!("Displaying {} products", results.len());
    for prod in results {
        println!("ID: {}", prod.product_id.unwrap_or_default());
        println!("Name: {}", prod.product_name.unwrap_or_default());
    }

    // Query the database
    let results = account
        .limit(5)
        .load::<Account>(&mut connection)
        .expect("Error loading accounts");

    // Print the results
    println!("Displaying {} accounts", results.len());
    for acc in results {
        println!("ID: {}", acc.account_id.unwrap_or_default());
        println!("Name: {} {}", acc.fname.unwrap_or_default(), acc.lname.unwrap_or_default());
    }
}
