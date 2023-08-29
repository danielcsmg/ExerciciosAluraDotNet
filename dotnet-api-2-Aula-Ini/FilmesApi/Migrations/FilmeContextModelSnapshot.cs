﻿// <auto-generated />
using System;
using FilmesApi.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FilmesApi.Migrations
{
    [DbContext(typeof(FilmeContext))]
    partial class FilmeContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("FilmesApi.Models.Cinema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("EnderecoId")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.HasIndex("EnderecoId")
                        .IsUnique();

                    b.ToTable("Cinemas");
                });

            modelBuilder.Entity("FilmesApi.Models.Endereco", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Logradouro")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("Numero")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Enderecos");
                });

            modelBuilder.Entity("FilmesApi.Models.FilmeAPI", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("Duracao")
                        .HasColumnType("int");

                    b.Property<string>("Genero")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("FilmesAPI");
                });

            modelBuilder.Entity("FilmesApi.Models.Sessao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int?>("CinemaId")
                        .HasColumnType("int");

                    b.Property<int>("FilmeAPIId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CinemaId");

                    b.HasIndex("FilmeAPIId");

                    b.ToTable("Sessao");
                });

            modelBuilder.Entity("FilmesApi.Models.Cinema", b =>
                {
                    b.HasOne("FilmesApi.Models.Endereco", "Endereco")
                        .WithOne("Cinema")
                        .HasForeignKey("FilmesApi.Models.Cinema", "EnderecoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Endereco");
                });

            modelBuilder.Entity("FilmesApi.Models.Sessao", b =>
                {
                    b.HasOne("FilmesApi.Models.Cinema", "Cinema")
                        .WithMany("Sessoes")
                        .HasForeignKey("CinemaId");

                    b.HasOne("FilmesApi.Models.FilmeAPI", "FilmeAPI")
                        .WithMany("Sessoes")
                        .HasForeignKey("FilmeAPIId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cinema");

                    b.Navigation("FilmeAPI");
                });

            modelBuilder.Entity("FilmesApi.Models.Cinema", b =>
                {
                    b.Navigation("Sessoes");
                });

            modelBuilder.Entity("FilmesApi.Models.Endereco", b =>
                {
                    b.Navigation("Cinema")
                        .IsRequired();
                });

            modelBuilder.Entity("FilmesApi.Models.FilmeAPI", b =>
                {
                    b.Navigation("Sessoes");
                });
#pragma warning restore 612, 618
        }
    }
}
