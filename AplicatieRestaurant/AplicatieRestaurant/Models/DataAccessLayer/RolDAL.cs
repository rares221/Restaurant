using Dapper;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.DataAccessLayer
{
    class RolDAL
    {
        internal List<Rol> ToateRolurile()
        {
            using (SqlConnection connection = DALHelper.Connection)
            {
                string sql = @"select ID, Nume from dbo.Rol;";
                return connection.Query<Rol>(sql).ToList();
            }
        }
    }
}
