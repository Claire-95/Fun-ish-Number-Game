using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Program
    {
        
        static void Main(string[] args)
        {
        Start:
            Question question = new Question();
            ScoreManager score = new ScoreManager(); 

            Console.WriteLine("What is " + question.num1 + " times " + question.num2 + "?");
            int answer = int.Parse(Console.ReadLine());

            ProcessAnswer answerProcessor = new ProcessAnswer(answer, question, score);
            answerProcessor.CheckAnswer();
            

            Console.Write("Would you like to try again? y/n: ");
            var Answer = Console.ReadLine();

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


    }

}


