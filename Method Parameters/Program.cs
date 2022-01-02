using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




/*
 
وانت بتبعت بارمتر للفنكشن في اكتر من طريقة 
by value :
لما تبعت  المتغير للفنكشن : 
هيتعمل منه نسخة ف الميموري ويحصل عليه العمليات الحسابية ال بتعملها عليه مثلا
الفكرة هنا ان قيمة المتغير ال انت بعته للفنكشن مش بتتغير او بتتاثر 
int x = 1;
addOne(x);
//x=1  not 2 
by ref
وهنا بتغير  القيمة وليه شرط 
تكتب كلمة 
ref :
الكلمة بتتكتب قدام البارمتر ف الفنكشن وقدام الارجيومنت وانت بتعمل الكول 
addOne(ref x)// void addOne(ref x) {x=x++;}
ret many results:
by out key word .
لو عايز ترترن باكتر من قيمة من الفنكشن 
وهنا برضه 
هتكتب out
قدام البارمتر والارجيومنت 
using params keyword 
موجودة ف 
ParamsTutorial

 
 
 
 */
namespace Method_Parameters
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1;
            AddOneByVal(x);
            Console.WriteLine($"{x}");
            AddOneByRef(ref x);
            Console.WriteLine($"{x}");
            int result;
            bool isEven;
            x = 1;
            returnMany(x, out result, out isEven);
            Console.WriteLine($"{x}-{result}-{isEven}");

        }
        static void AddOneByVal(int x)
        {
            x = ++x;
        }
        static void AddOneByRef(ref int x)
        {
            x = ++x;
        }
        static void returnMany(int x, out int restult, out bool isEven)
        {
            isEven = x % 2 == 0 ? true : false;

            x = ++x;
            restult = x;


        }
    }
}
