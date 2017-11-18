using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public static class UtilisateurDAO
    {
        private static readonly string QUERY = "SELECT * FROM Utilisateur";
        private static readonly string GET = QUERY + "WHERE id_User = @id_User";
        private static readonly string CREATE = "INSERT INTO Utilisateur(mdp_User,sexe_User,adresse_User,dateNais_User,numCompte_User,login_User) OUTPUT INSERTED.id_User VALUES(@mdp_User,@sexe_User,@adresse_User,@dateNais_User,@numCompte_User,@login_User) ";
        private static readonly string DELETE = "DELETE FROM Utilisateur WHERE id_User = @id_User";
        private static readonly string UPDATE = "UPDATE Utilisateur SET mdp_User=@mdp_User ,sexe_User= @sexe_User,adresse_User=@adresse_User ,dateNais_User=@dateNais_User ,numCompte_User=@numCompte_User, login_User=@login_User WHERE id_User = @id_User";

        public static List<Utilisateur> GetAllUtilisateur()
        {
            List<Utilisateur> utilisateurs = new List<Utilisateur>();

            using (SqlConnection connection = DataBase.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(QUERY, connection);

                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Utilisateur util = new Utilisateur(
                        reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetString(5),
                        reader.GetString(6));
                    utilisateurs.Add(util);
                }
            }
            return utilisateurs;
        }
        
        //TODO
        public static Utilisateur Get(int id)
        {
            Utilisateur utilisateur = new Utilisateur();

            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
               
                SqlCommand command = new SqlCommand(GET, conn);
                command.Parameters.AddWithValue("@id_User", id);
               

                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    utilisateur = new Utilisateur(
                       reader.GetInt32(0),
                        reader.GetString(1),
                        reader.GetInt32(2),
                        reader.GetInt32(3),
                        reader.GetDateTime(4),
                        reader.GetString(5),
                        reader.GetString(6));
                }
            }
            return utilisateur;
        }

        public static Utilisateur Create(Utilisateur utilisateur)
        {
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
                
                SqlCommand command = new SqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("@login_User", utilisateur.Login_User);
                command.Parameters.AddWithValue("@mdp_User", utilisateur.Mdp_User);
                command.Parameters.AddWithValue("@adresse_User", utilisateur.Adresse_User);
                command.Parameters.AddWithValue("@dateNais_User", utilisateur.DateNais_User);
                command.Parameters.AddWithValue("@numCompte_User", utilisateur.NumCompte_User);
                command.Parameters.AddWithValue("@sexe_User", utilisateur.Sexe_User);

                utilisateur.Id_User = (int)command.ExecuteScalar();
            }
            return utilisateur;
        }

        public static bool Delete(int id)
        {
            bool estSupprime = false;
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();


                SqlCommand command = new SqlCommand(DELETE, conn);
                command.Parameters.AddWithValue("@id_User", id);

                estSupprime = command.ExecuteNonQuery() != 0;
            }

            return estSupprime;
        }
        
        public static bool Update(Utilisateur utilisateur)
        {
            bool aEteModifie = false;
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();

                SqlCommand command = new SqlCommand(UPDATE, conn);
                command.Parameters.AddWithValue("@login_User", utilisateur.Login_User);
                command.Parameters.AddWithValue("@mdp_User", utilisateur.Mdp_User);
                command.Parameters.AddWithValue("@adresse_User", utilisateur.Adresse_User);
                command.Parameters.AddWithValue("@dateNais_User", utilisateur.DateNais_User);
                command.Parameters.AddWithValue("@numCompte_User", utilisateur.NumCompte_User);
                command.Parameters.AddWithValue("@sexe_User", utilisateur.Sexe_User);
                command.Parameters.AddWithValue("@id_User", utilisateur.Id_User);


                aEteModifie = command.ExecuteNonQuery() != 0;

            }
            return aEteModifie;
        }
    }
}