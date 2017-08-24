using System;

class BinaryDecimal
{
    static void Main()
    {
        string input = Console.ReadLine();
        string subinput;
        int exp = 2;
        int result = 0;

        for (int i = 0; i < input.Length; i++)
        {
            subinput = input.Substring(input.Length - i - 1, 1);
            if (subinput == "1")
            {
                result += (int)Math.Pow(exp, i);
            }           
        }
        Console.WriteLine(result);
    }
}
