
using Microsoft.EntityFrameworkCore;
using Ismile.Models;

namespace Ismile.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Acte> Actes { get; set; }
        public DbSet<Cabinet> Cabinets { get; set; }
        public DbSet<Caisse> Caisses { get; set; }
        public DbSet<CategorieActe> CategoriesActe { get; set; }
        public DbSet<Consultation> Consultations { get; set; }
        public DbSet<Dentiste> Dentistes { get; set; }
        public DbSet<Disponibilite> Disponibilites { get; set; }
        public DbSet<DossierMedicale> DossiersMedicale { get; set; }
        public DbSet<Facture> Factures { get; set; }
        public DbSet<HistoriqueMedicale> HistoriquesMedicale { get; set; }
        public DbSet<InterventionMedecin> InterventionsMedecins { get; set; }
        public DbSet<Medicament> Medicaments { get; set; }
        public DbSet<Ordonnance> Ordonnances { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Secretaire> Secretaires { get; set; }

        public DbSet<PrescriptionDeMedicament> PrescriptionsDeMedicaments { get; set; }
        public DbSet<RendezVous> RendezVous { get; set; }
        public DbSet<Revenue> Revenues { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<SituationFinanciere> SituationsFinancieres { get; set; }
       
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Patient>()
                         .Property(p => p.Sexe)
                         .HasConversion<string>();

            modelBuilder.Entity<Patient>()
                .Property(p => p.GroupeSanguin)
                .HasConversion<string>();

            modelBuilder.Entity<Patient>()
                .Property(p => p.Mutuelle)
                .HasConversion<string>();

            modelBuilder.Entity<DossierMedicale>()
                .Property(d => d.StatutPaiement)
                .HasConversion<string>();

            modelBuilder.Entity<Consultation>()
                .Property(c => c.TypeConsultation)
                .HasConversion<string>();

            modelBuilder.Entity<Facture>()
                .Property(f => f.TypePaiement)
                .HasConversion<string>();

            modelBuilder.Entity<RendezVous>()
                .Property(r => r.TypeRDV)
                .HasConversion<string>();

            modelBuilder.Entity<Dentiste>()
                .Property(d => d.Specialite)
                .HasConversion<string>();

            modelBuilder.Entity<Dentiste>()
                .Property(d => d.StatusActuel)
                .HasConversion<string>();

        }

    }
}
