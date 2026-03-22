
class Zoo
{
    private float _money;
    private float _childPrice;
    private float _adultPrice;
    public string ZooName { get; private set; }

    public List<Enclosure>? _enclosures;
    private List<Animals>? _animals;
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
            Console.WriteLine($"Vous venez de dépenser {amount}€");
            Console.WriteLine($"Fonds restant {_money}€.");
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
            PrintAnimals(_animals[i]);
        }
    }

    public void PrintZooEnclosure()
    {
        for (int i = 0; i < _enclosures.Count;i++)
        {
            PrintEnclosures(_enclosures[i]);
        }
    }

    public void PrintAnimals(Animals animal)
    {
        Console.WriteLine($"Nom : {animal.Name}, espece : {animal.Species}, sexe : {animal.Sexe}, age : {animal.Age} mois");
    }

    public void PrintEnclosures(Enclosure enclosure)
    {
        Console.WriteLine($"ID : {enclosure.IdEnclosure}, type : {enclosure.EnclosureType}, resident actuel : {enclosure.CurrentResident}/{enclosure.MaxResident}");
    }

    public void ChooseEnclosure(Animals NewAnimal)
    {
        Console.WriteLine("\n=== Dans quel Enclos voulez-vous mettre votre animal ? ===\n");
        PrintZooEnclosure();
        
        int IntChoice;

        while (true){

            string? choice = Console.ReadLine();

           
            if (!int.TryParse(choice, out IntChoice))
            {
                Console.WriteLine(" Veuillez entrer un NUMÉRO !");
                continue;
            }

            if (IntChoice <= 0 || IntChoice > _enclosures.Count)
            {
                Console.WriteLine("====================================================");
                Console.WriteLine($"    Choix invalide ! L'enclos {IntChoice} n'existe pas !");
                Console.WriteLine("         Choisissez un autre enclos.");
                Console.WriteLine("====================================================");
                continue;
            }
            
            break;
        }
        _enclosures[IntChoice-1].AddAnimalToEnclosure(NewAnimal);

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