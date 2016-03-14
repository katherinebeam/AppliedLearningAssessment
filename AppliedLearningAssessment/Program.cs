using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppliedLearningAssessment
{
    class Program
    {
        static void Main(string[] args)
        {
            // Question 1
            Console.WriteLine("Enter an integer:");
            int number = int.Parse(Console.ReadLine());

            if (number < 10)
            {
                Console.WriteLine("This number is too small");
            }
            else if (number >= 10)
            {
                Console.WriteLine("This number is big enough");
            }

            // Question 2
            double[] floatingPointNumbers = { 1.01, 2.22, 3.34, 4.56, 6.76 };
            Console.WriteLine(floatingPointNumbers[1]);

            //Question 3
            foreach(double num in floatingPointNumbers)
            {
                Console.Write(num + " ");
            }
        }
    }
}
