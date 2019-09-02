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
            /*Console.WriteLine("Exercise 1");
            Console.Write("Enter a letter: ");
            letter1 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a letter: ");
            letter2 = Convert.ToChar(Console.ReadLine());

            Console.Write("Enter a letter: ");
            letter3 = Convert.ToChar(Console.ReadLine());
  
            Console.WriteLine("{0}, {1}, {2}", letter3, letter2, letter1);*/

            //Write a C# Sharp program that takes a character as input and check the input (lowercase) 
            //is a vowel, a digit, or any other symbol.
            /*Console.WriteLine("Exercise 2");
            char symbol;

            Console.Write("Input a symbol: ");
            symbol = Convert.ToChar(Console.ReadLine());
         

            Console.WriteLine("Symbol: " + symbol);
            

            if ((symbol == 'a') || (symbol == 'e') || (symbol == 'i') ||
                    (symbol == 'o') || (symbol == 'u'))
                Console.WriteLine("It's a lowercase vowel.");
            else if ((symbol >= '0') && (symbol <= '9'))
                Console.WriteLine("It's a digit.");
            else
            {
                Console.Write("It's another symbol.");
            }

            Console.ReadLine();*/

            //Write a C# Sharp program that takes two numbers as input and returns 
            //true or false when both numbers are even or odd.

            int n1, n2;
            bool bothEven;
            Console.Write("Input First number: ");
            n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Second number: ");
            n2 = Convert.ToInt32(Console.ReadLine());


            //bothEven = ((n1%2!=0) || (n1%2!=0))? false:true;
            bothEven = ((n1 % 2 == 0)
                && (n2 % 2 == 0)) ? true : false;

            Console.WriteLine(bothEven ?
              "there're both numbers are even" :
              "there's at least one odd number");
            Console.ReadLine();
        }
    }
}
