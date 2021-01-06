using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL
{
    public class IndividualRepository : Repository, IIndividualRepository
    {
        public List<Individual> GetAll()
        {
            return Session.Query<Individual>().ToList();
        }

        public List<User> GetUser()
        {
            return Session.Query<User>().ToList();
        }

        public List<Admin> GetAdmin()
        {
            return Session.Query<Admin>().ToList();
        }

        public void Save(Individual individual)
        {
            Session.SaveOrUpdate(individual);
            Session.Flush();
        }
    }
}
