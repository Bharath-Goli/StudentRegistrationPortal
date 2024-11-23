namespace StudentRegistrationPortal.Models.Entities
{
    public class Student
    {
        public int Id { get; set; }
        public  required string Name { get; set; }

        public required string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Address { get; set; }

    }
}
