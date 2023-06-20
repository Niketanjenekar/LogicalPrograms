using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Logic_For_Program
    {
        public static void ProgramLogic()
        {

            Console.WriteLine("This program is to find the given number is the perfect number");

            Console.WriteLine("Please enter your Number");

            int Num = Convert.ToInt32(Console.ReadLine());

            int Sum = 0;

            for (int i = 1; i < Num; i++)
            {
                if(Num % i == 0)
                {
                    Sum += i;
                                       
                }
                
            }
            if (Num == Sum)
            {
                Console.WriteLine("The Number is Perfect Number");
            }
            else
            {
                Console.WriteLine("The number is not the perfect number");
            }

        }
        
    }
}
