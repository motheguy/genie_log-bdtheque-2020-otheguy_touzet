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

        public Album() { }
        public Album(int id)
        {
            Id = id;
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
        }
    }
}
