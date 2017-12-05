using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public static class CommandeDAO
    {
        private static readonly string QUERY = "SELECT * FROM Commande";
        private static readonly string GET = QUERY + " WHERE id_Utilisateur = @id_User";
        private static readonly string CREATE = "INSERT INTO Commande(id_Utilisateur,id_Produit,quantite,total) OUTPUT INSERTED.id_Commande VALUES(@id_User,@id_Produit,@quantite,@total) ";
        private static readonly string DELETE = "DELETE FROM Commande WHERE id_Produit = @id";
        private static readonly string UPDATE = "UPDATE Commande SET id_Utilisateur=@id_User,id_Produit=@id_Produit,quantite=@quantite,total=@total";
        //private static readonly string GETCATEG = "SELECT distinct categorie_Prod FROM Produit";


        public static List<Commande> GetAllCommandes()
        {
            List<Commande> commandes = new List<Commande>();

            using (SqlConnection connection = DataBase.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(QUERY, connection);

                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Commande comm = new Commande(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetInt32(2),
                        reader.GetDecimal(3),
                        reader.GetInt32(4)
                        );
                       
                    commandes.Add(comm);
                }
            }
            return commandes;
        }

       
        public static List<Commande> GetPanier(int id)
        {
            List<Commande> commandes =new List<Commande>();

            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
               
                SqlCommand command = new SqlCommand(GET, conn);
                command.Parameters.AddWithValue("@id_User", id);
               
                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Commande com = new Commande(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                       reader.GetInt32(2),
                       reader.GetDecimal(3),
                       reader.GetInt32(4)
                      
                       );
                    commandes.Add(com);
                }
            }
            return commandes;
        }

        public static Commande Create(Commande commande)
        {
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
                
                SqlCommand command = new SqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("@id_User", commande.Id_Utilisateur);
                command.Parameters.AddWithValue("@id_Produit", commande.Id_Produit);
                command.Parameters.AddWithValue("@quantite", commande.Quantite);
                command.Parameters.AddWithValue("@total", commande.Total);
                commande.Id_Commande= (int)command.ExecuteScalar();
            }
            return commande;
        }

        public static bool Delete(int id)
        {
            bool estSupprime = false;
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();


                SqlCommand command = new SqlCommand(DELETE, conn);
                command.Parameters.AddWithValue("@id", id);

                estSupprime = command.ExecuteNonQuery() != 0;
            }

            return estSupprime;
        }
        
       public static bool Update(Commande commande)
        {
            bool aEteModifie = false;
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();

                SqlCommand command = new SqlCommand(UPDATE, conn);
                command.Parameters.AddWithValue("@id_User", commande.Id_Utilisateur);
                command.Parameters.AddWithValue("@id_Produit", commande.Id_Produit);
                command.Parameters.AddWithValue("@quantite", commande.Quantite);
                command.Parameters.AddWithValue("@total", commande.Total);

                aEteModifie = command.ExecuteNonQuery() != 0;
            }
            return aEteModifie;
        }
    }
}