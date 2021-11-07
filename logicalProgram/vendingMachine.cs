using System;
using System.Collections.Generic;
using System.Text;

namespace logicalProgram
{
    class vendingMachine
    {
        public void MinimumNumberOfNote(int change)
        {
            int[] arr = { 1000, 500, 100, 50,10,3, 2, 1 };

            int[] notes = new int[10];

            int count = 0;

            //Console.WriteLine("enter the input");
            for (int i = 0; i < arr.Length; i++)
            {
                while (change / arr[i] != 0)
                {
                    if (arr[i] == 1000 || arr[i] == 100 || arr[i] == 10)
                    {
                        notes[i] = change / arr[i];
                        change %= arr[i];
                    }
                    else
                    {
                        notes[i] = ++count;
                        change %= arr[i];
                    }
                }
                count = 0;
            }
            for (int i = 0; i < notes.Length; i++)
            {
                count += notes[i];
                Console.WriteLine("number of rs: " + arr[i] + " number of notes are needed " + notes[i]);
            }
            Console.WriteLine("total number of notes nedded to return chenge " + count);
            
        }
    }
}
