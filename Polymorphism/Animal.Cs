using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Animal
    {

       public virtual void Walk()
        {
            Console.WriteLine("no defined Animation for walk method");
        }
    }
}
