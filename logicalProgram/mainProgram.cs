using System;

namespace logicalProgram
{
    class mainProgram
    {
        static void Main(string[] args)
        {
    lable1:Console.WriteLine("select the program : 1.fibonacci series 2.Perfect number 3.prime number");
           Console.WriteLine("                     4.reverce number   5.stop watch     6.coupon number 7.stop watch");
            int option = int.Parse(Console.ReadLine());

            switch(option)
            {
                 case 1:
                    fibonacciSeries obj1 = new fibonacciSeries();
                    obj1.logicPart();
                    break;
                case 2:
                    perfectNumber obj2 = new perfectNumber();
                    obj2.checkNum();
                    break;
                case 3:
                    primeNumber obj3 = new primeNumber();
                    obj3.opration();
                    break;

                case 4:
                    reversNumber obj4 = new reversNumber();
                    obj4.check();
                    break;
                case 5:
                    couponNumber obj5 = new couponNumber();
                    obj5.coupons();
                    break;
                case 6:
                    vendingMachine obj6 = new vendingMachine();
                    obj6.MinimumNumberOfNote(1580);
                    break;
                case 7:
                    stopWatch obj7 = new stopWatch();
                    obj7.logic();
                    break;
                default:
                    Console.WriteLine("enter correct choice");
                    break;
            }

            Console.WriteLine("do you want to continue.....y/n");
            char key = char.Parse(Console.ReadLine());
            if (key == 'y')
            {
                goto lable1;
            }
            else
            {
                Console.WriteLine("thank you for your time");
            }

        }
    }
}
