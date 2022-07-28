﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webAPiINZ.Data;

#nullable disable

namespace webAPiINZ.Migrations
{
    [DbContext(typeof(InżContext))]
    [Migration("20220718143751_personalAddDateTime")]
    partial class personalAddDateTime
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.7")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("IngredientProduct", b =>
                {
                    b.Property<string>("IngredientsIdIgredient")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("ProductsBarcode")
                        .HasColumnType("varchar(255)");

                    b.HasKey("IngredientsIdIgredient", "ProductsBarcode");

                    b.HasIndex("ProductsBarcode");

                    b.ToTable("IngredientProduct");
                });

            modelBuilder.Entity("webAPiINZ.Model.Ingredient", b =>
                {
                    b.Property<string>("IdIgredient")
                        .HasColumnType("varchar(255)");

                    b.Property<int>("HealthInfo")
                        .HasColumnType("int");

                    b.Property<string>("Info")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("IdIgredient");

                    b.ToTable("Ingredients", (string)null);
                });

            modelBuilder.Entity("webAPiINZ.Model.IngrProd", b =>
                {
                    b.Property<int>("ingredietnId")
                        .HasColumnType("int");

                    b.Property<string>("prodId")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.ToTable("IngrProds");
                });

            modelBuilder.Entity("webAPiINZ.Model.Personal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Age")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CPM")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("CPMTarget")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Carbonates")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("CarbonatesPer")
                        .HasColumnType("double");

                    b.Property<string>("Fat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("FatPer")
                        .HasColumnType("double");

                    b.Property<string>("Gender")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Height")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("char(36)");

                    b.Property<string>("IdealBodyMass")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Mass")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Pal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Protein")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<double>("ProteinPer")
                        .HasColumnType("double");

                    b.Property<DateTime>("SaveTime")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Target")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Personals", (string)null);
                });

            modelBuilder.Entity("webAPiINZ.Model.Product", b =>
                {
                    b.Property<string>("Barcode")
                        .HasColumnType("varchar(255)");

                    b.Property<string>("Carbohydrate")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Fat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Kcal100")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("KcalTotal")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Producer")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ProductWeight")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Protein")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Salt")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("SaturatesFat")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Sugar")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Barcode");

                    b.ToTable("Product", (string)null);
                });

            modelBuilder.Entity("webAPiINZ.Model.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("char(36)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("User", (string)null);
                });

            modelBuilder.Entity("IngredientProduct", b =>
                {
                    b.HasOne("webAPiINZ.Model.Ingredient", null)
                        .WithMany()
                        .HasForeignKey("IngredientsIdIgredient")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("webAPiINZ.Model.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductsBarcode")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}