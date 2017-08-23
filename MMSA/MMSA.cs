using System;

class MMSAofNumbers
{
    static void Main()
    {
        int N = int.Parse(Console.ReadLine());
        double min = 0;
        double max = 0;
        double avg = 0;
        double snum = 0;

        for (int i = 1; i <= N; i++)
        {
            double number = double.Parse(Console.ReadLine());
            snum += number;

            if (i == 1)
            {
                min = number;
                max = number;
            }
            else if (number <= min)
            {
                min = number;
            }
            else if (number >= max)
            {
                max = number;
            }
        }
        avg = snum / N;
        Console.WriteLine("min={0:0.00}", min);
        Console.WriteLine("max={0:0.00}", max);
        Console.WriteLine("sum={0:0.00}", snum);
        Console.WriteLine("avg={0:0.00}", avg);
    }
}