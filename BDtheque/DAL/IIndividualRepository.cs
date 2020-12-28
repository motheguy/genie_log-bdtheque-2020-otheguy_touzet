using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public interface IIndividualRepository
    {
        /// <summary>
        /// Return all individuals
        /// </summary>
        /// <returns></returns>
        List<Individual> GetAll();

        /// <summary>
        /// Save an individual
        /// </summary>
        /// <param name="individual">The individual</param>
        void Save(Individual individual);
    }
}
