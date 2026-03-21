class Program
{
    static string ChooseZooName()
    {
        Console.Clear();
        Console.WriteLine("===== Bienvenue dans ce super simulateur de Zoo ! =====\n");
        Console.Write("Choisissez le nom de votre Zoo : ");
        string? nomZoo = Console.ReadLine();
        Console.Clear();

        while (string.IsNullOrWhiteSpace(nomZoo))
        {
            Console.Write("Nom invalide. Re-tapez le nom de votre Zoo : ");
            nomZoo = Console.ReadLine();
        }
        return nomZoo;
    }



    static void Main(string[] args)
    {
        string zooName = ChooseZooName();
        Zoo zoo = new Zoo(80000,13,17,zooName);
        MenuManager menu = new MenuManager(zoo);
        zoo.PrintZoo();
        
        int numeroTour = 0;
        bool jeuEnCours = true;

        while (jeuEnCours)
        {
            // 1. Afficher le mois avant chaque menu
            Month moisActuel = Month.GetCurrentMonth(numeroTour);
            Console.WriteLine($"\nMois {moisActuel.Number}/12  |  Tour {numeroTour}");
            if (moisActuel.HighSeason)
                Console.WriteLine("Haute saison !");
            Console.WriteLine("─────────────────────────────");

            // 2. Ton menu existant s'exécute normalement
            menu.MainMenu();
            Console.WriteLine("\n1. Passer au tour suivant");
            Console.WriteLine("2. Quitter le jeu");
            Console.WriteLine("3. Retour au menu");
            string? choix = Console.ReadLine();

            bool inOption = true;
            while (inOption) {
            switch (choix)
            {
                case "1":
                zoo.PasserUnTour(numeroTour);  //
                inOption = false; 
                numeroTour++;
                break;
                case "2":
                    jeuEnCours = false;
                    break;
                case "3":
                inOption = false;
                break;
            }
            }
        }

        Console.WriteLine("Merci d'avoir joué !");
    }
    
}