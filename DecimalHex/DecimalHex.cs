using System;

class DecimalHex
{
    static void Main()
    {
        long number = long.Parse(Console.ReadLine());
        long divnumber = number;
        string result = "";
        string[] hexarray = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        while (divnumber > 0)
        {
            result = hexarray[(divnumber % 16)] + result;
            divnumber = divnumber / 16;
        }
        Console.WriteLine(result);
    }
}
