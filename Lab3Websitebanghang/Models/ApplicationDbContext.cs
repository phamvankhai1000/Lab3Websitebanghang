namespace Lab3Websitebanghang.Models
{
    using Microsoft.EntityFrameworkCore;
    public class ApplicationDbContext(DbContextOptions<ApplicationDbContext>
        options) : DbContext(options)
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<ProductImage> ProductImages { get; set; }
    }
}
