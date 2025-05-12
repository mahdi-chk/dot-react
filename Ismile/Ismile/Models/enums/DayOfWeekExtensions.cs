namespace Ismile.Models.enums
{
    public static class DayOfWeekExtensions
    {
        public static string ToFrench(this DayOfWeek day)
        {
            return day switch
            {
                DayOfWeek.Monday => "Lundi",
                DayOfWeek.Tuesday => "Mardi",
                DayOfWeek.Wednesday => "Mercredi",
                DayOfWeek.Thursday => "Jeudi",
                DayOfWeek.Friday => "Vendredi",
                DayOfWeek.Saturday => "Samedi",
                DayOfWeek.Sunday => "Dimanche",
                _ => throw new ArgumentException("Jour invalide")
            };
        }
    }
}
