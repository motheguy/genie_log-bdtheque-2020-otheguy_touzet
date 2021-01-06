using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IAlbumRepository
    {
        /// <summary>
        /// Returns all existing albums
        /// </summary>
        List<Album> GetAll();
        List<Album> GetPossess(User user);
        List<Album> GetSouhait(User user);

        /// <summary>
        /// Save an album
        /// </summary>
        /// <param name="album">The album</param>
        void Save(Album album);
    }
}
