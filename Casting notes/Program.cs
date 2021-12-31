using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casting_notes
{
    /*
     لو بتراجع اقرا دي بس 
    -----------------------------------------------
      الخلاصة : 
    التايب كاست ال انت بتكتبه بايدك 
    مثلا (int)bla
    دا مش هيديلك اكسبشن لكنه هيجيب القيمة حسب حجم الحاجة والنتيجة
    مش هتكون دقيقة لو الرقم اكبر من حجم الدتا تايب 

    Convert Class ;
    هتحول ولو في اوفر فلو هتدي اكسبشن 

    Implicit exception:
    الكومبيلر هو ال بيعملها .. لان الظروف تسمح

    parse: give exception if not sucess.
  
    tryparse: return false if not sucess . 

    ---------------------------------------------------------------------
     
     
     
     ايه هي انواع الكاست ؟ 
    implicit cast : 
    دا كاست موجود جوة الفجول ستديو والهدف منه التحويل مباشرة 
     int a = 0;
     float x =  9991231921999999.2f;
     x = a;
    لاحظ هنا حول من فلوت ل انتجر بدون اي مشاكل . 
    لان الفلوت ف الميموري حجمها اكبر من الانتجر 
    بالتالي الكومبيلر هو ال عمل الكاست  
    ودا موجود ف الكومبيلر بشكل طبيعي للاسباب الاتية : 
    ينفع تحول من الدتا تايب دا 
    والمساحة تسمح ومش هيحصل اوفر فلو

    explicit cast : 
      int a = 0;
      float x =  9991231921999999.2f;
      x = a;
      a = (int)x;
    لاحظ هنا انت عملت كاست بايدك وكتبت 
    (int)
    والكاست دا بيكون علي مسئوليتك لانه في احتمال يحصل اوفر فلو 
    والحل ؟ 
    تعمل الكاست بكلاس كونفرت
    Convert 
    لو حصل اوفر فلو هيديلك اكسبشن وبالتالي لازم تهندل الاكسبشن دا 

  

     -------------------------------------------------------------------------------------

    وانت بتعمل كاست من دتا تايب كبير ل داتا تايب صغير 
    متستعمل ال 
    explicit cast 
    لانه مش بيشوف الاوفر فلو .. يعني مش هيحط النتيجة الصحيحة . 
    مثلا : 
    لو هتحط فلوت جوة انتجر .. 
    uint max val =4294967295 ;
    int max val = 2147483647;
    فلو حطيت فلوت اكبر من حجم الانتجر . 
    وعملت كاست ايه ال هيحصل ؟ 
    float x =  9991231921999999.2f;
     a = (int)x;
    هيطبع رقم معين لكن الرقم دا غير صحيح .. لانه اكبر من حجم الانتجر 
    والحل ؟ 
    تستعمل كلاس 
    Convert : 
    ف الحالة دي كلاس كونفرت لو لقا انه في اوفر فلو هيديلك اكسبشن ويعرفك 

     
     */
    class Program
    {
        static void Main(string[] args)
        {
            int a = 0;
            float x =  333333333333333333333333f;
 
            a = (int)x;
            Console.WriteLine(x);
 
            try
            {
                Console.WriteLine(Convert.ToInt32(x));
            }
            catch (Exception ee)
            {

                Console.WriteLine(ee);
            }

            try
            {
                string _str = "123ggg";
                x = int.Parse(_str);
                Console.WriteLine(x);
            }
            catch (Exception ee)
            {

                Console.WriteLine(ee);
            }

           
            int result=0;
            string str = "12.2";
            var isConverted = int.TryParse(str,out result);
            if (isConverted)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Can't parse .. ");
            }



              result = 0;
            str = "12";
              isConverted = int.TryParse(str, out result);
            if (isConverted)
            {
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Can't parse .. ");
            }

        }
    }
}
