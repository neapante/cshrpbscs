using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HelloWorlds
{
    class Program
    {
        static void Main(string[] args)
        {
            //Basic Hello World
            Console.WriteLine("Hello Worlds.");
            //Saying Hello with a method
            SayHello(); //method call
            //Saying Hello with a class/object
            SaySomething hello = new SaySomething(); //create an object
            hello.SayHello(); //call the method in the class to say Hello!!
            Console.ReadLine();
        }

        public static void SayHello()
        {
            Console.WriteLine("Hello World.");
        }
    }
}
