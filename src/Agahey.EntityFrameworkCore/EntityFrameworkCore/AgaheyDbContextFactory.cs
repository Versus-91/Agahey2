using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Agahey.Configuration;
using Agahey.Web;

namespace Agahey.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class AgaheyDbContextFactory : IDesignTimeDbContextFactory<AgaheyDbContext>
    {
        public AgaheyDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<AgaheyDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            AgaheyDbContextConfigurer.Configure(builder, configuration.GetConnectionString(AgaheyConsts.ConnectionStringName));

            return new AgaheyDbContext(builder.Options);
        }
    }
}
