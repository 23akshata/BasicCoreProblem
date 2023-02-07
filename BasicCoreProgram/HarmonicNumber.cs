using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class HarmonicNumber
    {
        public void Harmonic()
        {
            Console.WriteLine("Enter the Last Harmonic");
            double num = Convert.ToDouble(Console.ReadLine());
            double sum = 0;

            for(int i=1; i<=num; i++)
            {
                Console.WriteLine("1/" + i + "=" +(1/i));
                sum+= (1/i);
            }
            Console.WriteLine("\n Sum of Series is :"+ sum);
        }

    }
}
