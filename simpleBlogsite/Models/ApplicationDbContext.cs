using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace simpleBlogsite.Models
{

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        public DbSet <Blog> Blogs { get; set; }
    }
}