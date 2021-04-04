using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.Write("Please enter your name: "); //Added dialog
            string str = Console.ReadLine();
            Console.WriteLine("Hi, " + str);
            Console.WriteLine("Hit Enter to end");
            Console.ReadLine();
        }
    }
}
