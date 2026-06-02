namespace F1API.DTOs
{
    public class CreateRaceRequest
    {
        public int Season { get; set; }

        public int Round { get; set; }

        public string RaceName { get; set; } = string.Empty;

        public DateTime RaceDate { get; set; }

        public int CircuitId { get; set; }
    }
}
