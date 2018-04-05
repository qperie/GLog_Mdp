create database if not exists mdpgestion character set utf8 collate utf8_unicode_ci;
use mdpgestion;

grant all privileges on mdpgestion.* to 'mdpgestion_user'@'localhost' identified by 'secret';

drop table if exists compte;
drop table if exists wifi;
drop table if exists utilisateur;
drop table if exists liaisonUtilWifi;
drop table if exists liaisonUtilCompte;

create table compte
(
    compte_id integer not null primary key auto_increment,
    compte_titre varchar(150) not null,
    compte_login varchar(100) not null,
    compte_mdp varchar(100) not null,
	compte_last_modif date not null,
	compte_last_modif_mdp date not null
);

create table wifi
(
  wifi_id integer not null primary key auto_increment,
  wifi_SSID varchar(100) not null,
  wifi_mdp varchar(100) not null
);

create table utilisateur
(
    util_id integer not null primary key auto_increment,
    util_login varchar(100) not null,
    util_mdp varchar(100) not null
);

create table liaisonUtilWifi
(
    utilWifi_id integer not null primary key auto_increment,
	util_id integer not null,
	wifi_id integer not null,
    foreign key (util_id) references utilisateur(util_id),
    foreign key (wifi_id) references wifi(wifi_id)
);

create table liaisonUtilCompte
(
    utilCompte_id integer not null primary key auto_increment,
	util_id integer not null,
	compte_id integer not null,
	foreign key (util_id) references utilisateur(util_id),
    foreign key (compte_id) references compte(compte_id)
);