using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using week08ToyFactory.Abstractions;

namespace week08ToyFactory.Entities
{
    public class CarFactory : IToyFactory
    {
        public Toy CreateNew() 
        {
            return new Car();
        }
    }
}
