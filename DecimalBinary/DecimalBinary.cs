using System;

class DecimalBinary
{
    static void Main()
    {
        int Number = int.Parse(Console.ReadLine());
        int divNumber = Number;
        string result = "";

        while (divNumber >= 1)
        {
            result = (divNumber % 2) + result;
            divNumber = divNumber / 2;
        }
        Console.WriteLine(result);
    }
}
