using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CELOG.Models
{
    public static class ProduitDAO
    {
        private static readonly string QUERY = "SELECT * FROM Produit";
        private static readonly string GET = QUERY + "WHERE id_prod = @id";
        private static readonly string CREATE = "INSERT INTO Produit(qte_Prod,label_Prod,prix_Prod,promo_Prod,categorie_Prod,urlImage_Prod) OUTPUT INSERTED.id_Prod VALUES(@qte_Prod,@label_Prod,@prix_Prod,@promo_Prod,@categorie_Prod,@UrlImage_Prod) ";
        private static readonly string DELETE = "DELETE FROM produit WHERE id_prod = @id";
        private static readonly string UPDATE = "UPDATE Produit SET qte_Prod=@qte_Prod ,label_Prod= @label_Prod,prix_Prod=@prix_Prod ,promo_Prod=@promo_Prod ,categorie_Prod=@categorie_Prod, urlImage_Prod=@URlImage_Prod";

        public static List<Produit> GetAllProduit()
        {
            List<Produit> produits = new List<Produit>();

            using (SqlConnection connection = DataBase.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(QUERY, connection);

                SqlDataReader reader = command.ExecuteReader();

                //TODO
                while (reader.Read())
                {
                    produits.Add(new Produit(reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetDouble(2),
                                        reader.GetDouble(3),
                                        reader.GetString(4),
                                        reader.GetString(5)

                                       ));
                }
            }
            return produits;
        }

        public static Produit Get(int id)
        {
            Produit produit = null;


            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();

                SqlCommand command = new SqlCommand(GET, conn);
                command.Parameters.AddWithValue("@id_Prod", id);

                SqlDataReader reader = command.ExecuteReader();
                //TODO
                if (reader.Read())
                {
                    produit = new Produit(reader.GetInt32(0),
                                        reader.GetString(1),
                                        reader.GetDouble(2),
                                        reader.GetDouble(3),
                                        reader.GetString(4),
                                        reader.GetString(5)
                                       );
                }
            }
            return produit;
        }

        public static Produit Create(Produit produit)
        {
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
                //TODO
                SqlCommand command = new SqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("@label_Prod", produit.Label_Prod);
                command.Parameters.AddWithValue("@qte_Prod", produit.Qte_Prod);
                command.Parameters.AddWithValue("@prix_Prod", produit.Prix_Prod);
                command.Parameters.AddWithValue("@categorie_Prod", produit.Categorie_Prod);
                command.Parameters.AddWithValue("@promo_Prod", produit.Promo_Prod);
                command.Parameters.AddWithValue("@UrlImage_Prod", produit.UrlImage_Prod);

                produit.Id_Prod = (int)command.ExecuteScalar();
            }
            return produit;
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
        //TODO
        public static bool Update(Produit produit)
        {
            bool aEteModifie = false;
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();

                SqlCommand command = new SqlCommand(UPDATE, conn);
                command.Parameters.AddWithValue("@label_Produit", produit.Label_Prod);
                command.Parameters.AddWithValue("@qte_Prod", produit.Qte_Prod);
                command.Parameters.AddWithValue("@prix_Prod", produit.Prix_Prod);
                command.Parameters.AddWithValue("@categorie_Prod", produit.Categorie_Prod);
                command.Parameters.AddWithValue("@promo_Prod", produit.Promo_Prod);
                command.Parameters.AddWithValue("@UrlImage_Prod", produit.UrlImage_Prod);

                command.Parameters.AddWithValue("@id", produit.Id_Prod);

            }
            return aEteModifie;
        }
    }
}