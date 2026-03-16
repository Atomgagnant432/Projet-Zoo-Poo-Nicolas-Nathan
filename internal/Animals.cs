class Animals
{
    public string? Name;
    public string? Species;
    public string? FoodType;
    public float ActualHunger;
    public int MaxHunger;
    public float LifeTime;
    public string? Sexe;
    public float Age;
    public float BuyPrice;
    public float SellPrice;

    public Animals(string name, string species, string foodType, float actualHunger, int maxHunger, float lifeTime, string sexe, float age, float buyPrice, float sellPrice)
    {
        Name = name;
        Species = species;
        FoodType = foodType;
        ActualHunger = actualHunger;
        MaxHunger = maxHunger;
        LifeTime = lifeTime;
        Sexe = sexe;
        Age = age;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
    }
}

class Tiger : Animals
{
    public Tiger(string name, string sexe, float buyPrice, float sellPrice)
        : base(name, "Tiger", "Carnivore", 0f, 100, 25f, sexe, 0f, buyPrice, sellPrice)
    {
    }
}

class Eagle : Animals
{
    public Eagle(string name, string sexe, float buyPrice, float sellPrice)
        : base(name, "Eagle", "Carnivore", 0f, 100, 25f, sexe, 0f, buyPrice, sellPrice)
    {
    }
}

class Chicken : Animals
{
    public Chicken(string name, string sexe, float buyPrice, float sellPrice)
        : base(name, "Chicken", "Omnivore", 0f, 100, 15f, sexe, 0f, buyPrice, sellPrice)
    {
    }
}