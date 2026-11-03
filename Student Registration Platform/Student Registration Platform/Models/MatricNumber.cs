namespace StudentRegistrationApp.Models
{
    public class MatricNumber
    {
        public static string Generate()
        {
            string prefix = "ARM";
            string year = DateTime.Now.Year.ToString().Substring(2);
            string random = new Random().Next(1000, 9999).ToString();
            return $"{prefix}{year}/{random}";
        }
    }
}
