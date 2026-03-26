namespace DirectVisa.Models
{
    public class ServiceDetailsViewModel
    {
        public required string Key { get; init; }
        public required string Title { get; init; }
        public required string ImageUrl { get; init; }
        public required string Overview { get; init; }
        public required string[] Bullets { get; init; }
    }
}

