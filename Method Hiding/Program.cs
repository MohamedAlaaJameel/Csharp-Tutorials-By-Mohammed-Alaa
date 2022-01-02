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

            //cast to parent object 
            ((Player)myPlayer).Run();
            Console.WriteLine("Calling the hidden method  run  on Myplayer ");
            myPlayer.Run();


            //parent point on child data .
            Player player = new MyPlayer();//polymorphism ..base point to dervied class
            player.Run();//run will be called on base .


            /*
             to call parent method you need to : 
            -cast to parent Or point to child 
             
             
             */
        }
    }
}
