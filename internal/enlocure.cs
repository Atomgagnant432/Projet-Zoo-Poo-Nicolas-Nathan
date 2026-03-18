// création de la class Enclosure 
public class Enclosure 
{ public int IdEnclosure;
  public string? EnclosureType;
  public int CurrentResident;
  public float ProbaSick;
  public int MaxResident;
  public bool Overcrowding;
  public int PurchasePriceEnclosure;
  public int SellingPriceEnclosure;

  public Enclosure(int idEnclosure, string enclosureType, int currentResident, float probaSick, int maxResident, bool overcrowding, int purchasePriceEnclosure, int sellingPriceEnclosure)
  {
    IdEnclosure = idEnclosure;
    EnclosureType = enclosureType;
    CurrentResident = currentResident;
    ProbaSick = probaSick;
    MaxResident = maxResident;
    Overcrowding = overcrowding;
    PurchasePriceEnclosure = purchasePriceEnclosure;
    SellingPriceEnclosure = sellingPriceEnclosure;
  }
}