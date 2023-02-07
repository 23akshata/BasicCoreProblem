using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
        public class PowerOfTwo
        {
            public void PowerTwo()
            {
                Console.WriteLine("Enter The Number");
                int num = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < num; i++)
                {
                    Console.WriteLine("2^{0}" + " " + " = {1}", i, Math.Pow(2, i));
                }
            }
        }
    
}
    
