class Item
{
    protected string _label;
    protected float _quantity;
    protected float _cost;
    protected float _sellPrice;

    public Item(string label, float quantity, float cost, float sellPrice)
    {
        _label = label;
        _quantity = quantity;
        _cost = cost * quantity;
        _sellPrice = sellPrice;
        
    }

    // Remove money from the player and adds an item to their inventory
    public virtual void Buy(Zoo zoo)
    {
        
    }

}


class Meat : Item
{
    public Meat(string label, float quantity, float cost)
        : base (label, quantity, cost, 0)
    {
        
    }

    public override void Buy(Zoo zoo)
    {
        if (zoo.Pay(_cost))
        {
            zoo.FillCold(_quantity);
        }else
        {
            Console.WriteLine("Transaction annulée.");
        }
    }
    
}

class Seed : Item    
{
    public Seed(string label, float quantity, float cost)
        : base (label, quantity, cost, 0)
    {
        
    }

    public override void Buy(Zoo zoo)
    {
        if (zoo.Pay(_cost))
        {
            zoo.FillSilo(_quantity);
        }else
        {
            Console.WriteLine("Transaction annulée.");
        }
    }
}

