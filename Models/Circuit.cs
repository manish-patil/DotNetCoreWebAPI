namespace F1API.Models
{
    public class Circuit
    {
        public int Id { get; set; }

        public string CircuitName { get; set; } = string.Empty;

        // Foreign Key
        public int LocationId { get; set; }

        public Location Location { get; set; } = null!;
    }
}
