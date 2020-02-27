using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VemDeZap.Domain.Entities;

namespace VemDeZap.Infra.Repositories.Map
{
    public class MapGroup : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
           

            builder.ToTable("Group");

            //Propriedades

            builder.Property(x => x.Id);
            builder.Property(x => x.Name).HasMaxLength(150);
            builder.Property(x => x.Niche).IsRequired();

            //Foreikey
            builder.HasOne(x => x.User).WithMany().HasForeignKey("IdUser");

        }
    }
}
