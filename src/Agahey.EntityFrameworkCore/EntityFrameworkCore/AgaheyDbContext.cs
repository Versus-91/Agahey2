using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Agahey.Authorization.Roles;
using Agahey.Authorization.Users;
using Agahey.MultiTenancy;
using Agahey.Pages;
using Agahey.Categories;
using Agahey.SubCategories;
using Agahey.Tags;

namespace Agahey.EntityFrameworkCore
{
    public class AgaheyDbContext : AbpZeroDbContext<Tenant, Role, User, AgaheyDbContext>
    {
        /* Define a DbSet for each entity of the application */

        public DbSet<Page> Pages { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<SubCategory> SubCategories { get; set; }

        public DbSet<Tag> Tags { get; set; }



        public AgaheyDbContext(DbContextOptions<AgaheyDbContext> options)
            : base(options)
        {
        }
    }
}
