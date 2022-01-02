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

        //public new void Walk()
        //{
        //    Console.WriteLine("Cat walking");
        //}
        //it will hide the parent method .. but  Animal cat = new Cat();
        //cat.Walk will call the parent walk .. not the cat walk take care . take care . 
        

    }
}
