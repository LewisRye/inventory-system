create table inventory.Account
(
    account_id int          not null
        primary key,
    first_name varchar(16)  null,
    last_name  varchar(16)  null,
    address    varchar(50)  null,
    level_id   int          null,
    username   varchar(16)  null,
    passhash   varchar(100) null,
    constraint Account_ibfk_1
        foreign key (level_id) references inventory.AccessLevel (level_id)
);

create index level_id
    on inventory.Account (level_id);

