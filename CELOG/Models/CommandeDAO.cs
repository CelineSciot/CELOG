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
        private static readonly string GET = QUERY + " WHERE id_Utilisateur = @id_Utilisateur";
        private static readonly string CREATE = "INSERT INTO Commande(id_Commande,id_Utilisateur,id_Produit,quantite) OUTPUT INSERTED.id_Commande VALUES(@id_Utilisateur,@id_Produit,@quantite) ";
        private static readonly string DELETE = "DELETE FROM Commande WHERE id_Utilisateur = @id";
       // private static readonly string UPDATE = "UPDATE Commande SET id_Utilisateur=@id_Utilisateur,id_Produit=@id_Produit,quantite=@quantite";
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
                        reader.GetInt32(2));
                       
                    commandes.Add(comm);
                }
            }
            return commandes;
        }

       
        public static Commande Get(int id)
        {
            Commande comm = new Commande();

            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
               
                SqlCommand command = new SqlCommand(GET, conn);
                command.Parameters.AddWithValue("@id_Utilisateur", id);
                // EXECPTION ICI avec le =
                //System.Data.SqlClient.SqlException : 'Incorrect syntax near '='.'

                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    comm = new Commande(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                       reader.GetInt32(2)
                      
                                       );
                }
            }
            return comm;
        }

        public static Commande Create(Commande commande)
        {
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
                
                SqlCommand command = new SqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("@id_Utilisateur", commande.Id_Utilisateur);
                command.Parameters.AddWithValue("@id_Produit", commande.Id_Produit);
                command.Parameters.AddWithValue("@quantite", commande.Quantite);

               commande.Id_Commande = (int)command.ExecuteScalar();
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
        
       /* public static bool Update(Produit produit)
        {
            bool aEteModifie = false;
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();

                SqlCommand command = new SqlCommand(UPDATE, conn);
                command.Parameters.AddWithValue("@label_Prod", produit.Label_Prod);
                command.Parameters.AddWithValue("@qte_Prod", produit.Qte_Prod);
                command.Parameters.AddWithValue("@prix_Prod", produit.Prix_Prod);
                command.Parameters.AddWithValue("@categorie_Prod", produit.Categorie_Prod);
                command.Parameters.AddWithValue("@promo_Prod", produit.Promo_Prod);
                command.Parameters.AddWithValue("@urlImage_Prod", produit.UrlImage_Prod);
                command.Parameters.AddWithValue("@id_Prod", produit.Id_Prod);

                aEteModifie = command.ExecuteNonQuery() != 0;
            }
            return aEteModifie;
        }*/
    }
}