﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Project.Data;

#nullable disable

namespace Project.Data.Migrations
{
    [DbContext(typeof(DataContex))]
    [Migration("20241212105528_many-many")]
    partial class manymany
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RegistersTrip", b =>
                {
                    b.Property<string>("registersid")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("tripscode")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("registersid", "tripscode");

                    b.HasIndex("tripscode");

                    b.ToTable("RegistersTrip");
                });

            modelBuilder.Entity("projectNaomi.Core.model.Guide", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("guides");
                });

            modelBuilder.Entity("projectNaomi.Core.model.Registers", b =>
                {
                    b.Property<string>("id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("age")
                        .HasColumnType("int");

                    b.Property<string>("codeTrip")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("status")
                        .HasColumnType("bit");

                    b.HasKey("id");

                    b.ToTable("registers");
                });

            modelBuilder.Entity("projectNaomi.Core.model.Trip", b =>
                {
                    b.Property<string>("code")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<string>("guideId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("idGuide")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("numRegisters")
                        .HasColumnType("int");

                    b.HasKey("code");

                    b.HasIndex("guideId");

                    b.ToTable("trips");
                });

            modelBuilder.Entity("RegistersTrip", b =>
                {
                    b.HasOne("projectNaomi.Core.model.Registers", null)
                        .WithMany()
                        .HasForeignKey("registersid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("projectNaomi.Core.model.Trip", null)
                        .WithMany()
                        .HasForeignKey("tripscode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("projectNaomi.Core.model.Trip", b =>
                {
                    b.HasOne("projectNaomi.Core.model.Guide", "guide")
                        .WithMany("Trips")
                        .HasForeignKey("guideId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("guide");
                });

            modelBuilder.Entity("projectNaomi.Core.model.Guide", b =>
                {
                    b.Navigation("Trips");
                });
#pragma warning restore 612, 618
        }
    }
}
