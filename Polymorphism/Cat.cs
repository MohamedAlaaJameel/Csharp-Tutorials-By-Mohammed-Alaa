using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Cat:Animal
    {
        public override void Walk()
        {
            Console.WriteLine("Cat walking");
        }
    }
}
