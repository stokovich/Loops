using System;
using System.Numerics;

class TrailingN
{
    static void Main()
    {
        uint NumN = uint.Parse(Console.ReadLine());
        uint Sum = 0;
        uint Result = 0;
        uint Counter = 1;

        do
        {
            Result = NumN / (uint)(Math.Pow(5, Counter));
            Counter++;
            Sum += Result;
        }
        while (Result >= 1);

        Console.WriteLine(Sum);
    }
}
    
