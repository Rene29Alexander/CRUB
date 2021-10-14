using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace CRUB
{
    class Crud
    {
        
        private Connection conn = new Connection();

        
        public MySqlDataReader select(string query)
        {
            MySqlDataReader dataReader;

            
            conn.command = new MySqlCommand(query, conn.openConnection());
            dataReader = conn.command.ExecuteReader();
            return dataReader;
        }

       
    }
}