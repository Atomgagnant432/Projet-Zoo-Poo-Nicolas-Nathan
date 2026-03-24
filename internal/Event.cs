public class Event
{
    private string Type;
    private float Proba;

    public Event(string type, float proba)
    {
        Type = type;
        Proba = proba;
    }

    public virtual void Consequence(Zoo zoo)
    {
        
    }

    public float GetProba()
    {
        return Proba;
    }

    public string GetEventType()
    {
        return Type;
    }

}

class Fire : Event
{
    public Fire() : base("Incendie", 0.01f) {}

    public override void Consequence(Zoo zoo)
    {
        if (zoo._enclosures.Count > 0)
        {
            var enclosure = zoo._enclosures[0];
            zoo._enclosures.Remove(enclosure);

            Console.WriteLine("Incendie ! Un enclos a été détruit !");
        }else
        {
            Console.WriteLine("Incendie évité (aucun enclos).");
        }
    }
}

class Robbery : Event
{
    public Robbery() : base("Vol", 0.01f) {}

    public override void Consequence(Zoo zoo)
    {
        if (zoo._animals.Count > 0)
        {
            var animal = zoo._animals[0];

            zoo._enclosures[animal.HomeID - 1]._residents.Remove(animal);
            zoo._animals.Remove(animal);

            Console.WriteLine("Vol ! Un animal a été volé !");
        } else
        {
            Console.WriteLine("Vol échoué (aucun animal).");
        }
    }
}

class Harmful : Event
{
    public Harmful(): base("Nuisible", 0.2f)
    {
    }

    public override void Consequence(Zoo zoo)
    {
        if (zoo._storage._actualSiloStorage > 0)
        {
            float amount = zoo._storage._actualSiloStorage * 0.10f;
            zoo._storage._actualSiloStorage -= amount;

            Console.WriteLine($"Nuisibles ! Perte de {amount} kg de graines !");
        } else
        {
            Console.WriteLine("Nuisibles sans effet (stock vide).");
        }
    }
}

class SpoiledMeat : Event
{
    public SpoiledMeat() : base("Viande avariée", 0.10f)
    {   
    }

    public override void Consequence(Zoo zoo)
    {
        if (zoo._storage._actualColdChamberStorage > 0)
        {
            float amount = zoo._storage._actualColdChamberStorage * 0.20f;
            zoo._storage._actualSiloStorage -= amount;

            Console.WriteLine($"Viande avariée ! Perte de {amount} kg de viande !");
        } else
        {
            Console.WriteLine("Aucun stock de viande.");
        }
    }
}