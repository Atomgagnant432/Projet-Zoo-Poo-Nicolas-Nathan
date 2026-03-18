class Animals
{
    public string Name;
    public string species;
    public string FoodType;
    public float ActualHunger;
    public int MaxHunger;
    public float LifeTime;
    public string Sexe;
    public float BuyPrice;
    public float SellPrice;

    public void PasserUnTour()
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
    public Tiger(string name, string sexe)
    {
        Name = name;
        species = "Tiger";
        FoodType = "Carnivore";
        ActualHunger = 0f;
        MaxHunger = 100;
        LifeTime = 25f;
        Sexe = sexe;
        BuyPrice = 3000f;
        SellPrice = 1500f;
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
        BuyPrice = 1000f;
        SellPrice = 500f;
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
        BuyPrice = 20f;
        SellPrice = 10f;
    }
    
}

