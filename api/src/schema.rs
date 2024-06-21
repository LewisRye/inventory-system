// @generated automatically by Diesel CLI.

diesel::table! {
    access_level (level_id) {
        level_id -> Nullable<Integer>,
        level_name -> Nullable<Text>,
    }
}

diesel::table! {
    account (account_id) {
        account_id -> Nullable<Integer>,
        fname -> Nullable<Text>,
        lname -> Nullable<Text>,
        address -> Nullable<Text>,
        level_id -> Nullable<Integer>,
        username -> Nullable<Text>,
        passhash -> Nullable<Text>,
    }
}

diesel::table! {
    category (category_id) {
        category_id -> Nullable<Integer>,
        category_name -> Nullable<Text>,
    }
}

diesel::table! {
    customer (customer_id) {
        customer_id -> Nullable<Integer>,
        customer_fname -> Nullable<Text>,
        customer_lname -> Nullable<Text>,
        customer_address -> Nullable<Text>,
        customer_phone -> Nullable<Text>,
    }
}

diesel::table! {
    customer_order_details (order_id) {
        order_id -> Nullable<Integer>,
        product_id -> Nullable<Integer>,
        quantity_ordered -> Nullable<Integer>,
    }
}

diesel::table! {
    customer_orders (order_id) {
        order_id -> Nullable<Integer>,
        customer_id -> Nullable<Integer>,
        order_date -> Nullable<Timestamp>,
    }
}

diesel::table! {
    product (product_id) {
        product_id -> Nullable<Integer>,
        product_name -> Nullable<Text>,
        category_id -> Nullable<Integer>,
        number_in_stock -> Nullable<Integer>,
        buy_price -> Nullable<Double>,
        discontinued -> Nullable<Bool>,
    }
}

diesel::joinable!(account -> access_level (level_id));
diesel::joinable!(customer_order_details -> customer_orders (order_id));
diesel::joinable!(customer_order_details -> product (product_id));
diesel::joinable!(customer_orders -> customer (customer_id));
diesel::joinable!(product -> category (category_id));

diesel::allow_tables_to_appear_in_same_query!(
    access_level,
    account,
    category,
    customer,
    customer_order_details,
    customer_orders,
    product,
);
