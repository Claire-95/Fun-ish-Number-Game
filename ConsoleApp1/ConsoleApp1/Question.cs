using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Question
    {
       
        public int num2 { get; private set; }
        public int num1 { get; private set; }

        public Question()
        {
            Random numberGenerator = new Random();
            this.num1 = numberGenerator.Next(1, 11);
            this.num2 = numberGenerator.Next(1, 11);
            
        }
        

        public int GetCorrectAnswer()
        {
            return this.num1 * this.num2;
        }
    }
}
