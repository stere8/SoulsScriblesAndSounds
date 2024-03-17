using Microsoft.EntityFrameworkCore;

namespace SoulsScribblesAndSounds.Models;

public class BlogDbContext : DbContext
{
    public DbSet<BlogPost> BlogPosts { get; set; }
    
    public BlogDbContext(DbContextOptions<BlogDbContext> options): 
        base(options){}
}