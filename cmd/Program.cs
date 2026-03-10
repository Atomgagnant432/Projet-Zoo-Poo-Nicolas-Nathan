using System;
class Program
{
    static string ChooseZooName()
    {
        Console.Clear();
        Console.Write("Choisis le nom de ton Zoo : ");
        string? nomZoo = Console.ReadLine();

        while (string.IsNullOrWhiteSpace(nomZoo))
        {
            Console.Write("Nom invalide. Re-tape le nom de ton Zoo : ");
            nomZoo = Console.ReadLine();
        }
        return nomZoo;
    }



    static void Main(string[] args)
    {
        
        string nomZoo = ChooseZooName();
        Zoo monPremierZoo = new Zoo(80000f, 13f, 17f, nomZoo);


        monPremierZoo.PrintZoo();
        monPremierZoo.PrintStorage();
        
        MenuManager Game = new MenuManager(monPremierZoo);
        Game.MainMenu();
    }
}