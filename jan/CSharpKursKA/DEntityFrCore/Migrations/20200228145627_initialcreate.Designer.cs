﻿// <auto-generated />
using System;
using DEntityFrCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DEntityFrCore.Migrations
{
    [DbContext(typeof(KundenDbContext))]
    [Migration("20200228145627_initialcreate")]
    partial class initialcreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2");

            modelBuilder.Entity("DEntityFrCore.Anschrift", b =>
                {
                    b.Property<int>("AnschriftId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adresszeile")
                        .HasColumnType("TEXT");

                    b.Property<int?>("KundeInAKundenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("KundenId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("PLZ")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Stadt")
                        .HasColumnType("TEXT");

                    b.HasKey("AnschriftId");

                    b.HasIndex("KundeInAKundenId");

                    b.ToTable("Anschriften");
                });

            modelBuilder.Entity("DEntityFrCore.Kunde", b =>
                {
                    b.Property<int>("KundenId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("KundenName")
                        .HasColumnType("TEXT");

                    b.HasKey("KundenId");

                    b.ToTable("Kunden");
                });

            modelBuilder.Entity("DEntityFrCore.Anschrift", b =>
                {
                    b.HasOne("DEntityFrCore.Kunde", "KundeInA")
                        .WithMany("Anschriften")
                        .HasForeignKey("KundeInAKundenId");
                });
#pragma warning restore 612, 618
        }
    }
}
