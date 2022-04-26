using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //tipos de variable

            //estructuras de control

            //Arrays y listas
            int[] numbers = new int[2];
            List<int> numbersAsList = new List<int>();

            numbersAsList.Add(1);
            numbersAsList.Add(2);
            numbersAsList.Add(3);

            foreach (var item in numbersAsList)
            {
                Console.WriteLine(item);
            }

            //iteradores

            //funciones
            Program.func1();
            
        }

        public static void func1()
        {
            Console.WriteLine("func ativada");
        }
    }
}
