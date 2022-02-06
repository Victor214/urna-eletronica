﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Urna.Data;

namespace Urna.Data.Migrations
{
    [DbContext(typeof(UrnaDbContext))]
    partial class UrnaDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.9");

            modelBuilder.Entity("Urna.Core.Candidate", b =>
                {
                    b.Property<int>("CandidateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<DateTime>("DataRegistro")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("Legenda")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .HasColumnType("longtext");

                    b.Property<string>("NomeVice")
                        .HasColumnType("longtext");

                    b.HasKey("CandidateId");

                    b.ToTable("Candidates");

                    b.HasData(
                        new
                        {
                            CandidateId = -1,
                            DataRegistro = new DateTime(2022, 2, 4, 1, 16, 54, 346, DateTimeKind.Local).AddTicks(6879),
                            Legenda = 0,
                            Nome = "Branco",
                            NomeVice = ""
                        });
                });

            modelBuilder.Entity("Urna.Core.Vote", b =>
                {
                    b.Property<int>("VoteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("CandidateId")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataVoto")
                        .HasColumnType("datetime(6)");

                    b.HasKey("VoteId");

                    b.HasIndex("CandidateId");

                    b.ToTable("Votes");
                });

            modelBuilder.Entity("Urna.Core.Vote", b =>
                {
                    b.HasOne("Urna.Core.Candidate", "Candidato")
                        .WithMany("Votos")
                        .HasForeignKey("CandidateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Candidato");
                });

            modelBuilder.Entity("Urna.Core.Candidate", b =>
                {
                    b.Navigation("Votos");
                });
#pragma warning restore 612, 618
        }
    }
}
