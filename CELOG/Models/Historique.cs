using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public class Historique
    {


        public int Id_Historique
        {
            get;
            set;
        }

        public int Id_User
        {
            get;
            set;
        }

        public string Resume
        {
            get;
            set;
        }

        public decimal Total
        {
            get;
            set;
        }

        public Historique()
        {
        }

        public Historique(int id_Historique,int id_User, string resume, decimal total)
        {
            Id_Historique = id_Historique;
            Id_User = id_User;
            Resume = resume;
            Total = total;
        }
        //public Commande(int qte_Prod,string label_Prod, decimal prix_Prod, decimal promo_Prod, string categorie_Prod, string UrlImage_Prod) : this(0,qte_Prod, label_Prod, prix_Prod, promo_Prod, categorie_Prod, UrlImage_Prod) { }
    }
}