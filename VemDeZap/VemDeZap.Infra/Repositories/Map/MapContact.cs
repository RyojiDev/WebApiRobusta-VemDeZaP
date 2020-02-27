using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entities;

namespace VemDeZap.Infra.Repositories.Map
{
    class MapContact : IEntityTypeConfiguration<Contact>
    {
        public void Configure(EntityTypeBuilder<Contact> builder)
        {
            builder.ToTable("Contact");
            // Propridades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired();
            builder.Property(x => x.Phone).HasMaxLength(50).IsRequired();
            builder.Property(x => x.Niche).IsRequired();

            //Foreig Key

            builder.HasOne(x => x.User).WithMany().HasForeignKey("IdUser");
        }
    }
}
