﻿// <auto-generated />
using Lab38George.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace Lab38George.Migrations
{
    [DbContext(typeof(PartsDbContext))]
    partial class PartsDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Lab38George.Models.Parts", b =>
                {
                    b.Property<int>("PartID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Details");

                    b.Property<string>("Name");

                    b.Property<int>("Quantity");

                    b.HasKey("PartID");

                    b.ToTable("Parts");
                });
#pragma warning restore 612, 618
        }
    }
}
