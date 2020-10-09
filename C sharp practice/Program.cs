using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace C_sharp_practice
{
    class MainClass
    {
        static void Main(string []args)
        {
            Console.WriteLine("Please Enter two numbers");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int restriction;
            Console.WriteLine("Now Processing");



            List<float> results = new List<float>();
            List<float> resultsTwo = new List<float>();
            for(int i = a; i >= 1; i--)
            {
                float temp = a % i;

                if (temp == 0)
                    results.Add(i);
            }

            for (int i = b; i >= 1; i--)
            {
                float temp = b % i;

                if (temp == 0)
                    resultsTwo.Add(i);
            }

            foreach (float num in results)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("And");

            foreach (float num in resultsTwo)
            {
                Console.WriteLine(num);
            }




            List<int> commonFactors = new List<int>();
           for(int i = 0; i < results.Count; i ++)
            {
                for( int s = 0; s< resultsTwo.Count; s++)
                {
                    if(results.ElementAt(i) == resultsTwo.ElementAt(s))
                    {
                        commonFactors.Add((int)results.ElementAt(i));
                    }
                }
            }

            Console.WriteLine("We've found some common factors! and they are : ");
           foreach (int num in commonFactors)
            {
                Console.WriteLine(num);
            }

            if (commonFactors.ElementAt(0) != 1)
                Console.WriteLine("The greatest common factor is : {0}", commonFactors.ElementAt(0));
            else
                Console.WriteLine("We did not find any GCF that is not 1");

            Console.WriteLine("Please restrict the range for Lowest Common Multiple");
            restriction = Convert.ToInt32(Console.ReadLine());
            List<int> lcm = new List<int>();
            List<int> lcmT = new List<int>();

            int tempCount = 1;
            while(true)
            {
                
                int tempNum;
                tempNum  = tempCount *a;
                tempCount++;

                if (tempNum >= restriction)
                {
                    tempCount = 1;
                    break;
                }
                else
                    lcm.Add(tempNum);
            }

            while (true)
            {

                int tempNum;
                tempNum = tempCount * b;
                tempCount++;

                if (tempNum >= restriction)               
                    break;               
                else
                    lcmT.Add(tempNum);
            }

            List<int> commonMultiple = new List<int>();
            for (int t = 0; t < lcm.Count; t++)
            {
                for (int d = 0; d < lcmT.Count; d++)
                {
                    if (lcm.ElementAt(t) == lcmT.ElementAt(d))
                    {
                        commonMultiple.Add(lcm.ElementAt(t));
                    }
                }
            }


            Console.WriteLine("Common multiples within the restriction of {0} are : ", restriction);

            foreach (int num in commonMultiple)
            {
                Console.WriteLine(num);
            }



            Console.WriteLine("To exit, please press any key.");

            Console.ReadKey();
        }
    }

}
