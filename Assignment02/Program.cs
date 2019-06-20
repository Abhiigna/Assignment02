using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02
{
    public class Program
    {
        static void Main(string[] args)
        {
            // initializing variables
            int choice;
            int line1 = 0, line2 = 0, line3 = 0;
            do
            {
                Console.WriteLine("Enter  the correct options: ");
                Console.WriteLine("1.Enter triangle's dimensions");
                Console.WriteLine("2.Exit");
                String ch = Console.ReadLine();
                // checking user input
                if ((!int.TryParse(ch, out choice) || choice <= 0 || choice > 2))
                {
                    Console.WriteLine("Please give your choice: ");
                    continue;
                }

                switch (choice)
                {
                    case 1:
                        do
                        {
                            do
                            {
                                Console.WriteLine("Enter First Side: ");
                                //convert a string representation of number to an integer
                            } while (!int.TryParse(Console.ReadLine(), out line1));
                        } while (line1 <= 0);
                        do
                        {
                            do
                            {
                                Console.WriteLine("Enter Second Side: ");
                            } while (!int.TryParse(Console.ReadLine(), out line2));
                        } while (line2 <= 0);
                        do
                        {
                            do
                            {
                                Console.WriteLine("Enter third Side: ");
                            } while (!int.TryParse(Console.ReadLine(), out line3));
                        } while (line3 <= 0);
                        break;

                    case 2:
                        Environment.Exit(0);
                        break;
                }
                Console.WriteLine(TriangleSolver.Analyze(line1, line2, line3));
            } while (choice != 2);


        }
    }
}
