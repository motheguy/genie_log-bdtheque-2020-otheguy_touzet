using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using DAL;
using Domain;


namespace DAL.Tests
{
    [TestClass()]
    public class AlbumRepositoryTests : Repository
    {
        private IAlbumRepository albumRepository;
        private Album a;
        private Album b;
        private Album c;
        private Album d;
        private Album e;
        private Album p;
        private Album w;
        private User u;

        [TestInitialize]
        public void TestInit()
        {
            this.albumRepository = new AlbumRepository();
            this.a = new Album("testa", "test", "test", "test", "test", "test", "test");
            this.b = new Album("testb", "test", "test", "test", "test", "test", "test");
            this.c = new Album("testc", "test", "test", "test", "test", "test", "test");
            this.d = new Album("testd", "test", "test", "test", "test", "test", "test");
            this.e = new Album("teste", "test", "test", "test", "test", "test", "test");
            this.p = new Album("en possession", "test", "test", "test", "test", "test", "test");
            this.w = new Album("en souhait", "test", "test", "test", "test", "test", "test");
            this.u = new User("Martin", "malin");
            
        }

        [TestMethod()]
        public void GetAllTest()
        {
            int nbEx = Session.QueryOver<Album>().RowCount();
            int nbRe = albumRepository.GetAll().Count;
            Assert.AreEqual(nbEx, nbRe);
        }

        [TestMethod()]
        public void GetPossessTest()
        {
            albumRepository.Save(p);
            u.AddComicOwned(p);
            int nb = albumRepository.GetPossess(u).Count;
            Assert.AreEqual(1,nb);
        }

        [TestMethod()]
        public void GetSouhaitTest()
        {
            albumRepository.Save(w);
            u.ComicsWanted.Add(w) ;
            int nb = albumRepository.GetSouhait(u).Count;
            Assert.AreEqual(1, nb);
        }

        [TestMethod()]
        public void SearchTest()
        {
            albumRepository.Save(c);
            bool real = albumRepository.Search("test").Contains(c);
            Assert.AreEqual(true,real);
        }

        [TestMethod()]
        public void SearchOwnedTest()
        {
            albumRepository.Save(d);
            u.AddComicOwned(d);
            albumRepository.Save(d);
            bool real = albumRepository.SearchOwned(u,"test").Contains(d);
            Assert.AreEqual(true, real);
        }

        [TestMethod()]
        public void SearchWantedTest()
        {
            albumRepository.Save(e);
            u.AddComicWanted(e);
            albumRepository.Save(e);
            bool real = albumRepository.SearchWanted(u, "test").Contains(e);
            Assert.AreEqual(true, real);
        }

        [TestMethod()]
        public void SaveTest()
        {
            albumRepository.Save(a);
            Assert.AreEqual(a,albumRepository.GetAll().Last()) ;
        }

        [TestMethod()]
        public void DeleteTest()
        {
            albumRepository.Save(b);
            albumRepository.Delete(b);
            bool presence = albumRepository.GetAll().Last()==b;
            Assert.AreEqual(false,presence);
        }

        [TestCleanup]
        public void TestClean()
        {
            albumRepository.Delete(a);
            albumRepository.Delete(c);
            albumRepository.Delete(d);
            albumRepository.Delete(e);
            albumRepository.Delete(p);
            albumRepository.Delete(w);
            
            this.albumRepository = null;
            this.a = null;
            this.b = null;
            this.c = null;
            this.d = null;
            this.e = null;
            this.p = null;
            this.w = null;
            this.u = null;
        }
    }
}