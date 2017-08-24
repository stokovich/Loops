using System;
using System.Numerics;

class CalculateThird
{
    static void Main()
    {
        double NumN = double.Parse(Console.ReadLine());
        double NumK = double.Parse(Console.ReadLine());
        double NminusK = NumN - NumK;
        BigInteger FactN = 1;
        BigInteger FactK = 1;
        BigInteger FactNK = 1;

        for (int i = 1; i <= NumN; i++)
        {
            if (i <= NumK)
            {
                FactN *= i;
                FactK *= i;
            }
            else
            {
                FactN *= i;
            }
        }

        for (int i = 1; i <= NminusK; i++)
        {
            FactNK *= i;
        }

        Console.WriteLine(FactN / (FactK * FactNK));
    }
}
