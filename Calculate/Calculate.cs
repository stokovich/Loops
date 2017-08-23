using System;

class Calculate
{
    static void Main()
    {
        short N = short.Parse(Console.ReadLine());
        double x = double.Parse(Console.ReadLine());
        double sum = 1;
        ulong factorielN = 1;

        for (int i = 1; i <= N; i++)
        {
            factorielN *= (ulong)i;
            sum += factorielN / Math.Pow(x, i);
        }

        Console.WriteLine("{0:f5}", sum);
    }
}
