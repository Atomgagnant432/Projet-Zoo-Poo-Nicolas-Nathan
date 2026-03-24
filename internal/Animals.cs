public class Animals
{
    public int ID;
    public string? Name;
    public string? Species;
    public string? FoodType;
    public float DayliFoodNeed;
    public float ActualHunger;
    public int MaxHunger;
    public float LifeTime;
    public string? Sexe;
    public float Age;
    public float BuyPrice;
    public float SellPrice;
    public float HighSaisonVisit;
    public float DownSaisonVisit;
    public int HomeID;
    public bool Alive;


    public Animals(int id,string name, string species, string foodType, float dayliFoodNeed, float actualHunger, int maxHunger, float lifeTime, string sexe, float age, float buyPrice, float sellPrice, float highSaisonVisit, float downSaisonVisit, bool alive)
    {
        ID = id;
        Name = name;
        Species = species;
        FoodType = foodType;
        DayliFoodNeed = dayliFoodNeed;
        ActualHunger = actualHunger;
        MaxHunger = maxHunger;
        LifeTime = lifeTime;
        Sexe = sexe;
        Age = age;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
        HighSaisonVisit = highSaisonVisit;
        DownSaisonVisit = downSaisonVisit;
        Alive = alive;

    }

    public virtual string ChooseSexe()
    {
        return "";
    }

    public virtual void AnimalsNextTurn(Month month)
    {
        
    }
    public virtual void FeedAnimals(Zoo _zoo, Month month)
    {
    }
}




class Tiger : Animals
{
    public Tiger(int id, string name, string sexe, int age, float dayliFoodNeed, float buyPrice, float sellPrice)
        : base(id, name, "Tigre", "Carnivore", dayliFoodNeed, 0f, 100, 300f, sexe, age, buyPrice, sellPrice, 30f, 5f, true)
    {
    }

    public override string ChooseSexe()
    {
        Console.WriteLine("\nVoulez-vous un mâle (1) ou une femelle (2) ?");

        string? input = "";

        while (input != "1" && input != "2")
        {
            input = Console.ReadLine();

            if (input != "1" && input != "2")
            {
                Console.WriteLine("Choisissez 1 ou 2 !");
            }
        }

        if (input == "1")
        {
            DayliFoodNeed = 12f;
            return "mâle";
        }
        else
        {
            DayliFoodNeed = 10f;
            return "femelle";
        }
            
    }

    public override void AnimalsNextTurn(Month month)
    {
        Age += 1f;
        ActualHunger += 50f;        // l'animal a plus faim chaque tour

        if (ActualHunger >= MaxHunger)
        {
            ActualHunger = MaxHunger; // on plafonne à MaxHunger
            Alive = false;
        }
        if (Age > LifeTime)
        {
            Alive = false;
        }
        if (Age > 47 && Age < 168)
        {
            SellPrice = 60000f;

        }else if (Age > 167)
        {
            SellPrice = 10000f;
        }
    }

    public override void FeedAnimals(Zoo _zoo, Month month)
    {
        float MonthFood = DayliFoodNeed * month.NumberOfDays;
        if (FoodType == "Carnivore")
        {
            if (MonthFood <= _zoo._storage._actualColdChamberStorage)
            {
                    ActualHunger = 0f;
                    _zoo._storage._actualColdChamberStorage -= MonthFood;
                    Console.WriteLine($"\n{Name} vient de manger {MonthFood}kg de viandes :");
                    _zoo.ColdInfos();
            }else
            {
                Console.WriteLine($"Vous n'avez plus assez de nourriture pour nourrir {Name}..");
            }
        }
    }
}
class Eagle : Animals
{
    public Eagle(int id, string name, float dayliFoodNeed, string sexe, int age, float buyPrice, float sellPrice)
        : base(id, name, "Aigle", "Carnivore", dayliFoodNeed, 0f, 100, 300f, sexe, age, buyPrice, sellPrice, 15f, 7f, true)
    {
    }

    public override string ChooseSexe()
    {
        Console.WriteLine("\nVoulez-vous un mâle (1) ou une femelle (2) ?");

        string? input = "";

        while (input != "1" && input != "2")
        {
            input = Console.ReadLine();

            if (input != "1" && input != "2")
            {
                Console.WriteLine("Choisissez 1 ou 2 !");
            }
        }

        if (input == "1")
        {
            DayliFoodNeed = 0.25f;
            return "mâle";
        }
        else
        {
            DayliFoodNeed = 10f;
            return "femelle";
        }
    }

    public override void AnimalsNextTurn(Month month)
    {
        Age += 1f;
        ActualHunger += 100f;        // l'animal a plus faim chaque tour

        if (ActualHunger >= MaxHunger)
        {
            ActualHunger = MaxHunger; // on plafonne à MaxHunger
            Alive = false;
        }
        if (Age > LifeTime)
        {
            Alive = false;
        }
        if (Age > 47 && Age < 168)
        {
            SellPrice = 2000f;

        }else if (Age > 167)
        {
            SellPrice = 400f;
        }
    }

    public override void FeedAnimals(Zoo _zoo, Month month)
    {
        float MonthFood = DayliFoodNeed * month.NumberOfDays;
        if (FoodType == "Carnivore")
        {
            if (MonthFood <= _zoo._storage._actualColdChamberStorage)
            {
                    ActualHunger = 0f;
                    _zoo._storage._actualColdChamberStorage -= MonthFood;
                    Console.WriteLine($"\n{Name} vient de manger {MonthFood}kg de viandes :");
                    _zoo.ColdInfos();
            }else
            {
                Console.WriteLine($"Vous n'avez plus assez de nourriture pour nourrir {Name}..");
            }
        }
    }
}

class Chicken : Animals
{
    public Chicken(int id, string name, string sexe, float dayliFoodNeed, int age, float buyPrice, float sellPrice)
        : base(id, name, "Poulet", "Végétalien", dayliFoodNeed, 0f, 100, 180f, sexe, age, buyPrice, sellPrice, 2f, 0.5f, true)
    {
    }

    public override string ChooseSexe()
    {
        return "";
    }
    public override void AnimalsNextTurn(Month month)
    {
        Age += 1f;
        ActualHunger += 100f;        // l'animal a plus faim chaque tour

        if (ActualHunger >= MaxHunger)
        {
            ActualHunger = MaxHunger; // on plafonne à MaxHunger
            Alive = false;
        }
        if (Age > LifeTime)
        {
            Alive = false;
        }
        
    }

    public override void FeedAnimals(Zoo _zoo, Month month)
    {
        float MonthFood = DayliFoodNeed * month.NumberOfDays;
        if (FoodType == "Végétalien")
        {
            if (MonthFood <= _zoo._storage._actualSiloStorage)
            {
                    ActualHunger = 0f;
                    _zoo._storage._actualSiloStorage -= MonthFood;
                    Console.WriteLine($"\n{Name} vient de manger {MonthFood}kg de graines :");
                    _zoo.SiloInfos();
            }else
            {
                Console.WriteLine($"Vous n'avez plus assez de nourriture pour nourrir {Name}...");
            }
        }
    }
}