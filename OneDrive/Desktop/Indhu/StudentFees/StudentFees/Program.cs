using System;

namespace StudentFees
{
    internal class Program
    {
     
        static double[] GetDiscountFees(double[] fees)
        {
            double[] newFees = new double[fees.Length];

            for (int i = 0; i < fees.Length; i++)
            {
                if (fees[i] > 7000)
                {
                    Console.WriteLine("Student " + (i + 1) + " eligible for 5% discount");
                    newFees[i] = fees[i] - (fees[i] * 0.05);
                }
                else
                {
                    newFees[i] = fees[i];
                }
            }

            return newFees;
        }

        static void Main(string[] args)
        {
            double[] fees = new double[5];
            for (int i = 0; i < 5; i++)
            {
                while (true)
                {
                    Console.Write("Enter fees for student " + (i + 1) + ": ");
                    fees[i] = Convert.ToDouble(Console.ReadLine());

                    if (fees[i] >= 5000 && fees[i] <= 10000)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Error: Fees must be between 5000 and 10000. Enter again.");
                    }
                }
            }
            double[] finalFees = GetDiscountFees(fees);
            Console.WriteLine("\nFees after discount:");

            for (int i = 0; i < finalFees.Length; i++)
            {
                Console.WriteLine("Student " + (i + 1) + " Fees: " + finalFees[i]);
            }
        }
    }
}