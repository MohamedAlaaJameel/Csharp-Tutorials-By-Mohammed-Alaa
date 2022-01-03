using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_Important_notes
{
 public delegate bool IsTopPlayerDelegate(Player player);
    /*
     الدلجيت ليه استعمالات كتير منها : 
    الهدف من الدلجيت اني معدلش في سطر من الكلاس 
    واعدل في كل حاجة من ال 
    caller

    مثلا انت عايز تعمل ست للتوب بلاير ف السرفر 
    طب التوب بلاير هيكون صاحب اعلي هيلث 
    شوية وغيرت رايك انا عايزه يكون  صاحب اكبر جولد 
    هتروح تغير الكود كل شوية ؟ 
    الصح تعمل دلجيت 
    وتبعت فيه الحاجة ال انت عايزها 
    مثلا : 
    دا الغلط 
    class bla
    if ((player.health>100))//كل ما تحتاج تغير حاجة هتروح جوة الكلاس وتعدل ف الكود ؟ مش حلو 
                {
                    player.isTop = true;
                    Console.WriteLine(player.name);
                }



     if (isTopPlayerD(player))//دا الصح بعت دلجيت وبغيره من برة الكلاس وبيوصلها 
                {
                    player.isTop = true;
                    Console.WriteLine(player.name);
                }
    تابع الامثلة تحت 
     */

    public class Player
    {
     public string name;
     public int gold;
     public int health;
     public int rank;
     public bool isTop;
    }
 
    public class PlayersUtil
    {
        
       public static void SetTopPlayer(List<Player> players, IsTopPlayerDelegate isTopPlayerD)
        {
            foreach (var player in players)
            {
                if (isTopPlayerD(player))//this will call all the functions inside the delegates
                {
                    player.isTop = true;
                    Console.WriteLine(player.name);
                }
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Player> players = new List<Player>();
            players.Add(new Player { health = 122, name = "Mohammed", rank = 1, gold = 10000 }); ;
            players.Add(new Player { health = 2, name = "ahmed", rank = 14, gold = 50 }); ;
            players.Add(new Player { health = 500, name = "khamed", rank = 3, gold = 100 }); ;
            players.Add(new Player { health = 101, name = "osama", rank = 5, gold = 10 }); ;


            #region Using lambda expression
            // public delegate bool IsTopPlayerDelegate(Player player);
            /*
             ركز هنا 
             بيتقسم لحاجتينlambda expressionال 
            A => B ;
            A:ودا  حاجة بتكتبها بتعبر عن البارمتر ال هيدخل الفنكشن 
            B: الرترن فاليو بتاع الفنكشن  

            مثال :
            دا الدلجيت بتاعنا 
            الدلجيت محتاج اساويه ب  فنكشن البارمتر بتاعها بلاير 
            ممكن اكتب الفنكشن باللمضة اكسبرشن 
            وممكن اكتب فنكشن ليها نفس بارمتر الدلجيت وابعت اسمها
            زي الامثلة تحت 

            public delegate bool IsTopPlayerDelegate(Player player);

       ---------------------------------- 
            الاتنين دول زي بعض  
--------------------------------------------------------
       p => p.gold > 1000;
            ترجمة السطر
p = البلاير ال هيدخل للفنكشن ك ارجيومنت
p.gold > 1000;= return  p.gold > 1000;   

--------------------------------------------------------
       static bool IsTopGold(Player player)
        {
            Console.WriteLine("IsTopGold has been called");

            return player.gold > 100;
        }
--------------------------------------------------------
             
             */
            IsTopPlayerDelegate lambdaTest  = p => p.gold > 1000;
            PlayersUtil.SetTopPlayer(players, p => p.gold > 1000) ; 
            PlayersUtil.SetTopPlayer(players, p => p.health > 100);
            PlayersUtil.SetTopPlayer(players, p => p.rank < 3);

            #endregion


            #region using pre defined delegate
            PlayersUtil.SetTopPlayer(players, IsTopHealth);
            #endregion

            #region using += to add more functions to the same delegate (named :multicast delegate)
            isTop += IsTopHealth;
            isTop += IsTopGold;
            isTop += IsTopRank; 
       
            // I'm trolling here
            //it will print  IsTopHealth   IsTopHealth IsTopGold  IsTopRank  has been called 
            //the first one is from  line 77:  new IsTopPlayerDelegate(IsTopHealth);
            /*
             ف المثال دا انا هبعت دلجيت جواه 4 فنكشنز
             inside SetTopPlayer it will call this condition:
             if (isTopPlayerD(player))// it will call 4 functions with one line 
              ال انا عامله دا غلط 
              بس ف الحالة دي هياخد الرترن بتاع اخر كول حصل .. 
             */
            PlayersUtil.SetTopPlayer(players, isTop);
            #endregion


        }
        static IsTopPlayerDelegate isTop = new IsTopPlayerDelegate(IsTopHealth);// isTop+=IsTopHealth;
        static bool IsTopHealth(Player player)
        {
            Console.WriteLine("IsTopHealth has been called");

            return player.health > 100;
        }
        static bool IsTopGold(Player player)
        {
            Console.WriteLine("IsTopGold has been called");

            return player.gold > 100;
        }
        static bool IsTopRank(Player player)
        {
            Console.WriteLine("IsTopRank has been called");
            return player.rank == 1;
        }
    }
}
