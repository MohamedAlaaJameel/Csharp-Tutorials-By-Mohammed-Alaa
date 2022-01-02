using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Ctor
{
    class Player
    {
        static int PlayersNum;
        public static int bla;
        static Player()
        {
            Console.WriteLine("player static ctor called once");
            PlayersNum = 0;
        }
        public Player()
        {
            PlayersNum++;
            Console.WriteLine($" player num {PlayersNum} has been created ");
        }
    }
}
