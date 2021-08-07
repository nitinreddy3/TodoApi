using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using NoteApp.Configuration;
using NoteApp.Web;

namespace NoteApp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class NoteAppDbContextFactory : IDesignTimeDbContextFactory<NoteAppDbContext>
    {
        public NoteAppDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<NoteAppDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            NoteAppDbContextConfigurer.Configure(builder, configuration.GetConnectionString(NoteAppConsts.ConnectionStringName));

            return new NoteAppDbContext(builder.Options);
        }
    }
}
