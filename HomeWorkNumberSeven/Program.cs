using System;

namespace HomeWorkNumberSeven
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[6];
            for(int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine("Введите {0}-й элемент массива", i + 1);
                numbers[i] = int.Parse(Console.ReadLine());
            }
            //Console.WriteLine();
            foreach(int userNumber in numbers)
            {
                Console.Write($"{userNumber} ");
            }

            Array.Sort(numbers);
            Array.Reverse(numbers);

            Console.WriteLine();
            foreach (int sortedUserNumber in numbers)
            {
                Console.Write($"{sortedUserNumber} ");
            }
        }
    }
}
