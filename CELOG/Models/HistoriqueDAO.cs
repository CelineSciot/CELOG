using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public static class HistoriqueDAO
    {
        private static readonly string QUERY = "SELECT * FROM Historique";
        private static readonly string GET = QUERY + " WHERE id_User = @id_User";
        private static readonly string CREATE = "INSERT INTO Historique(id_User,resume,total) OUTPUT INSERTED.id_Historique VALUES(@id_User,@resume,@total) ";
        private static readonly string DELETE = "DELETE FROM Historique WHERE id_User = @id";
       // private static readonly string UPDATE = "UPDATE Commande SET id_Utilisateur=@id_Utilisateur,id_Produit=@id_Produit,quantite=@quantite";
        //private static readonly string GETCATEG = "SELECT distinct categorie_Prod FROM Produit";


        public static List<Historique> GetAllHistoriques()
        {
            List<Historique> historiques = new List<Historique>();

            using (SqlConnection connection = DataBase.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(QUERY, connection);

                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Historique hist = new Historique(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetDecimal(3)
                        );
                       
                   historiques.Add(hist);
                }
            }
            return historiques;
        }

       
        public static List<Historique> Get(int id)
        {
            List<Historique> historiques = new List<Historique>();

            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
               
                SqlCommand command = new SqlCommand(GET, conn);
                command.Parameters.AddWithValue("@id_User", id);


                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    Historique hist = new Historique(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                       reader.GetString(2),
                       reader.GetDecimal(3)
                      
                       );
                    historiques.Add(hist);
                }
            }
            return historiques;
        }

        public static Historique Create(Historique historique)
        {
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
                
                SqlCommand command = new SqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("@id_User", historique.Id_User);
                command.Parameters.AddWithValue("@resume", historique.Resume);
                command.Parameters.AddWithValue("@total", historique.Total);

                historique.Id_Historique = (int)command.ExecuteScalar();
            }
            return historique;
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