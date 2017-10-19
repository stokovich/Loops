using System;
class FrequentNumber
{
    static void Main()
    {
        int Nnum = int.Parse(Console.ReadLine());
        int[] MyArray = new int[Nnum];
        int tempcounter = 0;
        int counter = 0;
        int number = 0;
        for (int i = 0; i < Nnum; i++)
        {
            MyArray[i] = int.Parse(Console.ReadLine());
        }

        for (int i = 0; i < Nnum; i++)
        {
            for (int j = 0; j < Nnum; j++)
            {
                if (MyArray[j] == MyArray[i])
                {
                    tempcounter++;
                }
            }
            if (tempcounter > counter)
            {
                number = MyArray[i];
                counter = tempcounter;
            }
            tempcounter = 0;
        }

        Console.WriteLine("{0} ({1} times)", number, counter);

    }
}
