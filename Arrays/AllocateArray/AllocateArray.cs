using System;
class AllocateArray
{
    static void Main()
    {
        int Number = int.Parse(Console.ReadLine());
        int[] Array = new int[Number];
        for (int i = 0; i < Array.Length; i++)
        {
            Array[i] = i * 5;
            Console.WriteLine(Array[i]);
        }

    }
}
