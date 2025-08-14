using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace alsatminiode.Persistence
{
    static class Configuration
    {
        static public string ConnectionString
        {
            get
            {
                //ConfigurationManager configurationManager = new();
                //configurationManager.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/alsatminiode.API/"));
                //configurationManager.AddJsonFile("appsettings.json");

                //"Server=alsatminiode.com;Data Source=WIN-EI50N0U33B4\\SQLEXPRESS;Initial Catalog=alsatminiodeAPI;User Id=emperor_sql;Password=E123456s!**;"
                //return configurationManager.GetConnectionString("MSSQL");

                return "Server=alsatminiode.com;Data Source=WIN-EI50N0U33B4\\SQLEXPRESS;Initial Catalog=alsatminiodeAPI;User Id=emperor_sql;Password=21&JXH3mmH2Z;";
            }
        }
    }
}
