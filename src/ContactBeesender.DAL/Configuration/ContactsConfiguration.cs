using ContactBeesender.Common.Constants;
using ContactBeesender.DAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactBeesender.DAL.Configuration
{
    public class ContactsConfiguration : IEntityTypeConfiguration<Contacts>
    {
        /// <inheritdoc/>
        public void Configure(EntityTypeBuilder<Contacts> builder)
        {
            builder = builder ?? throw new ArgumentNullException(nameof(builder));

            builder.ToTable(TablesConstants.Contacts, BranchConstants.Common)
                   .HasKey(contacts => contacts.Id);

            builder.Property(contacts => contacts.Name)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.SmallLenghtSimvbol);

            builder.Property(contacts => contacts.MobilePhone)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.ShotLenghtSimvbol);

            builder.Property(contacts => contacts.Dear)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.SmallLenghtSimvbol);

            builder.Property(contacts => contacts.JobTittle)
                   .IsRequired()
                   .HasMaxLength(ConfigurationConstants.SmallLenghtSimvbol);

            builder.Property(contacts => contacts.Birthdate)
                   .IsRequired();

            builder.HasOne(contacts => contacts.User)
                   .WithMany(identity => identity.Contacts)
                   .HasForeignKey(contacts => contacts.UserId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
