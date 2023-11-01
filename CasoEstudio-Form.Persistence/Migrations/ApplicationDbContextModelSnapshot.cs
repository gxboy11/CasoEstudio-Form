﻿// <auto-generated />
using System;
using CasoEstudio_Form.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CasoEstudio_Form.Persistence.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CasoEstudio_Form.Domain.EntityModels.Publicaciones.Publicaciones", b =>
                {
                    b.Property<int>("idComentario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idComentario"));

                    b.Property<DateTime>("fechaComentario")
                        .HasColumnType("datetime2");

                    b.Property<int?>("idParent")
                        .HasColumnType("int");

                    b.Property<int>("idUsuario")
                        .HasColumnType("int");

                    b.Property<string>("textComentario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idComentario");

                    b.HasIndex("idParent");

                    b.HasIndex("idUsuario");

                    b.ToTable("Publicaciones");
                });

            modelBuilder.Entity("CasoEstudio_Form.Domain.EntityModels.Usuarios.Usuario", b =>
                {
                    b.Property<int>("idUsuario")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("idUsuario"));

                    b.Property<string>("nombreUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("passwordUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("idUsuario");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("CasoEstudio_Form.Domain.EntityModels.Publicaciones.Publicaciones", b =>
                {
                    b.HasOne("CasoEstudio_Form.Domain.EntityModels.Publicaciones.Publicaciones", "Publicacion")
                        .WithMany()
                        .HasForeignKey("idParent");

                    b.HasOne("CasoEstudio_Form.Domain.EntityModels.Usuarios.Usuario", "Usuario")
                        .WithMany()
                        .HasForeignKey("idUsuario")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Publicacion");

                    b.Navigation("Usuario");
                });
#pragma warning restore 612, 618
        }
    }
}
