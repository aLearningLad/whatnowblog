using Microsoft.EntityFrameworkCore;
using whatnowblog.Models;

namespace whatnowblog.Data
{
    public class PostContext : DbContext
    {

        // constructor
        public PostContext(DbContextOptions<PostContext> options) : base(options) {
        
           // tables within the db, we call them dbsets 
           public DbSet<Post> AllPosts { get; set; }
        }

    }
}
