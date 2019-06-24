using Dapper;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proj_przegladarka
{
    public class SqlDataAcces
    {
        

        public static string LoadConnectionString(string id = "Default")
        { return ConfigurationManager.ConnectionStrings[id].ConnectionString; }

       
    }
}