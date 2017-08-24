using System;

class GCD
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] IntArray = input.Split(' ');
        int NumA = Math.Abs(int.Parse(IntArray[0]));
        int NumB = Math.Abs(int.Parse(IntArray[1]));
        int NumAB = 0;
        int tNumB = 0;

        if (NumA < NumB)
        {
            NumAB = NumA;
            NumA = NumB;
            NumB = NumAB;
        }

        if (NumA % NumB == 0)
        {
            NumA = NumB;
        }
        else
        {
            while (NumA != 0 && NumB != 0)
            {
                tNumB = NumB;
                NumB = NumA % tNumB;
                NumA = tNumB;
            }
        }
        
        Console.WriteLine(NumA);
    }
}
