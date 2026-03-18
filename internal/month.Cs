class Month
{
    public int Number;
    public int NumberOfDays;  // était "NomberOfDay"
    public bool HighSeason;   // était "highSeason"

    public static Month GetCurrentMonth(int numeroTour)  // était "numerb", et manquait "public"
    {
        int monthOfYear = (numeroTour % 12) + 1;

        Month month = new Month();
        month.Number = monthOfYear;
        month.HighSeason = (monthOfYear >= 5 && monthOfYear <= 9); // "moisDeLAnnee" n'existait pas
        
        int[] days = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
        month.NumberOfDays = days[monthOfYear - 1];

        return month;
    }
}