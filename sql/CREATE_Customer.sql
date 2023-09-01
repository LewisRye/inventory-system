create table inventory.Customer
(
    customer_id      int         not null
        primary key,
    customer_fname   varchar(15) null,
    customer_lname   varchar(15) null,
    customer_address varchar(50) null,
    customer_phone   bigint      null
);

