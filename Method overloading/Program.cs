using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_overloading
{
    /*
     depend on Parameters
    
    Type: int ,float,double..
    kind: out ,ref ...not params. keywords
    num: number of parameters

     
    
     
     
     
     
     
     
     */
    class Program
    {
        static void Main(string[] args)
        {
        }


        static void sum(int x, int y)
        {

        }
        static void sum(out int x, int y)//kind
        {
            x = 0;
        }

        static void sum(int x, int y, int z)//num
        {

        }

        static void sum(float x, int y, int z)//type
        {

        }
    }
}
