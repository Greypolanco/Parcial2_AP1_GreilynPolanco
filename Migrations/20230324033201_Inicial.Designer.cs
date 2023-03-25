﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Parcial2_AP1_GreilynPolanco.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230324033201_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.4");

            modelBuilder.Entity("Productos", b =>
                {
                    b.Property<int>("ProductoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<float>("Costo")
                        .HasColumnType("REAL");

                    b.Property<string>("Descripcion")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Existencia")
                        .HasColumnType("INTEGER");

                    b.Property<float>("Precio")
                        .HasColumnType("REAL");

                    b.HasKey("ProductoId");

                    b.ToTable("Productos");

                    b.HasData(
                        new
                        {
                            ProductoId = 1,
                            Costo = 30f,
                            Descripcion = "Many",
                            Existencia = 30,
                            Precio = 50f
                        },
                        new
                        {
                            ProductoId = 2,
                            Costo = 20f,
                            Descripcion = "Pasas",
                            Existencia = 25,
                            Precio = 40f
                        },
                        new
                        {
                            ProductoId = 3,
                            Costo = 50f,
                            Descripcion = "Ciruela",
                            Existencia = 30,
                            Precio = 70f
                        },
                        new
                        {
                            ProductoId = 4,
                            Costo = 65f,
                            Descripcion = "Arandanos",
                            Existencia = 20,
                            Precio = 90f
                        });
                });
#pragma warning restore 612, 618
        }
    }
}