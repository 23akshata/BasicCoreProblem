﻿using System;
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
            Console.WriteLine("1 :FlipCoin \n 2: LeapYear \n 3:PowerOfTwo \n 4:HarmonicNumber");
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
            }
            Console.ReadLine();
        }
    }
}
