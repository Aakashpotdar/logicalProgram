using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProgram
{
    class reversNumber
    {
        public void check()
        {
            Console.WriteLine("enter input");
            int num=int.Parse(Console.ReadLine());
            int rev = 0;
            while (num > 0)
            {
                int temp = num % 10;
                rev = (rev * 10) + temp;
                num = num / 10;
            }

            Console.WriteLine(" " + rev);
        } 
    }
}
