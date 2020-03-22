﻿// <auto-generated />
using AerolineaV1.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace AerolineaV1.Migrations.Reservacion
{
    [DbContext(typeof(ReservacionContext))]
    partial class ReservacionContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AerolineaV1.Models.Reservacion", b =>
                {
                    b.Property<int>("ReservaID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaVuelo")
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NombreCliente")
                        .IsRequired()
                        .HasColumnType("varchar(30)");

                    b.Property<string>("PaisDestino")
                        .IsRequired()
                        .HasColumnType("varchar(20)");

                    b.Property<string>("PosAsiento")
                        .IsRequired()
                        .HasColumnType("char");

                    b.HasKey("ReservaID");

                    b.ToTable("Reservaciones");
                });
#pragma warning restore 612, 618
        }
    }
}