using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Week2CodeChalange
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i <= 20; i++)
            {
                //FizzBuzz(i);

            }
            LetterCounter('i', "I love biscuits and gravy. It's the best breakfast ever.");
            LetterCounter('n', "Never gonna give you up. Never gonna let you down.");
            LetterCounter('s', "Sally sells seashelss down by the seashore. She's from Sussex.");
            Console.ReadKey();
        }

        static void LetterCounter(char letter, string inString)
        {
            int numberOfUpper = inString.Count(x => x.ToString().Contains(letter.ToString().ToUpper()));
            int numberOfLower = inString.Count(x => x.ToString().Contains(letter.ToString().ToLower()));
            int numberOfLetters = inString.Count(x => "abcdefghijklmnopqrstuv".Contains(x.ToString().ToLower()));

            Console.WriteLine("Input: " + inString);
            Console.WriteLine("\nLooking for '" + letter.ToString().ToUpper() + "'s in the input string.");
            Thread.Sleep(2000);
            Console.WriteLine("\nNumber of lowercase: " + numberOfLower);
            Console.WriteLine("Number of UPERCASE: " + numberOfUpper);
            Console.WriteLine("Total number of '" + letter.ToString().ToUpper() + "'s found: " + (numberOfUpper += numberOfLower));
            Console.WriteLine("Total number of letters: " + numberOfLetters);
            Console.WriteLine("\nHit any key to continue to the next input.");
            Console.ReadKey();
            Console.Clear();
        }


        /// <summary>
        /// FizzBuzz TM
        /// </summary>
        /// <param name="number"></param>
        static void FizzBuzz(int number)
        {

            //uses loops created in main function to use this equation to complete processes    
            if (number == 0)
            {
                Console.WriteLine(number);
            }
            else if (number % 3 == 0 && number % 5 == 0)
            {
                Console.WriteLine("FizzBuzz");
            }
            else if (number % 3 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else if (number % 5 == 0)
            {
                Console.WriteLine("Fizz");
            }
            else
            {
                Console.WriteLine(number);
            }

        }
    }
}
