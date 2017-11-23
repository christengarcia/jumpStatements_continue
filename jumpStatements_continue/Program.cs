using System;

namespace jumpStatements_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("i = {0}", i);
                if (i == 2)
                continue; /* the rest of the loop after the continue
                keyword is skipped for theat iteration.*/

                Console.WriteLine("I will not be printed if i = 2. \n");
            }
        }
    }
}
