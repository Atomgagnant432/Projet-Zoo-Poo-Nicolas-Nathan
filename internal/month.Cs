using System.ComponentModel.DataAnnotations.Schema;

class Month{
    public int Number;
    public int NomberOfDay;
    public bool highSeason;
    static Month GetCurrentMonth(int numerb)
{
    int monthofyear = (numbTour % 12) + 1; // 1 à 12

    Month month = new Month();
    month.Number = monthofyear;

    month.HighSeason = (moisDeLAnnee >= 5 && moisDeLAnnee <= 9);


    int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    month.NumberOfDays = days[monthofyear - 1];

    return month;
}
} 