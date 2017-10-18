using System;
class SumOfK
{
    static void Main()
    {
        int NNum = int.Parse(Console.ReadLine());
        int KNum = int.Parse(Console.ReadLine());
        int[] MainArray = new int[NNum];
        int MaxSum = 0;

        for (int i = 0; i < NNum; i++)
        {
            MainArray[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(MainArray, new Comparison<int>((i1, i2) => i2.CompareTo(i1)));

        for (int i = 0; i < KNum; i++)
        {
            MaxSum = MaxSum + MainArray[i];
        }
        Console.WriteLine(MaxSum);
    }
}
