using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_100_conosle
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int answer = random.Next(1, 101);
            string guess;
            int intGuess;
            int i = 0;
            bool correct = false;

            while (correct == false)
            {
                i++;
                Console.WriteLine("Guess a number between 1 and 100");
                guess = (Console.ReadLine());
                intGuess = int.Parse(guess);

                if (intGuess < answer)
                {
                    Console.Clear();
                    Console.WriteLine("Your guess was to small");
                }
                else if (intGuess > answer)
                {
                    Console.Clear();
                    Console.WriteLine("Your guess was to big");
                }

            }
        }
    }
}

