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
            int score = 0;

        Start:

            Random numberGenerator = new Random();

            int num01 = numberGenerator.Next(1, 11);
            int num02 = numberGenerator.Next(1, 11);
            string Answer;


            Console.WriteLine("What is " + num01 + " times " + num02 + "?");
            string stringAnswer = Console.ReadLine();
            int answer = Convert.ToInt32(stringAnswer);

            if (answer == num01 * num02)
            {
                CorrectResponse();

                if (stringAnswer.EndsWith("0") || stringAnswer.EndsWith("5"))
                {
                    score++;
                }
                else
                {
                    score+=2;
                }

                Console.WriteLine("Your Score now is: " + score);
            }
            else
            {
                IncorrectResponse();

                Console.WriteLine("Your Score is now " + score + " loser...");
            }

            Console.Write("Would you like to try again? y/n: ");
            Answer = Console.ReadLine();

            if (Answer == "y")
            {
                goto Start;
            }
            else
            {
                Console.WriteLine("You're no fun.");
            }

            Console.ReadLine();
        }

        static void CorrectResponse()
        {
            Random numberGenerator = new Random();
            int response = numberGenerator.Next(1, 4);
        

            switch (response)
            {
                case 1:
                    Console.WriteLine("You're so smart!");
                    break;

                case 2:
                    Console.WriteLine("You clever Cookie, you!");
                    break;

                default:
                    Console.WriteLine("I am in awe of your brain!!");
                    break;
            }

        }

        static void IncorrectResponse()
        {

            Random numberGenerator = new Random();
            int responseIndex = numberGenerator.Next(1, 4);
            
            switch (responseIndex)
            {
                case 1:
                    Console.WriteLine("Wrong, dummy!");
                    break;

                case 2:
                    Console.WriteLine("So Wrong, OMG!");
                    break;

                default:
                    Console.WriteLine("No, that is so wrong...");
                    break;
            }

            
        }


    }

}


