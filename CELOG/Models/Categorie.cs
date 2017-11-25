using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public class Categorie
    {
        public int Id_Categ
        {
            get;
            set;
        }

        public int NbProd_Categ
        {
            get;
            set;
        }

        public string Nom_Categ
        {
            get;
            set;
        }


        public Categorie()
        {
        }

        public Categorie(int id_Categ, int nbProd_Categ, string nom_Categ)
        {
            Id_Categ = id_Categ;
            this.NbProd_Categ = nbProd_Categ;
            this.Nom_Categ = nom_Categ;
        }

        public Categorie(int nbProd_Categ, string nom_Categ) : this(0, nbProd_Categ, nom_Categ) { }
    }
}