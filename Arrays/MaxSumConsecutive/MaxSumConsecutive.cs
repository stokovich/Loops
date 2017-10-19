using System;

class MaxSumConsecutive
{
    static void Main()
    {
        int Nnum = int.Parse(Console.ReadLine());
        int[] MyArray = new int[Nnum];

        for (int i = 0; i < Nnum; i++)
        {
            MyArray[i] = int.Parse(Console.ReadLine());
        }

        int start = 0;
        int end = 0;
        int tempstart = 0;
        int sum = 0;
        int tempresult = 0;

        for (int i = 0; i < MyArray.Length; i++)
        {
            tempresult += MyArray[i];
            if (tempresult > sum)
            {
                sum = tempresult;
                start = tempstart;
                end = i;
            }
            if (tempresult < 0)
            {
                tempresult = 0;
                tempstart = i + 1;
            }
        }
        Console.WriteLine(sum);
    }
}
