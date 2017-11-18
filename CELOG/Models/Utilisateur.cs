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

        public int Sexe_User
        {
            get;
            set;
        }

        public int Adresse_User
        {
            get;
            set;
        }
        public DateTime DateNais_User
        {
            get;
            set;
        }
        public string NumCompte_User
        {
            get;
            set;
        }
       



        public Utilisateur()
        {
        }

        public Utilisateur(int id_User, string mdp_User, int sexe_User, int adresse_User, DateTime dateNais_User, string numCompte_User, string login_User)
        {
            Id_User = id_User;
            Mdp_User = mdp_User;
            Sexe_User = sexe_User;
            Adresse_User = adresse_User;
            DateNais_User = dateNais_User;
            NumCompte_User = numCompte_User;
            Login_User = login_User;
        }

        public Utilisateur(string mdp_User, int sexe_User, int adresse_User, DateTime dateNais_User, string numCompte_User, string login_User) : this(0, mdp_User, sexe_User, adresse_User, dateNais_User, numCompte_User, login_User) { }
    }
}