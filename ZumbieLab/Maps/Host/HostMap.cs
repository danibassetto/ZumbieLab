using ZumbieLab.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ZumbieLab.Map
{
    public class HostMap : IEntityTypeConfiguration<HostModel>
    {
        public void Configure(EntityTypeBuilder<HostModel> builder)
        {
            builder.ToTable("hospedeiro");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id");
            builder.Property(x => x.Id).IsRequired();
            builder.Property(x => x.Id).ValueGeneratedOnAdd();

            builder.Property(x => x.Age).HasColumnName("idade");
            builder.Property(x => x.Age).IsRequired();
            builder.Property(x => x.Age).ValueGeneratedNever();

            builder.Property(x => x.Gender).HasColumnName("sexo");
            builder.Property(x => x.Gender).IsRequired();
            builder.Property(x => x.Gender).ValueGeneratedNever();

            builder.Property(x => x.Weight).HasColumnName("peso");
            builder.Property(x => x.Weight).IsRequired();
            builder.Property(x => x.Weight).ValueGeneratedNever();

            builder.Property(x => x.Height).HasColumnName("altura");
            builder.Property(x => x.Height).IsRequired();
            builder.Property(x => x.Height).ValueGeneratedNever();

            builder.Property(x => x.BloodType).HasColumnName("tipo_sanguineo");
            builder.Property(x => x.BloodType).IsRequired();
            builder.Property(x => x.BloodType).ValueGeneratedNever();

            builder.Property(x => x.MusicalTaste).HasColumnName("gosto_musical");
            builder.Property(x => x.MusicalTaste).IsRequired();
            builder.Property(x => x.MusicalTaste).ValueGeneratedNever();

            builder.Property(x => x.SportPlayed).HasColumnName("esporte_praticado");
            builder.Property(x => x.SportPlayed).IsRequired();
            builder.Property(x => x.SportPlayed).ValueGeneratedNever();

            builder.Property(x => x.FavoriteGame).HasColumnName("jogo_preferido");
            builder.Property(x => x.FavoriteGame).IsRequired();
            builder.Property(x => x.FavoriteGame).ValueGeneratedNever();
        }
    }
}