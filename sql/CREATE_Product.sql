create table inventory.Product
(
    product_id      int         not null
        primary key,
    product_name    varchar(50) null,
    category_id     int         null,
    number_in_stock int         null,
    buy_price       decimal     null,
    discontinued    char        null,
    constraint Product_ibfk_1
        foreign key (category_id) references inventory.Category (category_id)
);

create index category_id
    on inventory.Product (category_id);

