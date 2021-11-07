using System;
using System.Collections.Generic;
using System.Text;
namespace logicalProgram
{
    class couponNumber
    {
        public void coupons(int n)//n=5
        {

            Random ran = new Random();
            //n = ran.Next(1, 9);
            int check = ran.Next(1, 9);
            //Console.WriteLine("enter the coupon limit");
            int count = 0;
            Console.WriteLine("coupon number is: "+n);
            while (n > 0)
            {
                if (check==n) 
                {
                    Console.WriteLine("number is present");
                    break;
                }
                count++;
                Console.WriteLine("count :" + count);
                n--;
            }
            Console.WriteLine("to get  number we need count " + count);
            //int numberOfCoupons = int.Parse(Console.ReadLine()), i = 0, k = 0, temp=0,chek=0;

            //int[] totalCoupons = new int[numberOfCoupons];

            //while (i!=numberOfCoupons)
            //{
            //    k++;
            //    chek = 0;
            //    temp = ran.Next(1, numberOfCoupons+1);
            //    for (int j = 0; j < numberOfCoupons; j++)
            //    {
            //        if (temp == totalCoupons[j])
            //        {
            //            chek++;
            //        }
            //    }
            //    if (chek == 0)
            //    {
            //        totalCoupons[i] = temp;
                    
            //        i++;
            //    }
            //}
            //for (int j = 0; j < numberOfCoupons; j++)
            //{          
            //        Console.WriteLine("person "+(j+1)+" = " + totalCoupons[j]);
            //}
        } 
    }
}
