using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleSample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Regex reg = new Regex("^[0-9]*$");
            bool outerLoop = true;
            bool innerLoop = true;
            while (outerLoop)
            {
                Console.Write("Do you want to purchase an apple? (Y|N):  ");
                string input = Console.ReadLine().ToUpper();
                if (input.Equals("Y"))
                {
                    Console.WriteLine("\nThe price of apple is 32.50 each.");
                    while (innerLoop) 
                    {
                        Console.Write("\nEnter the number of apple/s you want to purchase: ");
                        string numOfApple = Console.ReadLine();
                        if (reg.IsMatch(numOfApple))
                        {
                            double totalPrice = 32.50 * Convert.ToInt32(numOfApple);
                            string message = Convert.ToInt32(numOfApple) > 1 ? "The total price of " + numOfApple + " apples" : "The total price of " + numOfApple + " apple";
                            Console.Write(message + " is: " + totalPrice + "\n");
                            Console.WriteLine("The values of the converted price is: " + (int)totalPrice + "\n");
                            outerLoop = false;
                            innerLoop = false;
                        }
                        else 
                        {
                            Console.WriteLine("INVALID INPUT!");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("INVALID INPUT!");
                }
            }
        }
    }
}
