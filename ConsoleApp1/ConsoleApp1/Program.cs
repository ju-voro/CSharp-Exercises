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
            char letter1, letter2, letter3;

            //Write a C# Sharp program that takes three letters 
            //as input and display them in reverse order. 
            Console.Write("Enter a letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a letter: ");
            letter3 = Convert.ToChar(Console.ReadLine());

            Console.WriteLine("{0}, {1}, {2}", letter3, letter2, letter1);
            Console.ReadLine();
        }
    }
}
