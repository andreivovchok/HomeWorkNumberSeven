using System;

namespace TaskTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] twoDimensional = { { 87, 25, 45 }, { 74, 12, 32 }, { 51, 97, 165 } };

            for(int i = 0; i < 3; i++)
            {
                int maxValue = 0;
                for(int n = 0; n < 3; n++)
                {
                    if(twoDimensional[i,n] > maxValue)
                    {
                        maxValue = twoDimensional[i, n];
                    }
                }
                Console.WriteLine($"Максимальное число - {maxValue}");
            }
        }
    }
}
