
class Zoo
{
    private float _money;
    private float _childPrice;
    private float _adultPrice;
    public string ZooName { get; private set; }

    private Storage _storage;
 
    public Zoo(float money, float childPrice, float adultPrice, string zooName)
    {
        _money = money;
        _childPrice = childPrice;
        _adultPrice = adultPrice;
        ZooName = zooName;
        _storage = new Storage (200f,100f);
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


}