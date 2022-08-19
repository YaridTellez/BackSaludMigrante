﻿// <auto-generated />
using System;
using BackSaludMigrantes.Models.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BackSaludMigrantes.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20220819075348_InitialMigrate")]
    partial class InitialMigrate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("BackSaludMigrantes.Models.Entities.Location", b =>
                {
                    b.Property<int>("LocationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LocationId"), 1L, 1);

                    b.Property<string>("LocationName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMBRE");

                    b.HasKey("LocationId");

                    b.ToTable("LOCALIDAD", (string)null);

                    b.HasData(
                        new
                        {
                            LocationId = 1,
                            LocationName = "01. USAQUÉN"
                        },
                        new
                        {
                            LocationId = 2,
                            LocationName = "02. CHAPINERO"
                        },
                        new
                        {
                            LocationId = 3,
                            LocationName = "03. SANTA FE"
                        },
                        new
                        {
                            LocationId = 4,
                            LocationName = "04. SAN CRISTOBAL"
                        },
                        new
                        {
                            LocationId = 5,
                            LocationName = "05. USME"
                        },
                        new
                        {
                            LocationId = 6,
                            LocationName = "06. TUNJUELITO"
                        },
                        new
                        {
                            LocationId = 7,
                            LocationName = "07. BOSA"
                        },
                        new
                        {
                            LocationId = 8,
                            LocationName = "08. KENNEDY"
                        },
                        new
                        {
                            LocationId = 9,
                            LocationName = "09. FONTIBÓN"
                        },
                        new
                        {
                            LocationId = 10,
                            LocationName = "10. ENGATIVÁ"
                        },
                        new
                        {
                            LocationId = 11,
                            LocationName = "11. SUBA"
                        },
                        new
                        {
                            LocationId = 12,
                            LocationName = "12. BARRIOS UNIDOS"
                        },
                        new
                        {
                            LocationId = 13,
                            LocationName = "13. TEUSAQUILLO"
                        },
                        new
                        {
                            LocationId = 14,
                            LocationName = "14. MÁRTIRES"
                        },
                        new
                        {
                            LocationId = 15,
                            LocationName = "15. ANTONIO NARIÑO"
                        },
                        new
                        {
                            LocationId = 16,
                            LocationName = "16. PUENTE ARANDA"
                        },
                        new
                        {
                            LocationId = 17,
                            LocationName = "17. CANDELARIA"
                        },
                        new
                        {
                            LocationId = 18,
                            LocationName = "18. RAFAEL URIBE"
                        },
                        new
                        {
                            LocationId = 19,
                            LocationName = "19. CIUDAD BOLIVAR"
                        },
                        new
                        {
                            LocationId = 29,
                            LocationName = "20. SUMAPAZ"
                        });
                });

            modelBuilder.Entity("BackSaludMigrantes.Models.Entities.MigrantsAcreditadom", b =>
                {
                    b.Property<int>("MigrantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_MIGRANTE");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MigrantId"), 1L, 1);

                    b.Property<DateTime?>("BirthDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("FEC_NAC");

                    b.Property<string>("Direction")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DIR_VIVIENDA");

                    b.Property<string>("DocNum")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DOC_NUM");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMBRE_A");

                    b.Property<string>("LocationName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("LOCALIDAD");

                    b.Property<string>("MigrantsStatementsFile")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("FICHA");

                    b.Property<bool>("Nucleo")
                        .HasColumnType("bit")
                        .HasColumnName("NUCLEO");

                    b.Property<string>("Relationship")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("PARENTESCO");

                    b.Property<string>("SecondName")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("NOMBRE_B");

                    b.Property<string>("SecondSurname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APELLIDO_B");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("APELLIDO_A");

                    b.Property<string>("TypeDoc")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("DOC_TIP");

                    b.HasKey("MigrantId");

                    b.ToTable("MIGRANTES_ACREDITADOM", (string)null);
                });

            modelBuilder.Entity("BackSaludMigrantes.Models.Entities.MigrantsStatements", b =>
                {
                    b.Property<string>("DataSISBEN")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnName("FICHA_SISBEN");

                    b.Property<string>("Direction")
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)")
                        .HasColumnName("DIRECCION");

                    b.Property<int?>("LocationId")
                        .HasColumnType("int")
                        .HasColumnName("LOCALIDAD");

                    b.Property<string>("Mobile")
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("TELEFONO");

                    b.Property<DateTime?>("StatamentsDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_DECLARA");

                    b.Property<DateTime?>("ValidityDate")
                        .HasColumnType("datetime2")
                        .HasColumnName("FECHA_VIGENCIA");

                    b.HasKey("DataSISBEN");

                    b.HasIndex("LocationId");

                    b.ToTable("DECLARACIONES_MIGRANTES", (string)null);
                });

            modelBuilder.Entity("BackSaludMigrantes.Models.Entities.MigrantsStatements", b =>
                {
                    b.HasOne("BackSaludMigrantes.Models.Entities.Location", "Location")
                        .WithMany("MigrantsStatementsLoc")
                        .HasForeignKey("LocationId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Location");
                });

            modelBuilder.Entity("BackSaludMigrantes.Models.Entities.Location", b =>
                {
                    b.Navigation("MigrantsStatementsLoc");
                });
#pragma warning restore 612, 618
        }
    }
}
