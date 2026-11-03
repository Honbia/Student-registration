namespace StudentRegistrationApp.Models
{
    public class Student
    {
        public required string Name { get; set; }
        public DateTime Dob { get; set; }
        public int Age => CalculateAge(Dob);
        public required string Department { get; set; } // Added 'required' modifier
        public required string MatricNumber { get; set; } // Added 'required' modifier

        public int  CalculateAge(DateTime dob)
        {
            var today = DateTime.Today;
            int age = today.Year - dob.Year;
            if (dob > today.AddYears(-age)) age--;
            return age;
        }
    }
}