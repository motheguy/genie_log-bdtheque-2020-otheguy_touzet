using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : Individual
    {
        public virtual IList<Album> ComicsOwned {get;set;}
        public virtual IList<Album> ComicsWanted { get; set; }

        public User() {}
        public User(string login, string pw)
        {
            Login = login;
            Password = pw;
            ComicsOwned = new List<Album>();
            ComicsWanted = new List<Album>();
        }

        public virtual void AddComicOwned(Album newAlbum)
        {
            ComicsOwned.Add(newAlbum);
        }
        public virtual void AddComicWanted(Album newAlbum)
        {
            ComicsWanted.Add(newAlbum);
        }
    }
}
