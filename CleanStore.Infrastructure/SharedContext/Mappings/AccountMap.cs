using CleanStore.Domain.AccountContext.Entities;
using CleanStore.Domain.AccountContext.ValueObjects;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanStore.Infrastructure.SharedContext.Mappings
{
    internal class AccountMap : IEntityTypeConfiguration<Account>
    {
        public void Configure(EntityTypeBuilder<Account> builder)
        {
            #region Table and Primary Keu

            builder
                .ToTable("Account)");

            builder
                .HasKey(x => x.Id)
                .HasName("PK_Account");

            #endregion

            #region Columns
            builder.OwnsOne(x => x.Email, email =>
            {
                email.HasIndex(e => e.Address)
                    .HasDatabaseName("IX_Account_Email")
                    .IsUnique();

                email.Property(x => x.Address)
                    .IsRequired()
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(Email.MaxLength)
                    .HasColumnName("Email");

                email.Property(x => x.Hash)
                    .IsRequired()
                    .HasColumnType("VARCHAR")
                    .HasMaxLength(255)
                    .HasColumnName("EmailHash");
            });
            #endregion
        }
    }
}
