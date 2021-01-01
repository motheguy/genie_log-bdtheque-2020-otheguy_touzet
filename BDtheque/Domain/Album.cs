using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Album
    {
        public virtual int Id { get; set; }
        public virtual string Img { get; set; }
        public virtual string Nom { get; set; }
        public virtual string Serie { get; set; }
        public virtual string Auteur { get; set; }
        public virtual string Categorie { get; set; }
        public virtual string Genre { get; set; }
        public virtual string Editeur { get; set; }
        public virtual IList<User> OwnedBy { get; set; }
        public virtual IList<User> WantedBy { get; set; }

        /// <summary>
        /// Constructor for NHibernate, do no use to initialize an Individual object
        /// </summary>
        public Album() { }

        public Album(int id)
        {
            Id = id;
            OwnedBy = new List<User>();
            WantedBy = new List<User>();
        }

        public Album(string img, string nom, string serie, string auteur, string categorie, string genre, string editeur)
        {
            Img = img;
            Nom = nom;
            Serie = serie;
            Auteur = auteur;
            Categorie = categorie;
            Genre = genre;
            Editeur = editeur;
            OwnedBy = new List<User>();
            WantedBy = new List<User>();
        }
        public Album(int id, string img, string nom, string serie, string auteur, string categorie, string genre, string editeur)
        {
            Id = id;
            Img = img;
            Nom = nom;
            Serie = serie;
            Auteur = auteur;
            Categorie = categorie;
            Genre = genre;
            Editeur = editeur;
            OwnedBy = new List<User>();
            WantedBy = new List<User>();
        }
        /// <summary>
        /// Method to add an User to the list of People who Own the Album
        /// </summary>
        public virtual void AddWantedBy(User user)
        {
            WantedBy.Add(user);
        }
        /// <summary>
        /// Method to add an User to the list of People who Own the Album
        /// </summary>
        public virtual void AddOwnedBy(User user)
        {
            OwnedBy.Add(user);
        }

        public override string ToString()
        {
            return Nom;
        }
    }
}
