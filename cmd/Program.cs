class Program
{
    static string ChooseZooName()
    {
        Console.Clear();
        
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
        PrintPrologue();
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
            Console.WriteLine("2. Retour au menu");
            Console.WriteLine("3. Quitter le jeu");
            
            
            string? choix = Console.ReadLine();

            bool inOption = true;
            while (inOption) {
                switch (choix)
                {
                    case "1":
                    zoo.NextTurn(numeroTour);  //
                    inOption = false; 
                    numeroTour++;
                    break;
                    case "2":
                        inOption = false;
                        break;
                    case "3":
                        jeuEnCours = false;
                        inOption = false;
                        break;
                }
            }
        }
        Console.WriteLine("\n=====================");
        Console.WriteLine(" Merci d'avoir joué !");
        Console.WriteLine("=====================\n");
    }
    
    static void PrintPrologue()
    {
        Console.Clear();
        Console.WriteLine("        ===== Bienvenue dans ce super simulateur de Zoo ! =====");
        Console.WriteLine("\n=========================================================================");
        Console.WriteLine("   Votre mission : accueillir, nourrir et prendre soin de vos animaux.");
        Console.WriteLine("         Développez vos installations et créer le zoo de vos rêves.");
        Console.WriteLine("   Gérez vos ressources avec attention pour faire prospérer votre parc.");
        Console.WriteLine("                 Bonne chance et amusez-vous bien !");
        Console.WriteLine("=========================================================================\n");

        Console.WriteLine("**Appuyez sur Entrée pour continuer.**");

        Console.ReadLine();


    }
}


