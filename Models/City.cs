namespace UserDetails.Models
{
    public class City
    {
        public int id { get; set; }

        public int StateId { get; set; }
        public string Name { get; set; }

        public City()
        {
            if (Name == null) {
                Name = "";
            }
        }
    }
}