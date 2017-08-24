using System;

class Matrix
{
    static void Main()
    {
        byte NumN = byte.Parse(Console.ReadLine());

        for (int i = 1; i <= NumN; i++)
        {
            Console.Write(i);
            for (int j = 1; j < NumN; j++)
            {
                Console.Write(" {0}", i + j);
            }
            Console.Write("\n");
        }
    }
}
