﻿// <auto-generated />
using Kodeli.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kodeli.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20220322065046_db")]
    partial class db
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Kodeli.Models.Entity.Tanimlar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<int>("tanimlarTurId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("tanimlarTurId");

                    b.ToTable("Tanimlar");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.TanimlarTur", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool>("AltifMi")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TanimlarTur");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Tanimlar", b =>
                {
                    b.HasOne("Kodeli.Models.Entity.TanimlarTur", "TanimlarTur")
                        .WithMany()
                        .HasForeignKey("tanimlarTurId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("TanimlarTur");
                });
#pragma warning restore 612, 618
        }
    }
}