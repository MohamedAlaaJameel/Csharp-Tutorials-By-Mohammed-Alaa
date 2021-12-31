using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 params :
بتبعت اراي من البارمتر 


لو عايز تبعت عدد غير معروف من البارمتر لفنكشن معينة . 
مثلا هبعت كل مهارات البلاير .. ومش عارف عدد المهارات دي 
او هبعت ارقام عايز مجموعها مثلا ومش عارف اليوزر هيدخل كام رقم زي الالة الحاسبة
بتتعمل ازاي؟ 
بتعرف اراي من الدتا تايب ال انت عايزه 
وتكتب جنبه 
param 

 void PrintNums(params int [] nums)
شروطها ؟ 
كلمة  param
لازم تكون اخر ارجيومنت 
تتكتب مرة واحدة فقط 

الكولر ؟ 
ينفع تعمل كول من غير ماتبعت بارمتر 


 */
namespace ParamsTutorial
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintNums();


            int[] nums = new int[100];
            PrintNums(nums);

            int[] nums2 = {1,2,3,4 };
            PrintNums(nums2);


        }

        static void PrintNums(params int [] nums)
        {
            if (nums.Length!=0)
            {
                var nonZero = nums.Where(n => n != 0);
                foreach (var item in nonZero)
                {
                    Console.WriteLine(item);
                }
                
            }
            else
            {
                Console.WriteLine(nums);
            }
 
        }
    }
}
