using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes
{

    /*لو بتراجع بص هنا
     كلمة ابستراكت يعني بتعرف فنكشن ملهاش بودي 
 
    مش ينفع تعمل اوبجكت من الابستراكت كلاس انت بتورث منها فقط  
    لازم الابستراكت ميثود تكون ببلك وتكتبها بايدك ببلك

    في 3 انواع من الفنكشن ممكن اعرفهم جوة الابستراكت كلاس: 
    virtual : دي الاوفر رايد عليها اختياري 
    public abstract :دي الاوفر رايد عليها اجباري 
    normal Func: دي لازم تكون ببلك فقط 

    ينفع تعمل ابستراكت كلاس وارثة من ابستراكت تانية 
    ينفع تورث من انترفيس عادي

    عشان تعمل كول لاي فنكشن ف الابستراكت كلاس بتورث منها وتعمل اوبجكت من الوارث وتعمل كول 
    مثلا : 

         public abstract class SharedData
    {
 
         public  abstract void Print(); تعريف البودي احباري ف الوارث
         public virtual void Print2() {; } تعريف البودي اختياري ف الوارث
         public void doprint() بيتعملها كول فقط وممكن يتعملها هايد 
         {
             Console.WriteLine("123");
         }
    }

           class Program: SharedData
           Program p = new Program();
           p.doprint();
           p.Print();
           p.Print2();
     */



    /* diff bet keywords (virtual - abstract)
       virtual keyword:you can  make  some virtual methods that are not mandatory to override inside abstract class
       abstract keyword: abstract bla();//mandatory to implement bla body..
       virtual and abstract  need override keyword. 
       override with virtual is not mandatory .
       override with abstract is  mandatory .
       
       abstract methods can't be private you have to write public  abstract
 
 
       
     */

    #region diff bet override and hide
    /*
//https://www.geeksforgeeks.org/difference-between-method-overriding-and-method-hiding-in-c-sharp/
Method overriding	:
In method overriding, you need to define the 
method of a parent class as a virtual method 
using virtual keyword and the method of child class 
as an overridden method using override keyword.

It only redefines the implementation of the method.

Here overriding is an object type.	//called by parent ptr...

If you do not use override keyword, 
then the compiler will not override the method.
Instead of the overriding compiler will hide the method.

In method overriding, 
when base class reference variable pointing to the object of the derived class,
then it will call the overridden method in the derived class.

Method hiding:
 In method hiding,
 you just simply create a method in a parent class and in child class
 you need to define that method using new keyword.

 In method hiding, you can completely redefine the method.
 Here hiding is a reference type.//called by the object it self

 If you do not use the new keyword,
 then the compiler will automatically hide the method of the base class.


*/
    #endregion

    /*
    معني كلمة abstract
    An abstract class means that 
    hiding the implementation and showing the function definition to the user

    abstract class
    مينفعش :
            مينفعش تعمل اوبجكت منها

    ينفع: 
             ينفع تحط فيها اي داتا تايب
             ينفع تعرف جواها فنكشن عادية 
             ينفع تعرف جواها ابستراكت فنكشن  

     
     
     */


    public class Player : SharedData
    {
        public override void Print()
        {
            Print2();
        }
    }

    public class NPC : SharedData
    {
        public override void Print()
        {
           
        }
        public override void Print2()
        {
            base.Print2();
            Console.WriteLine("I have used override of base virtual method");
        }
        //public new void  Print2()
        //{
           /*
            method hiding can work 
            الافر رايد والهايد ينفعو بس ايه الفرق بينهم ؟ 
             اول حاجة ف الهايد 
           كلمة نيو بتعمل اسم جديد للفنكشن بالتالي الفنكشن دي هتخص الكلاس ال هي فيه فقط
           ف انت لو رحت عملت بوينتر من البيس كلاس وناديت علي فنشكن برنت 
           البيس كلاس هينادي علي الفنكشن الموجودة في داخله 
           لان برنت الموجودة ف التشيلد ليها اسم جديد ومش معرفة للبيس
           تاني حاجة البرنت الجديدة دي  ال معمولة بكلمة نيو  مدخلتش الفي تيبل
          لكن الفنكشن لو كدا متعرفة  اوفر رايد  
           وناديت علي الفنكشنن من بوينتر البيس 
            فنكشن الاتشيلد هيحلصها كول 

            */
        //}

    }



    public abstract class SharedData
    {
       //public  int x;
       //public  int y;
         public  abstract void Print();
         public virtual void Print2() {; }

        public void doprint()
        {
            Console.WriteLine("123");
        }
   

    }

 
    class Program: SharedData//عشان استعمل اي فنكشن عادي جوة الابستراكت كلاس لازم اورث منها واعمل اوبجكت من الكلاس الاساسي
    {
        static void Main(string[] args)
        {
            Program p = new Program();
            p.doprint();
            p.Print();
            p.Print2();

            /*
             ورثت من الاببستراكت كلاس عشان اعرف انادي علي الفنكشن ال جواها 
              الفنكشن دي مش ابستراكت   
             */

        }

        public override void Print()
        {
           //لازم تعمل اوفر رايد اجباري 
        }

        //public override void Print2()
        //{
        //   //مش اجباري تعمل اوفر رايد وممكن تنادي علي البيس فنكشن 
        //   //tostring شبه فنكشن
        //}
    }
}
