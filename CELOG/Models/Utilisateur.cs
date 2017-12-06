using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public class Utilisateur
    {
        public int Id_User
        {
            get;
            set;
        }
        public string Nom_User
        {
            get;
            set;
        }
        public string Login_User
        {
            get;
            set;
        }
        public string Mdp_User
        {
            get;
            set;
        }

        public string Sexe_User
        {
            get;
            set;
        }

        public string DateNais_User
        {
            get;
            set;
        }
        public string NumCompte_User
        {
            get;
            set;
        }

        public string Rue_User
        {
            get;
            set;
        }
        public string Num_User
        {
            get;
            set;
        }
        public int CodePostal_User
        {
            get;
            set;
        }
        public string Ville_User
        {
            get;
            set;
        }
        public string Pays_User
        {
            get;
            set;
        }
        public bool Status_Admin
        {
            get;
            set;
        }



        public Utilisateur()
        {
        }

        public Utilisateur(int id_User, string nom_User,string mdp_User, string sexe_User, string dateNais_User, string numCompte_User, string login_User, string rue_User, string num_User, int codePostal_User, string ville_User, string pays_User, bool status_Admin)
        {
            Id_User = id_User;
            Nom_User = nom_User;
            Mdp_User = mdp_User;
            Sexe_User = sexe_User;
            DateNais_User = dateNais_User;
            NumCompte_User = numCompte_User;
            Login_User = login_User;
            Rue_User = rue_User;
            Num_User = num_User;
            CodePostal_User = codePostal_User;
            Ville_User = ville_User;
            Pays_User = pays_User;
            Status_Admin = status_Admin;
           
        }

        public Utilisateur(string nom_User,string mdp_User, string sexe_User, string dateNais_User, string numCompte_User, string login_User, string rue_User, string num_User, int codePostal_User, string ville_User, string pays_User, bool status_Admin) : this(0,nom_User, mdp_User, sexe_User, dateNais_User, numCompte_User, login_User, rue_User, num_User, codePostal_User, ville_User, pays_User,status_Admin) { }
    }
}