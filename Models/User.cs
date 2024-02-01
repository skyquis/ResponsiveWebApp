namespace ResponsiveWebApp.Models
{
    public class User
    {
        public string Name { get; set; } = string.Empty;
        public int BirthYear { get; set; }

        public int AgeThisYear()
        {
            int currentYear = DateTime.Now.Year;
            return currentYear - BirthYear;
        }
    }
}
