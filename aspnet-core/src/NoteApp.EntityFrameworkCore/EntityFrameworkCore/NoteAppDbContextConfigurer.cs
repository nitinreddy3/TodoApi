using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace NoteApp.EntityFrameworkCore
{
    public static class NoteAppDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<NoteAppDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<NoteAppDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
