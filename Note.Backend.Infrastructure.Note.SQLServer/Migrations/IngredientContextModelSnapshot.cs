﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Note.Backend.Infrastructure.SQLServer.Context;

#nullable disable

namespace Note.Backend.Infrastructure.SQLServer.Migrations
{
    [DbContext(typeof(IngredientContext))]
    partial class IngredientContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Note.Backend.Infrastructure.SQLServer.Models.RecipeIngredientDto", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("CarbohydratesPercentage")
                        .HasColumnType("float");

                    b.Property<double>("FatsPercentage")
                        .HasColumnType("float");

                    b.Property<byte>("IngredientType")
                        .HasColumnType("tinyint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(255)");

                    b.Property<double>("ProteinsPercentage")
                        .HasColumnType("float");

                    b.Property<double>("Weight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("IngredientData", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}
