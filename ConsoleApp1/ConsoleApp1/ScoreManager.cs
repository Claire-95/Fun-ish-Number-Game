using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class ScoreManager
    {
        public int score = 0;


        public void AddReward(Question question)
        {
            this.score += CalculateReward(question);
        }

        private int CalculateReward(Question question)
        {
            if (IsEasyNumber(question.num1) || IsEasyNumber(question.num2))
            {
                return 1;
            }
            else
            {
                return 2;
            }
        }
        private static bool IsEasyNumber(int number)
        {
            char numLast = number.ToString().ToCharArray().Last();
            return numLast == '0' || numLast == '5' || number == 2 || number == 1;
        }
    }
}
