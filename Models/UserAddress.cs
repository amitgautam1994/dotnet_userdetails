namespace UserDetails.Models
{
    public class UserAddress
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int Type { get; set; }
        public string Address1 { get; set; }
        public string? Address2 { get; set; }
        public string? Address3 { get; set; }
        public string? NearBy { get; set; }
        public string? ProfileUrl { get; set; }
        public DateTime DateCreated {get; set;} = DateTime.Now;
        public int CityId { get; set; }


        public UserAddress()
        {
            if (Address1 == null) {
                Address1 = "";
            }
        }
    }
}