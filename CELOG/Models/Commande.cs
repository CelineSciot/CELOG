using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public class Commande
    {
        public int Id_Commande
        {
            get;
            set;
        }

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
      
        public Commande()
        {
        }

        public Commande(int id_Utilisateur,int id_Produit, int quantite)
        {
            Id_Utilisateur = id_Utilisateur;
            Id_Produit = id_Produit;
            Quantite = quantite;
        }
        //public Commande(int qte_Prod,string label_Prod, decimal prix_Prod, decimal promo_Prod, string categorie_Prod, string UrlImage_Prod) : this(0,qte_Prod, label_Prod, prix_Prod, promo_Prod, categorie_Prod, UrlImage_Prod) { }
    }
}