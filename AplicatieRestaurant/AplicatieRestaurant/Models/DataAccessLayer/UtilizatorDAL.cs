using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.DataAccessLayer
{
    class UtilizatorDAL
    {
        internal List<Utilizator> TotiUtilizatorii()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select u.ID, u.Nume, u.Prenume, u.NumeUtilizator, u.Parola, r.Nume as Rol from dbo.Utilizator u
                                inner join Rol r on r.ID = u.IDRol;";
                return connection.Query<Utilizator>(sql).ToList();
            }
        }

        internal List<Utilizator> TotiOspatarii()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select u.ID, u.Nume, u.Prenume, u.NumeUtilizator, u.Parola, r.Nume as Rol from dbo.Utilizator u
                                inner join Rol r on r.ID = u.IDRol
                                where r.Nume = 'ospatar';";
                return connection.Query<Utilizator>(sql).ToList();
            }
        }

        internal void AdaugareUtilizator(Utilizator utilizator)
        {
            int idRol=0;

            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "select ID from dbo.Rol where Nume = @Nume";
                cmd.Parameters.AddWithValue("@Nume", utilizator.Rol);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idRol = Convert.ToInt32(reader["ID"]);
                    }
                }
            }

            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = @"insert into dbo.Utilizator (Nume, Prenume, NumeUtilizator, Parola, IDRol)
							values (@Nume, @Prenume, @NumeUtilizator, @Parola, @IDRol);";
                cmd.Parameters.AddWithValue("@Nume", utilizator.Nume);
                cmd.Parameters.AddWithValue("@Prenume", utilizator.Prenume);
                cmd.Parameters.AddWithValue("@NumeUtilizator", utilizator.NumeUtilizator);
                cmd.Parameters.AddWithValue("@Parola", utilizator.Parola);
                cmd.Parameters.AddWithValue("@IDRol", idRol);

                cmd.ExecuteNonQuery();
            }
        }


        internal void ModificareUtilizator(Utilizator utilizator)
        {
            int idRol = 0;

            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "select ID from dbo.Rol where Nume = @Nume";
                cmd.Parameters.AddWithValue("@Nume", utilizator.Rol);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        idRol = Convert.ToInt32(reader["ID"]);
                    }
                }
            }

            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = @"update dbo.Utilizator
							set Nume = @Nume, Prenume = @Prenume, NumeUtilizator = @NumeUtilizator, Parola = @Parola, IDRol = @IDRol
							where ID = @ID;";
                cmd.Parameters.AddWithValue("@ID", utilizator.ID);
                cmd.Parameters.AddWithValue("@Nume", utilizator.Nume);
                cmd.Parameters.AddWithValue("@Prenume", utilizator.Prenume);
                cmd.Parameters.AddWithValue("@NumeUtilizator", utilizator.NumeUtilizator);
                cmd.Parameters.AddWithValue("@Parola", utilizator.Parola);
                cmd.Parameters.AddWithValue("@IDRol", idRol);

                cmd.ExecuteNonQuery();
            }
        }

        internal void StergeUtilizator(Utilizator utilizator)
        {
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM dbo.Utilizator WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", utilizator.ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
