using System;

namespace AlgortGeneral
{
	public static class MultTableGrade
    {
        public static void ShowTableGrade()
        {
            int number;

            Console.Write("Enter a number: ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number <= 0)
            {
                Console.WriteLine("You entered an invalid no");
                number = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Multiplication Table :");
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine("\n");
                for (int j = 1; j <= number; j++)
                {
                    Console.Write("{0,6}", i * j);
                }
            }
            Console.Read();
        }
    }
}
