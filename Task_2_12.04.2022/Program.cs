using System;

namespace Task_2_12._04._2022
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1-ci reqemi daxil edin");
            int FirstNumber = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("2-ci reqemi daxil edin");
            int SecondNumber = Convert.ToInt16(Console.ReadLine());
            if (FirstNumber > SecondNumber)
            {
                Console.WriteLine("First number" + " " + FirstNumber);
            }
            else if (SecondNumber > FirstNumber)
            {
                Console.WriteLine("Second number" + " " + SecondNumber);
            }
            else
            {
                Console.WriteLine("Reqemler Beraberdir =)");
            }
        }
    }
}
