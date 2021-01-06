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

        public void Save(Album album)
        {
            Session.SaveOrUpdate(album);
            Session.Flush();
        }
    }
}
