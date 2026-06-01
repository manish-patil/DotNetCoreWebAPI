 namespace F1API.Models
{
    public class Race
    {
        public int Season { get; set; }

        public int Round { get; set; }

        public string RaceName { get; set; } = string.Empty;

        public DateTime RaceDate { get; set; }

        public Circuit Circuit { get; set; }
    }

    public class Circuit 
    {
        public string Id { get; set; } = string.Empty;

        public string CircuitName { get; set; } = string.Empty;

        public Location Location { get; set; }
    }

    public class Location
    {
        public string Id { get; set; } = string.Empty;

        public string City { get; set; } = string.Empty;

        public string Country { get; set; } = string.Empty;
    }
}
