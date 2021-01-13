using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using DAL;
using Domain;

namespace DALTests
{
    [TestClass()]
    public class IndividualTests
    {

        [TestMethod()]
        public void SaveTest()
        {
            IIndividualRepository indivRepository = new IndividualRepository();
            User u = new User("lundi", "mardi");
            indivRepository.Save(u);
            Assert.AreEqual(u, indivRepository.GetAll().Last());
        }

        [TestMethod()]
        public void GetAllTest()
        {
            IIndividualRepository indivRepository = new IndividualRepository();
            indivRepository.
            Assert.Fail();
        }

        [TestMethod()]
        public void GetUserTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void GetAdminTest()
        {
            Assert.Fail();
        }

        
    }
}
