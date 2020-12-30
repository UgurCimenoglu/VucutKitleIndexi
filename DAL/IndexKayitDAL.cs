using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    public class IndexKayitDAL
    {
        private DBConnection dBConnection;

        public IndexKayitDAL()
        {
            dBConnection = new DBConnection();
        }

        public void IndexKayit(string index, string kullaniciadi) {
            OleDbCommand command = dBConnection.GetAccessCommand();
            command.CommandText = string.Format("Select * from Users where kullaniciadi='{0}'", kullaniciadi);
            OleDbDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                command.CommandText = string.Format("Update Users SET VKI='{0}' where kullaniciadi ='{1}'", index,kullaniciadi);
                dr.Close();
                command.ExecuteNonQuery();
            }
            else
            {
                dr.Close();
            }
        }

    }
}
