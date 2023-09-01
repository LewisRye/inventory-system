create table inventory.CustomerOrders
(
    order_id    int  not null
        primary key,
    customer_id int  null,
    order_date  date null,
    constraint CustomerOrders_ibfk_1
        foreign key (customer_id) references inventory.Customer (customer_id)
);

create index customer_id
    on inventory.CustomerOrders (customer_id);

