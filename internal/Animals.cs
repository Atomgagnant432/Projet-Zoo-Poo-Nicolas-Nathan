class Animals
{
    public string Name;
    public string species;
    public string FoodType;
    public float ActualHunger;
    public int MaxHunger;
    public float LifeTime;
    public string Sexe;
    public float Age;
    public float BuyPrice;
    public float SellPrice;
    
}


class Tiger : Animals
{
    public Tiger(string name, string sexe)
    {
        Name = name;
        species = "Tiger";
        FoodType = "Carnivore";
        ActualHunger = 0f;
        MaxHunger = 100;
        LifeTime = 25f;
        Sexe = sexe;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
    }
}


class Eagle : Animals
{
     public Eagle(string name, string sexe)
    {
        Name = name;
        species = "Eagle";
        FoodType = "Carnivore";
        ActualHunger = 0f;
        MaxHunger = 100;
        LifeTime = 25f;
        Sexe = sexe;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
    }
    
}

class Chicken : Animals
{ 
    public Chicken(string name, string sexe)
    {
        Name = name;
        species = "Chicken";
        FoodType = "omnivorous";
        ActualHunger = 0f;
        MaxHunger = 100;
        LifeTime = 15f;
        Sexe = sexe;
        BuyPrice = buyPrice;
        SellPrice = sellPrice;
    }
    
}

