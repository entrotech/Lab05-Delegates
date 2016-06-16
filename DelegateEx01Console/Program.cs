using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegateLibrary;

namespace DelegateEx01Console
{
    class Program
    {
        static void Main(string[] args)
        {
            AdjustDelegate d;

            Console.WriteLine("Delegate Example 1: Plug-In Method ");
            Console.WriteLine("Enter an adjustment percentage between -100 ");
            Console.WriteLine("and + 1000 or <Enter> for standard markup:");
            decimal percentage;
            if (decimal.TryParse(Console.ReadLine(), out percentage)
                && percentage >= -100.0M && percentage <= 1000.0M)
            {
                // To use an instance method, we need to create an instance
                // of an object that has the method.
                Adjuster adj = new Adjuster(percentage);
                // delegate operation to the object
                d = adj.Apply;
            }
            else
            {
                // To use a static method, we just use the class name to 
                // reference the method.
                d = Adjuster.ApplyStandard;
            }

            while (true)
            {
                Console.WriteLine("Enter list price then "
                    + "<Enter> or just <Enter> to quit:");
                decimal listPrice;
                if (decimal.TryParse(Console.ReadLine(), out listPrice))
                {
                    Console.WriteLine("List Price: "
                        + listPrice.ToString("c")
                        + "\t Adj Price: "
                        + d(listPrice).ToString("c"));
                }
                else
                {
                    break;
                }
            }

            Console.WriteLine("Press <Enter> to quit the program:");
            Console.ReadLine();
        }
    }
}
