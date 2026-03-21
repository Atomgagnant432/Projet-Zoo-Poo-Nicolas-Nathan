public class Animals
{
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


    public Animals(string name, string species, string foodType, float dayliFoodNeed, float actualHunger, int maxHunger, float lifeTime, string sexe, float age, float buyPrice, float sellPrice, float highSaisonVisit, float downSaisonVisit)
    {
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
        
    }

    public virtual string ChooseSexe()
    {
        return "";
    }
    
    public virtual void PasserUnTour()
    {
        ActualHunger += 10f;        // l'animal a plus faim chaque tour

        if (ActualHunger >= MaxHunger)
        {
            LifeTime -= 1f;         // il vieillit/dépérit s'il est affamé
            ActualHunger = MaxHunger; // on plafonne à MaxHunger
        }
    }
}


    

class Tiger : Animals
{
    public Tiger(string name, string sexe, int age,float dayliFoodNeed, float buyPrice, float sellPrice)
        : base(name, "Tigre", "Carnivore", dayliFoodNeed, 0f, 100, 25f, sexe, age, buyPrice, sellPrice, 30f, 5f)
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
            return "mâle";
        else
            return "femelle";
    }  
}

class Eagle : Animals
{
    public Eagle(string name, float dayliFoodNeed, string sexe, int age, float buyPrice, float sellPrice)
        : base(name, "Aigle", "Carnivore", dayliFoodNeed ,0f, 100, 25f, sexe, age, buyPrice, sellPrice, 15f, 7f)
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
            return "mâle";
        else
            return "femelle";
        }
    }


    
class Chicken : Animals
{
    public Chicken(string name, string sexe, float dayliFoodNeed, int age, float buyPrice, float sellPrice)
        : base(name, "Poulet", "Végétalien", dayliFoodNeed, 0f, 100, 15f, sexe, age, buyPrice, sellPrice, 2f, 0.5f)
    {
    }

    public override string ChooseSexe()
    {
        return "";
    }
}