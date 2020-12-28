using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Class child of Individual that allow the owning and wishes of Comic albums
    /// </summary>
    public class User : Individual
    {
        public virtual IList<Album> ComicsOwned { get;set;}
        public virtual IList<Album> ComicsWanted { get; set; }

        /// <summary>
        /// Constructor for NHibernate, do no use to initialize an User object
        /// </summary>
        public User() {}

        /// <summary>
        /// Constructor to initialize an User object with a login and a password
        /// </summary>
        public User(string login, string pw)
        {
            Login = login;
            Password = pw;
            ComicsOwned = new List<Album>();
            ComicsWanted = new List<Album>();
        }

        /// <summary>
        /// Method to add an Album to the list of Comics Owned by the User
        /// </summary>
        public virtual void AddComicOwned(Album newAlbum)
        {
            if (!ComicsOwned.Contains(newAlbum))
            {
                ComicsOwned.Add(newAlbum);
            }
            if(!newAlbum.OwnedBy.Contains(this))
            {
                newAlbum.AddOwnedBy(this);
            }
        }
        /// <summary>
        /// Method to add an Album to the list of Comics Wanted by the User
        /// </summary>
        public virtual void AddComicWanted(Album newAlbum)
        {
            if (!ComicsWanted.Contains(newAlbum))
            {
                ComicsWanted.Add(newAlbum);
            }
            if (!newAlbum.WantedBy.Contains(this))
            {
                newAlbum.AddWantedBy(this);
            }
        }
    }
}
