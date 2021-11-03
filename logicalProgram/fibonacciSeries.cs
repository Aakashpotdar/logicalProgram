using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProgram
{
    class fibonacciSeries
    {
        public void logicPart()
        {
            Console.WriteLine("enter limit ");
            int limit = int.Parse(Console.ReadLine());

            int firstNum = 0, secondNum = 1,nextNum=0;
            Console.WriteLine("");
            Console.Write("the fibonacci series of numbers : " + firstNum +" "+ secondNum);
            for (int i = 0; i <= limit; i++)
            {
                nextNum = firstNum + secondNum;
                firstNum = secondNum;
                secondNum = nextNum;
                Console.Write(" " + nextNum);
            }
        }
    }
}
