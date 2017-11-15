using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

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

        public float Prix_Prod
        {
            get;
            set;
        }
        public float Promo_Prod
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

        public Produit(int id_Prod,int qte_Prod, string label_Prod, float prix_Prod, float promo_Prod, string categorie_Prod, string urlImage_Prod)
        {
            this.Id_Prod = id_Prod;
            this.Qte_Prod = qte_Prod;
            this.Label_Prod = label_Prod;
            this.Prix_Prod = prix_Prod;
            this.Promo_Prod = promo_Prod;
            this.Categorie_Prod = categorie_Prod;
            this.UrlImage_Prod = urlImage_Prod;
        }
        public Produit(int qte_Prod,string label_Prod, float prix_Prod, float promo_Prod, string categorie_Prod, string UrlImage_Prod) : this(0,qte_Prod, label_Prod, prix_Prod, promo_Prod, categorie_Prod, UrlImage_Prod) { }
    }
}