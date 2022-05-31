using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private Class1() { }
        public void someMethod()
        {
            Class2 obj = new Class2();
            obj.DoStuff();
        }
        //Que pasa?
        Class2.ClassInsideClass2 obj2 = new Class2.ClassInsideClass2();
    }

    //cambiar a public para que funcione ClassLibrary2
    internal class Class2
    {
        //en cualquiera de los 3 casos puedo hacer esto,
        //a no ser que haga privado el 
        public Class2() { }
        //este método es publico pero inaccesible en ClassLibrary2
        public void DoStuff()
        {
            Console.WriteLine("Doing stuff");
        }
        //Que pasa en Class2 si esta clase es internal, private?
        public class ClassInsideClass2
        {
            //Que pasa en Class2 si metodo es internal, private?
            public ClassInsideClass2() { }
        }
    }
}
