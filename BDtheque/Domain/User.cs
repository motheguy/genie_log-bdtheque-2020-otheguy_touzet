using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class User : Individual
    {
        public virtual List<Album> ComicsOwned {get;set;}
        public virtual List<Album> ComicsWanted { get; set; }

        public User() { }
        public void AddComicOwned(Album newAlbum)
        {
            ComicsOwned.Add(newAlbum);
        }
        public void AddComicWanted(Album newAlbum)
        {
            ComicsWanted.Add(newAlbum);
        }
    }
}
