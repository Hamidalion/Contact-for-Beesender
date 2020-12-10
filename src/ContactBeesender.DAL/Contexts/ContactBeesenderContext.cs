using ContactBeesender.DAL.Configuration;
using ContactBeesender.DAL.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace ContactBeesender.DAL.Contexts
{
    public class ContactBeesenderContext : IdentityDbContext<User>
    {
        public ContactBeesenderContext(DbContextOptions<ContactBeesenderContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Ingridients entities.
        /// </summary>
        public DbSet<Contacts> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new ContactsConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
