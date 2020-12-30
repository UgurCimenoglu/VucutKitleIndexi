using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
   public class LoginDAL
    {
        private DBConnection dBConnection;   

        public LoginDAL()
        {
            dBConnection = new DBConnection();
        }

        public bool Login(string id,string password)
        {
            OleDbCommand command = dBConnection.GetAccessCommand();


            command.CommandText = string.Format("Select * from Admin Where kullaniciadi ='{0}' and sifre = '{1}'", id, password);

            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        public bool UserLogin(string id, string password)
        {
            OleDbCommand command = dBConnection.GetAccessCommand();
            command.CommandText = string.Format("Select * from Users Where kullaniciadi ='{0}' and sifre = '{1}'", id, password);

            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
