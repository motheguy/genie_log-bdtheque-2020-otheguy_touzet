using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Tool.hbm2ddl;
using DAL;
using Domain;

namespace DALTests
{
    [TestClass()]
    public class IndividualTests : Repository
    {
        private IIndividualRepository indivRepository;
        private User u;

        [TestInitialize]  
        public void TestInit()
        {
            this.indivRepository = new IndividualRepository();
            this.u = new User("lundi", "mardi");
        }

        [TestMethod()]
        public void SaveTest()
        {
            indivRepository.Save(u);
            Assert.AreEqual(u, indivRepository.GetAll().Last());
        }

        [TestMethod()]
        public void GetAllTest()
        {
            int nb = indivRepository.GetAll().Count;
            Assert.AreEqual(4,nb);
            
        }
        //[TestMethod()]
        //public void GetAllTest2()
        //{
        //    int nbEx = Session.QueryOver<Individual>().RowCount();
        //    int nbRe = indivRepository.GetAll().Count;
        //    Assert.AreEqual(nbEx, nbRe);

        //}

        [TestMethod()]
        public void GetUserTest()
        {
            int nb = indivRepository.GetUser().Count;
            Assert.AreEqual(2,nb);
        }

        //[TestMethod()]
        //public void GetUserTest2()
        //{
        //    int nbEx = Session.QueryOver<User>().RowCount();
        //    int nbRe = indivRepository.GetUser().Count;
        //    Assert.AreEqual(nbEx, nbRe);
        //}

        [TestMethod()]
        public void GetAdminTest()
        {
            int nb = indivRepository.GetAdmin().Count;
            Assert.AreEqual(2, nb);
        }

        [TestCleanup]
        public void TestClean()
        {
            string requete = "delete from Individual u where u.Login =?";
            Session.CreateQuery(requete).SetString(0,u.Login).ExecuteUpdate();
            this.indivRepository = null;
            this.u = null;
        }
    }
}
