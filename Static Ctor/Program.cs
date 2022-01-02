using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//we use it to init static data .
//called one time only . after using any class static var (any static var)
//you can say static ctor is called on class first usage 
// you can't add paramters to static ctor 
//static ctor is called once no matter how many instances u create 
//its called before any other ctor 


namespace Static_Ctor
{
    class Program
    {
        static void Main(string[] args)
        {
            Player.bla = 1; //static ctor is called 
            Console.WriteLine("after calling static ctor");
            List<Player> players = new List<Player>();
            for (int i = 0; i < 10; i++)
            {
                players.Add(new Player());
            }

        }
    }
}
