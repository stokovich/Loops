using System;

class HexDecimal
{
    static void Main()
    {
        string HexNum = Console.ReadLine();
        long result = 0;
        string subinput;
        string[] hexarray = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "A", "B", "C", "D", "E", "F" };

        for (int i = 0; i < HexNum.Length; i++)
        {
            subinput = HexNum.Substring(HexNum.Length - i - 1, 1);
            result += Array.IndexOf(hexarray, subinput) * (long)Math.Pow(16,i);
        }
        Console.WriteLine(result);  
    }
}
