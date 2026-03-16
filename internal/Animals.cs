class Animals
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
}

class Tiger : Animals
{
    public Tiger(string name, string sexe, float dayliFoodNeed, float buyPrice, float sellPrice)
        : base(name, "Tigre", "Carnivore", dayliFoodNeed, 0f, 100, 25f, sexe, 0f, buyPrice, sellPrice, 30f, 5f)
    {
    }
}

class Eagle : Animals
{
    public Eagle(string name, string sexe, float dayliFoodNeed, float buyPrice, float sellPrice)
        : base(name, "Aigle", "Carnivore", dayliFoodNeed ,0f, 100, 25f, sexe, 0f, buyPrice, sellPrice, 15f, 7f)
    {
    }
}

class Chicken : Animals
{
    public Chicken(string name, string sexe, float dayliFoodNeed, float buyPrice, float sellPrice)
        : base(name, "Poulet", "Végétalien", dayliFoodNeed, 0f, 100, 15f, sexe, 0f, buyPrice, sellPrice, 2f, 0.5f)
    {
    }
}