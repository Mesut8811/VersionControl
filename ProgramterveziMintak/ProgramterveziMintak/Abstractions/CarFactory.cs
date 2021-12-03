using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramterveziMintak.Abstractions
{
    public class CarFactory : ToyFactory1
    {
        public Toy CreateNew()
        {
            return new Car();
        }
                
    }
}
