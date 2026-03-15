

class Storage
{
    private float _maxSiloCapacity;
    private float _actualSiloStorage;

    private float _maxColdChamberCapacity;
    private float _actualColdChamberStorage;


    public Storage (float maxSilo, float maxCold)
    {
        _maxSiloCapacity = maxSilo;
        _maxColdChamberCapacity = maxCold;

        _actualColdChamberStorage = 0;
        _actualSiloStorage = 0;
    
    }

    public void PrintSiloInfos()
    {
        Console.WriteLine($"Stockage du silo actuel : {_actualSiloStorage}/{_maxSiloCapacity}");

    }

    public void PrintColdInfos()
    {
        Console.WriteLine($"Stockage de la chambre froide actuel : {_actualColdChamberStorage}/{_maxColdChamberCapacity}");

    }

    public void AddSeed(float amount)
    {
        if (_actualSiloStorage + amount > _maxSiloCapacity)
        {
            float Waste = _actualSiloStorage + amount - _maxSiloCapacity;
            _actualSiloStorage = _maxSiloCapacity;
            Console.WriteLine($"Vous avez acheté {Waste} de trop, votre silo est plein, vous perdez donc {Waste} kg de graines...");
        }else
        {
            _actualSiloStorage += amount;   
            Console.WriteLine($"Stockage du silo actuel : {_actualSiloStorage}/{_maxSiloCapacity}\n");
        }
    }

    public void AddMeat(float amount)
    {
        if (_actualColdChamberStorage + amount > _maxColdChamberCapacity)
        {
            float Waste = _actualColdChamberStorage + amount - _maxColdChamberCapacity;
            _actualColdChamberStorage = _maxColdChamberCapacity;
            Console.WriteLine($"Vous avez acheté {Waste} de trop, votre chambre froide est pleine, vous perdez donc {Waste} kg de viandes...");
        }else
        {
            _actualColdChamberStorage += amount;   
            Console.WriteLine($"Stockage de la chambre froide actuel : {_actualColdChamberStorage}/{_maxColdChamberCapacity}");
        }
    }
}