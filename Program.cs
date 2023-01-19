/*
Author: SM Zaman
Date: 1/19/2023
Descriotion: C# Concole Application for calculating letter grades
*/

using System;

namespace Deliverable_2_
{
class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a numeric grade: ");

            try
            {

                decimal grade = decimal.Parse(Console.ReadLine());

                

                if (grade >= 90)
                {
                   
                    Console.WriteLine("Your expected letter grade for ISM 4300 is A");
                    Console.ReadKey();
                }

                else if (grade >= 80 && grade < 90)
                {
                    Console.WriteLine("Your execpted letter grade for ISM 4300 is B");
                    Console.ReadKey();
                }

                else if (grade >= 70 && grade < 80)
                {
                    Console.WriteLine("Your execpted letter grade for ISM 4300 is C");
                    Console.ReadKey();
                }

                else if (grade >= 60 && grade < 70)
                {
                    Console.WriteLine("Your execpted letter grade for ISM 4300 is D");
                    Console.ReadKey();
                }

                else if (grade < 60)
                {
                    Console.WriteLine("Your execpted letter grade for ISM 4300 is F");
                    Console.ReadKey();
                }
            }
            catch
            {
                Console.WriteLine("Enter a numeric value");
            }
            
        }

    }
}

