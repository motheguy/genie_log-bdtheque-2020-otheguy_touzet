using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    /// <summary>
    /// Class child of Individual granting Administrator's rights
    /// </summary>
    public class Admin : Individual
    {
        /// <summary>
        /// Constructor for NHibernate, do no use to initialize an Individual object
        /// </summary>
        public Admin() { }

        /// <summary>
        /// Constructor to initialize an Admin object with a login and a password
        /// </summary>
        public Admin(string login, string pw) 
        {
            Login = login;
            Password = pw;
        }
    }
}
