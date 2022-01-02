using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    class MyPlayer:Player
    {
        // new keyword to hide the method and avoid the warning of method hiding . 
        //if new is not written the method will be hidden and np , only warning will pop up.
        public new void Run()
        {
            Console.WriteLine("My player is rurning");

          //  base.Run();//calling base method
        }
    }
}
