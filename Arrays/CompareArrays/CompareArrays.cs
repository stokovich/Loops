using System;
class CompareArrays
{
    static void Main()
    {
        int Number = int.Parse(Console.ReadLine());
        int[] Array1 = new int[Number];
        int[] Array2 = new int[Number];
        string Result = "Equal";

        for (int i = 0; i < Number; i++)
        {
            Array1[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Number; i++)
        {
            Array2[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 0; i < Number; i++)
        {
            if (Array1[i] != Array2[i])
            {
                Result = "Not equal";
            }
        }
        Console.WriteLine(Result);
    }
}
