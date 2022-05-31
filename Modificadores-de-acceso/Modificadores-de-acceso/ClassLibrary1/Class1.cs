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
        Class2 obj = new Class2();
    }

    internal class Class2
    {
        public class PrivateClass
        {
            internal PrivateClass() { }
        }
        PrivateClass obj2 = new PrivateClass();
    }
}
