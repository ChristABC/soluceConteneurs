using System;
class MainProgram
{
    public static void Main()
    {
        // Création d'un tableau de taille 10. 
        int[] tab = new int[10];

        //Déclaration de la variable x comme une chaine de caractère
        string x;

        /*Association d'un nombre pour chaque emplacement qui compose
        notre tableau, en demandant une valeur à l'utilisateur*/
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine("Veuillez renseigner un entier. ");
            x = Console.ReadLine();
            tab[i] = Convert.ToInt32(x); 
        }
        
       //Affichage des valeurs du tableau

        Console.WriteLine("Voici les valeurs de otre tableau. ");
        
        for (int i = 0; i < tab.Length; i++)
        {
            Console.WriteLine(tab[i]);
        }
    }
}