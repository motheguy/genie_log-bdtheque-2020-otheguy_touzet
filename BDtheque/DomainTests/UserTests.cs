using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using Domain;

namespace DomainTests
{
    [TestClass]
    public class UserTests
    {   
        [TestMethod]
        // Vérifions que la première BD dans la liste possédé correspond bien à la BD inséré
        public void AddComicOwned_Test1()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.AddComicOwned(a);

            Assert.AreEqual(a, u.ComicsOwned[0]);
        }
        [TestMethod]
        // Vérifions que l'individu est inséré dans la liste de possesseurs pour la BD quand on ajoute la bd dans la liste de possession de l'utilisateur
        public void AddComicOwned_Test2()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.AddComicOwned(a);

            Assert.AreEqual(u, a.OwnedBy[0]);
        }
        [TestMethod]
        // Vérifions que la bd n'est pas ajouté en doublon dans la liste de possession de l'utilisateur
        public void AddComicOwned_Test3()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.ComicsOwned.Add(a);
            u.AddComicOwned(a);

            int count = u.ComicsOwned.Count(c => c==a);

            Assert.AreEqual(1,count);
        }
        [TestMethod]
        // Vérifions que l'utilisateur n'est pas ajouté en doublon dans la liste de posseseur de la BD
        public void AddComicOwned_Test4()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.OwnedBy.Add(u);
            u.AddComicOwned(a);

            int count = a.OwnedBy.Count(c => c == u);

            Assert.AreEqual(1, count);
        }

        [TestMethod]
        // Vérifions que la première BD dans la liste souhaité correspond bien à la BD inséré
        public void AddComicWanted_Test1()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.AddComicWanted(a);

            Assert.AreEqual(a, u.ComicsWanted[0]);
        }
        [TestMethod]
        // Vérifions que l'individu est inséré dans la liste de gens voulant la BD quand on ajoute la bd dans la liste de souhait de l'utilisateur
        public void AddComicWanted_Test2()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.AddComicWanted(a);

            Assert.AreEqual(u, a.WantedBy[0]);
        }
        [TestMethod]
        // Vérifions que la bd n'est pas ajouté en doublon dans la liste de souhaits de l'utilisateur
        public void AddComicWanted_Test3()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.ComicsWanted.Add(a);
            u.AddComicWanted(a);

            int count = u.ComicsWanted.Count(c => c == a);

            Assert.AreEqual(1, count);
        }
        [TestMethod]
        // Vérifions que l'utilisateur n'est pas ajouté en doublon dans la liste de gens qui souhaite la BD
        public void AddComicWanted_Test4()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            a.WantedBy.Add(u);
            u.AddComicWanted(a);

            int count = a.WantedBy.Count(c => c == u);

            Assert.AreEqual(1, count);
        }
        [TestMethod]
        // Vérifions que l'utilisateur n'est pas ajouté en doublon dans la liste de gens qui souhaite la BD
        public void RemoveComicWanted_Test1()
        {
            User u = new User("mm1", "mm1");
            Album a = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.AddComicWanted(a);
            u.RemoveComicWanted(a);

            int count = u.ComicsWanted.Count;

            Assert.AreEqual(0, count);
        }
        [TestMethod]
        // Vérifions que l'utilisateur n'est pas ajouté en doublon dans la liste de gens qui souhaite la BD
        public void RemoveComicWanted_Test2()
        {
            User u = new User("mm1", "mm1");
            Album a1 = new Album("adresse_img", "Astérix et Cléopâtre", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            Album a2 = new Album("adresse_img", "Astérix et Cléopâtre 2", "Astérix", "René Goscinny, Albert Uderzo", "", "humoristique", "Dargaud");
            u.AddComicWanted(a1);
            u.AddComicWanted(a2);
            u.RemoveComicWanted(a1);

            Assert.AreEqual(u.ComicsWanted[0], a2);
        }

    }
}
