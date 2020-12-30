using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;

namespace BLL
{
    public class AdminDBShowBLL
    {
        private AdminDBShowDAL adminDB;
        public AdminDBShowBLL()
        {
            adminDB = new AdminDBShowDAL();
        }
        public DataTable ShowDB()
        {
            return adminDB.ShowDB();
        }
    }
}
