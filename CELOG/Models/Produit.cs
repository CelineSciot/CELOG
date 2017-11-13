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

        public double Prix_Prod
        {
            get;
            set;
        }
        public double Promo_Prod
        {
            get;
            set;
        }
        public string Categorie_Prod
        {
            get;
            set;
        }


        public Produit()
        {
        }

        public Produit(int qte_Prod, string label_Prod, double prix_Prod, double promo_Prod, string categorie_Prod)
        {
            this.Qte_Prod = qte_Prod;
            this.Label_Prod = label_Prod;
            this.Prix_Prod = prix_Prod;
            this.Promo_Prod = promo_Prod;
            this.Categorie_Prod = categorie_Prod;
        }
        public Produit(string label_Prod, double prix_Prod) : this(0,label_Prod, prix_Prod,0.0,"") { }
    }
}