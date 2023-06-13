namespace UserDetails.Models
{
    public class Country
    {
        public int id { get; set; }

        public string CountryCode { get; set; }
        public string Name { get; set; }

        public Country()
        {
            if (CountryCode == null) {
                CountryCode = "";
            }
            if (Name == null) {
                Name = "";
            }
        }
    }
}