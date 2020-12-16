using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;

namespace InitDB
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exporting DB schema... ");

            Configuration cfg = new Configuration();
            cfg.Configure();
            // Update database according to mapping files and DB credentials
            new SchemaExport(cfg).Execute(true, true, false);

            //Initialize data for tables
            //string sqlQuery;
            //string filePath = Directory.GetCurrentDirectory();
            //filePath = filePath.Split(new[] {"BDtheque" },StringSplitOptions.None)[0]+ @"BDtheque\DAL\DB\Content.sql";
            ////Console.WriteLine(filePath);
            //using (FileStream file = File.OpenRead(filePath))
            //{
            //    var reader = new StreamReader(file);
            //    sqlQuery = reader.ReadToEnd();
            //}

            //ISession Session = cfg.Configure().BuildSessionFactory().OpenSession();
            //Session.CreateSQLQuery(sqlQuery);
            

            Console.WriteLine("Done!");
            Console.ReadKey();

        }
    }
}
