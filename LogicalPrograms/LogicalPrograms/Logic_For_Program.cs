using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Logic_For_Program
    {
        public static void ProgramLogic()
        {
            Console.WriteLine("This is the Program for Fibonacci Series");

            int First = 0, Second = 1, Next;

            Console.WriteLine("Please write the number Upto what you wanted the Fibonacci Series : ");

            int Number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The Fibonacci Series for " + Number + " numbers is : ");
            for (int i = 0; i < Number; i++)
            {
                if (i < 1)
                {
                    Next = i;
                }
                else
                {
                    Next = First + Second;
                    First = Second;
                    Second = Next;
                }
                Console.Write(Next + " ");
            }
        }
    }
}
