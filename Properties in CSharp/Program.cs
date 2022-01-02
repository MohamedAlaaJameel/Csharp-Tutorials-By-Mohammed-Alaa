using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties_in_CSharp
{
    //Encapsulation of fields by properties(setters and getters). 

    /*
    Don't use fields , use Properties:
    fields example in C#? 
    int x ; string name ; 
    why not to use fields?
    to get more control and checks on vars.
    we use 
    مثلا عايز الحاجة ريد اونلي او تعمل قيم موجبة بس او الاسترنج مش بيقبل ارقام مثلا  
    يعني بتقدر تحط شروط للمتغيرات بتاعتك لو عايز . 
    مثلا
    ID {if num<0 ret 0 };
    ف انت عايز الاي دي يكون موجب فقط 

    لو هتعمل بروسسنج او تعمل تشك علي المتغير هتكتب زي كدا    string name;public string Name
        {
            get { return name; }
            set
            {
                if (value != string.Empty && value.Length > 10)
                {

                    name = value;
                    Console.WriteLine($"Hello {value}");
                }
                else
                {
                    Console.WriteLine("Name length must be more than 10 chars ");
                }
            }
        }
    
    لو هيكون في قراء وكتابة بشكل عادي هتختصرها كدا 

     public int Size { get; set; }
    او 
     public int Size { get;private set; }
    ودي مش بتحتاج متغير تاني ... 
    لو عايز تعمل جت فقط وبشكل اسهل ف الكتابة
    public int ID => id
    public int Size { get;}

    لاحظ
    get;
    set;
    semicolon الاتنين بينتهو ب 
    get { return name ; }
    -----------------------------------------------------------------------
     
     
 
     
     
     */
    class Player
    {
        #region Vars
        public int Size { get; set; }
        string name;public string Name
        {
            get { return name; }
            set
            {
                if (value != string.Empty && value.Length > 10)
                {

                    name = value;
                    Console.WriteLine($"Hello {value}");
                }
                else
                {
                    Console.WriteLine("Name length must be more than 10 chars ");
                }
            }
        }
        static int id;public int ID => id;//get another syntax ..  ID= ret ID 

        #endregion
        public Player()
        {
            id++;
        }
    }
    class Program
    {
 

        static void Main(string[] args)
        {
 
 
            Player player = new Player();
            player.Name = "Mohammed";
            player.Name = "MohammedAlaa";
            player.Size = 4;
            Console.WriteLine(player.Size);
            Console.WriteLine(player.ID);
            Player player2 = new Player();
            
            Console.WriteLine(player2.ID);

        }
    }
}
