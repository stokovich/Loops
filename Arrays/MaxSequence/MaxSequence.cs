using System;

class MaxSequence
{
    static void Main()
    {
        int Number = int.Parse(Console.ReadLine());
        int[] MyArray = new int[Number];
        int MaxCounter = 1;
        int PrevMaxCounter = 0;
        for (int i = 0; i < Number; i++)
        {
            MyArray[i] = int.Parse(Console.ReadLine());
        }
        for (int i = 1; i < Number; i++)
        {
            if (MyArray[i - 1] < (MyArray[i]))
            {
                MaxCounter = MaxCounter + 1;
            }
            else
            {
                MaxCounter = 1;
            }
            if (MaxCounter > PrevMaxCounter)
            {
                PrevMaxCounter = MaxCounter;
            }
        }
        Console.WriteLine(PrevMaxCounter);
    }
}
