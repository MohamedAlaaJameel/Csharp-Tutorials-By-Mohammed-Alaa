using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace async_and_await
{
    /*
     عايز تعمل فنكشن بتاخد 9 ثوان عشان تحسب عملية معينة
    لما بتعمل كدا ال
    UI block بيحصل
    ومش بتقدر تتحكم ف حاجة . 

    ف انت عايز الفنكشن تشتغل وف نفس الوقت تقدر تدوس علي اليو اي 
    وتتحكم فيها 

    هتعمل تاسك 

    التاسك :
    زي الثريد بتشتغل جنب الثريد الاساسي
    بس عليها كنترول اكتر 
    ايه شروط التاسك؟ 
    عايز الفنكشن ال هتعملها كول 
    في حجات اضافية : 
    انا عايز البرنامج بتاعي يستني التاسك لما تخلص 
    وف نفس الوقت البرنامج اليو بتاعته تكون شغالة 

    يعني في مجموعة سطور هتتفنذ بعد ما التاسك تخلص 

      شوف الحالة دي  
      السطر الاول " بروسسنج" مش هيظهر ف اليو اي 
      لان الفنكشن هتاخد 9 ثوان   
      ui will freez till 9 sec pass...


      button1.Text = "processing";//the ui will freez 
      ConsumingTimeFunction();
      button1.Text = "done";// u will see this np..
     
     والحل؟
            Task t1 = new Task(ConsumingTimeFunction);
            button1.Text = "processing";
            t1.Start();
            await t1;
            button1.Text = "done";
    هتعمل تاسك 
    await:
    بتقوله مش تنفذ اي سطر تحتي لحد ما التاسك تخلص 
    all lines will be executed when task ends only

    async: telling compiler this is asynchronous func .. 
    الاويت لازم يكون معاها اسنك 
    async the function to make await.

     
     */
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void ConsumingTimeFunction()
        {
            Thread.Sleep(8000);
        }
        private async void button1_Click(object sender, EventArgs e)
        {
            Task t1 = new Task(ConsumingTimeFunction);
            button1.Text = "processing";
            t1.Start();
            await t1;// custom await location ....
            //await Task.Run(new Action(ConsumingTimeFunction)); at one line
            button1.Text = "done";

        }

        private void button2_Click(object sender, EventArgs e)
        {  //this will not be shown 
            button1.Text = "processing";//the ui will freez 
            ConsumingTimeFunction();
            button1.Text = "done";
        }
    }
}
