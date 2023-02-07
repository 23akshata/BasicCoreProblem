using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 :FlipCoin \n 2: LeapYear \n 3:PowerOfTwo \n 4:HarmonicNumber \n 5:CalculatingFactor \n 6:QuotientRemainder \n 7:SwappingNumber \n 8:EvenorOdd");
            Console.WriteLine("Enter a Option");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    FlipCoin flip = new FlipCoin();
                    flip.Coin();
                    break;

                case 2:
                    LeapYear leap = new LeapYear();
                    leap.Leap();
                    break;

                case 3:
                    PowerOfTwo power = new PowerOfTwo();
                    power.PowerTwo();
                    break;

                case 4:
                    HarmonicNumber Harmonic = new HarmonicNumber();
                    Harmonic.Harmonic();
                    break;

                case 5:
                    CalculatingFactor factor = new CalculatingFactor();
                    factor.Factor();
                    break;

                case 6:
                    QuotientRemainder division = new QuotientRemainder();
                    division.Division();
                    break;

                 case 7:
                     SwappingNumber swap = new SwappingNumber();
                     swap.swap();
                     break;

                 case 8:
                    EvenorOdd Evenodd = new EvenorOdd();
                    Evenodd.EvenOdd();
                    break;
            }
            Console.ReadLine();
        }
    }
}
