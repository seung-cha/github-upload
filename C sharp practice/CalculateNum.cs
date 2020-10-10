using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace Tools
{
    static class CalculateNum
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static int Sub(int a, int b)
        {
            return a - b;
        }

        public static int Time(int a, int b)
        {
            return a * b;
        }

        public static float Divide(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("You cannot divide number by 0");
                return 0;
            }
            else
                return a / b;

        }

        public static List<int>[] Factors(int a, int b)
        {

            if (a == 0 || b == 0)
            {
                Console.WriteLine("Please provide a proper number that is not 0");
                return null;
            }
            else
            {
                List<int> factorsA = new List<int>();
                List<int> factorsB = new List<int>();
                List<int> CF = new List<int>();


                for (int i = 1; i <= a; i++)
                {
                    if (a % i == 0)
                        factorsA.Add(i);
                }

                for (int i = 1; i <= b; i++)
                {
                    if (b % i == 0)
                        factorsB.Add(i);
                }


                for (int i = 0; i < factorsA.Count; i++)
                {
                    for (int s = 0; s < factorsB.Count; s++)
                    {
                        if (factorsA.ElementAt(i) == factorsB.ElementAt(s))
                            CF.Add(factorsA.ElementAt(i));
                    }
                }

                List<int>[] group = new List<int>[3];
                group[0] = factorsA;
                group[1] = factorsB;
                group[2] = CF;

                return group;
            }
        }

        public static List<int>[] Multiple(int a, int b, int range)
        {
            if (a == 0 || b == 0)
            {
                Console.WriteLine("Please provide a proper number that is not 0");
                return null;
            }

            if (range < a || range < b)
            {
                Console.WriteLine("Range cannot be smaller than the numbers provided!");
                return null;
            }
            int limit = 0;
            List<int> multipleA = new List<int>();
            List<int> multipleB = new List<int>();
            List<int> CM = new List<int>();

            for (int i = 1; limit <= range; i++)
            {
                limit = a * i;

                if (limit >= range)
                {
                    multipleA.Add(limit);
                    break;
                }

                multipleA.Add(limit);
            }

            limit = 0;

            for (int i = 1; limit <= range; i++)
            {
                limit = b * i;


                if (limit >= range)
                {
                    multipleB.Add(limit);
                    break;
                }


                multipleB.Add(limit);
            }


            for (int i = 0; i < multipleA.Count; i++)
            {
                for (int s = 0; s < multipleB.Count; s++)
                {
                    if (multipleA.ElementAt(i) == multipleB.ElementAt(s))
                        CM.Add(multipleA.ElementAt(i));
                }
            }

            List<int>[] group = new List<int>[3];
            group[0] = multipleA;
            group[1] = multipleB;
            group[2] = CM;

            return group;
        }
    }
}