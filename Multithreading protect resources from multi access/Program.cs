using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading_protect_resources_from_multi_access
{

    /*
     مينفعش تخلي كذا ثريد يستعملو نفس المتغير ف نفس الوقت 
    لو عملت كدا هيديلك نتيجة غلط 
    مثلا :
    num
addNum();
addNum();
addNum();
150000
    كدا النتيجة هتكون ثابتة لاني عملت كول لنفس الفنكشن 3 مرات من نفس الثريد
  a,b,c are threads   
     A.Start();
     B.Start();
     C.Start();
give wrong result 
     A.Join();
     B.Join();
     C.Join();
 still wrong results 

increment is not thread safe .


corrent result =  Interlocked.Increment( ref num);
    لان المتغير في كذا ثريد بيحاولو ياكسسو عليه ف نفس الوقت 
    ف المتغير مش هيدي اكسس للكل ف نفس الوقت
    في ثريدات هتكتب وفي ثريدات مش هتعرف تكتب 
    ف دا ال بيدي النتيجة الغلط .
    والحل ؟
    في كذا حل 
    1-Interlocked.Increment
    2-Lock 

     
     */
    class Program
    {
        static Thread A;
        static Thread B;
        static Thread C;
        static object lockAddNum = new object();

        static int num;
        static void Main(string[] args)
        {
            Stopwatch stopwatch = Stopwatch.StartNew();

            A = new Thread(addNum);
            B = new Thread(addNum);
            C = new Thread(addNum);
            A.Start();
            B.Start();
            C.Start();

            A.Join();
            B.Join();
            C.Join();

            Console.WriteLine(num);//wrong result
            stopwatch.Stop();
            Console.WriteLine(stopwatch.ElapsedTicks);
        }

        static void addNum()
        {


            //for (int i = 0; i < 50000; i++)
            //{
            //    lock (lockAddNum)
            //    {
            //        num++;
            //    }

            //}

            for (int i = 0; i < 50000; i++)
            {


                Interlocked.Increment(ref num);
                

            }

        }
    }
}
