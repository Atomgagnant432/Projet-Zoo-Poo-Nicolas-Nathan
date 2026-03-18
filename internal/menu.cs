
class MenuManager 
{
    private Zoo _zoo;

    public MenuManager(Zoo zoo)
    {
        _zoo = zoo;
    }


    public void MainMenu() {
        bool InMenu = true;
        while (InMenu)
        {
            PrintMainMenu();
            string? action = Console.ReadLine();
            switch (action)
            {
                case "1" :
                    Console.Clear();
                    Console.WriteLine("\nVous entrez dans le stock\n");
                    StorageMenu();
                    break;
                case "2" :
                    Console.Clear();
                    Console.WriteLine("\nChoisissez un habitat\n");
                    HomeMenu();
                    break;
                case "3" :
                    Console.Clear();
                    _zoo.PrintZooInfos();
                    break;
                case "4" :
                    Console.Clear();
                    Console.WriteLine("");
                    ShopMenu();
                    break;
                case "5" :
                    Console.Clear();
                    InMenu = false;
                    break;
                    
            }
        }
        
    }   

    public void StorageMenu()
    {
        bool InStorage = true;
        while (InStorage)
        {
            PrintStorageMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    Console.WriteLine("\nVous entrez dans la chambre froide\n");
                    ColdMenu();
                    break;
                case "2" :
                    Console.Clear();
                    Console.WriteLine("\nVous entrez dans le silo\n");
                    SiloMenu();
                    break;
                case "3" :
                    Console.Clear();
                    InStorage = false;
                    break;
            }
        }
    
    }

public void SiloMenu()
    {
        bool InSilo = true;
        
        while (InSilo)
        {
            PrintSiloMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    _zoo.SiloInfos();
                    break;
                case "2" :
                    Console.Clear();
                    InSilo = false;
                    break;
            }
        }
    
    }

public void ColdMenu()
    {
        bool InCold = true;
        
        while (InCold)
        {
            PrintColdMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    _zoo.ColdInfos();
                    break;
                case "2" :
                    Console.Clear();
                    InCold = false;
                    break;
            }
        }
    
}


// FONCTION A REFAIRE POUR GERER UN PLUS GRAND NOMBRE D'HABITAT
    public void HomeMenu()
    {
        bool InHome = true;
        while (InHome)
        {
            PrintHomeMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    Console.WriteLine("\nVous entrez dans l'habitat 1\n");
                    break;
                case "2" :
                    Console.Clear();
                    Console.WriteLine("\nVous entrez dans l'habitat 2\n");
                    break;
                case "3" :
                    Console.Clear();
                    InHome = false;
                    break;
            }
        }
    
    }

public void ShopMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            PrintShopMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    Console.WriteLine("");
                    BuyMenu();
                    break;
                case "2" :
                    Console.Clear();
                    Console.WriteLine("");
                    break;
                case "3" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    
    }


public void BuyMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            PrintBuyMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    Console.WriteLine("====== Quelle quantité (kg) ? ======");
                    
                    float quantite = float.Parse(Console.ReadLine()!);

                    Meat meat = new Meat("Viande", quantite, 5);
                    meat.Buy(_zoo);

                    break;
                case "2" :
                    Console.Clear();
                    Console.WriteLine("====== Quelle quantité (kg) ? ======");

                    float quantity = float.Parse(Console.ReadLine()!);

                    Seed seed = new Seed ("Graine", quantity, 2.5f);
                    seed.Buy(_zoo);

                    break;
                case "3" :
                    Console.Clear();
                    BuyAnimalMenu();
                    break;
                case "4" :
                    Console.Clear();
                    break;
                case "5" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    
    }

    public void SellMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            PrintBuyMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    break;
                case "2" :
                    Console.Clear();
                    break;
                case "3" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    
    }

    public void BuyAnimalMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            PrintBuyAnimals();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    BuyTigerMenu();
                    break;
                case "2" :
                    Console.Clear();
                    BuyEagleMenu();
                    break;
                case "3" :
                    Console.Clear();
                    BuyChickenMenu();
                    break;
                case "4" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    }

    public void BuyTigerMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            PrintBuyTigre();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    Console.WriteLine("Nommez le tigre :");
                    string? name = Console.ReadLine();
                    Tiger tigre = new Tiger(name,"mâle",12,3000f,1500f);
                    break;
                case "2" :
                    Console.Clear();
                    Console.WriteLine("Nommez le tigre :");
                    string? name2 = Console.ReadLine();
                    Tiger tigre2 = new Tiger(name2,"mâle",12,3000f,1500f);
                    break;
                case "3" :
                    Console.Clear();
                    Console.WriteLine("Nommez le tigre :");
                    string? name3 = Console.ReadLine();
                    Tiger tigre3 = new Tiger(name3,"mâle",12,3000f,1500f);
                    break;
                case "4" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    }

    public void BuyEagleMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            PrintBuyEagle();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    break;
                case "2" :
                    Console.Clear();
                    break;
                case "3" :
                    Console.Clear();
                    break;
                case "4" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    }

    public void BuyChickenMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            PrintBuyChicken();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    break;
                case "2" :
                    Console.Clear();
                    break;
                case "3" :
                    Console.Clear();
                    break;
                case "4" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    }



















    public void PrintMainMenu() {
        Console.WriteLine("\n======= Choisissez une action =======\n");
        Console.WriteLine("1.Stockage");
        Console.WriteLine("2.Habitats");
        Console.WriteLine("3.Infos du zoo");
        Console.WriteLine("4.Magasin");
        Console.WriteLine("5.Quitter\n");
    }

    public void PrintStorageMenu()
    {
        Console.WriteLine("\n======= Stockage =======\n");
        Console.WriteLine("1.Chambre froide");
        Console.WriteLine("2.Silo");
        Console.WriteLine("3.Retour\n");
    }

    public void PrintHomeMenu()
    {
        Console.WriteLine("\n======= Choisissez un habitat =======\n");
        Console.WriteLine("1.Habitat 1");
        Console.WriteLine("2.Habitat 2");
        Console.WriteLine("3.Retour\n");
    }

    public void PrintSiloMenu()
    {
        Console.WriteLine("\n======= Silo =======\n");
        Console.WriteLine("1.Infos du Silo");
        Console.WriteLine("2.Retour\n");
    }

    public void PrintColdMenu()
    {
        Console.WriteLine("\n======= Chambre froide =======\n");
        Console.WriteLine("1.Infos de la chambre froide");
        Console.WriteLine("2.Retour\n");
    }

    public void PrintShopMenu()
    {
        Console.WriteLine("\n======= Magasin =======\n");
        Console.WriteLine("1.Acheter");
        Console.WriteLine("2.Vendre");
        Console.WriteLine("3.Retour");
    
    }

    public void PrintBuyMenu()
    {
        Console.WriteLine("\n======= Que voulez-vous acheter ? =======\n");
        Console.WriteLine("1.Viandes (5€/kg)");
        Console.WriteLine("2.Graines (2.5€/kg)");
        Console.WriteLine("3.Animaux");
        Console.WriteLine("4.Habitats");
        Console.WriteLine("5.Retour\n");
    }

    public void PrintSellMenu()
    {
        Console.WriteLine("\n======= Que voulez-vous vendre ? =======\n");
        Console.WriteLine("1.Animaux");
        Console.WriteLine("2.Habitats");
        Console.WriteLine("3.Retour\n");
    }

 public void PrintBuyAnimals()
    {
        Console.WriteLine("\n======= Quel Animal voulez-vous acheter ? =======\n");
        Console.WriteLine("1.Tigre");
        Console.WriteLine("2.Aigle");
        Console.WriteLine("3.Poule");
        Console.WriteLine("4.Retour\n");
    }

    public void PrintBuyTigre()
    {
        Console.WriteLine("\n======= Quel Tigre voulez-vous acheter ? =======\n");
        Console.WriteLine("1.Tigre bébé - 6 mois (3 000€)");
        Console.WriteLine("2.Tigre ado - 4 ans (120 000€)");
        Console.WriteLine("3.Tigre adulte - 14 ans (60 000€)");
        Console.WriteLine("4.Retour\n");
    }

    public void PrintBuyEagle()
    {
        Console.WriteLine("\n======= Quel Aigle voulez-vous acheter ? =======\n");
        Console.WriteLine("1.Aigle bébé - 6 mois (1 000€)");
        Console.WriteLine("2.Aigle ado - 4 ans (4 000€)");
        Console.WriteLine("3.Aigle adulte - 14 ans (2 000€)");
        Console.WriteLine("4.Retour\n");
    }

    public void PrintBuyChicken()
    {
        Console.WriteLine("\n======= Quel Poulet voulez-vous acheter ? =======\n");
        Console.WriteLine("1.Poule - 6 mois (20€)");
        Console.WriteLine("2.Coq - 6 mois (100€)");
        Console.WriteLine("3.Gyrophare - 6 mois (10 000 000 000€)");
        Console.WriteLine("4.Retour\n");
    }
}
