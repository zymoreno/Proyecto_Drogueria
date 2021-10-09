﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ProyectoG58.App.Persistencia;

namespace ProyectoG58.App.Persistencia.Migrations
{
    [DbContext(typeof(AppContext))]
    partial class AppContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("ProyectoG58.App.Dominio.Bodega", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<string>("telefono")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Bodega");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.Cliente", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<string>("telefono")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.Empleado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("cargo")
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<int>("identificacion")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Empleado");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.Estado", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("codigo")
                        .HasColumnType("text");

                    b.Property<string>("fechaRegistro")
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Estado");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.Factura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("clienteId")
                        .HasColumnType("int");

                    b.Property<int>("empleadoId")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<string>("fecha")
                        .HasColumnType("text");

                    b.Property<double>("saldo")
                        .HasColumnType("double");

                    b.Property<int>("tipo")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Factura");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.OrdenCompra", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("bodegaId")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<string>("fecha")
                        .HasColumnType("text");

                    b.Property<int>("proveedorId")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("OrdenCompra");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.OrdenProducto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<double>("iva")
                        .HasColumnType("double");

                    b.Property<int>("ordenCompraId")
                        .HasColumnType("int");

                    b.Property<int>("productoId")
                        .HasColumnType("int");

                    b.Property<double>("valor")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.ToTable("OrdenProducto");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.Producto", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<string>("fechaVencim")
                        .HasColumnType("text");

                    b.Property<string>("lote")
                        .HasColumnType("text");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<string>("presentacion")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Producto");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.ProductoFactura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<int>("cantidad")
                        .HasColumnType("int");

                    b.Property<int>("facturaId")
                        .HasColumnType("int");

                    b.Property<double>("iva")
                        .HasColumnType("double");

                    b.Property<int>("productoId")
                        .HasColumnType("int");

                    b.Property<double>("valor")
                        .HasColumnType("double");

                    b.HasKey("id");

                    b.ToTable("ProductoFactura");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.Proveedor", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("direccion")
                        .HasColumnType("text");

                    b.Property<string>("email")
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<int>("nit")
                        .HasColumnType("int");

                    b.Property<string>("nombre")
                        .HasColumnType("text");

                    b.Property<string>("telefono")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("Proveedor");
                });

            modelBuilder.Entity("ProyectoG58.App.Dominio.TipoFactura", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("descripcion")
                        .HasColumnType("text");

                    b.Property<string>("estado")
                        .HasColumnType("text");

                    b.Property<string>("fechaRegistro")
                        .HasColumnType("text");

                    b.HasKey("id");

                    b.ToTable("TipoFactura");
                });
#pragma warning restore 612, 618
        }
    }
}
