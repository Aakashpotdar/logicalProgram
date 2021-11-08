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
            //Console.WriteLine("enter start to start stop watch");
            //string s = Console.ReadLine();
            Stopwatch watch1 = new Stopwatch();
            watch1.Start();
            Console.WriteLine("enter no.: ");
            for(int i = 0; i < 1000; i++)
            {
                System.Threading.Thread.Sleep(50);

            }
            watch1.Stop();
            Console.WriteLine("elast time:{0:hh\\:mm\\:ss} "+watch1.ElapsedTicks);

            //if (s.Equals("start"))
            //{
              //  new stopWatch();
                //watch1.Start();
            //}
            //Console.WriteLine("enter start to stop stop watch");
            //string s1 = Console.ReadLine();
            //stopWatch watch2 = null;
            //if (s1.Equals("stop"))
            //{
              //  new stopWatch();
                //watch1.Stop();
            //}
        }
    }
}
