using Foody.Entities.Concrete;
using Microsoft.EntityFrameworkCore;

namespace Foody.DataAccess.Context
{
    public class FoodyContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5432; Database=FoodyDb; User ID=postgres; Password=Burcum2855;");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<About> Abouts { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Category>  Categories { get; set; }
        public DbSet<Feature> Features { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Slider> Sliders { get; set; }
        public DbSet<SocialMedia> SocialMedias { get; set; }
    }
}