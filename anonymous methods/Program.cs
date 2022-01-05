using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace anonymous_methods
{

    /*
     هي فنكشن ملهاش اسم
    بتعمل دلجيت انستنس 
    يعني بعمل قيمة ينفع تتحط جوة دلجيت
    C# 2 اتعملت ف الاصدار التاني من السي شارب

    predicate data type? 
    public delegate bool Predicate<in T>(T obj);
    
    delegate :
    يعني حاجة هتشاور علي فنكشن
    ولازم يكون نفس السينتشر 
    ptr on func+same sig;

    يعني البرديكت هو نوع من انواع الدلجيت يعني 
    بوينتر علي فنكشن وبيرترن ببولين اما ترو او فولس

    هو بوينتر علي فنكشن وبيرترن ب ترو او فولس

    بمعني ؟؟
    في بعض الفنكشنز جوة السي شارب بتطلب برديكيت 
    يعني انت مطلوب منك تبعت للفنكشن دي فنكشن شبه البردكيت المطلوب 
    u need to create a func with the same signature of that predicate;
    public delegate bool Predicate<in T>(T obj);
    هنا ايه المطلوب ؟ 
    اوبجكت من اي نوع 
    in : The in keyword causes arguments to be passed by reference 
    but ensures the argument is not modified.  C# 7.2 and later.

    static bool FindPlayer(Player player)
    عملت فنكشن عشان تتحط ف البردكيت 
    بترترن ب بولين
    وبتاخد اوبجكت ك بارمتر 
    now both have the same signature

    anonymous_method : طريقة تعريفها 
    delegate(parameters, , ,){body}

    examples 
    btn.click+= delegate(object send ,EventArgs eArgs){msgbox.hello};
    btn.click+= delegate {msgbox.hello};
    لو مفيش بارمتر ممكن تمسح الاقواس وتخلي البودي فقط 
    delegates params are optional

     */


    public class Player 
    {

      public  int ID;
      public  string Name;

    
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            Player p1 = new Player() { ID = 1, Name = "p1" };
            Player p2 = new Player() { ID = 2, Name = "p2" };
            Player p3 = new Player() { ID = 3, Name = "p3" };

            players.Add(p1);
            players.Add(p2);
            players.Add(p3);
            Predicate<Player> playerPredicate = new Predicate<Player>(FindPlayer);

            Player f = players.Find(playerPredicate);
            Player d = players.Find(p=>playerPredicate(p));
            //D&&F are the same 
            Console.WriteLine(f.Name);
            Console.WriteLine(d.Name);

            //using annymouse func:
            Predicate<Player> bla = delegate (Player p) { return p.ID == 1; };
            Player e = players.Find(bla);
            Player c = players.Find(delegate(Player p) { return p.ID == 1; });

            //lambda with delegate 
            Player dd = players.Find((Player p)=> { return p.ID == 1; });

            /*
             (Player p)=>
             my  parameter will "goto" the body { func body });
            delegate(Player p){func body}


            1- delegate(param){func body}
            2-         (param)=>{func body}
             
             */


        }
        static bool FindPlayer(Player player)
        {
            return player.ID == 1;
        }
    }
}
