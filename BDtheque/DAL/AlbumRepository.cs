using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AlbumRepository : Repository, IAlbumRepository
    {
        public List<Album> GetAll()
        {
            return Session.Query<Album>().ToList();
        }

        public List<Album> GetPossess(User user)
        {
            List<Album> albums = Session.Query<Album>().ToList();
            List<Album> possess = new List<Album>();
            foreach(Album album in albums)
            {
                if (user.ComicsOwned.Contains(album))
                {
                    possess.Add(album);
                }
            }
            return possess;
        }

        public List<Album> GetSouhait(User user)
        {
            List<Album> albums = Session.Query<Album>().ToList();
            List<Album> souhait = new List<Album>();
            foreach (Album album in albums)
            {
                if (user.ComicsWanted.Contains(album))
                {
                    souhait.Add(album);
                }
            }
            return souhait;
        }

        public List<Album> Search(string recherche)
        {
            List<Album> albums = Session.Query<Album>().ToList();
            List<Album> result = new List<Album>();
            foreach(Album album in albums)
            {
                if(album.Nom.Contains(recherche) || album.Serie.Contains(recherche) || album.Auteur.Contains(recherche) || album.Genre.Contains(recherche))
                {
                    result.Add(album);
                }
            }
            return result;
        }

        public List<Album> SearchOwned(User user, string recherche)
        {
            List<Album> albums = GetPossess(user);
            List<Album> result = new List<Album>();
            foreach (Album album in albums)
            {
                if (album.Nom.Contains(recherche) || album.Serie.Contains(recherche) || album.Auteur.Contains(recherche) || album.Genre.Contains(recherche))
                {
                    result.Add(album);
                }
            }
            return result;
        }

        public List<Album> SearchWanted(User user, string recherche)
        {
            List<Album> albums = GetSouhait(user);
            List<Album> result = new List<Album>();
            foreach (Album album in albums)
            {
                if (album.Nom.Contains(recherche) || album.Serie.Contains(recherche) || album.Auteur.Contains(recherche) || album.Genre.Contains(recherche))
                {
                    result.Add(album);
                }
            }
            return result;
        }

        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }
        public void Delete(Album album)
        {
            Session.Delete(album);
            Session.Flush();
        }
    }
}
