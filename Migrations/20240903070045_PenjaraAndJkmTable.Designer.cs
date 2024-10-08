﻿// <auto-generated />
using System;
using Iguaman.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Iguaman.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240903070045_PenjaraAndJkmTable")]
    partial class PenjaraAndJkmTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Iguaman.Models.Cawangan.CawanganJBG", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alamat1")
                        .HasColumnType("text");

                    b.Property<string>("Alamat2")
                        .HasColumnType("text");

                    b.Property<string>("Alamat3")
                        .HasColumnType("text");

                    b.Property<Guid>("IdNegeri")
                        .HasColumnType("uuid");

                    b.Property<string>("KodCawangan")
                        .HasColumnType("text");

                    b.Property<string>("NamaCawangan")
                        .HasColumnType("text");

                    b.Property<string>("NoTel")
                        .HasColumnType("text");

                    b.Property<string>("Poskod")
                        .HasColumnType("text");

                    b.Property<bool>("StatusJBG")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Cawangans");
                });

            modelBuilder.Entity("Iguaman.Models.JKM.JKM", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alamat1")
                        .HasColumnType("text");

                    b.Property<string>("Alamat2")
                        .HasColumnType("text");

                    b.Property<string>("Alamat3")
                        .HasColumnType("text");

                    b.Property<Guid>("IdNegeri")
                        .HasColumnType("uuid");

                    b.Property<string>("KodCawanganJKM")
                        .HasColumnType("text");

                    b.Property<string>("NamaCawanganJKM")
                        .HasColumnType("text");

                    b.Property<string>("NoTel")
                        .HasColumnType("text");

                    b.Property<string>("Poskod")
                        .HasColumnType("text");

                    b.Property<bool>("StatusCawanganJKM")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("JKMs");
                });

            modelBuilder.Entity("Iguaman.Models.JenisKes.JenisKes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdKategori")
                        .HasColumnType("uuid");

                    b.Property<string>("Jenis_Kes")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("JenisKess");
                });

            modelBuilder.Entity("Iguaman.Models.Kategori.Kategori", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("JenisKategori")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Kategoris");
                });

            modelBuilder.Entity("Iguaman.Models.KhidmatNasihat.KhidmatNasihat", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Agama")
                        .HasColumnType("text");

                    b.Property<string>("AlamatSurat1")
                        .HasColumnType("text");

                    b.Property<string>("AlamatSurat2")
                        .HasColumnType("text");

                    b.Property<string>("AlamatSurat3")
                        .HasColumnType("text");

                    b.Property<string>("AnakNo")
                        .HasColumnType("text");

                    b.Property<string>("Bangsa")
                        .HasColumnType("text");

                    b.Property<string>("CiptaOleh")
                        .HasColumnType("text");

                    b.Property<Guid>("IdKategori")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdNegeri")
                        .HasColumnType("uuid");

                    b.Property<string>("IdPengenalanMangsa")
                        .HasColumnType("text");

                    b.Property<Guid>("IdPengguna")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdTemuJanji")
                        .HasColumnType("uuid");

                    b.Property<string>("JantinaMangsa")
                        .HasColumnType("text");

                    b.Property<string>("JenisKes")
                        .HasColumnType("text");

                    b.Property<string>("JenisPengenalanMangsa")
                        .HasColumnType("text");

                    b.Property<string>("JenisPermohonan")
                        .HasColumnType("text");

                    b.Property<double>("JumlahBayaran")
                        .HasColumnType("double precision");

                    b.Property<string>("KemaskiniOleh")
                        .HasColumnType("text");

                    b.Property<string>("NamaMangsa")
                        .HasColumnType("text");

                    b.Property<string>("NamaWakil")
                        .HasColumnType("text");

                    b.Property<bool>("Perakuan")
                        .HasColumnType("boolean");

                    b.Property<string>("Poskod")
                        .HasColumnType("text");

                    b.Property<bool>("StatusBayaran")
                        .HasColumnType("boolean");

                    b.Property<string>("StatusKN")
                        .HasColumnType("text");

                    b.Property<DateTime>("TarikhCipta")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("TarikhKemaskini")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("TarikhLahirMangsa")
                        .HasColumnType("date");

                    b.Property<string>("UlasanPegawai")
                        .HasColumnType("text");

                    b.Property<string>("UlasanPermohonan")
                        .HasColumnType("text");

                    b.Property<string>("UmurMangsa")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("KhidmatNasihats");
                });

            modelBuilder.Entity("Iguaman.Models.Negeri.Negeri", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("KodNegeri")
                        .HasColumnType("text");

                    b.Property<string>("NamaNegeri")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Negeris");
                });

            modelBuilder.Entity("Iguaman.Models.Pengguna.Pengguna", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Agama")
                        .HasColumnType("text");

                    b.Property<string>("AlamatTetap1")
                        .HasColumnType("text");

                    b.Property<string>("AlamatTetap2")
                        .HasColumnType("text");

                    b.Property<string>("AlamatTetap3")
                        .HasColumnType("text");

                    b.Property<string>("BahagianPegawai")
                        .HasColumnType("text");

                    b.Property<string>("Bandar")
                        .HasColumnType("text");

                    b.Property<string>("Bangsa")
                        .HasColumnType("text");

                    b.Property<Guid>("CawanganJbgId")
                        .HasColumnType("uuid");

                    b.Property<string>("CiptaOleh")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Emel")
                        .HasColumnType("text");

                    b.Property<string>("GredPegawai")
                        .HasColumnType("text");

                    b.Property<bool>("IsPegawai")
                        .HasColumnType("boolean");

                    b.Property<string>("Jantina")
                        .HasColumnType("text");

                    b.Property<string>("JawatanPegawai")
                        .HasColumnType("text");

                    b.Property<string>("JenisPengenalan")
                        .HasColumnType("text");

                    b.Property<string>("KataLaluan")
                        .HasColumnType("text");

                    b.Property<string>("KemaskiniOleh")
                        .HasColumnType("text");

                    b.Property<string>("KodKeselamatan")
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("Nama")
                        .HasColumnType("text");

                    b.Property<Guid>("NegeriId")
                        .HasColumnType("uuid");

                    b.Property<string>("NoPengenalan")
                        .HasColumnType("text");

                    b.Property<string>("NoTel")
                        .HasColumnType("text");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<Guid>("PerananId")
                        .HasColumnType("uuid");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("Poskod")
                        .HasColumnType("text");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<bool>("StatusPengguna")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("TarikhCipta")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("TarikhKemaskini")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Iguaman.Models.Penjara.Penjara", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Alamat1")
                        .HasColumnType("text");

                    b.Property<string>("Alamat2")
                        .HasColumnType("text");

                    b.Property<string>("Alamat3")
                        .HasColumnType("text");

                    b.Property<Guid>("IdNegeri")
                        .HasColumnType("uuid");

                    b.Property<string>("KodCawanganPenjara")
                        .HasColumnType("text");

                    b.Property<string>("NamaCawanganPenjara")
                        .HasColumnType("text");

                    b.Property<string>("NoTel")
                        .HasColumnType("text");

                    b.Property<string>("Poskod")
                        .HasColumnType("text");

                    b.Property<bool>("StatusCawanganPenjara")
                        .HasColumnType("boolean");

                    b.HasKey("Id");

                    b.ToTable("Penjaras");
                });

            modelBuilder.Entity("Iguaman.Models.TemuJanji.TemuJanji", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("CawanganJBG")
                        .HasColumnType("uuid");

                    b.Property<string>("CiptaOleh")
                        .HasColumnType("text");

                    b.Property<Guid>("IdKhidmatNasihat")
                        .HasColumnType("uuid");

                    b.Property<Guid>("IdPegawaiKN")
                        .HasColumnType("uuid");

                    b.Property<string>("KemaskiniOleh")
                        .HasColumnType("text");

                    b.Property<TimeOnly>("MasaAkhirTemuJanji")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("MasaMulaTemuJanji")
                        .HasColumnType("time without time zone");

                    b.Property<string>("Status")
                        .HasColumnType("text");

                    b.Property<DateTime>("TarikhCipta")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("TarikhKemaskini")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateOnly>("TarikhTemuJanji")
                        .HasColumnType("date");

                    b.Property<string>("TempatTemuJanji")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("TemuJanjis");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasMaxLength(21)
                        .HasColumnType("character varying(21)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);

                    b.HasDiscriminator().HasValue("IdentityRole<Guid>");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("RoleId")
                        .HasColumnType("uuid");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.Property<Guid>("UserId")
                        .HasColumnType("uuid");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("Iguaman.Models.Peranan.Peranan", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>");

                    b.HasDiscriminator().HasValue("Peranan");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<System.Guid>", b =>
                {
                    b.HasOne("Iguaman.Models.Pengguna.Pengguna", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<System.Guid>", b =>
                {
                    b.HasOne("Iguaman.Models.Pengguna.Pengguna", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<System.Guid>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole<System.Guid>", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Iguaman.Models.Pengguna.Pengguna", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<System.Guid>", b =>
                {
                    b.HasOne("Iguaman.Models.Pengguna.Pengguna", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
