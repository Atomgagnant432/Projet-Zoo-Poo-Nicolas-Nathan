
class Zoo
{
    public float _money;
    private float _childPrice;
    private float _adultPrice;
    public string ZooName { get; private set; }

    public List<Enclosure>? _enclosures;
    public List<Animals>? _animals;
    private Storage _storage;
    public void NextTurn(int numeroTour)
    {
        Month month = Month.GetCurrentMonth(numeroTour);
        foreach (Animals animal in _animals)
        {
            if (month.HighSeason)
            _money += 60 * animal.HighSaisonVisit;
            else
            _money += 60 * animal.DownSaisonVisit;

        foreach (Enclosure enclosure in _enclosures)
        {
            animal.AnimalsNextTurn(month);
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

    public void PrintZoo()
    {
        Console.WriteLine($"\nVotre Zoo {ZooName}, vient d'être créé avec un budget initial de {_money} € ! ");
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
            Console.WriteLine($"Fonds insufissant ! Il ne vous reste que {_money}€.");
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
        Console.Write($"ID : {animal.ID}, nom : {animal.Name}, espece : {animal.Species}, sexe : {animal.Sexe}, age : {animal.Age} mois\n");
    }

    public void PrintEnclosures(Enclosure enclosure)
    {
        Console.Write($"ID : {enclosure.IdEnclosure}, type : {enclosure.EnclosureType}, resident actuel : {enclosure.CurrentResident}/{enclosure.MaxResident}\n");
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