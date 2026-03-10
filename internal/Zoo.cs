
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

    public void PrintZooInfos()
    {
        Console.WriteLine($"Votre Zoo {ZooName}, vient d'être créé avec un budget initial de {_money} € ! ");
        Console.WriteLine($"Tarif enfant : {_childPrice} €\nTarif adulte : {_adultPrice} €");
        
    }
    
    public void PrintStorage()
    {
        _storage.PrintStorageInfos();
    }
   
}