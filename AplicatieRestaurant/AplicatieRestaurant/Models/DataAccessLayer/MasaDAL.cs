using AplicatieRestaurant.Models.BusinessLogicLayer;
using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.DataAccessLayer
{
    class MasaDAL
    {
        internal List<Masa> ToateMesele()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select m.ID, m.Numar, m.NrLocuriLibere, m.NrLocuriOcupate, u.Nume as NumeOspatar from dbo.Masa m
                                inner join Utilizator u on u.ID = m.IDOspatar
                              
                               union

								select m.ID, m.Numar, m.NrLocuriLibere, m.NrLocuriOcupate, NULL as NumeOspatar from dbo.Masa m
								where m.IDOspatar IS NULL;";
                return connection.Query<Masa>(sql).ToList();
            }
        }

        internal void AdaugareMasa(Masa masa)
        {
          
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = @"insert into dbo.Masa (Numar, NrLocuriLibere, NrLocuriOcupate)
							values (@Numar, @NrLocuriLibere, @NrLocuriOcupate);";
                cmd.Parameters.AddWithValue("@Numar", masa.Numar);
                cmd.Parameters.AddWithValue("@NrLocuriLibere", masa.NrLocuriLibere);
                cmd.Parameters.AddWithValue("@NrLocuriOcupate", masa.NrLocuriOcupate);

                cmd.ExecuteNonQuery();
            }
        }


        internal void ModificareMasa(Masa masa)
        {

            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = @"update dbo.Masa
							set Numar = @Numar, NrLocuriLibere = @NrLocuriLibere, NrLocuriOcupate = @NrLocuriOcupate, IDOspatar = @IDOspatar
							where ID = @ID";
                cmd.Parameters.AddWithValue("@ID", masa.ID);
                cmd.Parameters.AddWithValue("@Numar", masa.Numar);
                cmd.Parameters.AddWithValue("@NrLocuriLibere", masa.NrLocuriLibere);
                cmd.Parameters.AddWithValue("@NrLocuriOcupate", masa.NrLocuriOcupate);


                if (masa.NumeOspatar == null)
                {
                    cmd.Parameters.AddWithValue("@IDOspatar", DBNull.Value);
                }
                else
                {
                    Utilizator ospatar = new Utilizator();
                    UtilizatorBLL utilizatorBLL = new UtilizatorBLL();
                    List<Utilizator> utilizatori = utilizatorBLL.TotiUtilizatorii();
                    foreach (Utilizator utilizator in utilizatori)
                    {
                        if (utilizator.Nume == masa.NumeOspatar)
                        {
                            ospatar = utilizator;
                            cmd.Parameters.AddWithValue("@IDOspatar", ospatar.ID);
                        }
                    }
                }

                cmd.ExecuteNonQuery();

            }
        }

        internal void StergeMasa(Masa masa)
        {
            using (SqlConnection sc = DALHelper.Connection)
            using (var cmd = sc.CreateCommand())
            {
                sc.Open();
                cmd.CommandText = "DELETE FROM dbo.Masa WHERE ID = @ID";
                cmd.Parameters.AddWithValue("@ID", masa.ID);
                cmd.ExecuteNonQuery();
            }
        }
    }
}
