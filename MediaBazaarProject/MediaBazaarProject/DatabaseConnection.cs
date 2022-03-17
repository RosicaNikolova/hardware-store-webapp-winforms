using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarProject
{
    public class DatabaseConnection
    {
        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection("server = localhost; database = mediabazaar_database; uid = root; password = ceVu9eTH; "); //here change the database string to yours
        }
    }
}
