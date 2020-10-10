using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Tools;

namespace C_sharp_practice
{
    class MainClass
    {
        static void Main(string[] args)
        {
            bool life = true;
            int numOne, numTwo;
            int desiredAction;

            while (life)
            {
                Console.WriteLine("Please provide two numbers you want to calculate.");
                numOne = Convert.ToInt32(Console.ReadLine());
                numTwo = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("What do you want to do with these numbers?");
                Console.WriteLine("1. Add | 2. Subtract | 3. Time | 4. Divide | 5. Factors | 6. Multiples");
                desiredAction = Convert.ToInt32(Console.ReadLine());


                switch (desiredAction)
                {
                    case 1:
                        Console.WriteLine("Your result is {0}", CalculateNum.Add(numOne, numTwo));
                        break;
                    case 2:
                        Console.WriteLine("Your result is {0}", CalculateNum.Sub(numOne, numTwo));
                        break;
                    case 3:
                        Console.WriteLine("Your result is {0}", CalculateNum.Time(numOne, numTwo));
                        break;
                    case 4:
                        Console.WriteLine("Your result is {0}", CalculateNum.Divide(numOne, numTwo));
                        break;
                    case 5:
                        if (CalculateNum.Factors(numOne, numTwo) != null)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (i == 0)
                                {
                                    Console.WriteLine("Factors of {0} are ", numOne);
                                }
                                else if (i == 1)
                                {
                                    Console.WriteLine("Factors of {0} are ", numTwo);
                                }
                                else
                                {
                                    Console.WriteLine("Common factors of two numbers are");
                                }

                                foreach (int numbers in CalculateNum.Factors(numOne, numTwo)[i])
                                {
                                    Console.WriteLine(numbers);

                                }
                            }
                        }
                        break;

                    case 6:
                        Console.WriteLine("Please provide range for the common multiple calculation");
                        int range = Convert.ToInt32(Console.ReadLine());
                        if (CalculateNum.Multiple(numOne, numTwo, range) != null)
                        {
                            for (int i = 0; i < 3; i++)
                            {
                                if (i == 0)
                                {
                                    Console.WriteLine("Multiples of {0} are ", numOne);
                                }
                                else if (i == 1)
                                {
                                    Console.WriteLine("Multiples of {0} are ", numTwo);
                                }
                                else
                                {
                                    Console.WriteLine("Common multiples of two numbers are");
                                }

                                foreach (int numbers in CalculateNum.Multiple(numOne, numTwo, range)[i])
                                {
                                    Console.WriteLine(numbers);
                                }
                            }

                        }
                        break;
                }

                Console.WriteLine("Do you wish to exit the program?");
                Console.WriteLine("1. Yes | 2. No");

                if (Convert.ToInt32(Console.ReadLine()) == 1)
                    life = false;
                else
                {
                   for(int i = 0; i  < 6; i++)
                    {
                        Console.WriteLine(".");
                    }
                }
            }

                    Console.WriteLine("Please press any key to exit");
            Console.ReadKey();
        }
    }
}
