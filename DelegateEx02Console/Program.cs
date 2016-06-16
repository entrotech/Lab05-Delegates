using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DelegateLibrary;

namespace DelegateEx02Console
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Example 2:");
            Console.WriteLine("Delegate as a Call-Back method");

            decimal[] prices = { 678.34m, 34.22m, 1293.11m };
            Adjuster adj = new Adjuster(-25.0M);
            AdjustDelegate adjustDelegate = adj.Apply;

            // Second method argument is a call-back delegate,
            // which the method "plugs into" its code at the 
            // appropriate place(s).
            DecimalTransformer.Transform(prices, adjustDelegate);

            // Print adjusted prices
            foreach (var item in prices)
            {
                Console.WriteLine("Adjusted Price: "
                    + item.ToString("c"));
            }

            Console.WriteLine("Press <Enter> to quit the program:");
            Console.ReadLine();
        }
    }
}
