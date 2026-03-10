class Item
{
    protected string _label;
    protected float _quantity;
    protected float _cost;
    protected float _sellPrice;
    protected Zoo _zoo;

    public Item(string label, float quantity, float cost, float sellPrice)
    {
        _label = label;
        _quantity = quantity;
        _cost = cost * quantity;
        _sellPrice = sellPrice;
    }

    public virtual void Buy(Zoo zoo)
    {
        
    }

}


class Viande : Item
{
    public Viande(string label, float quantity, float cost)
        : base (label, quantity, cost)
    {
        
    }

    public override void Buy(Zoo zoo)
    {
        zoo.Pay(_cost);
        zoo.FillCold(_quantity);
    }
    
}

class Graine : Item    
{
    public Graine(string label, float quantity, float cost)
        : base (label, quantity, cost)
    {
        
    }

    public override void Buy(Zoo zoo)
    {
        zoo.Pay(_cost); 
        zoo.FillSilo(_quantity);
    }
}

class Animal : Item    
{
    public Animal(string label, float quantity, float cost, float sellPrice)
        : base (label, quantity, cost, sellPrice)
    {
        
    }

    public override void Buy(Zoo zoo)
    {
        zoo.Pay(_cost); 
        zoo.FillSilo(_quantity);
    }
}

class Habitat : Item    
{
    public Habitat(string label, float quantity, float cost, float sellPrice)
        : base (label, quantity, cost, sellPrice)
    {
        
    }

    public override void Buy(Zoo zoo)
    {
        zoo.Pay(_cost); 
        zoo.FillSilo(_quantity);
    }
}