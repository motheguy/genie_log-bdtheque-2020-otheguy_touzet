using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : Individual
    {
        public new static bool AdminRight = false;
        public virtual List<Album> ComicsOwned {get;set;}
        public virtual List<Album> ComicsWanted { get; set; }

        public User() { }
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
