using BackSaludMigrantes.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace BackSaludMigrantes.Models.Context
{
    public class DataContext : DbContext
    {

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
           
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Location>(entidad => {
                entidad.ToTable("LOCALIDAD");
                entidad.Property(x => x.LocationId).HasColumnName("ID").IsRequired();
                entidad.HasKey(x => x.LocationId);
                entidad.Property(x => x.LocationName).HasColumnName("NOMBRE").IsRequired();

                entidad.HasData(
                    new Location
                    {
                        LocationId = 1,
                        LocationName = "01. USAQUÉN",
                    },
                    new Location
                    {
                        LocationId = 2,
                        LocationName = "02. CHAPINERO",
                    },
                    new Location
                    {
                        LocationId = 3,
                        LocationName = "03. SANTA FE",
                    },
                    new Location
                    {
                        LocationId = 4,
                        LocationName = "04. SAN CRISTOBAL",
                    },
                    new Location
                    {
                        LocationId = 5,
                        LocationName = "05. USME",
                    },
                    new Location
                    {
                        LocationId = 6,
                        LocationName = "06. TUNJUELITO",
                    },
                    new Location
                    {
                        LocationId = 7,
                        LocationName = "07. BOSA",
                    },
                    new Location
                    {
                        LocationId = 8,
                        LocationName = "08. KENNEDY",
                    },
                    new Location
                    {
                        LocationId = 9,
                        LocationName = "09. FONTIBÓN",
                    },
                    new Location
                    {
                        LocationId = 10,
                        LocationName = "10. ENGATIVÁ",
                    },
                    new Location
                    {
                        LocationId = 11,
                        LocationName = "11. SUBA",
                    },
                    new Location
                    {
                        LocationId = 12,
                        LocationName = "12. BARRIOS UNIDOS",
                    },
                    new Location
                    {
                        LocationId = 13,
                        LocationName = "13. TEUSAQUILLO",
                    },
                    new Location
                    {
                        LocationId = 14,
                        LocationName = "14. MÁRTIRES",
                    },
                    new Location
                    {
                        LocationId = 15,
                        LocationName = "15. ANTONIO NARIÑO",
                    },
                    new Location
                    {
                        LocationId = 16,
                        LocationName = "16. PUENTE ARANDA",
                    },
                    new Location
                    {
                        LocationId = 17,
                        LocationName = "17. CANDELARIA",
                    },
                    new Location
                    {
                        LocationId = 18,
                        LocationName = "18. RAFAEL URIBE",
                    },
                    new Location
                    {
                        LocationId = 19,
                        LocationName = "19. CIUDAD BOLIVAR",
                    },
                    new Location
                    {
                        LocationId = 29,
                        LocationName = "20. SUMAPAZ",
                    }
                );
            });

            modelBuilder.Entity<MigrantsStatements>(entidad =>
            {
                entidad.ToTable("DECLARACIONES_MIGRANTES");
                entidad.Property(x => x.DataSISBEN).HasColumnName("FICHA_SISBEN").IsRequired();
                entidad.HasKey(x => x.DataSISBEN);
                entidad.Property(x => x.Direction).HasColumnName("DIRECCION").IsRequired();
                entidad.Property(x => x.Mobile).HasColumnName("TELEFONO").IsRequired();
                entidad.Property(x => x.LocationId).HasColumnName("LOCALIDAD").IsRequired();
                entidad.Property(x => x.StatamentsDate).HasColumnName("FECHA_DECLARACION").IsRequired();
                entidad.Property(x => x.ValidityDate).HasColumnName("FECHA_VIGENCIA").IsRequired();
                entidad.Property(x => x.latitude).HasColumnName("LATITUD").IsRequired();
                entidad.Property(x => x.longitude).HasColumnName("LONGITUD").IsRequired();
            });

            modelBuilder.Entity<MigrantsAcreditadom>(entidad =>
            {
                entidad.ToTable("MIGRANTES_ACREDITADOM");
                entidad.Property(x => x.MigrantId).HasColumnName("ID_MIGRANTE").IsRequired();
                entidad.HasKey(x => x.MigrantId);
                entidad.Property(x => x.TypeDoc).HasColumnName("DOC_TIPO").IsRequired();
                entidad.Property(x => x.DocNum).HasColumnName("DOC_NUM").IsRequired();
                entidad.Property(x => x.Surname).HasColumnName("APELLIDO_A").IsRequired();
                entidad.Property(x => x.SecondSurname).HasColumnName("APELLIDO_B").IsRequired();
                entidad.Property(x => x.FirstName).HasColumnName("NOMBRE_A").IsRequired();
                entidad.Property(x => x.SecondName).HasColumnName("NOMBRE_B").IsRequired();
                entidad.Property(x => x.BirthDate).HasColumnName("FECHA_NACIMIENTO").IsRequired();
                entidad.Property(x => x.MigrantsStatementsFile).HasColumnName("FICHA").IsRequired();
                entidad.Property(x => x.LocationName).HasColumnName("LOCALIDAD").IsRequired();
                entidad.Property(x => x.Relationship).HasColumnName("PARENTESCO").IsRequired();
                entidad.Property(x => x.Direction).HasColumnName("DIR_VIVIENDA").IsRequired();
                entidad.Property(x => x.Nucleo).HasColumnName("NUCLEO").IsRequired();
            });          

            modelBuilder.Entity<MigrantsStatements>()
                    .HasOne(b => b.Location)
                    .WithMany(p => p.MigrantsStatementsLoc)
                    .HasForeignKey(b => b.LocationId)
                    .OnDelete(DeleteBehavior.Restrict);




        }
        public DbSet<Location> Location { get; set; }
        public DbSet<MigrantsStatements> MigrantsStatements { get; set; }
        public DbSet<MigrantsAcreditadom> MigrantsAcreditadom { get; set; }
    }
}
