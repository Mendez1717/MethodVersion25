using System;

namespace MethodVersion25
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, my name is Mikayla Anne Mendez and this is Version 25!");
            
            int Num1;
            int Num2;
            int result;
            
            Console.WriteLine("Enter the symbol of which operation you would like to use out of Addition(+), Subtraction(-), Multiplication(*), or Division(/):  ");
            string operationsign;
            Console.Write("You Typed:  ");
            operationsign = Console.ReadLine();

            // Ask user to enter value
            Console.Write("Enter the first number:  ");
            Num1 = Convert.ToInt32(Console.ReadLine());

            // Ask user to enter value
            Console.Write("Enter the second number:  ");
            Num2 = Convert.ToInt32(Console.ReadLine());

            if (operationsign == "+")
            {
                result = Num1 + Num2;
                Console.WriteLine("The sum of the Addition Operation is: {0}", result);
            }
            else if (operationsign == "-")
            {
                result = Num1 - Num2;
                Console.WriteLine("The result from the Subtraction Operation is:  {0}", result);
            }
            else if (operationsign == "*")
            {
                result = Num1 * Num2;
                Console.WriteLine("The result from the Multiplication Operation is:  {0}", result);

            }
            else if (operationsign == "/")
            {
                if (Num2 != 0)
                {

                    result = Num1 / Num2;
                    Console.WriteLine("The result from the Division Operation is:  {0}", result);
                }
                else
                { Console.WriteLine("DIV/ZERO!"); }
            }
        }
    }
}
