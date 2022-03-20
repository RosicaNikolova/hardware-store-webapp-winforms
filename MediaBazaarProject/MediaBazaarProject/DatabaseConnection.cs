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
            return new MySqlConnection("server=localhost;database=media_bazar;uid=root;password=9Rosica9;"); //here change the database string to yours
        }
    }
}
