using System;
using Alura.Filmes.App.Negocio;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Alura.Filmes.App.Dados
{
    public class AtorConfiguration : IEntityTypeConfiguration<Ator>
    {
        public void Configure(EntityTypeBuilder<Ator> builder)
        {
            builder
                .ToTable("actor");

            builder
                .Property(a => a.Id)
                .HasColumnName("actor_id");

            builder
                .Property(a => a.PrimeiroNome)
                .HasColumnName("first_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder
                .Property(a => a.UltimoNome)
                .HasColumnName("last_name")
                .HasColumnType("varchar(45)")
                .IsRequired();

            builder
                .Property<DateTime>("last_update")
                .HasDefaultValueSql("getdate()")
                .HasColumnType("datetime");

            //Cria um índice para melhorar buscas na tabela
            builder
                .HasIndex(a => a.UltimoNome);

            //Cria uma chave única para uma coluna ou conjunto de colunas
            builder
                .HasAlternateKey(a => new { a.UltimoNome, a.PrimeiroNome });
        }
    }
}
