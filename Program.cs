using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Csharp_Tutorials_By_Mohammed_Alaa
{
    class Program
    {
        static void Main(string[] args)
        {
            string userName = "Mohamed";
            string PW = "123";

            /*
            Console.WriteLine 
            عندها 19 اوفر لود  .... 
            اهم واحد بتاع الفورمات .. 
            بتكتب 
            Console.WriteLine(string{index of var} other string {index of sec var ..},var)
            الخلاصة انت عايز تكتب سترنج بايدك وجنبه سترنج متغير 
            في اكتر من طريقة 
            ممكن تعمل كونكات
             Console.WriteLine("hello "+userName+", your password is "+PW);
            وممكن تعمل 
            $
            Console.WriteLine($"hello {userName} your password is {PW}");


             */

            Console.WriteLine("hello {0}, your password is {1}", userName, PW);
            Console.WriteLine("hello "+userName+", your password is "+PW);
            Console.WriteLine($"hello {userName} your password is {PW}");
            //
            //
        }
    }
}
