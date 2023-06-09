﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolidTask.Repositories.Context;

#nullable disable

namespace SolidTask.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230330071446_init")]
    partial class init
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.HasSequence("AnimalSequence");

            modelBuilder.Entity("SolidTask.Models.Animal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValueSql("NEXT VALUE FOR [AnimalSequence]");

                    SqlServerPropertyBuilderExtensions.UseSequence(b.Property<int>("Id"));

                    b.Property<bool>("IsBird")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sound")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable((string)null);

                    b.UseTpcMappingStrategy();
                });

            modelBuilder.Entity("SolidTask.Models.Carnivore", b =>
                {
                    b.HasBaseType("SolidTask.Models.Animal");

                    b.Property<bool>("EatenFoodToday")
                        .HasColumnType("bit");

                    b.ToTable("Carnivores");
                });

            modelBuilder.Entity("SolidTask.Models.Herbavore", b =>
                {
                    b.HasBaseType("SolidTask.Models.Animal");

                    b.Property<bool>("GrassedToday")
                        .HasColumnType("bit");

                    b.ToTable("Herbavores");
                });
#pragma warning restore 612, 618
        }
    }
}
