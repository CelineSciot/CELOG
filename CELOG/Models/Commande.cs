﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public class Commande
    {

        public int Quantite
        {
            get;
            set;
        }

        public int Id_Produit
        {
            get;
            set;
        }

        public int Id_Utilisateur
        {
            get;
            set;
        }
        public decimal Total
        {
            get;
            set;
        }
        public int Id_Commande
        {
            get;
            set;
        }

        public Commande()
        {
        }

        public Commande(int id_Utilisateur,int id_Produit, int quantite, decimal total, int id_Commande)
        {
            Id_Utilisateur = id_Utilisateur;
            Id_Produit = id_Produit;
            Quantite = quantite;
            Total = total;
            Id_Commande = id_Commande;
        }
        //public Commande(int qte_Prod,string label_Prod, decimal prix_Prod, decimal promo_Prod, string categorie_Prod, string UrlImage_Prod) : this(0,qte_Prod, label_Prod, prix_Prod, promo_Prod, categorie_Prod, UrlImage_Prod) { }
    }
}