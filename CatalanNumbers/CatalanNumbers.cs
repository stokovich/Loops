using System;
using System.Numerics;

class CatalanNumbers
{
    static void Main()
    {
        byte NumN = byte.Parse(Console.ReadLine());
        BigInteger NK = 1;
        BigInteger K = 1;

        for (int i = 2; i <= NumN; i++)
        {
            NK *= NumN + i;
            K *= i;
        }
        Console.WriteLine(NK / K);
    }
}
