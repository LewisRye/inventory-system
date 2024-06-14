use diesel::Queryable;
use diesel::sql_types::Date;

#[derive(Queryable)]
pub struct AccessLevel {
    pub level_id: Option<i32>,
    pub name: Option<String>,
}

#[derive(Queryable)]
pub struct Account {
    pub account_id: Option<i32>,
    pub fname: Option<String>,
    pub lname: Option<String>,
    pub address: Option<String>,
    pub level_id: Option<i32>,
    pub username: Option<String>,
    pub passhash: Option<String>,
}

#[derive(Queryable)]
pub struct Category {
    pub category_id: Option<i32>,
    pub category_name: Option<String>,
}

#[derive(Queryable)]
pub struct Customer {
    pub customer_id: Option<i32>,
    pub fname: Option<String>,
    pub lname: Option<String>,
    pub address: Option<String>,
    pub phone: Option<String>,
}

#[derive(Queryable)]
pub struct CustomerOrderDetails {
    pub order_id: Option<i32>,
    pub product_id: Option<i32>,
    pub quantity: Option<i32>,
}

#[derive(Queryable)]
pub struct CustomerOrder {
    pub order_id: Option<i32>,
    pub customer_id: Option<i32>,
    pub order_date: Option<Date>,
}

#[derive(Queryable)]
pub struct Product {
    pub product_id: Option<i32>,
    pub product_name: Option<String>,
    pub category_id: Option<i32>,
    pub number_in_stock: Option<i32>,
    pub buy_price: Option<f64>,
    pub discontinued: Option<bool>,
}