using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.DataAccessLayer
{
    class ProdusDAL
    {
        internal List<Produs> ToateProdusele()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select ID, Denumire, Pret, Stoc from dbo.Produs;";
                return connection.Query<Produs>(sql).ToList();
            }
        }

        internal int AdaugareProdus(Produs produs)
        {
            string sql = @"insert into dbo.Produs (Denumire, Pret, Stoc)
                            values (@Denumire, @Pret, @Stoc);";
            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, produs);
            }
        }


        internal int ModificareProdus(Produs produs)
        {
            string sql = @"update dbo.Produs
                            set Denumire = @Denumire, Pret = @Pret, Stoc = @Stoc
                            where ID = @ID;";

            using (SqlConnection connection = DALHelper.Connection)
            {
                return connection.Execute(sql, produs);
            }
        }

        internal void StergeProdus(Produs produs)
        {
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM dbo.Produs WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", produs.ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
