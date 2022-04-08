using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaBazaarLibrary
{
    public class DatabaseConnection
    {
        public static MySqlConnection CreateConnection()
        {
            return new MySqlConnection("Server=studmysql01.fhict.local;Uid=dbi497286;Database=dbi497286;Pwd=9Rosica9"); //here change the database string to yours
        }
    }
}
