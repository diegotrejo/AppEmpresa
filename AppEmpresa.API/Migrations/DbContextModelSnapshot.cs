﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AppEmpresa.API.Migrations
{
    [DbContext(typeof(DbContext))]
    partial class DbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("AppEmpresa.Entidades.Cargo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cargos");
                });

            modelBuilder.Entity("AppEmpresa.Entidades.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Ciudad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("AppEmpresa.Entidades.Empleado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Apellidos")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("CargoId")
                        .HasColumnType("int");

                    b.Property<int?>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("Direcrion")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdCargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdDepartamento")
                        .HasColumnType("int");

                    b.Property<string>("Nombres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salario")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CargoId");

                    b.HasIndex("DepartamentoId");

                    b.ToTable("Empleados");
                });

            modelBuilder.Entity("AppEmpresa.Entidades.Empleado", b =>
                {
                    b.HasOne("AppEmpresa.Entidades.Cargo", "Cargo")
                        .WithMany("EmpleadoList")
                        .HasForeignKey("CargoId");

                    b.HasOne("AppEmpresa.Entidades.Departamento", "Departamento")
                        .WithMany("Empleados")
                        .HasForeignKey("DepartamentoId");

                    b.Navigation("Cargo");

                    b.Navigation("Departamento");
                });

            modelBuilder.Entity("AppEmpresa.Entidades.Cargo", b =>
                {
                    b.Navigation("EmpleadoList");
                });

            modelBuilder.Entity("AppEmpresa.Entidades.Departamento", b =>
                {
                    b.Navigation("Empleados");
                });
#pragma warning restore 612, 618
        }
    }
}
