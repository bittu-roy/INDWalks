using System.ComponentModel.DataAnnotations.Schema;

namespace INDWalks.API.Models.Domain
{
    public class Image
    {
        public Guid Id { get; set; }

        //NotMapped- We use it when we don't want to add a class from the database
        [NotMapped]  
        public IFormFile File { get; set; }
        public string FileName { get; set; }
        public string? FileDescription { get; set; }
        public string FileExtension { get; set; }
        public long FileSizeInBytes { get; set; }
        public string FilePath { get; set; }

    }
}
