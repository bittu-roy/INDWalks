namespace INDWalks.API.Models.Domain
{
    public class Region
    {
        public Guid Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        
        // Adding ? so that RegionImageUrl can have null values
        public string? RegionImageUrl { get; set; }
    }
}
