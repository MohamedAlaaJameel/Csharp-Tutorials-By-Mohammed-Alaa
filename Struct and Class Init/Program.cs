using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_and_Class_Init
{


    /*
 =============================================================================================
    الخلاصة  :
    الرفرنس تايب لما بتساويه بحاجة تانية كلهم هيشاورو علي نفس المكان ف الهيب او الميموري
    الفاليو تايب بيتعمل متغير جديد جوة الاستاك ف كل مرة 

    الرفرنس تايب بيتمسح بالكولكتور 
    الفاليو تايب بيتمسح لما تخرج من الاسكوب مباشرة 

    الاستركت لما تعمل فيه بارمتريزد كونستركتور 
    لازم تعرف كل الممبرز الموجودين داخل الاستركت ف البودي بتاع الكونستركتور

    ف حالة الكلاس ينفع تخليه فاضي حتي 

    ف الاستركت ينفع تعمل بارمتريزد كونستركتور لوحده player(int xp)
    ف الكلاس لازم يكون في كونستركتور مش بياخد بارمتر لو هتعمل واحد بياخد بارمتر  player(){} player(int xp){}
=============================================================================================

     Diffrence bet Class and struct :
    memory:
    Struct :  val type - stored In Stack
    Class :   ref type - stored In Heap
    مثلا 

    {
    player p1=new player();//player is class
    p1.Name="ahmed";
    }
    هنا 
    p1 دا عبارة عن متغير هيكون ف الاستاك 
    اعتبره بوينتر .
    Name دا هيتخزن ف الهيب 
    بمجرد ما تخرج من الاسكوب 
    هتتمسح ال هو البوينتر  p1 
     لكن الدتا الموجودة ف الهيب وال بتعبر عن الاوبجكت هتفضل موجودة لحد ما ال
    garbage collector يمسحها

    الخلاصة 
    val type removed with scope exit .
    ref type removed by garbage collector .
    هتقولي انت لسا قايل ان الاوبجكت ال معمول من كلاس عبارة عن رفرنس تايب
    لكن المتغير نفسه ال بيعبر عن الاوبجكت بتاع الكلاس هو فاليو تايب
    الخلاصة ان الاوبجكت الحقيقي بتاع الكلاس بيكون موجود ف الهيب 
    وال بيشاور عليه بيكون متغير لوكال زي المثال ..بيتمسح مع الاسكوب..
    والدتا بتاعت الكلاس او الاوبجكت الموجود ف الهيب بيتمسح بالكوليكتور..
    كلام سهل 

    كلام سهل بيوضح الفرق بين الرفرنس تايب والفاليو تايب:
    int a,b;
    a=b;
    كدا القيمة هتتنقل فقط .
    اي تغغير ف اي مش هياثر علي بي 

    obj a= obj b;
    كدا يعتبر نقلت ادرسات يعني التغيير  ف اوبجكت بي هياثر علي اوبجكت اي
    زي البوينترات بالظبط .. 
    ----------------
    ركز هنا : 
    لو غيرت الدتا ال جوة الاوبجكت الخاص بالكلاس من اي مكان 
    الدتا هتتغير 
    ليه ؟ 
    لانه زي البوينتر .
    مثلا : 
      public static void changeName(Boy boy)
        {
            boy.name = "changed";
        }
    الدتا ال جوة الاوبجكت هتغغير
    you didnot write ref & the data has been changed . 
    لانك غيرت الداتا ال ف الهيب . 
    struct is the same in this change. 
    لو هتاكسس علي الاوبجكت بتاع الاستركت وكتبتله هتغير الدتا ال جواه برضه ..

    طيب بما ان الرفرنس تايب بيتغير من جوة الفنكشن والفاليو تايب الاستركت برضه بيتغير بنفس 
    الطريقة 

            public static void changeName(BoyClass boy)//func.boy = main.boy//Ptr  address transfere
        {
            boy.name = "changed";//access the heap by the address.
        }
        public static void changeName(BoyStruct boy)//func.boy = main.boy//Ptr  address transfere
        {
            boy.name = "changed";//access the heap by the address.
        }
    الاتنين هيدو 
    changed 
    وانت اتلخبط ؟ 
    الفرق الحقيقي ف نقطة واحدة 
    ف النسخ 
    
    ف الرفرنس تايب لما بتعمل كذا بيساوي كذا 
    الاتنين هيشاورو علي نفس المكان  
    لكن ف الفاليو تايب لما تعمل كذا بيساوي كذا  
     كدا عندي 2 اوبجكت مخلتلفين وجواهم نفس القيم 
=============================================================================================
    مثال بيوضح القصة : 

    -------Class-ref type----------------------------------------
    Button b = new Button(); //a reference type 
    Button b2 = b; //another reference to the same object 
    b2.Text = "Hello"; 
    Console.WriteLine(b.Text); //This is now "Hello". 
    -------Struct-value type----------------------------------------
    Rectangle r = new Rectangle(); //a value type 
    Rectangle r2 = r; //another value type: NOT the same Rectangle 
    r2.Width = 50; 
    Console.WriteLine(r.Width); //This is still 0. 




    

     
     
     
     
     
     
     
     */
    /*
 شوية فروقات بين الاستركت والكلاس
Ctor:
 public Player(int xp){...}


at this line → p1 = new Player(); 
Struct :
-no error
Class:
error you need to implement  empty ctor before paramterized one .


Struct paramterized Ctor:

you must   init all struct members in that ctor .
field or prop :must be fully assigned before control returned to the called.
 public Player(int xp)
{
    PlayerName = "";
    PlayerAge = 12;
    Xp = 0;
}

Class paramterized Ctor:
you can make it empty .. or assign some values .. as u want.




 */
    public class BoyClass
    {
        public string name;
    }
    public class BoyStruct
    {
        public string name;
    }
    public struct Player
    {
        public string PlayerName { get; set; }
        public int PlayerAge { get; set; }
        public int Xp { get; set; }
        public Player(int xp)
        {
            PlayerName = "";
            PlayerAge = 12;
            Xp = 0;
        }
    }
    //public class Player
    //{
    //    public string PlayerName { get; set; }
    //    public int PlayerAge { get; set; }
    //    public int Xp { get; set; }


    //    public Player(int xp)
    //    {
    //        PlayerName = "";
    //        PlayerAge = 12;
    //        Xp = 0;
    //    }
    //}


    class Program
    {
        static void Main(string[] args)
        {

            Player p1 = new Player();//initu with empty ctor
            p1 = new Player(2);//init with param ctor
            p1 = new Player { Xp = 1 };//Object Initializer Syntax
            p1.PlayerAge = 1;
            p1.PlayerName = "m";
            p1.Xp = 1;

            BoyClass boy = new BoyClass();
            boy.name = "BoyClass";
            changeName(boy);
            Console.WriteLine(boy.name);

            BoyStruct boystruct = new BoyStruct();
            boy.name = "BoyStruct";
            changeName(boystruct);
            Console.WriteLine(boystruct.name) ;
    
        }
        public static void changeName(BoyClass boy)//func.boy = main.boy//Ptr  address transfere
        {
            boy.name = "changed";//access the heap by the address.
        }
        public static void changeName(BoyStruct boy)//func.boy = main.boy//Ptr  address transfere
        {
            boy.name = "changed";//access the heap by the address.
        }
    }
}
      