using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace DAL
{
    class DBConnection
    {
        private readonly string _connectionString;

        public DBConnection()
        {
            _connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/ugurc/Desktop/emrekiran/Veritabanı2.accdb";
        }

        private OleDbConnection GetAccessConnection()
        {
            OleDbConnection connection = new OleDbConnection(_connectionString);

            if(connection.State == ConnectionState.Open)
            {
                connection.Close();
                connection.Open();
            }
            else
            {
                connection.Open();
            }
            return connection;
        }

        public OleDbCommand GetAccessCommand()
        {
            OleDbCommand command = new OleDbCommand();
            command.Connection = GetAccessConnection();
            return command;
        }

    }
}
