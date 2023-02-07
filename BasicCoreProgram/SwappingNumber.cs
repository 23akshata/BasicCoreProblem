using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class SwappingNumber
    {
        public void swap()
        {
            int temp;
            Console.WriteLine("Enter the First Number:");
            int FirstNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Second Number:");
            int SecondNumber = Convert.ToInt32(Console.ReadLine());
            temp = FirstNumber;
            FirstNumber = SecondNumber;
            SecondNumber = temp;
            Console.WriteLine("\n After Swapping :");
            Console.WriteLine("\n First Number : " + FirstNumber);
            Console.WriteLine("\n Second Number : " + SecondNumber);
        }
    }
}
