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


insert into Produit(prix_Prod,label_Prod,quantite_Prod,categorie_Prod,promo_Prod ) VALUES
(1.20,"Banane",10,"FRUIT",0),
(1.03,"Pomme",15,"FRUIT",0),
(0.94,"Tomate",20,"FRUIT",0),
(0.80,"Noix",30,"FRUIT",0.125);