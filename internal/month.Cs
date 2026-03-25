public class Month
{
    public int Number; // nombre du moi ( 1 = janvier)
    public int NumberOfDays;  // le nombre de jour dans le moi 
    public bool HighSeason;   // la saison haute ( plus de visiteurs)

    // Get the current month of the game 
    public static Month GetCurrentMonth(int numeroTour)  // voit dans quel moi le joueur est  
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