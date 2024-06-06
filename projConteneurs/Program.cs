using System;
class MainProgram
{
    public static void Main()
    {
        int[] tab = new int[10];
        string x;
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine("Veuillez renseigner un entier. ");
            x = Console.ReadLine();
            tab[i] = Convert.ToInt32(x); 
        }
        
        Console.WriteLine("Voici les valeurs de otre tableau. ");

        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}