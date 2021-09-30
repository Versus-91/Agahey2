using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Agahey.EntityFrameworkCore
{
    public static class AgaheyDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<AgaheyDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<AgaheyDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
