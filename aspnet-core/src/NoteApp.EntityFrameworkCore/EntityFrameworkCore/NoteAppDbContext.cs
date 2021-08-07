using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using NoteApp.Authorization.Roles;
using NoteApp.Authorization.Users;
using NoteApp.MultiTenancy;

namespace NoteApp.EntityFrameworkCore
{
    public class NoteAppDbContext : AbpZeroDbContext<Tenant, Role, User, NoteAppDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public NoteAppDbContext(DbContextOptions<NoteAppDbContext> options)
            : base(options)
        {
        }
    }
}
