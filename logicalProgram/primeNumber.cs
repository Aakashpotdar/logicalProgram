using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProgram
{
    class primeNumber
    {
        public void opration()
        {
            Console.WriteLine("enter input number");
            int num = int.Parse(Console.ReadLine());
            int count = 0;
            for(int i = 1; i <= num; i++)
            {
                if ((num % i) == 0)
                {
                    count++;
                }
            }
            if (count == 2)
            {
                Console.WriteLine("the number is a prime number");
            }
            else
            {
                Console.WriteLine("the number is a not prime number");
            }
        }
    }
}
