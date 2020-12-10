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
        /// Contacts entities.
        /// </summary>
        public DbSet<Contact> Contacts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder = modelBuilder ?? throw new ArgumentNullException(nameof(modelBuilder));

            modelBuilder.ApplyConfiguration(new ContactConfiguration());

            base.OnModelCreating(modelBuilder);
        }
    }
}
