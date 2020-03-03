using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VemDeZap.Domain.Entities;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapSend : IEntityTypeConfiguration<Send>
    {
        public void Configure(EntityTypeBuilder<Send> builder)
        {


            builder.ToTable("Send");

            //Propriedades

            builder.Property(x => x.Id);
            builder.Property(x => x.Sent).IsRequired();
    

            //Foreikey
            builder.HasOne(x => x.Campaign).WithMany().HasForeignKey("IdCampaign");
            builder.HasOne(x => x.Group).WithMany().HasForeignKey("IdGroup");
            builder.HasOne(x => x.Contact).WithMany().HasForeignKey("IdContact");

        }

        
    }
}
