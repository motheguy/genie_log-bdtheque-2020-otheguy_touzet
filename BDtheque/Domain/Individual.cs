using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    ///<summary>
    /// User and Admin parent class  
    ///</summary>
    public abstract class Individual
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }

        /// <summary>
        /// Constructor for NHibernate, do no use to initialize an Individual object
        /// </summary>
        public Individual() { }
    }
}
