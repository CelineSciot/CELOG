using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public static class ProduitDAO
    {
        private static readonly string QUERY = "SELECT * FROM Produit";
        private static readonly string GET = QUERY + "WHERE id_Prod = @id_Prod";
        private static readonly string CREATE = "INSERT INTO Produit(qte_Prod,label_Prod,prix_Prod,promo_Prod,categorie_Prod,urlImage_Prod) OUTPUT INSERTED.id_Prod VALUES(@qte_Prod,@label_Prod,@prix_Prod,@promo_Prod,@categorie_Prod,@UrlImage_Prod) ";
        private static readonly string DELETE = "DELETE FROM produit WHERE id_prod = @id";
        private static readonly string UPDATE = "UPDATE Produit SET qte_Prod=@qte_Prod ,label_Prod= @label_Prod,prix_Prod=@prix_Prod ,promo_Prod=@promo_Prod ,categorie_Prod=@categorie_Prod, urlImage_Prod=@urlImage_Prod WHERE id_Prod = @id_Prod";

        public static List<Produit> GetAllProduit()
        {
            List<Produit> produits = new List<Produit>();

            using (SqlConnection connection = DataBase.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(QUERY, connection);

                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Produit prod = new Produit(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2),
                        reader.GetDecimal(3),
                        reader.GetDecimal(4),
                        reader.GetString(5),
                        reader.GetString(6));
                    produits.Add(prod);
                }
            }
            return produits;
        }
        
        public static Produit Get(int id)
        {
            Produit produit = new Produit();

            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
               
                SqlCommand command = new SqlCommand(GET, conn);
                command.Parameters.AddWithValue("@id_Prod", id);
                // EXECPTION ICI avec le =
                //System.Data.SqlClient.SqlException : 'Incorrect syntax near '='.'

                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    produit = new Produit(
                       reader.GetInt32(0),
                       reader.GetInt32(1),
                       reader.GetString(2),
                       reader.GetDecimal(3),
                       reader.GetDecimal(4),
                       reader.GetString(5),
                       reader.GetString(6)
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
                
                SqlCommand command = new SqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("@qte_Prod", produit.Qte_Prod);
                command.Parameters.AddWithValue("@label_Prod", produit.Label_Prod);
                command.Parameters.AddWithValue("@prix_Prod", produit.Prix_Prod);
                command.Parameters.AddWithValue("@promo_Prod", produit.Promo_Prod);
                command.Parameters.AddWithValue("@categorie_Prod", produit.Categorie_Prod);
                command.Parameters.AddWithValue("@urlImage_Prod", produit.UrlImage_Prod);

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
        
        public static bool Update(Produit produit)
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
        }
    }
}