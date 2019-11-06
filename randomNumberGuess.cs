/*
Developer: Hamed Mirlohi
Date: 11/6/2019
In this program, we are implementing a game which user must guess what a generated random number between 1-100 is
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomGuess
{
    
    class Program
    {

        const int TOO_FAR = 50;
        const int CLOSE = 25;
        const int VERY_CLOSE = 10;
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> list = new List<int>();
            int target = random.Next(0, 100);
            int user_attempt = 0;

            while(true)
            {

                Console.WriteLine("Please Guess a number");
                int userInput = int.Parse(Console.ReadLine());
                list.Add(userInput);
                ++user_attempt;
                Console.Clear();
                int difference = Math.Abs(userInput - target);
               
                if (difference > TOO_FAR)
                {
                    Console.WriteLine("Your too far");
                }
                else if(difference > CLOSE)
                {
                    Console.WriteLine("Your close");
                }
                else if(difference > VERY_CLOSE)
                {
                    Console.WriteLine("Your very close");
                }
                else
                {
                    Console.WriteLine("Success !!");
                    break;
                }
               
            }

            Console.WriteLine("You have tried {0}", user_attempt);
            Console.Write("Numbers tried: ");
            for(int i = 0; i < list.Count(); ++i)
            {
                Console.Write("{0}, ", list[i]);
            }
            Console.WriteLine();
        }
    }
    
}
