using System;

namespace Course01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime date = new DateTime(2023, 8, 12, 11, 30, 15);
            Console.WriteLine(date.ElapsedTime());

            DateTime date2 = new DateTime(2023, 9, 11, 13, 23, 20);
            Console.WriteLine(date2.ElapsedTime());

            String message1 = "Good morning dear students!";
            Console.WriteLine(message1.Cut(10));
        }
    }
}
