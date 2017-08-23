using System;

class NumFrom1ToN
{
    static void Main()
    {
        int NumN = int.Parse(Console.ReadLine());
        int i = 1;
        while (i <= NumN)
        {
            Console.Write("{0} ", i);
            i++;
        }
    }
}
