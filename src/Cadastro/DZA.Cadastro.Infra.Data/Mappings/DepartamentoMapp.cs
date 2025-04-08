using DZA.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DZA.Cadastro.Infra.Data.Mappings;

internal class DepartamentoMapp : IEntityTypeConfiguration<Departamento>
{
    public void Configure(EntityTypeBuilder<Departamento> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("varchar(60)");

        builder.HasMany(m => m.Pessoas)
            .WithOne(o => o.Departamento)
            .HasForeignKey(fk => fk.DepartamentoId);

        builder.ToTable("Departamentos");
    }
}
