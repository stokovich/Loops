using System;

class SelectionSort
{
    static void Main()
    {
        int NNum = 4; // int.Parse(Console.ReadLine());
        int[] MyArray = new int[] { 2, 1, 4, 3 }; // new int[NNum];
        int TempMin;

        // for (int i = 0; i < NNum; i++)
        // {
        //     MyArray[i] = int.Parse(Console.ReadLine());
        // }

        for (int i = 0; i < NNum; i++)
        {
            for (int j = (i + 1); j < (NNum); j++)
            {
                if (MyArray[i] > MyArray[j])
                {
                    TempMin = MyArray[j];
                    MyArray[j] = MyArray[i];
                    MyArray[i] = TempMin;
                }
            }
        }

        for (int i = 0; i < NNum; i++)
        {
            Console.WriteLine(MyArray[i]);
        }
    }
}
