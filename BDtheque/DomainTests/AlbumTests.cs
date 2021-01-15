using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Domain;

namespace DomainTests
{
    [TestClass]
    public class AlbumTests
    {
        [TestMethod]
        // Vérifions que la première BD dans la liste possédé correspond bien à la BD inséré
        public void AddWantedBy_Test1()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.AddWantedBy(u);

            Assert.AreEqual(u, a.WantedBy[0]);
        }
        [TestMethod]
        // Vérifions que la première BD dans la liste possédé correspond bien à la BD inséré
        public void AddWantedBy_Test2()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.AddWantedBy(u);

            int count = a.WantedBy.Count;

            Assert.AreEqual(count, 1);
        }
        [TestMethod]
        // Vérifions que la première BD dans la liste possédé correspond bien à la BD inséré
        public void RemoveWantedBy_Test1()
        {
            User u1 = new User("mm1", "mm1");
            User u2 = new User("mm2", "mm2");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.AddWantedBy(u1);
            a.AddWantedBy(u2);
            a.RemoveWantedBy(u1);

            Assert.AreEqual(u2, a.WantedBy[0]);
        }
        [TestMethod]
        // Vérifions que la première BD dans la liste possédé correspond bien à la BD inséré
        public void RemoveWantedBy_Test2()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.AddWantedBy(u);
            a.RemoveWantedBy(u);

            int count = a.WantedBy.Count;

            Assert.AreEqual(0, count);
        }
        [TestMethod]
        // Vérifions que la première BD dans la liste souhaité correspond bien à la BD inséré
        public void AddOwnedBy_Test1()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.AddOwnedBy(u);

            Assert.AreEqual(u, a.OwnedBy[0]);
        }
        [TestMethod]
        // Vérifions que la première BD dans la liste souhaité correspond bien à la BD inséré
        public void AddOwnedBy_Test2()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.AddOwnedBy(u);

            int count = a.OwnedBy.Count;

            Assert.AreEqual(count, 1);
        }
    }
}
