using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



/*
 ايه مميزات Params:
بستعملها عشان ابعت ارجيومنت عددها مش معروف للفنكشن 
تقدر تبعت الارج منفصلة
  PrintNums(1, 2, 3, 4);
تقدر تبعتهم علي هيئة اراي 
int[] nums2 = {1,2,3,4 };
 PrintNums(nums2);
تقدر متبعتش حاجة خالص 
PrintNums();

طب في واحد هيقولك ما ابعت اراي عادية للفنكشن وفيها الارج بتاعي : 
كلامك صح بس ف الحالة دي هتكون مقيد انك تبعت داتا تايب من نوع اراي فقط
ومش هتقدر تبعت الدتا منفصلة 1,2,3 
او تعملها كول من غير بارمتر .. 
 */

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
            PrintNums(1, 2, 3, 4);


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
