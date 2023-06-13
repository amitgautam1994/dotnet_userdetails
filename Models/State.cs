namespace UserDetails.Models
{
    public class State
    {
        public int id { get; set; }

        public int CountryId { get; set; }
        public string Name { get; set; }

        public State()
        {
            if (Name == null) {
                Name = "";
            }
        }
    }
}