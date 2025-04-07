﻿using DZA.Cadastro.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DZA.Cadastro.Infra.Data.Mappings;

internal class PessoaMapp : IEntityTypeConfiguration<Pessoa>
{
    public void Configure(EntityTypeBuilder<Pessoa> builder)
    {
        builder.HasKey(k => k.Id);

        builder.Property(p => p.DepartamentoId)
            .IsRequired(false);

        builder.Property(p => p.Nome)
            .IsRequired()
            .HasColumnType("varchar(60)");

        builder.Property(p => p.SobreNome)
            .IsRequired()
            .HasColumnType("varchar(60)");

        builder.Property(p => p.Idade)
            .IsRequired()
            .HasColumnType("integer");

        builder.HasOne(o => o.Departamento)
            .WithMany(m => m.Pessoas)
            .HasForeignKey(fk => fk.DepartamentoId);

        builder.ToTable("Pessoas");
    }
}