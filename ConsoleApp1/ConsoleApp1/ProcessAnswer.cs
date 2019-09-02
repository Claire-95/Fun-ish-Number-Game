using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ProcessAnswer
    {
        int answer;
        Question question;
        ScoreManager scoreManager; 

        public ProcessAnswer(int answer, Question question, ScoreManager score)
        {
            this.answer = answer;
            this.question = question;
            this.scoreManager = score;
            
        }

        public void CheckAnswer()
        {
            if (answer == question.GetCorrectAnswer())
            {
                HandleCorrectResponse();

                scoreManager.AddReward(question);

                Console.WriteLine("Your Score now is: " + scoreManager.score);
            }
            else
            {
                HandleIncorrectResponse();

                Console.WriteLine("Your Score is now " + scoreManager.score + " loser...");
            }
        }


        void HandleCorrectResponse()
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

        void HandleIncorrectResponse()
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
