using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Domain
{
    ///<summary>
    /// User and Admin's class parent  
    ///</summary>
    public class Individual
    {
        public virtual int Id { get; set; }
        public virtual string Login { get; set; }
        public virtual string Password { get; set; }
        public Individual() { }
    }
}
