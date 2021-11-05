using System;
using System.Collections.Generic;
using System.Text;
namespace logicalProgram
{
    class couponNumber
    {
        public void coupons()
        {
            Random ran = new Random();
            Console.WriteLine("enter the coupon limit");
            int numberOfCoupons = int.Parse(Console.ReadLine()),i=0,temp=0,chek=0;

            int[] totalCoupons = new int[numberOfCoupons];

            while (i!=numberOfCoupons)
            {
                chek = 0;
                temp = ran.Next(1, numberOfCoupons+1);
                for (int j = 0; j < numberOfCoupons; j++)
                {
                    if (temp == totalCoupons[j])
                    {
                        chek++;
                    }
                }
                if (chek == 0)
                {
                    totalCoupons[i] = temp;
                    
                    i++;
                }
            }
            for (int j = 0; j < numberOfCoupons; j++)
            {          
                    Console.WriteLine("person "+(j+1)+" = " + totalCoupons[j]);
            }
        } 
    }
}
