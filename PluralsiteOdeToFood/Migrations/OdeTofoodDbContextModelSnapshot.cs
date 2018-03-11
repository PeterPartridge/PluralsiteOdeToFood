﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using PluralsiteOdeToFood.Data;
using PluralsiteOdeToFood.Models;
using System;

namespace PluralsiteOdeToFood.Migrations
{
    [DbContext(typeof(OdeTofoodDbContext))]
    partial class OdeTofoodDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("PluralsiteOdeToFood.Models.Restaurant", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("Cusine");

                    b.Property<string>("name");

                    b.HasKey("id");

                    b.ToTable("Restaurants");
                });
#pragma warning restore 612, 618
        }
    }
}