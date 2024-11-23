namespace StudentRegistrationPortal.Models
{
    public class AddStudentDto
    {
        public required string Name { get; set; }

        public required string Gender { get; set; }
        public DateTime? DateOfBirth { get; set; }

        public required string PhoneNumber { get; set; }

        public required string Address { get; set; }
    }
}
