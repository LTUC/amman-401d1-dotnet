﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RazorPagesDemo.Data;

namespace RazorPagesDemo.Migrations
{
    [DbContext(typeof(RazorDbContext))]
    [Migration("20220612082623_createDB")]
    partial class createDB
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("RazorPagesDemo.Models.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("people");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Age = 25,
                            Name = "Hanan"
                        },
                        new
                        {
                            Id = 2,
                            Age = 29,
                            Name = "Yahia"
                        },
                        new
                        {
                            Id = 3,
                            Age = 31,
                            Name = "Ola"
                        },
                        new
                        {
                            Id = 4,
                            Age = 35,
                            Name = "Bashar"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
