using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_notes
{

    /*
    Interface = No Fields - No access modifires - No Body (no implemntation)
    Can contain delegates - props -methods - events only declartion (no implemntation)
    class or struct هما ال هيعرفو البودي بتاع الحجات ال جوة الانترفيس 
    
    Interface can inherit other interfaces and your class must implement interface and its inheritance
    ex: I1    I2:I1    class bla:I2    you must implement I1 and I2 into bla class.

    you can't make objects from Interfaces . But you can use it as parameter.
    يعني مثلا الفنكشن دي هتستقبل حاجة من نوع انرفيس كذا 
    او الكونستركتور بتاع الكلاس دا هيستقبل انترفيس من نوع كونترولر 
    الخلاصة انك ينفع تعمل رفرنس او بوينتر من نوع انترفيس فقط لكن مش بتعمل اوبجكت
    p1= new player(IController controller);
    IController keyboard = new KeyBoard();
    هنا استعمله ك بيونتر لان الكيبورد ورث من الانترفيس اي كنترولر

    كل اعضاء الانترفيس ببلك 
    مش ينفع تكتب اي اكسس مودفير لاعضاء الانترفيس 
    public  int Print();//error access modifires are not allowed .
    int Print();//its public by default .
    الانترفيس تقدر تشيل اي حاجة عادي ماعدا الفيلد
    delegates - props -methods - events..
    ممنوع تعرف بودي اي فنكشن ف الانترفيس.
    no implementaion inside interfaces .
    int Print() {Console.WriteLine("bla")}; error
    int Print();//no error

     
     
     */
    public interface Icontroller
    {
          void Print();
    }
    public interface Icontroller2
    {
        void Print();
    }
    public interface Icontroller3
    {
        void Print();
    }

    class Program: Icontroller, Icontroller2,Icontroller3
    {
        static void Main(string[] args)
        {
            Program bla= new Program();
            bla.Printfa();
          
        }

         void Icontroller2.Print()
        {
            Console.WriteLine("print2 has been called");
        }

        public void Printfa()
        {
            ((Icontroller)this).Print();
            ((Icontroller2)this).Print();
            Print();
        }

        void Icontroller.Print()
        {
            Console.WriteLine("print has been called");
        }

        public void Print()
        {
            Console.WriteLine("print 3 called");
        }
    }
}
