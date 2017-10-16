using System;
class CompareCharArrays
{
    static void Main()
    {
        string Array1 = Console.ReadLine();
        string Array2 = Console.ReadLine();
        string Result = "=";

        if (Array1.Length > Array2.Length)
        {
            for (int i = 0; i < Array2.Length; i++)
            {
                if (Array1[i] > Array2[i])
                {
                    Result = ">";
                    break;
                }
                else if (Array1[i] < Array2[i])
                {
                    Result = "<";
                    break;
                }
                else
                {
                    Result = ">";
                }
            }
        }
        else if (Array1.Length < Array2.Length)
        {
            for (int i = 0; i < Array1.Length; i++)
            {
                if (Array1[i] > Array2[i])
                {
                    Result = ">";
                    break;
                }
                else if (Array1[i] < Array2[i])
                {
                    Result = "<";
                    break;
                }
                else
                {
                    Result = "<";
                }
            }
        }
        else
        {
            for (int i = 0; i < Array2.Length; i++)
            {
                if (Array1[i] > Array2[i])
                {
                    Result = ">";
                    break;
                }
                else if (Array1[i] < Array2[i])
                {
                    Result = "<";
                    break;
                }
                else
                {
                    Result = "=";
                }
            }
        }
        Console.WriteLine(Result);
    }
}