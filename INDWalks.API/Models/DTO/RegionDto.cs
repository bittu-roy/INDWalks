namespace INDWalks.API.Models.DTO
{
    //exposing everything back to the client
    public class RegionDto
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }

        // Adding ? so that RegionImageUrl can have null values
        public string? RegionImageUrl { get; set; }
    }
}
