create sequence compositions_comp_type_id_seq;

alter sequence compositions_comp_type_id_seq owner to postgres;

create table users
(
    user_id            serial
        primary key,
    login              varchar(50),
    password_hash      varchar(255),
    name               varchar(50),
    bio                text,
    profile_img_url    varchar(50),
    background_img_url varchar(50)
);

alter table users
    owner to postgres;

create table categories
(
    category_id serial
        primary key,
    name        varchar(50)
);

alter table categories
    owner to postgres;

create table genres
(
    genre_id    serial
        primary key,
    category_id integer
        constraint category_id_fk
            references categories,
    name        varchar(50)
);

alter table genres
    owner to postgres;

create table subgenres
(
    subgenre_id serial
        primary key,
    genre_id    integer
        constraint genre_id_fk
            references genres,
    name        varchar(50)
);

alter table subgenres
    owner to postgres;

create table user_subgenres
(
    user_id     integer not null
        constraint user_id_fk
            references users,
    subgenre_id integer not null
        constraint subgenre_id_fk
            references subgenres,
    primary key (user_id, subgenre_id)
);

alter table user_subgenres
    owner to postgres;

create table tags
(
    tag_id serial
        primary key,
    name   varchar(50)
);

alter table tags
    owner to postgres;

create table composition_types
(
    comp_type_id serial
        primary key,
    name         varchar(50)
);

alter table composition_types
    owner to postgres;

create table composition_subtypes
(
    comp_subtype_id serial
        primary key,
    comp_type_id    integer
        constraint comp_type_id_fk
            references composition_types,
    name            varchar(50)
);

alter table composition_subtypes
    owner to postgres;

create table compositions
(
    comp_id         serial
        primary key,
    title           varchar(50),
    created_at      date    default CURRENT_DATE,
    cover_img_url   varchar(50),
    comp_subtype_id integer
        constraint comp_subtype_id_fk
            references composition_subtypes,
    comp_type_id    integer
        constraint comp_type_id_fk
            references composition_types,
    info            text,
    is_private      boolean default false
);

alter table compositions
    owner to postgres;

create table composition_subgenres
(
    comp_id     integer not null
        constraint comp_id_fk
            references compositions,
    subgenre_id integer not null
        constraint subgenre_id_fk
            references subgenres,
    primary key (comp_id, subgenre_id)
);

alter table composition_subgenres
    owner to postgres;

create table roles
(
    role_id serial
        primary key,
    name    varchar(50)
);

alter table roles
    owner to postgres;

create table tracks
(
    track_id      serial
        primary key,
    name          varchar(50),
    duration_sec  integer,
    cover_img_url varchar(50),
    audio_url     varchar(50),
    info          text
);

alter table tracks
    owner to postgres;

create table composition_creators
(
    comp_id integer not null
        constraint comp_id_fk
            references compositions,
    user_id integer not null
        constraint user_id_fk
            references users,
    role_id integer
        constraint role_id_fk
            references roles,
    primary key (comp_id, user_id)
);

alter table composition_creators
    owner to postgres;

create table composition_tracks
(
    comp_id  integer not null
        constraint comp_id_fk
            references compositions,
    track_id integer not null
        constraint track_id_fk
            references tracks,
    position integer,
    primary key (comp_id, track_id)
);

alter table composition_tracks
    owner to postgres;

create table track_creators
(
    track_id integer not null
        constraint track_id_fk
            references tracks,
    user_id  integer not null
        constraint user_id_fk
            references users,
    role_id  integer
        constraint role_id_fk
            references roles,
    primary key (track_id, user_id)
);

alter table track_creators
    owner to postgres;

create table track_tags
(
    track_id integer not null
        constraint track_id_fk
            references tracks,
    tag_id   integer not null
        constraint tag_id_fk
            references tags,
    primary key (track_id, tag_id)
);

alter table track_tags
    owner to postgres;

create table composition_tags
(
    comp_id integer not null
        constraint comp_id_fk
            references compositions,
    tag_id  integer not null
        constraint tag_id_fk
            references tags,
    primary key (comp_id, tag_id)
);

alter table composition_tags
    owner to postgres;

create table track_plays
(
    track_play_id serial
        primary key,
    user_id       integer
        constraint user_id_fk
            references users,
    track_id      integer
        constraint track_id_fk
            references tracks,
    played_at     date default CURRENT_DATE
);

alter table track_plays
    owner to postgres;

create table follow_types
(
    follow_type_id serial
        primary key,
    name           varchar(50)
);

alter table follow_types
    owner to postgres;

create table follows
(
    user_id        integer not null
        constraint user_id_fk
            references users,
    follow_type_id integer not null
        constraint follow_type_id_fk
            references follow_types,
    primary key (user_id, follow_type_id)
);

alter table follows
    owner to postgres;

create table track_notion_types
(
    notion_id serial
        primary key,
    name      varchar(50)
);

alter table track_notion_types
    owner to postgres;

create table track_notions
(
    user_id   integer not null
        constraint user_id_fk
            references users,
    track_id  integer not null
        constraint track_id_fk
            references tracks,
    notion_id integer
        constraint notion_id_fk
            references track_notion_types,
    primary key (user_id, track_id)
);

alter table track_notions
    owner to postgres;

