using ZumbieLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZumbieLab.Map
{
    public class SportMap : IEntityTypeConfiguration<SportModel>
    {
        public void Configure(EntityTypeBuilder<SportModel> builder)
        {
            builder.ToTable("esporte");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Description).HasColumnName("descricao");
            builder.Property(x => x.Description).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(100);
            builder.Property(x => x.Description).ValueGeneratedNever();
        }
    }
}