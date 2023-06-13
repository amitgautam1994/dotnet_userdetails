namespace UserDetails.Models
{
    public class UserDetail
    {
        public int id { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? Email { get; set; }
        public string? Mobile { get; set; }
        public string? FatherName { get; set; }
        public string? MotherName { get; set; }

        public string? ProfileUrl { get; set; }
        public DateTime DateCreated {get; set;} = DateTime.Now;

        public UserDetail()
        {
            if (FirstName == null) {
                FirstName = "";
            }
            if (LastName == null) {
                LastName = "";
            }
        }
    }
}