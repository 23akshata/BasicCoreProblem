using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class LargestNumber
    {
       public void ThreeNum()
       {
            int FirstNum, SecondNum, ThirdNum;
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("Input the 1st number :");
            FirstNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :");
            SecondNum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :");
            ThirdNum = Convert.ToInt32(Console.ReadLine());

            if (FirstNum > SecondNum)
            {
                if (FirstNum > ThirdNum)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (SecondNum > ThirdNum)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n");
       }
    }
}
