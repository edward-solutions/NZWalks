using Microsoft.EntityFrameworkCore;
using NZWalks.API.Models.Domain;

namespace NZWalks.API.Data
{
    public class NZWalksDbContext : DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            
        }

        public DbSet<Difficulty> Difficulties{ get; set; }
        public DbSet<Region> Regions{ get; set; }
        public DbSet<Walk> Walks{ get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Region>().HasData(
                new Region
                {
                    Id = Guid.Parse("11111111-1111-1111-1111-111111111111"),
                    Code = "AKL",
                    Name = "Auckland Region",
                    RegionImageUrl = "https://images.pexels.com/photos/1054218/pexels-photo-1054218.jpeg"
                },
                new Region
                {
                    Id = Guid.Parse("22222222-2222-2222-2222-222222222222"),
                    Code = "WGN",
                    Name = "Wellington Region",
                    RegionImageUrl = "https://images.pexels.com/photos/1032650/pexels-photo-1032650.jpeg"
                },
                new Region
                {
                    Id = Guid.Parse("33333333-3333-3333-3333-333333333333"),
                    Code = "BOP",
                    Name = "Bay of Plenty",
                    RegionImageUrl = "https://images.pexels.com/photos/325185/pexels-photo-325185.jpeg"
                },
                new Region
                {
                    Id = Guid.Parse("44444444-4444-4444-4444-444444444444"),
                    Code = "NSN",
                    Name = "Nelson Region",
                    RegionImageUrl = "https://images.pexels.com/photos/46274/pexels-photo-46274.jpeg"
                },
                new Region
                {
                    Id = Guid.Parse("55555555-5555-5555-5555-555555555555"),
                    Code = "STL",
                    Name = "Southland Region",
                    RegionImageUrl = "https://images.pexels.com/photos/414171/pexels-photo-414171.jpeg"
                }
            );
        }
    }
}
