using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Nullable types
//Null coalescing operators
/*
 الفكرة ف النل والنل ابل .. 
انه يربط بين متغيرات السي شارب والدتا بيس 
وبرضه ليه استعمالات تانية .. 

 */
/*
 لو بتراجع بص هنا :

 int? bla = null; to convert from int to Nullable type;


 data transfere between val type and nullable type with coalescing operator : 
   int x = bla??0;  //you have to insert  the default value of the null to prevent exceptions . 
 
 */












//-------------------------Nullable types---------------------------------------
//types?
/*
value types int,float,struct,enum, etc ;
refrence types  interface , delegate , array , class;

طب ايه الفرق بين الرفرنس تايب والفاليو تايب ؟ 
value type  default val is Zero;
ref type default val is Null ;
String ? 
الاسترنج كلاس وبالتالي القيمة الافتراضية ليه هتكون نل ..لانه رفرنس تايب 
طيب الكلام دا كله ليه ؟؟ 
عشان ال 
Nullable 
عايزك تعرف ان الفاليو تايب مش ينفع تساويه ب نل 
يعني ايه برضه  ؟ 
الفكرة اني عايز اعمل تشك علي الحجات النل : 
يعني عايز اعمل تشك علي الرفرنس تايب .. هل هو جواه اوبجكت ولا نل . 
لان الرفرنس تايب اما يكون جواه اوبجكت او ميكونش جواه حاجة . 
وانا بحتاج استعمل الاوبجكت ال جوة الرفرنس تايب .. بالتالي لو جيت استعمل اوبجكت فاضي 
هيحصل ارور . 
طيب : 
هل ينفع احول ال فاليو تايب ل نل تايب ؟ 
how to make value type nullable and why we need that ? 
Conversion:
int x = null // error 
int? x= null // no error 
why:
Database dont have value type like c#
data base store default value as null . 
To store null int inside data base as default vaule .


طيب ايه السبب ال هيخليك تعمله نل ابل .. 
في مشاكل كتير منها : 
ف الدتا بيس : الانتجر بيكون نل عادي .. 
يعني الدتا بيس مش معرف فيها  فاليو تايب ورفرنس .. 
الدتا بيس بيكون فيها نل لكل حاجة عادي .. 
ف انا عايز اخزن النل داخل الدتا بيس . بالتالي هخلي الانتجر نل ابل . 
مثلا عايز تسال اليوزر سوال مش اجباري : 
are you over 50?
true - false - null ;
ف السي شارب في فرق بين النل والفولس 

هام جدا 
الخلاصة 
انت لما بتحط علامةاستفهام بعد الفاليو تايب 
فانت كدا يعتبر بتحول الحاجة لاوبجكت
يعني في خصائص مختلفة هتكون ف المتغير بتاعك مثلا 
 areYouOver60.Value:
هنتكلم عن خاصية الفاليو شوية : 
لو المتغير بتاعك ليه قيمة : هيطبع عادي زي المثال تحت 
طيب لو المتغير دا عبارة عن نل ؟  
هيديك اكسبشن . 
والحل ؟؟؟ 
لازم تعمل تشك 
 if (areYouOver60.HasValue)
طيب حاجة تانية لو عملت كدا ؟ 
 Console.WriteLine(areYouOver60);
مش هيحصل مشاكل ويطبع سطر فاضي 

لو عملت كدا ؟ 
  bool? areYouOver60 = null;
 Console.WriteLine(areYouOver60.Value);
هيديك ارور 

لو عملت كدا ؟ 
 bool? areYouOver60 = null;

 if (areYouOver60.HasValue)
 {
     Console.WriteLine(areYouOver60.Value);
 }
مش هيدخل الاف ستاتمنت ومش هيحصل مشاكل ..
----------------
هام جدا 
تقدر تعمل كاست عادي وهتحتاج تعمل كاست 
مثلا 
 int? bla = null;
 int x = 4;
 x = (int)bla;
 bla = x;
يعني الاوبجكت بيشيل فاليو جواه عادي .. لكن الفاليو هيحتاج كاست عشان تساويه باوبجكت.
طيب هل الكاست دا صح ؟ 
مش احسن حل وهيديك اكسبشن لو القيمة نل 
الخلاصة : 
مش ينفع انتجر عادي يشيل جواه نل : 
لانه هيديلك رن تايم اكسبشن . والحل ؟ 
coalescing operator 
مشروح تحت 


-----------------



//-------------------------coalescing operators ?? ---------------------------------------
??:
بص انت مثلا عندك انتجر : يعني هيشيل رقم صح ؟ 
int rakm ;
طيب انا عايز انقل قيمة من الدتا بيس للرقم دا 
عايز اقوله لو الرقم ال جاي من الدتا بيس عبارة عن نل ؟  خلي الرقم ب زيرو
لو مش نل خلي الرقم  نفس القيمة القادمة من الدتا بيس . 
ازاي ؟ 
عن طريق العلامة ?? 
بص ع المثال :
int? bla = 500;    
int x = bla ?? 0;
الاكس هيكون زيرو لو القيمة ال جوة بلا ب نل 
ف المثال هنا هتكون قيمة الاكس ب 500 
if bla == null  x=0 else x=500 
 */
namespace Nullable_types
{
    class Program
    {
       
        static void Main(string[] args)
        {
          // int? bla = null;
          // int x = 4;
          // x = (int)bla;//exception .. you have to check if bla is null ..normal ints can't carry null
          // bla = x;

            int? nullableint = null;
            bool? areYouOver60 = null;

            if (areYouOver60.HasValue)
            {
                Console.WriteLine(areYouOver60.Value);
            }



            int? blah= 500;
            int x1 = blah ?? 0;
            Console.WriteLine(x1);

        }
    }
}
