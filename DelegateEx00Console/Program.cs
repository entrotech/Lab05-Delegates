using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DelegateEx00Console
{
    // Step 1: Define a delegate type with the right "shape"
    // (i.e., parameter list and return type)
    public delegate double BinaryOperation(double operand1, double operand2);

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Delegate Example 0 - A degenerate usage: ");
            double a = 24;
            double b = 11;
            double c;

            // Step 2: Declare a reference variable for a 
            // Binary Operation delegate
            BinaryOperation binOp;

            // Step 3: Instantiate a delegate and 
            // assign to variable
            binOp = new BinaryOperation(BinaryOperations.Add);
            // binOp = BinaryOperations.Add;  // Short Form

            // Step 4: Invoke the delegate to use it.
            c = binOp.Invoke(a, b);
            //c = binOp(a, b); // Short Form

            Console.WriteLine(a + " + "
                + b + " = " + c);

            // Programmatically switch methods by
            // re-assigning the delegate to Subtract
            binOp = BinaryOperations.Subtract;

            // Delegate subtracts
            c = binOp(a, b);

            Console.WriteLine(a + " - "
                + b + " = " + c);

            Console.WriteLine("Press <Enter> to quit the program:");
            Console.ReadLine();
        }
    }

    public static class BinaryOperations
    {
        public static double Add(double op1, double op2)
        {
            return op1 + op2;
        }

        public static double Subtract(double op1, double op2)
        {
            return op1 - op2;
        }
    }
}
