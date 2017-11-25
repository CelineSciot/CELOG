using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;


namespace CELOG.Models
{
    public static class CategorieDAO
    {
        private static readonly string QUERY = "SELECT * FROM Categorie";
        private static readonly string GET = QUERY + " WHERE id_Categ = @id_Categ";
        private static readonly string CREATE = "INSERT INTO Categorie(nbProd_Categ,nom_Categ) OUTPUT INSERTED.id_Prod VALUES(@nbProd_Categ,@nom_Categ) ";
        private static readonly string DELETE = "DELETE FROM Categorie WHERE id_Categ = @id";
        private static readonly string UPDATE = "UPDATE Categorie SET nbProd_Categ=@nbProd_Categ ,nom_Categ= @nom_Categ WHERE id_Categ = @id_Categ";

        public static List<Categorie> GetAllCategorie()
        {
            List<Categorie> categs = new List<Categorie>();

            using (SqlConnection connection = DataBase.GetSqlConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand(QUERY, connection);

                SqlDataReader reader = command.ExecuteReader();
               
                while (reader.Read())
                {
                    Categorie categ = new Categorie(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2));
                    categs.Add(categ);
                }
            }
            return categs;
        }
        
        public static Categorie Get(int id)
        {
            Categorie categ = new Categorie();

            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
               
                SqlCommand command = new SqlCommand(GET, conn);
                command.Parameters.AddWithValue("@id_Categ", id);
             
                SqlDataReader reader = command.ExecuteReader();
               
                if (reader.Read())
                {
                    categ = new Categorie(
                        reader.GetInt32(0),
                        reader.GetInt32(1),
                        reader.GetString(2)
                                       );
                }
            }
            return categ;
        }

        public static Categorie Create(Categorie categ)
        {
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();
                
                SqlCommand command = new SqlCommand(CREATE, conn);
                command.Parameters.AddWithValue("@nbProd_Categ", categ.NbProd_Categ);
                command.Parameters.AddWithValue("@nom_Categ", categ.Nom_Categ);
               

                categ.Id_Categ = (int)command.ExecuteScalar();
            }
            return categ;
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
        
        public static bool Update(Categorie categ)
        {
            bool aEteModifie = false;
            using (SqlConnection conn = DataBase.GetSqlConnection())
            {
                conn.Open();

                SqlCommand command = new SqlCommand(UPDATE, conn);
                command.Parameters.AddWithValue("@nbProd_Categ", categ.NbProd_Categ);
                command.Parameters.AddWithValue("@nom_Categ", categ.Nom_Categ);
                command.Parameters.AddWithValue("@id_Categ", categ.Id_Categ);

                aEteModifie = command.ExecuteNonQuery() != 0;
            }
            return aEteModifie;
        }
    }
}