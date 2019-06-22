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
        //metoda wypisania danych z bazy
        public static List<nowezzz> LoadHist()
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                var output = cnn.Query<nowezzz>("select * from Hist", new DynamicParameters());
                return output.ToList();
            }
        }

        //metoda  zapisania danych do bazy
        public static void SaveHistory(nowezzz hist)
        {
            using (IDbConnection cnn = new SQLiteConnection(LoadConnectionString()))
            {
                cnn.Execute("insert into Hist (Url) " + "values (@Url)", hist);


            }
        }

        public static string LoadConnectionString(string id = "Default")
        { return ConfigurationManager.ConnectionStrings[id].ConnectionString; }

       
    }
}