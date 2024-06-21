use diesel::{Connection, ExpressionMethods, QueryDsl, RunQueryDsl, SqliteConnection};
use dotenv::dotenv;
use schema::customer_orders::order_date;
use std::env;
use chrono::{Duration, NaiveDate, NaiveDateTime, prelude::*};
use serde::Serialize;
use serde_json;

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

fn get_orders_between_dates(
    conn: &mut SqliteConnection,
    start_date: NaiveDateTime,
    end_date: NaiveDateTime,
) -> Result<Vec<CustomerOrder>, diesel::result::Error> {
    customer_orders
        .filter(order_date.between(start_date, end_date))
        .load::<CustomerOrder>(conn)
}

fn main() {
    dotenv().ok();

    let database_url = env::var("DATABASE_URL").expect("DATABASE_URL must be set");
    let mut connection = SqliteConnection::establish(&database_url)
        .expect(&format!("Error connecting to {}", database_url));

    let results: Result<Vec<CustomerOrder>, diesel::result::Error> = get_orders_between_dates(&mut connection, Utc::now().naive_utc() - Duration::days(7), Utc::now().naive_utc());

    if let Ok(data) = results {
        let json = serde_json::to_string(&data).unwrap();
        println!("Serialized JSON: {}", json);
    } else {
        println!("Error occurred");
    }
}
