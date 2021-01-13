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
            Album a1 = new Album("../../../img/1.jpg", "Astérix et Cléopâtre","Astérix", "René Goscinny, Albert Uderzo","BD", "humoristique", "Hachette Livre");
            albumRepo.Save(a1);
            Album a2 = new Album("../../../img/2.jpg", "La serpe d'or", "Astérix", "René Goscinny, Albert Uderzo", "BD", "humoristique", "Hachette Livre");
            albumRepo.Save(a2);
            Album a3 = new Album("../../../img/3.jpg", "Astérix le Gaulois", "Astérix", "René Goscinny, Albert Uderzo", "BD", "humoristique", "Hachette Livre");
            albumRepo.Save(a3);
            Album a4 = new Album("../../../img/4.jpg", "Objectif Lune", "Tintin", "Hergé", "BD", "aventure", "Casterman");
            albumRepo.Save(a4);
            Album a5 = new Album("../../../img/5.jpg", "On a marché sur la Lune", "Tintin", "Hergé", "BD", "aventure", "Casterman");
            albumRepo.Save(a5);

            IndividualRepository indivRepo = new IndividualRepository();
            Admin i1 = new Admin("motheguy", "1234");
            User i2 = new User("mtouzet", "mdp");
            i2.AddComicWanted(a1);
            i2.AddComicWanted(a3);
            i2.AddComicOwned(a5);
            List<Individual> individuals = new List<Individual> { i1, i2};
            individuals.ForEach(i => indivRepo.Save(i));

            Console.WriteLine("Done!");
            Console.ReadKey();

        }
    }
}
