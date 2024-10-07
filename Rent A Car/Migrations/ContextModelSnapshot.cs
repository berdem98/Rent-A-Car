﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Rent_A_Car.Data.Concrete.EfCore;

#nullable disable

namespace Rent_A_Car.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.18");

            modelBuilder.Entity("Rent_A_Car.Entity.Arac", b =>
                {
                    b.Property<int>("AracId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("AracFiyat")
                        .HasColumnType("TEXT");

                    b.Property<string>("AracModel")
                        .HasColumnType("TEXT");

                    b.Property<int>("KategoriId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Km")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Koltuk")
                        .HasColumnType("TEXT");

                    b.Property<string>("Marka")
                        .HasColumnType("TEXT");

                    b.Property<string>("Motor")
                        .HasColumnType("TEXT");

                    b.Property<bool?>("Musaitlik")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Plaka")
                        .HasColumnType("TEXT");

                    b.Property<string>("Renk")
                        .HasColumnType("TEXT");

                    b.Property<string>("Resim")
                        .HasColumnType("TEXT");

                    b.Property<int>("SehirId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Vites")
                        .HasColumnType("TEXT");

                    b.HasKey("AracId");

                    b.HasIndex("KategoriId");

                    b.HasIndex("SehirId");

                    b.ToTable("Araclar");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.BireyselKullanici", b =>
                {
                    b.Property<int>("BireyselKullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Adres")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("DogumTarihi")
                        .HasColumnType("TEXT");

                    b.Property<string>("Eposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("KimlikNo")
                        .HasColumnType("TEXT");

                    b.Property<string>("Sifre")
                        .HasColumnType("TEXT");

                    b.Property<string>("SifreKontrol")
                        .HasColumnType("TEXT");

                    b.Property<string>("Soyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("BireyselKullaniciId");

                    b.ToTable("BireyselKullanicilar");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Iletisim", b =>
                {
                    b.Property<int>("IletisimId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IletisimAdSoyad")
                        .HasColumnType("TEXT");

                    b.Property<string>("IletisimEposta")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsRead")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Mesaj")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("SentDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("Telefon")
                        .HasColumnType("TEXT");

                    b.HasKey("IletisimId");

                    b.ToTable("Iletisimler");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Kategori", b =>
                {
                    b.Property<int>("KategoriId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KategoriAdi")
                        .HasColumnType("TEXT");

                    b.HasKey("KategoriId");

                    b.ToTable("Kategoriler");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.KurumsalKullanici", b =>
                {
                    b.Property<int>("KurumsalKullaniciId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FaturaAdresi")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaAdi")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaEposta")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaIl")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaIlce")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaSifre")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaSifreKontrol")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirmaTelefon")
                        .HasColumnType("TEXT");

                    b.Property<string>("VergiDairesi")
                        .HasColumnType("TEXT");

                    b.Property<string>("VergiIl")
                        .HasColumnType("TEXT");

                    b.Property<string>("VergiIlce")
                        .HasColumnType("TEXT");

                    b.Property<string>("VergiNo")
                        .HasColumnType("TEXT");

                    b.HasKey("KurumsalKullaniciId");

                    b.ToTable("KurumsalKullanicilar");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Rezervasyon", b =>
                {
                    b.Property<int>("RezervasyonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("AracId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("BireyselKullaniciId")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("IadeTarih")
                        .HasColumnType("TEXT");

                    b.Property<string>("IadeYeriAdi")
                        .HasColumnType("TEXT");

                    b.Property<int?>("IadeYeriId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsActive")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsCompleted")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("KurumsalKullaniciId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SehirId")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Sigorta")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TeslimTarih")
                        .HasColumnType("TEXT");

                    b.Property<string>("TeslimYeriAdi")
                        .HasColumnType("TEXT");

                    b.Property<int?>("TeslimYeriId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RezervasyonId");

                    b.HasIndex("AracId");

                    b.HasIndex("BireyselKullaniciId");

                    b.HasIndex("KurumsalKullaniciId");

                    b.HasIndex("SehirId");

                    b.ToTable("Rezervasyonlar");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Sehir", b =>
                {
                    b.Property<int>("SehirId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("IlAdi")
                        .HasColumnType("TEXT");

                    b.Property<string>("IlceAdi")
                        .HasColumnType("TEXT");

                    b.HasKey("SehirId");

                    b.ToTable("Sehirler");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Arac", b =>
                {
                    b.HasOne("Rent_A_Car.Entity.Kategori", "Kategori")
                        .WithMany("Araclar")
                        .HasForeignKey("KategoriId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rent_A_Car.Entity.Sehir", "Sehir")
                        .WithMany("Araclar")
                        .HasForeignKey("SehirId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Kategori");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Rezervasyon", b =>
                {
                    b.HasOne("Rent_A_Car.Entity.Arac", "Arac")
                        .WithMany()
                        .HasForeignKey("AracId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Rent_A_Car.Entity.BireyselKullanici", "BireyselKullanici")
                        .WithMany()
                        .HasForeignKey("BireyselKullaniciId");

                    b.HasOne("Rent_A_Car.Entity.KurumsalKullanici", "KurumsalKullanici")
                        .WithMany()
                        .HasForeignKey("KurumsalKullaniciId");

                    b.HasOne("Rent_A_Car.Entity.Sehir", "Sehir")
                        .WithMany()
                        .HasForeignKey("SehirId");

                    b.Navigation("Arac");

                    b.Navigation("BireyselKullanici");

                    b.Navigation("KurumsalKullanici");

                    b.Navigation("Sehir");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Kategori", b =>
                {
                    b.Navigation("Araclar");
                });

            modelBuilder.Entity("Rent_A_Car.Entity.Sehir", b =>
                {
                    b.Navigation("Araclar");
                });
#pragma warning restore 612, 618
        }
    }
}
