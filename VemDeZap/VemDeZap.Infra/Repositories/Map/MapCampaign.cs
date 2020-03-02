using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using VemDeZap.Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapCampaign : IEntityTypeConfiguration<Campaign>
    {
        public void Configure(EntityTypeBuilder<Campaign> builder)
        {
            builder.ToTable("Campanha");

            ////Propriedades
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150).IsRequired();

            //Foreikey
            builder.HasOne(x => x.User).WithMany().HasForeignKey("IdUsuario");
        }
    }
}
