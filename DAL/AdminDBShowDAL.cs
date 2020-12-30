using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class AdminDBShowDAL
    {
        private DBConnection dBConnection;
        public AdminDBShowDAL()
        {
            dBConnection = new DBConnection();
        }
        public DataTable ShowDB()
        {
            OleDbCommand command = dBConnection.GetAccessCommand();
            command.CommandText = string.Format("Select * From Users");
            DataTable dt = new DataTable();
            dt.Load(command.ExecuteReader());
            return dt;
        }
    }
}
