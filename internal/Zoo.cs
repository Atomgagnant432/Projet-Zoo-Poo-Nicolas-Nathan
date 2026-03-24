
class Zoo
{
    public float _money;
    private float _childPrice;
    private float _adultPrice;
    public string ZooName { get; private set; }

    public List<Animals> _animals = new List<Animals>();
    public List<Enclosure> _enclosures = new List<Enclosure>();
    private Storage _storage;

    public void NextTurn(int numeroTour)
    {
        Month month = Month.GetCurrentMonth(numeroTour);

        foreach (Animals animal in _animals)
        {
            
            animal.AnimalsNextTurn(month);
            if (!CheckAnimalDeath(animal))
            {
                break;
            }
            
            FeedAnimals(animal,month);

            if (month.HighSeason)
            _money += 60 * animal.HighSaisonVisit;
            else
            _money += 60 * animal.DownSaisonVisit;

        }

        float PreMoney = _money;

        if (month.Number == 0 )
            {
                foreach (Animals animals in _animals)
                {
                    if (animals.Species == "Tigre")
                    {
                        _money += 43800f;
                    }else if (animals.Species == "Aigle")
                    {
                        _money += 2190f;
                    }
                }
            }
            if (_money != PreMoney)
            {
                Console.WriteLine("=================================================================================================");
                Console.WriteLine($"Vous vennez de gagnez {_money - PreMoney}€, grâce aux subvention annuelle des espèces protégée ! ");
                Console.WriteLine("=================================================================================================");
            } 
    }

    public Zoo(float money, float childPrice, float adultPrice, string zooName)
    {
        _money = money;
        _childPrice = childPrice;
        _adultPrice = adultPrice;
        ZooName = zooName;
        _storage = new Storage();
        _enclosures = new List<Enclosure>();
        _animals = new List<Animals>();
    }

    public void FeedAnimals(Animals animal, Month month)
    {
        float MonthFood = animal.DayliFoodNeed * month.NumberOfDays;
        if (animal.FoodType == "Carnivore")
        {
            if (MonthFood <= _storage._actualColdChamberStorage)
            {
                    animal.ActualHunger = 0f;
                    _storage._actualColdChamberStorage -= MonthFood;
                    Console.WriteLine($"\n{animal.Name} vient de manger {MonthFood}kg de viandes :");
                    ColdInfos();
            }else
            {
                Console.WriteLine($"Vous n'avez plus assez de nourriture pour nourrir {animal.Name}..");
            }
        }else if (animal.FoodType == "Végétalien")
        {
            if (MonthFood <= _storage._actualSiloStorage)
            {
                    animal.ActualHunger = 0f;
                    _storage._actualSiloStorage -= MonthFood;
                    Console.WriteLine($"\n{animal.Name} vient de manger {MonthFood}kg de graines :");
                    SiloInfos();
            }else
            {
                Console.WriteLine($"Vous n'avez plus assez de nourriture pour nourrir {animal.Name}...");
            }
        }
    }

    public bool CheckAnimalDeath(Animals animal)
    {
        if (!animal.Alive)
        {
            Console.WriteLine($"\nVotre animal {animal.Name} est malhereusement mort a {animal.Age} mois....");
            _animals.Remove(animal);
            return false;
        }else
        {
            return true;
        }
    }


    public void PrintZoo()
    {
        Console.WriteLine($"=================================================================================");
        Console.WriteLine($"        Votre Zoo {ZooName}, vient d'être créé avec un budget initial de {_money} € ! ");
        Console.WriteLine($"=================================================================================");
        Console.WriteLine($"\nTarif enfant : {_childPrice} €\nTarif adulte : {_adultPrice} €");
        
    }

    public void PrintZooInfos()
    {
        Console.WriteLine("\nVotre Zoo :\n");
        Console.WriteLine($"Nom: {ZooName}");
        Console.WriteLine($"Tarif enfant: {_childPrice}€");
        Console.WriteLine($"Tarif adulte: {_adultPrice}€");
        Console.WriteLine($"Budget: {_money}€");

    }
    
    public void PrintStorage()
    {
        _storage.PrintColdInfos();
        _storage.PrintSiloInfos();
    }
   public void ColdInfos()
    {
        _storage.PrintColdInfos();  
    }
    public void SiloInfos()
    {
        _storage.PrintSiloInfos();
    }

    public void FillSilo(float amount)
    {
        _storage.AddSeed(amount);
    }

    public void FillCold(float amount)
    {
        _storage.AddMeat(amount);
    }

    public bool Pay(float amount)
    {
        if (_money >= amount)
        {
            Console.Clear();
            _money -= amount;
            Console.WriteLine($"\nVous venez de dépenser {amount}€");
            Console.WriteLine($"Fonds restant {_money}€.\n");
            return true;
        }else
        {
            Console.WriteLine($"=====================================================");
            Console.WriteLine($"    Fonds insufissant ! Il ne vous reste que {_money}€.");
            Console.WriteLine($"=====================================================");
            return false;
        }
        
    }

    public void AddEnclosure(Enclosure enclosure)
    {
        _enclosures.Add(enclosure); 
    }

    public void AddAnimal(Animals animal)
    {
        _animals.Add(animal);
    }

    public void PrintZooAnimals()
    {
        for (int i = 0; i < _animals.Count;i++)
        {
             Console.Write($"{i+1}. ");
             PrintAnimals(_animals[i]);
        }
    }

    public void PrintZooEnclosure()
    {
        for (int i = 0; i < _enclosures.Count;i++)
        {
            Console.Write($"{i+1}. ");
            PrintEnclosures(_enclosures[i]);
        }
    }

    public void PrintAnimals(Animals animal)
    {
        Console.Write($"ID : {animal.ID}, nom : {animal.Name}, espece : {animal.Species}, sexe : {animal.Sexe}, age : {animal.Age} mois. Prix de vente {animal.SellPrice}€\n");
    }

    public void PrintEnclosures(Enclosure enclosure)
    {
        Console.Write($"ID : {enclosure.IdEnclosure}, type : {enclosure.EnclosureType}, resident actuel : {enclosure.CurrentResident}/{enclosure.MaxResident}. Prix de vente {enclosure.SellingPriceEnclosure}€\n");
    }

    public bool ChooseEnclosure(Animals NewAnimal)
    {
        Console.WriteLine("\n=== Dans quel Enclos voulez-vous mettre votre animal ? ===\n");
        PrintZooEnclosure();
        Console.WriteLine("Q. Retour");

        int IntChoice;

        while (true){

            string? choice = Console.ReadLine();

            if (choice == "Q")
            {
                Console.Clear();
                return false;  
            }
           
            if (!int.TryParse(choice, out IntChoice))
            {
                Console.WriteLine(" Veuillez entrer un NUMÉRO !");
                continue;
            }

            if (IntChoice <= 0 || IntChoice > _enclosures.Count)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"    Choix invalide ! L'enclos numéro {IntChoice} n'existe pas !");
                Console.WriteLine("         Choisissez un autre enclos.");
                Console.WriteLine("====================================================");
                continue;
            }
            
            break;
        }
        return _enclosures[IntChoice-1].AddAnimalToEnclosure(NewAnimal);

    }
    public Animals? ChooseAnimal()
    {
        PrintZooAnimals();
        Console.WriteLine("Q. Retour");

        int IntChoice;

        while (true){

            string? choice = Console.ReadLine();

           if (choice == "Q")
            {
                Console.Clear();
                return null;  
            }
            
            if (!int.TryParse(choice, out IntChoice))
            {
                Console.WriteLine(" Veuillez entrer un NUMÉRO !");
                continue;
            }

            if (IntChoice <= 0 || IntChoice > _animals.Count)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"    Choix invalide ! L'animal numéro {IntChoice} n'existe pas !");
                Console.WriteLine("             Choisissez un autre animal.");
                Console.WriteLine("====================================================");
                continue;
            }
            
            break;
        }
        return _animals[IntChoice-1];
    }


    public Enclosure? ChooseEnclosureToSell()
    {
        PrintZooEnclosure();
        Console.WriteLine("Q. Retour");
        
        int IntChoice;

        while (true){

            string? choice = Console.ReadLine();

            if (choice == "Q")
            {
                Console.Clear();
                return null;   
            }

            if (!int.TryParse(choice, out IntChoice))
            {
                Console.WriteLine(" Veuillez entrer un NUMÉRO !");
                continue;
            }

            if (IntChoice <= 0 || IntChoice > _enclosures.Count)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"    Choix invalide ! L'enclos numéro {IntChoice} n'existe pas !");
                Console.WriteLine("             Choisissez un autre enclos.");
                Console.WriteLine("====================================================");
                continue;
            }

            if (_enclosures[IntChoice-1]._residents.Count > 0)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"    Choix invalide ! L'enclos numéro {IntChoice} contient des animaux !");
                Console.WriteLine("             Vendez d'abords vos animaux.");
                Console.WriteLine("====================================================");
                continue;
            }
            
            break;
        }
        return _enclosures[IntChoice-1];
    }
    public bool CheckEnclosure(Animals animal)
    {
        bool finded = false;

        for (int i = 0; i < _enclosures.Count;i++)
        {
            if (_enclosures[i].AnimalType == animal.Species)
            {
                finded = true;
            }
        }
        return finded;
    }
}