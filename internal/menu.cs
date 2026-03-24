
class MenuManager 
{
    private Zoo _zoo;

    public MenuManager(Zoo zoo)
    {
        _zoo = zoo;
    }

    public void PrintTitle(string title)
    {
        int width = title.Length + 6; // marge autour du texte
        string line = new string('=', width);

        int padding = (width - title.Length) / 2;
        string centeredTitle = new string(' ', padding) + title;

        Console.WriteLine("\n" + line);
        Console.WriteLine(centeredTitle);
        Console.WriteLine(line + "\n");
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
                    Console.WriteLine("\n***Vous entrez dans le stock***\n");
                    StorageMenu();
                    break;
                case "2" :
                    Console.Clear();
                    PrintTitle("Voici tous vos habitats");
                    _zoo.PrintZooEnclosure();
                    break;
                case "3" :
                    Console.Clear();
                    PrintTitle("Voici tous vos animaux");
                    _zoo.PrintZooAnimals();
                    break;
                case "4" :
                    Console.Clear();
                    _zoo.PrintZooInfos();
                    break;
                case "5" :
                    Console.Clear();
                    ShopMenu();
                    break;
                case "6" :
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
                    Console.WriteLine("\n***Vous entrez dans la chambre froide***\n");
                    ColdMenu();
                    break;
                case "2" :
                    Console.Clear();
                    Console.WriteLine("\n***Vous entrez dans le silo***\n");
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


public void ShopMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            Console.Clear();
            PrintShopMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    Console.Clear();
                    BuyMenu();
                    break;
                case "2" :
                    Console.Clear();
                    SellMenu();
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
                    PrintTitle("Quelle quantité (kg) ?");
                    
                    string? quantite =Console.ReadLine();
                    float Fquantite;

                    if (!float.TryParse(quantite, out Fquantite))
                    {
                        Console.WriteLine(" Veuillez entrer un NUMÉRO !");
                        continue;
                    }
                    Meat meat = new Meat("Viande", Fquantite, 5);
                    meat.Buy(_zoo);

                    break;
                case "2" :
                    Console.Clear();
                    PrintTitle("Quelle quantité (kg) ?");
                    
                    string? quantity =Console.ReadLine();
                    float Fquantity;

                    if (!float.TryParse(quantity, out Fquantity))
                    {
                        Console.WriteLine(" Veuillez entrer un NUMÉRO !");
                        continue;
                    }

                    Seed seed = new Seed ("Graine", Fquantity, 2.5f);
                    seed.Buy(_zoo);

                    break;
                case "3" :
                    Console.Clear();
                    BuyAnimalMenu();
                    break;
                case "4" :
                    Console.Clear();
                    BuyEnclosureMenu();
                    break;
                case "5" :
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
            Console.Clear();

            PrintSellMenu();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1" :
                    SellAnimals();
                    break;
                case "2" :
                    SellEnclosure();
                    break;
                case "3" :
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
                    BuyTigerMenu();
                    break;
                case "2" :
                    BuyEagleMenu();
                    break;
                case "3" :
                    BuyChickenMenu();
                    break;
                case "4" :
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
            Console.Clear();

            PrintBuyTigre();
            string? action = Console.ReadLine();

            float BuyPrice = 0f;
            float SellPrice = 0f;
            int Age = 0;

            switch (action)
            {
                case "1" :
                    BuyPrice = 3000f;
                    SellPrice = 1500f;
                    Age = 6;
                    break;
                case "2" :
                    BuyPrice = 120000f;
                    SellPrice = 60000f;
                    Age = 48;
                    break;
                case "3" :
                    BuyPrice = 60000f;
                    SellPrice = 10000f;
                    Age = 168;
                    break;
                case "4" :
                    InShop = false;
                    break;
            }
            if (Age != 0) {
            string? name = "";
            string? sexe = "";
            Tiger tigre = new Tiger(_zoo._animals.Count+1,name,sexe,Age,12,BuyPrice,SellPrice);
            Console.Clear();
            if (_zoo._enclosures.Count > 0 && _zoo.CheckEnclosure(tigre)) 
            {
                if  (_zoo.ChooseEnclosure(tigre)){
                    if (_zoo.Pay(tigre.BuyPrice))
                    {
                        _zoo.AddAnimal(tigre);
                        PrintTitle("Nommez votre tigre :");
                        name = Console.ReadLine();
                        sexe = tigre.ChooseSexe();
                        tigre.Name = name;
                        tigre.Sexe = sexe;
                        Console.Clear();
                        Console.WriteLine("Vous venez d'aquérir un nouvel animal !\n");
                        _zoo.PrintAnimals(tigre);
                        Console.ReadLine();

                    }
                }
            }
            else
            {
                PrintTitle("Veuillez d'abord acheter un enclos pour cet animal.");
            }
            break;
            }
        }
    }

   

    public void BuyEagleMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            Console.Clear();

            PrintBuyEagle();
            string? action = Console.ReadLine();

            float BuyPrice = 0f;
            float SellPrice = 0f;
            int Age = 0;

            switch (action)
            {
                case "1" :
                    BuyPrice = 1000f;
                    SellPrice = 500f;
                    Age = 6;
                    break;
                case "2" :
                    BuyPrice = 4000f;
                    SellPrice = 2000f;
                    Age = 48;
                    break;
                case "3" :
                    BuyPrice = 2000f;
                    SellPrice = 400f;
                    Age = 168;
                    break;
                case "4" :
                    InShop = false;
                    break;
            }
            if (Age != 0){
                string? name = "";
                string? sexe = "";
                Eagle aigle = new Eagle(_zoo._animals.Count+1,name,0.25f,sexe,Age,BuyPrice,SellPrice);
                Console.Clear();
                if (_zoo._enclosures.Count > 0 && _zoo.CheckEnclosure(aigle)) 
                {
                    if  (_zoo.ChooseEnclosure(aigle)){
                        if (_zoo.Pay(aigle.BuyPrice))
                        {
                            _zoo.AddAnimal(aigle);
                            PrintTitle("Nommez votre aigle :");
                            name = Console.ReadLine();
                            sexe = aigle.ChooseSexe();
                            aigle.Name = name;
                            aigle.Sexe = sexe;
                            Console.Clear();
                            Console.WriteLine("Vous venez d'aquérir un nouvel animal !\n");
                            _zoo.PrintAnimals(aigle);
                            Console.ReadLine();
                        }
                    }
                }
                else
                {
                    PrintTitle("Veuillez d'abord acheter un enclos pour cet animal.");
                }
                break;
            }
        }
    }

    public void BuyChickenMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            Console.Clear();

            PrintBuyChicken();
            string? action = Console.ReadLine();

            float BuyPrice = 0f;
            float SellPrice = 0f;
            int Age = 0;
            string Sexe = "";
            float DailyFood = 0f;

            switch (action)
            {
                case "1" : 
                    BuyPrice = 20f;
                    SellPrice = 10f;
                    Age = 6;
                    Sexe = "poule";
                    DailyFood = 0.15f;
                    break;
                case "2" :
                    BuyPrice = 100f;
                    SellPrice = 20f;
                    Age = 480;
                    Sexe = "coq";
                    DailyFood = 0.18f;
                    break;
                case "3" :
                    BuyPrice = 10000000000f;
                    SellPrice = 1000000000000000000000000000000f;
                    Age = 1;
                    break;
                case "4" :
                    InShop = false;
                    break;
            }
            if (Age != 0){
            string? name = "";
            Chicken poulet = new Chicken(_zoo._animals.Count+1, name,Sexe,DailyFood,Age,BuyPrice,SellPrice);
            Console.Clear();
            if (_zoo._enclosures.Count > 0 && _zoo.CheckEnclosure(poulet)) 
            {   
                if  (_zoo.ChooseEnclosure(poulet)){ 
                    if (_zoo.Pay(poulet.BuyPrice))
                    {
                        _zoo.AddAnimal(poulet);
                        
                        PrintTitle("Nommez votre poulet :");
                        name = Console.ReadLine();
                        poulet.Name = name;
                        Console.Clear();
                        Console.WriteLine("Vous venez d'aquérir un nouvel animal !\n");
                        _zoo.PrintAnimals(poulet);
                        Console.ReadLine();
                    }
                }
            }
            else
            {
                
                PrintTitle("Veuillez d'abord acheter un enclos pour cet animal.");
            }
            break;
            }
        }
    }

    public void BuyEnclosureMenu()
    {
        bool InShop = true;
        while (InShop)
        {
            Console.Clear();

            PrintBuyEnclosure();
            string? action = Console.ReadLine();

            switch (action)
            {
                case "1":
                    Enclosure TigerEnclos = new Enclosure(_zoo._enclosures.Count+1,"Enclos pour Tigre","Tigre",20f,2,2000,500);
                    if (_zoo.Pay(TigerEnclos.PurchasePriceEnclosure))
                        {
                            _zoo.AddEnclosure(TigerEnclos);   
                            Console.Clear();
                            Console.WriteLine("Vous venez d'aquérir un nouvel habitat !\n");
                        }
                        Console.ReadLine();
                        Console.Clear();
                    break;
                case "2":
                    Enclosure EagleEnclos = new Enclosure(_zoo._enclosures.Count+1,"Enclos pour Aigle","Aigle",10f,4,2000,500);
                    if (_zoo.Pay(EagleEnclos.PurchasePriceEnclosure))
                    {
                        _zoo.AddEnclosure(EagleEnclos);   
                        Console.Clear();
                        Console.WriteLine("Vous venez d'aquérir un nouvel habitat !\n");
                    }
                    
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "3" : 
                    Enclosure ChickenEnclos = new Enclosure(_zoo._enclosures.Count+1,"Poulailler","Poulet",5f,10,300,50);
                    if (_zoo.Pay(ChickenEnclos.PurchasePriceEnclosure))
                    {
                        _zoo.AddEnclosure(ChickenEnclos);   
                        Console.Clear();
                        Console.WriteLine("Vous venez d'aquérir un nouvel habitat !\n");
                    }
                    Console.ReadLine();
                    Console.Clear();
                    break;
                case "4" :
                    Console.Clear();
                    InShop = false;
                    break;
            }
        }
    }

    public void SellAnimals()
    {
        bool InShop = true;

        while (InShop)
        {
            if (_zoo._animals.Count > 0)
            {
                Console.Clear();
                PrintTitle("Quel animal voulez-vous vendre ?");

                Animals animal = _zoo.ChooseAnimal();
                _zoo._money += animal.SellPrice;
                
                Console.WriteLine($"l'animal {animal.Name} d'Id {animal.ID} a bien était vendu pour {animal.SellPrice}€");
                _zoo._enclosures[animal.HomeID-1]._residents.Remove(animal); 
                _zoo._animals.Remove(animal);
                
                Console.ReadLine();
                InShop = false;
                break;
            }else
            {
                Console.WriteLine("Vous n'avez aucun animal a vendre.");
                Console.ReadLine();
                InShop = false;
                break;
            }
        }
    }

    public void SellEnclosure()
    {
        bool InShop = true;

        while (InShop)
        {
            if (_zoo._enclosures.Count > 0)
            {
                Console.Clear();
                PrintTitle("Quel enclos voulez-vous vendre ?");

                Enclosure? enclos = _zoo.ChooseEnclosureToSell();

                if (enclos == null)
                {
                    Console.WriteLine("Vente annulée.");
                    Console.ReadLine();
                    break;
                }
                
                _zoo._money += enclos.SellingPriceEnclosure;
                
                Console.WriteLine($"l'{enclos.EnclosureType} d'Id {enclos.IdEnclosure} a bien était vendu pour {enclos.SellingPriceEnclosure}€");
                
                _zoo._enclosures.Remove(enclos);
                
                Console.ReadLine();
                InShop = false;
            }else
            {
                Console.WriteLine("Vous n'avez aucun enclos a vendre.");
                Console.ReadLine();
                InShop = false;
            }
        }
    }





        public void PrintMainMenu() {
    PrintTitle("Choisissez une action");

    Console.WriteLine("1. Stockage");
    Console.WriteLine("2. Habitats");
    Console.WriteLine("3. Animaux");
    Console.WriteLine("4. Infos du zoo");
    Console.WriteLine("5. Magasin");
    Console.WriteLine("6. Autre options\n");
}

public void PrintStorageMenu()
{
    PrintTitle("Stockage");

    Console.WriteLine("1. Chambre froide");
    Console.WriteLine("2. Silo");
    Console.WriteLine("3. Retour\n");
}

public void PrintSiloMenu()
{
    PrintTitle("Silo");

    Console.WriteLine("1. Infos du Silo");
    Console.WriteLine("2. Retour\n");
}

public void PrintColdMenu()
{
    PrintTitle("Chambre froide");

    Console.WriteLine("1. Infos de la chambre froide");
    Console.WriteLine("2. Retour\n");
}

public void PrintShopMenu()
{
    PrintTitle("Magasin");

    Console.WriteLine("1. Acheter");
    Console.WriteLine("2. Vendre");
    Console.WriteLine("3. Retour");
}

public void PrintBuyMenu()
{
    PrintTitle("Que voulez-vous acheter ?");

    Console.WriteLine("1. Viandes (5€/kg)");
    Console.WriteLine("2. Graines (2.5€/kg)");
    Console.WriteLine("3. Animaux");
    Console.WriteLine("4. Habitats");
    Console.WriteLine("5. Retour\n");
}

public void PrintSellMenu()
{
    PrintTitle("Que voulez-vous vendre ?");

    Console.WriteLine("1. Animaux");
    Console.WriteLine("2. Habitats");
    Console.WriteLine("3. Retour\n");
}

public void PrintBuyAnimals()
{
    PrintTitle("Quel Animal voulez-vous acheter ?");

    Console.WriteLine("1. Tigre");
    Console.WriteLine("2. Aigle");
    Console.WriteLine("3. Poule");
    Console.WriteLine("4. Retour\n");
}

public void PrintBuyTigre()
{
    PrintTitle("Quel Tigre voulez-vous acheter ?");

    Console.WriteLine("1. Tigre bébé - 6 mois (3 000€)");
    Console.WriteLine("2. Tigre ado - 4 ans (120 000€)");
    Console.WriteLine("3. Tigre adulte - 14 ans (60 000€)");
    Console.WriteLine("4. Retour\n");
}

public void PrintBuyEagle()
{
    PrintTitle("Quel Aigle voulez-vous acheter ?");

    Console.WriteLine("1. Aigle bébé - 6 mois (1 000€)");
    Console.WriteLine("2. Aigle ado - 4 ans (4 000€)");
    Console.WriteLine("3. Aigle adulte - 14 ans (2 000€)");
    Console.WriteLine("4. Retour\n");
}

public void PrintBuyChicken()
{
    PrintTitle("Quel Poulet voulez-vous acheter ?");

    Console.WriteLine("1. Poule - 6 mois (20€)");
    Console.WriteLine("2. Coq - 6 mois (100€)");
    Console.WriteLine("3. Gyrophare - 6 mois (10 000 000 000€)");
    Console.WriteLine("4. Retour\n");
}

public void PrintBuyEnclosure()
{
    PrintTitle("Quel enclos voulez-vous acheter ?");

    Console.WriteLine("1. Enclos pour Tigre - 2000€");
    Console.WriteLine("2. Enclos pour Aigle - 2000€");
    Console.WriteLine("3. Poulailler - 300€");
    Console.WriteLine("4. Retour\n");
}
}