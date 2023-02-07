using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class EvenorOdd
    {
        public void EvenOdd()
        {
            int rem;
            Console.WriteLine("Enter the Number is Even or Odd");
            int num = Convert.ToInt32(Console.ReadLine());
            rem = num % 2;
            if (rem == 0)
                Console.WriteLine("{0} is an Even Number \n", num);
            else
                Console.WriteLine("{0} is an Odd Number \n", num);
        }
    }
}
