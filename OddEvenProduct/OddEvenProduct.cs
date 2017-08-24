using System;

class OddEvenProduct
{
    static void Main()
    {
        int NumOfelements = int.Parse(Console.ReadLine());
        string Elements = Console.ReadLine();
        string[] ElementsArray = Elements.Split(' ');
        long OddProduct = 1;
        long EvenProduct = 1;

        for (int i = 0; i < ElementsArray.Length; i += 2)
        {
            OddProduct *= int.Parse(ElementsArray[i]);
        }
        for (int i = 1; i < ElementsArray.Length; i += 2)
        {
            EvenProduct *= int.Parse(ElementsArray[i]);
        }

        if (OddProduct == EvenProduct)
        {
            Console.WriteLine("yes {0}", OddProduct);
        }
        else
        {
            Console.WriteLine("no {0} {1}", OddProduct, EvenProduct);
        }
    }
}
