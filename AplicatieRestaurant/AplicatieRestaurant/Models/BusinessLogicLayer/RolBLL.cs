using AplicatieRestaurant.Models.DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicatieRestaurant.Models.BusinessLogicLayer
{
    class RolBLL
    {
        RolDAL rolDAL;

        public RolBLL()
        {
            rolDAL = new RolDAL();
        }

        internal List<Rol> ToateRolurile()
        {
            return rolDAL.ToateRolurile();
        }
    }
}
