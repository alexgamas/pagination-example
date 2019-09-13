
--------------------
--    drop all    --
--------------------

drop table if exists area;
drop sequence if exists area_id_seq;

----------------
--    area    --
----------------

create sequence area_id_seq increment 1 minvalue 1 maxvalue 9223372036854775807 start 1 cache 1;

create table area (
    id bigint default nextval('area_id_seq') not null,
    name character varying(40) not null,
    creation_date timestamp(4) without time zone not null,
    constraint area_pkey primary key (id)
);
