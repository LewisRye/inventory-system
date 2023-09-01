create table inventory.CustomerOrderDetails
(
    order_id         int not null
        primary key,
    product_id       int null,
    quantity_ordered int null,
    constraint CustomerOrderDetails_ibfk_1
        foreign key (order_id) references inventory.CustomerOrders (order_id),
    constraint CustomerOrderDetails_ibfk_2
        foreign key (product_id) references inventory.Product (product_id)
);

create index product_id
    on inventory.CustomerOrderDetails (product_id);

