﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ScoreCardPlus;

#nullable disable

namespace ScoreCardPlus.Migrations
{
    [DbContext(typeof(ScoreCardDBContext))]
    partial class ScoreCardDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.9");

            modelBuilder.Entity("ScoreCardPlus.Models.Holes", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<int>("HoleNumber")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ParScore")
                        .HasColumnType("INTEGER");

                    b.Property<Guid?>("ScoreCardID")
                        .HasColumnType("TEXT");

                    b.Property<int>("Yardage")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("ScoreCardID");

                    b.ToTable("Holes");
                });

            modelBuilder.Entity("ScoreCardPlus.Models.ScoreCard", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("TEXT");

                    b.Property<string>("CourseName")
                        .HasColumnType("TEXT");

                    b.Property<int>("ParScore")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserName")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserScore")
                        .HasColumnType("INTEGER");

                    b.HasKey("ID");

                    b.ToTable("ScoreCards");
                });

            modelBuilder.Entity("ScoreCardPlus.Models.Holes", b =>
                {
                    b.HasOne("ScoreCardPlus.Models.ScoreCard", null)
                        .WithMany("Hole")
                        .HasForeignKey("ScoreCardID");
                });

            modelBuilder.Entity("ScoreCardPlus.Models.ScoreCard", b =>
                {
                    b.Navigation("Hole");
                });
#pragma warning restore 612, 618
        }
    }
}
