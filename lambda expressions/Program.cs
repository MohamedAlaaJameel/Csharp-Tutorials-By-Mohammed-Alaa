using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lambda_expressions
{

    /*
    annymouse method in c# 2 
    lambda in c# 3 
    (player=>player.ID==1)
     input , lambda operator , expression
    "lambda operator" = "goes to" = "=>"
     player can be any name ... for input 
    يعني لو بدور في لستت بلايرز  
    هتكتب ف المكان دا اي رمز بيعبر عن البلاير الواحد ف اللستة

    predicate = func with one param  ret bool 
    كلام مش مهم:
    يعني اي تجميعة اوبجكت 
     لست من الاوجكت مثلا 
    وعايز تطلع حاجة حسب كوندشن معين 
    هتعمل برديكيت ف الفنكشن وتستقبله
    مثلا فنكشن Find
    اللستة ضايفة فنكشن فايد ك اكستنشن ميثود مثلا
    اللستة هتعمل كول لفنكشن فايند
    فنكشن فايند بتستقبل برديكيت 

     */
    public class Player
    {

        public int ID;
        public string Name;


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
            var myPlayer = players.Find(p => p.ID == 1);
            var myPlayer2 = players.Find(اي_رمز_بيعبر_عن_البلاير => اي_رمز_بيعبر_عن_البلاير.ID == 1);
            var myPlayer3 = players.Find(Input => Input.ID == 1);

            //to define explicit typt add (type input) ;
            var myPlayer4 = players.Find((Player myplayer) => myplayer.ID == 1);

 
          
        }
 
    }
}
