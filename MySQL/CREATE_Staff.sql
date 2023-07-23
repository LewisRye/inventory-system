create table inventory.Staff
(
    staff_id   int         not null
        primary key,
    first_name varchar(16) null,
    last_name  varchar(16) null,
    address    varchar(50) null,
    account_id int         null,
    constraint Staff_ibfk_1
        foreign key (account_id) references inventory.Account (account_id)
);

create index account_id
    on inventory.Staff (account_id);

