using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using DAL;
using Domain;

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
            AlbumRepository albumRepo = new AlbumRepository();
            Album a = new Album("adresse_img", "Astérix et Cléopâtre","Astérix", "René Goscinny, Albert Uderzo","", "humoristique","Dargaud" );
            albumRepo.Save(a);

            IndividualRepository indivRepo = new IndividualRepository();
            Admin i1 = new Admin("motheguy", "1234");
            User i2 = new User("mtouzet", "mdp");
            i2.AddComicWanted(a);
            List<Individual> individuals = new List<Individual> { i1, i2};
            individuals.ForEach(i => indivRepo.Save(i));

            Console.WriteLine("Done!");
            Console.ReadKey();

        }
    }
}
