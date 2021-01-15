drop table if exists BDpossession;
drop table if exists BDsouhait;
drop table if exists album;
drop table if exists individu;

create table individu (
    indiv_id integer not null primary key auto_increment,
    indiv_admin integer not null,
    indiv_login varchar(100) not null,
    indiv_mdp varchar(100) not null
);

create table album (
	album_id integer not null primary key auto_increment,
	album_img varchar(200) not null,
	album_nom varchar(100) not null,
    album_serie varchar(100),
    album_auteur varchar(100) not null,
    album_cat varchar(100) not null,
    album_genre varchar(100) not null,
    album_edit varchar(100) not null
);

create table BDsouhait (
    indiv_id integer not null,
    constraint fk_indiv_id_souhait foreign key(indiv_id) references individu(indiv_id),
    album_id integer not null,
    constraint fk_album_id_souhait foreign key(album_id) references album(album_id)
);

create table BDpossession (
    indiv_id integer not null,
    constraint fk_indiv_id_possession foreign key(indiv_id) references individu(indiv_id),
    album_id integer not null,
    constraint fk_album_id_possession foreign key(album_id) references album(album_id)
);