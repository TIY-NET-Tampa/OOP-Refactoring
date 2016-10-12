using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Refactoring
{
    class Program
    {

        /*
         The goal of this project it to teach about Encapstualtion,
         abstraction and refactoring in OOP


        We will be building a non-static Calculator Class that:
        - Encapsulates a running total
        - Encapsulates all the calculator logic
        - Abstracts the math logic from the main app
        - Demostrates a Singleton Pattern
        
             
             */
        
        static void Main(string[] args)
        {
            var a = 2;
            var b = 3;

            Console.WriteLine(Calculator.Add(a, b));
            Console.WriteLine(Calculator.Subtract(a, b));
            Console.WriteLine(Calculator.Multiple(a, b));
            Console.WriteLine(Calculator.Divide(a, b));
            Console.WriteLine("-----");
            Console.WriteLine(Calculator.RunningTotal);

            Console.ReadLine();
        }
    }
}
