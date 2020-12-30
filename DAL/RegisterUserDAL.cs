using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class RegisterUserDAL
    {
        private DBConnection dBConnection;
        public RegisterUserDAL()
        {
            dBConnection = new DBConnection();
        }

        public bool RegisterUser(string kullaniciadi, string sifre, string adsoyad)
        {
            OleDbCommand command = dBConnection.GetAccessCommand();
            command.CommandText = string.Format("Select * from Users where kullaniciadi = '{0}'", kullaniciadi);
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                dr.Close();
                return true;
            }
            else
            {
                dr.Close();
                command.CommandText = string.Format("Insert Into Users( kullaniciadi,sifre,adsoyad) values('{0}','{1}','{2}')", kullaniciadi, sifre, adsoyad);
               
                command.ExecuteNonQuery();
                return false;
            }
        }
    }
}
