CREATE DATABASE IF NOT EXISTs Celog character set='UTF8';

use Celog;

CREATE TABLE IF NOT EXISTS Produit(
id_Prod  int not null auto_increment,
prix_Prod double not null,
label_Prod varchar(50) not null,
quantite_Prod int not null,
categorie_Prod varchar(20),
promo_Prod double,
primary key(id_Prod))ENGINE= INNODB;