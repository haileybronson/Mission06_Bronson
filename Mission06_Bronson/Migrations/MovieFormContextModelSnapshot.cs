﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Mission06_Bronson.Models;

#nullable disable

namespace Mission06_Bronson.Migrations
{
    [DbContext(typeof(MovieFormContext))]
    partial class MovieFormContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.2");

            modelBuilder.Entity("Mission06_Bronson.Models.Form", b =>
                {
                    b.Property<int>("FormID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieDirector")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("MovieEdited")
                        .HasColumnType("INTEGER");

                    b.Property<string>("MovieLent")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieNotes")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieRating")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("MovieTitle")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateOnly>("MovieYear")
                        .HasColumnType("TEXT");

                    b.HasKey("FormID");

                    b.ToTable("Forms");
                });
#pragma warning restore 612, 618
        }
    }
}
