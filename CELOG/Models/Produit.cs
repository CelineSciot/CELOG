using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public class Produit
    {
        public int Id_Prod
        {
            get;
            set;
        }

        public int Qte_Prod
        {
            get;
            set;
        }

        public string Label_Prod
        {
            get;
            set;
        }

        public decimal Prix_Prod
        {
            get;
            set;
        }
        public decimal Promo_Prod
        {
            get;
            set;
        }
        public string Categorie_Prod
        {
            get;
            set;
        }

        public string UrlImage_Prod
        {
            get;
            set;
        }

        public Produit()
        {
        }

        public Produit(int id_Prod,int qte_Prod, string label_Prod, decimal prix_Prod, decimal promo_Prod, string categorie_Prod, string urlImage_Prod)
        {
            Id_Prod = id_Prod;
            Qte_Prod = qte_Prod;
            Label_Prod = label_Prod;
            Prix_Prod = prix_Prod;
            Promo_Prod = promo_Prod;
            Categorie_Prod = categorie_Prod;
            UrlImage_Prod = urlImage_Prod;
        }
        public Produit(int qte_Prod,string label_Prod, decimal prix_Prod, decimal promo_Prod, string categorie_Prod, string UrlImage_Prod) : this(0,qte_Prod, label_Prod, prix_Prod, promo_Prod, categorie_Prod, UrlImage_Prod) { }
    }
}