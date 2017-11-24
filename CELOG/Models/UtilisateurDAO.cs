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
        private static readonly string GET = QUERY + " WHERE id_User = @id_User";
        private static readonly string CREATE = "INSERT INTO Utilisateur(login_User,mdp_User,sexe_User,dateNais_User,numCompte_User,rue_User,num_User,codePostal_User,ville_User,pays_User) OUTPUT INSERTED.id_User VALUES(@login_User,@mdp_User,@sexe_User,@dateNais_User,@numCompte_User,@rue_User,@num_User,@codePostal_User,@ville_User,@pays_User) ";
        private static readonly string DELETE = "DELETE FROM Utilisateur WHERE id_User = @id_User";
        private static readonly string UPDATE = "UPDATE Utilisateur SET login_User=@login_User,mdp_User=@mdp_User,sexe_User=@sexe_User,dateNais_User=@dateNais_User,numCompte_User=@numCompte_User,rue_User=@rue_User,num_User=@num_User,codePostal_User=@codePostal_User,ville_User=@ville_User,pays_User=@pays_User WHERE id_User = @id_User";
        private static readonly string GETTOKEN = "SELECT * FROM Utilisateur WHERE login_User=@email and mdp_User=@password";
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
                        (int)reader["id_User"],
                        (string)reader["mdp_User"],
                        (string)reader["sexe_User"],
                        (string)reader["dateNais_User"],
                        (string)reader["numCompte_User"],
                        (string)reader["login_User"],
                        (string)reader["rue_User"],
                        (string)reader["num_User"],
                        (int)reader["codePostal_User"],
                        (string)reader["ville_User"],
                        (string)reader["pays_User"]

                        );
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
                     (int)reader["id_User"],
                        (string)reader["mdp_User"],
                        (string)reader["sexe_User"],
                        (string)reader["dateNais_User"],
                        (string)reader["numCompte_User"],
                        (string)reader["login_User"],
                        (string)reader["rue_User"],
                        (string)reader["num_User"],
                        (int)reader["codePostal_User"],
                        (string)reader["ville_User"],
                        (string)reader["pays_User"]);
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
                command.Parameters.AddWithValue("@dateNais_User", utilisateur.DateNais_User);
                command.Parameters.AddWithValue("@numCompte_User", utilisateur.NumCompte_User);
                command.Parameters.AddWithValue("@sexe_User", utilisateur.Sexe_User);
                command.Parameters.AddWithValue("@rue_User", utilisateur.Rue_User);
                command.Parameters.AddWithValue("@num_User", utilisateur.Num_User);
                command.Parameters.AddWithValue("@codePostal_User", utilisateur.CodePostal_User);
                command.Parameters.AddWithValue("@ville_User", utilisateur.Ville_User);
                command.Parameters.AddWithValue("@pays_User", utilisateur.Pays_User);
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
                command.Parameters.AddWithValue("@dateNais_User", utilisateur.DateNais_User);
                command.Parameters.AddWithValue("@numCompte_User", utilisateur.NumCompte_User);
                command.Parameters.AddWithValue("@sexe_User", utilisateur.Sexe_User);
                command.Parameters.AddWithValue("@rue_User", utilisateur.Rue_User);
                command.Parameters.AddWithValue("@num_User", utilisateur.Num_User);
                command.Parameters.AddWithValue("@codePostal_User", utilisateur.CodePostal_User);
                command.Parameters.AddWithValue("@ville_User", utilisateur.Ville_User);
                command.Parameters.AddWithValue("@pays_User", utilisateur.Pays_User);
                command.Parameters.AddWithValue("@id_User", utilisateur.Id_User);

                aEteModifie = command.ExecuteNonQuery() != 0;

            }
            return aEteModifie;
        }

        public static bool GetConnection(string username, string password)
        {
            using (SqlConnection connection = DataBase.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(GETTOKEN, connection);
                command.Parameters.AddWithValue("@email", username);
                command.Parameters.AddWithValue("@password", password);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    return true;
                }
            }
            return false;
        }

    }
}