using System;
using System.Numerics;

class CalculateAgain
{
    static void Main()
    {
        ushort NumN = ushort.Parse(Console.ReadLine());
        ushort NumK = ushort.Parse(Console.ReadLine());
        BigInteger FactN = 1;
        BigInteger FactK = 1;



        for (int i = 1, j = 1; i <= NumN; i++, j++)
        {

            if (j <= NumK)
            {
                FactN *= i;
                FactK *= j;
            }
            else
            {
                FactN *= i;
            }         
        }

        Console.WriteLine(FactN / FactK);
    }
}
