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
        _cost = cost;
        _sellPrice = sellPrice;
    }

    public Buy(Zoo zoo)
    {
        
    }

}


class Viande : Item
{
    public Viande(string label, float quantity, float cost, float sellPrice)
        : base (label, quantity, cost, sellPrice );
    
}

class Graines : Item    
{
    public Graines(string label, float quantity, float cost, float sellPrice)
        : base (label, quantity, cost, sellPrice );
}
