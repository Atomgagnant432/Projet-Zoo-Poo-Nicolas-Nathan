// création de la class Enclosure 
public class Enclosure 
{ public int IdEnclosure;
  public string EnclosureType; 
  public string AnimalType;
  public float ProbaSick;
  public int MaxResident;
  public int PurchasePriceEnclosure;

  public int SellingPriceEnclosure;

  private List<Animals> _residents = new List<Animals>();

    public int CurrentResident => _residents.Count;
    public bool Overcrowding => _residents.Count > MaxResident;
    private Random _random = new Random();

  public Enclosure(int idEnclosure, string enclosureType, string animalType, float probaSick, int maxResident, int purchasePriceEnclosure, int sellingPriceEnclosure)
  {
    IdEnclosure = idEnclosure;
    EnclosureType = enclosureType;
    AnimalType = animalType;
    ProbaSick = probaSick;
    MaxResident = maxResident;
    PurchasePriceEnclosure = purchasePriceEnclosure;
    SellingPriceEnclosure = sellingPriceEnclosure;
    _residents = new List<Animals>();
  }

  public void AddAnimalToEnclosure(Animals animal)
    {
        // On vérifie que l'espèce correspond
        if (animal.Species != AnimalType)
        {
            Console.WriteLine($"Cet enclos est réservé aux {AnimalType} !");
            return;
        }

        if (_residents.Count >= MaxResident)
        {
            Console.WriteLine("Enclos plein !");
            return;
        }

        _residents.Add(animal);
        Console.WriteLine($"{animal.Name} ajouté à l'enclos {IdEnclosure}.");
    }
    
    public void NextTurn(Month month)
    {
        
        // 1. Chaque animal vieillit
        foreach (Animals animal in _residents)
        {
            animal.AnimalsNextTurn(month);
        }

        // 2. Gestion du surpeuplement
        if (Overcrowding)
        {
            Console.WriteLine($" Enclos {IdEnclosure} surpeuplé !");

            int tirage = _random.Next(0, 100); // nombre entre 0 et 99
            if (tirage < 50) // 50% de chance
            {
                // On choisit un résident au hasard
                int indexVictime = _random.Next(0, _residents.Count);
                Animals victime = _residents[indexVictime];

                Console.WriteLine($" {victime.Name} est mort à cause du surpeuplement !");
                _residents.RemoveAt(indexVictime);
            }
        }
    }
    public void PrintInfos()
    {
        Console.WriteLine($"Enclos {IdEnclosure} ({EnclosureType}) - {AnimalType}");
        Console.WriteLine($"  Résidents : {CurrentResident}/{MaxResident}");
        if (Overcrowding)
            Console.WriteLine("SURPEUPLÉ - risque de mort 50%");
        foreach (Animals animal in _residents)
        {
            Console.WriteLine($"    - {animal.Name} | Faim : {animal.ActualHunger}/{animal.MaxHunger}");
        }
    }
}

