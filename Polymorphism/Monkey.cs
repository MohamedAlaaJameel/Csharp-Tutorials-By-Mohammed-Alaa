using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Monkey:Animal
    {
        public override void Walk()
        {
            Console.WriteLine("Monkey walking");
        }
    }
}
