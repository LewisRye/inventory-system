use serde::{Serialize, Deserialize};

#[derive(Serialize, Deserialize)]
pub struct AccessLevel {
    pub level_id: i64,
    pub level_name: String,
}

#[derive(Serialize, Deserialize)]
pub struct Account {
    pub account_id: i64,
    pub fname: String,
    pub lname: String,
    pub address: String,
    pub level_id: i64,
    pub username: String,
    pub passhash: String,
}

#[derive(Serialize, Deserialize)]
pub struct Category {
    pub category_id: i64,
    pub category_name: String,
}

#[derive(Serialize, Deserialize)]
pub struct Customer {
    pub customer_id: i64,
    pub fname: String,
    pub lname: String,
    pub address: String,
    pub phone: String,
}

#[derive(Serialize, Deserialize)]
pub struct CustomerOrderDetails {
    pub order_id: i64,
    pub product_id: i64,
    pub quantity: i64,
}

#[derive(Serialize, Deserialize)]
pub struct CustomerOrder {
    pub order_id: i64,
    pub customer_id: i64,
    pub order_date: String,
}

#[derive(Serialize, Deserialize)]
pub struct Order {
    pub id: i64,
    pub product_name: String,
    pub customer_name: String, 
    pub quantity: i64,
    pub date: String,
    pub price: i64,
}

#[derive(Serialize, Deserialize)]
pub struct Product {
    pub product_id: i64,
    pub product_name: String,
    pub category_id: i64,
    pub number_in_stock: i64,
    pub buy_price: i64,
    pub discontinued: i64,
}

#[derive(Serialize, Deserialize)]
pub struct StockType {
    pub c: String,
    pub s: i64,
}

#[derive(Serialize, Deserialize)]
pub struct DailyOrder {
    pub date: String,
    pub orders: i64,
}

#[derive(Serialize, Deserialize)]
pub struct BestSeller {
    pub name: String,
    pub quantity: i64,
}