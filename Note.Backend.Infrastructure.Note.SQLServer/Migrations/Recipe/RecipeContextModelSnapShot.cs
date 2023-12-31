﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Note.Backend.Infrastructure.SQLServer.Context.Recipe;

#nullable disable

namespace Note.Backend.Infrastructure.SQLServer.Migrations.Recipe
{
    [DbContext(typeof(RecipeContext))]
    partial class RecipeContextModelSnapShot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Note.Backend.Infrastructure.SQLServer.Models.RecipeDto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("AuthorId")
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("CookingTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte>("Difficulty")
                        .HasColumnType("tinyint");

                    b.Property<long>("FirstPublicationDateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("IngredientIds")
                        .HasColumnType("nvarchar(255)");

                    b.Property<long>("LastUpdateDateTime")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(255)");

                    b.Property<byte>("PortionQuantity")
                        .HasColumnType("tinyint");

                    b.Property<long>("PreparationTime")
                        .HasColumnType("bigint");

                    b.Property<string>("RecipeNutritionDataID")
                        .HasColumnType("nvarchar(255)");

                    b.HasKey("Id");

                    b.ToTable("RecipeData", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
