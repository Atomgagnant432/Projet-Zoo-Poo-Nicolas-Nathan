

public class Storage
{
    public float _actualSiloStorage;
    public float _actualColdChamberStorage;


    public Storage ()
    {
        _actualColdChamberStorage = 0;
        _actualSiloStorage = 0;
    
    }


    public void PrintSiloInfos()
    {
        Console.WriteLine($"Stockage du silo actuel : {_actualSiloStorage}kg");

    }

    public void PrintColdInfos()
    {
        Console.WriteLine($"Stockage de la chambre froide actuel : {_actualColdChamberStorage}kg");

    }

    // Add an amount of seed to the silo of the zoo and print the silo's info
    public void AddSeed(float amount)
    {
        _actualSiloStorage += amount;   
        PrintSiloInfos();
    }

    // Add an amount of meat to the cold chamber of the zoo and print the cold chamber's info
    public void AddMeat(float amount)
    {
        _actualColdChamberStorage += amount;   
        PrintColdInfos();
    }
}