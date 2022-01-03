using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multiple_class_inheritance_using_interfaces
{


    /*
     كلاسات السي شارب مش بتورث من كذا كلاس ف نفس الوقت 
     المشكلة ؟
    u have class a contain method a;
    u have class b contain method b;
    u have class c contain method c;
    
    u have class blah want to inherit from a ,b,c classes  and  use a ,b , c methods ?
    الحل ؟
    make class a inhert from interface a . b from ib c from ic.. 
    blah:Ia,Ib,Ic
    {
    a= new a;
    b= new b;
    c= new c;
     Ameothod()
    {
    a.Ameothod();
    }
    Bmethod()
    {
     b.Bmeothod();
    }
    cMethod()
    {
    c.Cmeothod();
    }


    }

     
     */
    public class A:IA { public void Amethod() { Console.WriteLine("A method"); } }
    public class B:IB { public void Bmethod() { Console.WriteLine("B method"); } }
    public class C:IC { public void Cmethod() { Console.WriteLine("C method"); } }

    public interface IA { void Amethod();}  
    public interface IB { void Bmethod();}  
    public interface IC { void Cmethod();}


    class Porgram
    {
        static void Main(string[] args)
        {
            ABC abc = new ABC();
            abc.Amethod();
            abc.Bmethod();
            abc.Cmethod();

        }
    }
    class ABC : IA, IB, IC
    {
        A a = new A();
        B b = new B();
        C c = new C();
       

        public void Amethod()
        {
            a.Amethod();
        }

        public void Bmethod()
        {
            b.Bmethod();
        }

        public void Cmethod()
        {
            c.Cmethod();
        }
    }
}
