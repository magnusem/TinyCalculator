using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TinyCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            int FirstInput;
            int SecondInput;
            int Result = 0;
            string Method;

            Console.WriteLine("// TinyCalculator v0.1 //");
            Console.WriteLine("Please enter your first number");
            FirstInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Now enter second number");
            SecondInput = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Choose your calculating method (*, +, -, /)");
            Method = Console.ReadLine();

            if (Method == "*")
            {
                Result = FirstInput * SecondInput;
            }
            else if (Method == "+")
            {
                Result = FirstInput + SecondInput;
            }
            else if (Method == "-")
            {
                Result = FirstInput - FirstInput;
            }
            else if (Method == "%")
            {
                Result = FirstInput / SecondInput;
            }

            Console.WriteLine("Result: " + Result);

            Console.WriteLine("Press any key to exit the application");
            Console.ReadKey();
        }
    }
}
