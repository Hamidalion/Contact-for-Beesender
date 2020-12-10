using ContactBeesender.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace ContactBeesender.DAL.Contexts
{
    public class ContactBeesenderContext : IdentityDbContext<User>
    {
        public ContactBeesenderContext(DbContextOptions<ContactBeesenderContext> options)
            : base(options)
        {
        }
    }
}
