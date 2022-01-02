using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Hiding
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPlayer myPlayer = new MyPlayer();
            Console.WriteLine("type cast to parent object to call the parent method");
            ((Player)myPlayer).Run();
            Console.WriteLine("Calling the hidden method  run  on Myplayer ");
            myPlayer.Run();
        }
    }
}
