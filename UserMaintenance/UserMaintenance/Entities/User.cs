using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserMaintenance.Entities
{
    class User
    {
        public Guid guid { get; set; } = Guid.NewGuid();

        public string Firstname { get; set; }

        public string Lastname { get; set; }
                
        public string Fullname
        {
            get { return Lastname + " " + Firstname; }
            
        }



    }

    
}
