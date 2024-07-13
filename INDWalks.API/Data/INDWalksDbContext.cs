using INDWalks.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace INDWalks.API.Data
{
    public class INDWalksDbContext: DbContext
    {
        //constructor and passing DB options as we later on want to send our own connections through Program.cs
        //and passing it to the base class
        public INDWalksDbContext(DbContextOptions<INDWalksDbContext> dbContextOptions): base(dbContextOptions)
        {
            

        }
        //Create Db sets- A DB Set is a property of DB Context class that represents a collection of entities in the database
        //And we have 3 entities- Walk, Region, Difficulty

        public DbSet<Difficulty>  Difficulties { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<Walk> Walks { get; set; }
        public DbSet<Image> Images { get; set; }
        //seeding data- onModelCreating method which is an override method
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Seed Data for Difficulties
            // 3 types of difficulty- Easy, Medium, Hard

            var difficulties = new List<Difficulty>()
            {
                new Difficulty()
                {
                    Id = Guid.Parse("72d286ce-ab51-405a-8042-eefa52346af6"),
                    Name= "Easy"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("7e653e77-f773-4cc6-8c4c-00135a8d1f8a"),
                    Name = "Medium"
                },
                new Difficulty()
                {
                    Id = Guid.Parse("9358963d-1f5e-464a-9c9d-02954843c999"),
                    Name = "Hard"
                }

            };

            //seeding Difficulties to Database.
            modelBuilder.Entity<Difficulty>().HasData(difficulties);

            //Seed Data for Regions
            var regions = new List<Region>
            {
                new Region
                {
                    Id = Guid.Parse("4a5edd9a-1f83-4445-8e5b-8735bb5ae901"),
                    Name = "Durgapur",
                    Code = "DGP",
                    RegionImageUrl = "https://upload.wikimedia.org/wikipedia/commons/8/83/Durgapur_Aerial_view.jpg"
                },
                new Region
                {
                    Id = Guid.Parse("6884f7d7-ad1f-4101-8df3-7a6fa7387d81"),
                    Name = "Northland",
                    Code = "NTL",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("14ceba71-4b51-4777-9b17-46602cf66153"),
                    Name = "Bay Of Plenty",
                    Code = "BOP",
                    RegionImageUrl = null
                },
                new Region
                {
                    Id = Guid.Parse("cfa06ed2-bf65-4b65-93ed-c9d286ddb0de"),
                    Name = "Wellington",
                    Code = "WGN",
                    RegionImageUrl = "https://images.pexels.com/photos/4350631/pexels-photo-4350631.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("906cb139-415a-4bbb-a174-1a1faf9fb1f6"),
                    Name = "Nelson",
                    Code = "NSN",
                    RegionImageUrl = "https://images.pexels.com/photos/13918194/pexels-photo-13918194.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1"
                },
                new Region
                {
                    Id = Guid.Parse("f077a22e-4248-4bf6-b564-c7cf4e250263"),
                    Name = "Southland",
                    Code = "STL",
                    RegionImageUrl = null
                },

            };

            //Seed Regions Data to Database
            modelBuilder.Entity<Region>().HasData(regions);
        }
    }
}
