using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;

namespace ClassLibrary2
{
    public class Class1
    {
        Class2 instans = new Class2();
        ClassLibrary1.Class2 instancia = new ClassLibrary1.Class2();

        public void OtherMethod()
        {
            instancia.DoStuff();
        }
        ClassLibrary1.Class1 instance = new ClassLibrary1.Class1();
    } 
}
