// <auto-generated />
using System;
using Kodeli.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Kodeli.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Kodeli.Models.Entity.Basvuru", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<string>("CepTel")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CinsiyetId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("DogumTairih")
                        .HasColumnType("datetime2");

                    b.Property<string>("Eposta")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Kvkk")
                        .HasColumnType("bit");

                    b.Property<int>("OkulId")
                        .HasColumnType("int");

                    b.Property<bool?>("Sartname")
                        .HasColumnType("bit");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VeliAd")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("VeliSoyad")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<int>("YarismaId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CinsiyetId");

                    b.HasIndex("OkulId");

                    b.HasIndex("YarismaId");

                    b.ToTable("Basvuru");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Il", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlKodu")
                        .HasColumnType("int");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("UlkeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UlkeId");

                    b.ToTable("Il");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Ilce", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlId")
                        .HasColumnType("int");

                    b.Property<int>("IlceKodu")
                        .HasColumnType("int");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("IlId");

                    b.ToTable("Ilce");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Okul", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IlceId")
                        .HasColumnType("int");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int>("OkulTuruId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("IlceId");

                    b.HasIndex("OkulTuruId");

                    b.ToTable("Okul");
                });

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

                    b.Property<bool?>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

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

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("TanimlarTur");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Ulke", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ulke");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.YarismaTanim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<bool?>("AltifMi")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("GuncelleyenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IpAdresi")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KaydedenKullanici")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("KayitTarihi")
                        .HasColumnType("datetime2");

                    b.Property<int?>("Kontenjan")
                        .HasColumnType("int");

                    b.Property<int>("YarismaTuruId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("YarismaTuruId");

                    b.ToTable("YarismaTanim");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Basvuru", b =>
                {
                    b.HasOne("Kodeli.Models.Entity.Tanimlar", "Cinsiyet")
                        .WithMany()
                        .HasForeignKey("CinsiyetId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Kodeli.Models.Entity.Okul", "Okul")
                        .WithMany()
                        .HasForeignKey("OkulId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Kodeli.Models.Entity.YarismaTanim", "YarismaTanim")
                        .WithMany()
                        .HasForeignKey("YarismaId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Cinsiyet");

                    b.Navigation("Okul");

                    b.Navigation("YarismaTanim");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Il", b =>
                {
                    b.HasOne("Kodeli.Models.Entity.Ulke", "Ulke")
                        .WithMany()
                        .HasForeignKey("UlkeId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ulke");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Ilce", b =>
                {
                    b.HasOne("Kodeli.Models.Entity.Il", "Il")
                        .WithMany()
                        .HasForeignKey("IlId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Il");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Okul", b =>
                {
                    b.HasOne("Kodeli.Models.Entity.Ilce", "Ilce")
                        .WithMany()
                        .HasForeignKey("IlceId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Kodeli.Models.Entity.Tanimlar", "OkulTuru")
                        .WithMany()
                        .HasForeignKey("OkulTuruId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Ilce");

                    b.Navigation("OkulTuru");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.Tanimlar", b =>
                {
                    b.HasOne("Kodeli.Models.Entity.TanimlarTur", "TanimlarTur")
                        .WithMany()
                        .HasForeignKey("tanimlarTurId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("TanimlarTur");
                });

            modelBuilder.Entity("Kodeli.Models.Entity.YarismaTanim", b =>
                {
                    b.HasOne("Kodeli.Models.Entity.Tanimlar", "YarismaTuru")
                        .WithMany()
                        .HasForeignKey("YarismaTuruId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("YarismaTuru");
                });
#pragma warning restore 612, 618
        }
    }
}
