using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Struct_and_Class_Init
{
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

    /*
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


     
     
     
     
     
     
     
     */


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


        }
    }
}
