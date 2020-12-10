using ContactBeesender.Common.Constants;
using ContactBeesender.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBeesender.DAL.Configuration
{
    public class ContactConfiguration : IEntityTypeConfiguration<Contact>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TablesConstants.Contacts, BranchConstants.Common)
                   .HasKey(contact => contact.Id);

            builder.Property(contact => contact.Name)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.SmallLenghtSimvbol);

            builder.Property(contact => contact.MobilePhone)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.ShotLenghtSimvbol);

            builder.Property(contact => contact.Dear)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.SmallLenghtSimvbol);

            builder.Property(contact => contact.JobTittle)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.SmallLenghtSimvbol);

            builder.HasOne(contact => contact.User)
                   .WithMany(identity => identity.Contacts)
                   .HasForeignKey(contact => contact.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
