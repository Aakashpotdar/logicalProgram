using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace logicalProgram
{
    class stopWatch
    {
        public void logic()
        {
            Console.WriteLine("enter start to start stop watch");
            string s = Console.ReadLine();
            stopWatch watch1 = null;
            if (s.Equals("start"))
            {
                new stopWatch();
              //  watch1.Start();
            }
            Console.WriteLine("enter start to stop stop watch");
            string s1 = Console.ReadLine();
            stopWatch watch2 = null;
            if (s1.Equals("stop"))
            {
                new stopWatch();
               // watch2.Stop();
            }
        }
    }
}
