﻿// <auto-generated />
using System;
using DBContexts.DBContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace WebProject.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("WebProject.Domain.Models.WeatherTask.WeatherDayView", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeatherName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeatherShortDescription")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double?>("WeatherTemperature")
                        .HasColumnType("float");

                    b.Property<double?>("WeatherTemperatureFeelsLikeCels")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("WeatherDayViews");
                });
#pragma warning restore 612, 618
        }
    }
}
