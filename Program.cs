using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_largest_of_three_numbers
{
    class Program
    {
        static void Main(string[] args)
        //Find the gratesst number among three numbers.
        {
            int num1, num2, num3;
            Console.Write("\n\n");
            Console.Write("Find the largest of three numbers:\n");
            Console.Write("------------------------------------");
            Console.Write("\n\n");

            Console.Write("Input the 1st number :"); //first number
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the  2nd number :"); //second number
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input the 3rd  number :"); //third number
            num3 = Convert.ToInt32(Console.ReadLine());
            //If else statement used to find the gratest number
            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.Write("The 1st Number is the greatest among three. \n\n");
                }
                else
                {
                    Console.Write("The 3rd Number is the greatest among three. \n\n");
                }
            }
            else if (num2 > num3)
                Console.Write("The 2nd Number is the greatest among three \n\n");
            else
                Console.Write("The 3rd Number is the greatest among three \n\n");
        }
    }
}
