using System;

class DeckOfCards
{
    static void Main()
    {
        string input = Console.ReadLine();
        string[] CardsArray = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        string[] TypeOfCards = { "of spades", "of clubs", "of hearts", "of diamonds" };
        int NumIndex = Array.IndexOf(CardsArray, input);

        for (int i = 0; i <= NumIndex; i++)
        {
            for (int j = 0; j < TypeOfCards.Length; j++)
            {
                if (j < TypeOfCards.Length - 1)
                {
                    Console.Write("{0} {1}, ", CardsArray[i], TypeOfCards[j]);
                }
                else
                {
                    Console.Write("{0} {1}", CardsArray[i], TypeOfCards[j]);
                }                      
            }
            Console.Write("\n");
        }
    }
}
