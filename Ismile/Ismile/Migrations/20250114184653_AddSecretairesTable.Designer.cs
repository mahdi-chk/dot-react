﻿// <auto-generated />
using System;
using Ismile.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Ismile.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20250114184653_AddSecretairesTable")]
    partial class AddSecretairesTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("HistoriqueMedicalePatient", b =>
                {
                    b.Property<long>("HistoriqueMedicaleId")
                        .HasColumnType("bigint");

                    b.Property<long>("PatientsAvecHistoriqueMedicaleId")
                        .HasColumnType("bigint");

                    b.HasKey("HistoriqueMedicaleId", "PatientsAvecHistoriqueMedicaleId");

                    b.HasIndex("PatientsAvecHistoriqueMedicaleId");

                    b.ToTable("HistoriqueMedicalePatient");
                });

            modelBuilder.Entity("Ismile.Models.Acte", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CategorieId")
                        .HasColumnType("bigint");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrixDeBase")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CategorieId");

                    b.ToTable("Actes");
                });

            modelBuilder.Entity("Ismile.Models.Cabinet", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Logo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone1")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone2")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cabinets");
                });

            modelBuilder.Entity("Ismile.Models.Caisse", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("CabinetId")
                        .HasColumnType("bigint");

                    b.Property<double>("RecetteDeLAnnee")
                        .HasColumnType("float");

                    b.Property<double>("RecetteDuJour")
                        .HasColumnType("float");

                    b.Property<double>("RecetteDuMois")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CabinetId")
                        .IsUnique();

                    b.ToTable("Caisses");
                });

            modelBuilder.Entity("Ismile.Models.CategorieActe", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CategoriesActe");
                });

            modelBuilder.Entity("Ismile.Models.Consultation", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateConsultation")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DossierMedicaleId")
                        .HasColumnType("bigint");

                    b.Property<string>("TypeConsultation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DossierMedicaleId");

                    b.ToTable("Consultations");
                });

            modelBuilder.Entity("Ismile.Models.Dentiste", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CabinetDeTravailId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDerniereConnexion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRetourConge")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomUtilisateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoDeProfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SalaireDeBase")
                        .HasColumnType("float");

                    b.Property<int>("Sexe")
                        .HasColumnType("int");

                    b.Property<string>("Specialite")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("StatusActuel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CabinetDeTravailId");

                    b.ToTable("Dentistes");
                });

            modelBuilder.Entity("Ismile.Models.Disponibilite", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("DentisteId")
                        .HasColumnType("bigint");

                    b.Property<bool>("EstDisponible")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("HeureDebut")
                        .HasColumnType("time");

                    b.Property<TimeSpan>("HeureFin")
                        .HasColumnType("time");

                    b.Property<long?>("SecretaireId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DentisteId");

                    b.HasIndex("SecretaireId");

                    b.ToTable("Disponibilites");
                });

            modelBuilder.Entity("Ismile.Models.DossierMedicale", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<long?>("MedecinTraitantId")
                        .HasColumnType("bigint");

                    b.Property<long>("NumeroDossier")
                        .HasColumnType("bigint");

                    b.Property<string>("StatutPaiement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("MedecinTraitantId");

                    b.ToTable("DossiersMedicale");
                });

            modelBuilder.Entity("Ismile.Models.Facture", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ConsultationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateFacture")
                        .HasColumnType("datetime2");

                    b.Property<double>("MontantPaye")
                        .HasColumnType("float");

                    b.Property<double>("MontantReste")
                        .HasColumnType("float");

                    b.Property<double>("MontantTotal")
                        .HasColumnType("float");

                    b.Property<long>("SituationFinanciereId")
                        .HasColumnType("bigint");

                    b.Property<string>("TypePaiement")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationId");

                    b.HasIndex("SituationFinanciereId");

                    b.ToTable("Factures");
                });

            modelBuilder.Entity("Ismile.Models.HistoriqueMedicale", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<int>("Categorie")
                        .HasColumnType("int");

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("HistoriquesMedicale");
                });

            modelBuilder.Entity("Ismile.Models.InterventionMedecin", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ActeId")
                        .HasColumnType("bigint");

                    b.Property<long>("ConsultationId")
                        .HasColumnType("bigint");

                    b.Property<long>("Dent")
                        .HasColumnType("bigint");

                    b.Property<string>("NoteMedecin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("PrixPatient")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("ActeId");

                    b.HasIndex("ConsultationId");

                    b.ToTable("InterventionsMedecins");
                });

            modelBuilder.Entity("Ismile.Models.Medicament", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ActeId")
                        .HasColumnType("bigint");

                    b.Property<string>("NoteMedecin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ActeId");

                    b.ToTable("Medicaments");
                });

            modelBuilder.Entity("Ismile.Models.Ordonnance", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ConsultationId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<long?>("DossierMedicaleId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationId")
                        .IsUnique();

                    b.HasIndex("DossierMedicaleId");

                    b.ToTable("Ordonnances");
                });

            modelBuilder.Entity("Ismile.Models.Patient", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<long>("DossierMedicaleId")
                        .HasColumnType("bigint");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GroupeSanguin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Mutuelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profession")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Sexe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("DossierMedicaleId")
                        .IsUnique();

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Ismile.Models.PrescriptionDeMedicament", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("ContraintesAlimentation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContraintesTemps")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("MedicamentAPrescrireId")
                        .HasColumnType("bigint");

                    b.Property<long?>("OrdonnanceId")
                        .HasColumnType("bigint");

                    b.Property<int>("UnitesMaxAPrendre")
                        .HasColumnType("int");

                    b.Property<int>("UnitesMinAPrendre")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MedicamentAPrescrireId");

                    b.HasIndex("OrdonnanceId");

                    b.ToTable("PrescriptionsDeMedicaments");
                });

            modelBuilder.Entity("Ismile.Models.RendezVous", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long>("ConsultationId")
                        .HasColumnType("bigint");

                    b.Property<TimeSpan>("DateRDV")
                        .HasColumnType("time");

                    b.Property<long>("DossierMedicaleId")
                        .HasColumnType("bigint");

                    b.Property<string>("Motif")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<TimeSpan>("Temps")
                        .HasColumnType("time");

                    b.Property<string>("TypeRDV")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ConsultationId");

                    b.HasIndex("DossierMedicaleId");

                    b.ToTable("RendezVous");
                });

            modelBuilder.Entity("Ismile.Models.Revenue", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<double>("Amount")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Revenues");
                });

            modelBuilder.Entity("Ismile.Models.Role", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("DentisteId")
                        .HasColumnType("bigint");

                    b.PrimitiveCollection<string>("Privileges")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SecretaireId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("DentisteId");

                    b.HasIndex("SecretaireId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Ismile.Models.Secretaire", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<string>("Adresse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long>("CabinetDeTravailId")
                        .HasColumnType("bigint");

                    b.Property<string>("Cin")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DateDeCreation")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDeModification")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateDerniereConnexion")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateNaissance")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DateRetourConge")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotDePasse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomUtilisateur")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhotoDeProfile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Prenom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Prime")
                        .HasColumnType("float");

                    b.Property<double>("SalaireDeBase")
                        .HasColumnType("float");

                    b.Property<int>("Sexe")
                        .HasColumnType("int");

                    b.Property<int>("StatusActuel")
                        .HasColumnType("int");

                    b.Property<string>("Telephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CabinetDeTravailId");

                    b.ToTable("Secretaires");
                });

            modelBuilder.Entity("Ismile.Models.SituationFinanciere", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("Id"));

                    b.Property<long?>("CaisseId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("DateCreation")
                        .HasColumnType("datetime2");

                    b.Property<long>("DossierMedicaleId")
                        .HasColumnType("bigint");

                    b.Property<double>("MontantGlobalPaye")
                        .HasColumnType("float");

                    b.Property<double>("MontantGlobalRestant")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("CaisseId");

                    b.HasIndex("DossierMedicaleId")
                        .IsUnique();

                    b.ToTable("SituationsFinancieres");
                });

            modelBuilder.Entity("HistoriqueMedicalePatient", b =>
                {
                    b.HasOne("Ismile.Models.HistoriqueMedicale", null)
                        .WithMany()
                        .HasForeignKey("HistoriqueMedicaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ismile.Models.Patient", null)
                        .WithMany()
                        .HasForeignKey("PatientsAvecHistoriqueMedicaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ismile.Models.Acte", b =>
                {
                    b.HasOne("Ismile.Models.CategorieActe", "Categorie")
                        .WithMany()
                        .HasForeignKey("CategorieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Categorie");
                });

            modelBuilder.Entity("Ismile.Models.Caisse", b =>
                {
                    b.HasOne("Ismile.Models.Cabinet", "Cabinet")
                        .WithOne("Caisse")
                        .HasForeignKey("Ismile.Models.Caisse", "CabinetId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cabinet");
                });

            modelBuilder.Entity("Ismile.Models.Consultation", b =>
                {
                    b.HasOne("Ismile.Models.DossierMedicale", "DossierMedicale")
                        .WithMany()
                        .HasForeignKey("DossierMedicaleId");

                    b.Navigation("DossierMedicale");
                });

            modelBuilder.Entity("Ismile.Models.Dentiste", b =>
                {
                    b.HasOne("Ismile.Models.Cabinet", "CabinetDeTravail")
                        .WithMany("Dentistes")
                        .HasForeignKey("CabinetDeTravailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CabinetDeTravail");
                });

            modelBuilder.Entity("Ismile.Models.Disponibilite", b =>
                {
                    b.HasOne("Ismile.Models.Dentiste", null)
                        .WithMany("Disponibilites")
                        .HasForeignKey("DentisteId");

                    b.HasOne("Ismile.Models.Secretaire", null)
                        .WithMany("Disponibilites")
                        .HasForeignKey("SecretaireId");
                });

            modelBuilder.Entity("Ismile.Models.DossierMedicale", b =>
                {
                    b.HasOne("Ismile.Models.Dentiste", "MedecinTraitant")
                        .WithMany()
                        .HasForeignKey("MedecinTraitantId");

                    b.Navigation("MedecinTraitant");
                });

            modelBuilder.Entity("Ismile.Models.Facture", b =>
                {
                    b.HasOne("Ismile.Models.Consultation", "Consultation")
                        .WithMany("Factures")
                        .HasForeignKey("ConsultationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ismile.Models.SituationFinanciere", "SituationFinanciere")
                        .WithMany("Factures")
                        .HasForeignKey("SituationFinanciereId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultation");

                    b.Navigation("SituationFinanciere");
                });

            modelBuilder.Entity("Ismile.Models.InterventionMedecin", b =>
                {
                    b.HasOne("Ismile.Models.Acte", "Acte")
                        .WithMany("Interventions")
                        .HasForeignKey("ActeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ismile.Models.Consultation", "Consultation")
                        .WithMany("Interventions")
                        .HasForeignKey("ConsultationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acte");

                    b.Navigation("Consultation");
                });

            modelBuilder.Entity("Ismile.Models.Medicament", b =>
                {
                    b.HasOne("Ismile.Models.Acte", "Acte")
                        .WithMany()
                        .HasForeignKey("ActeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Acte");
                });

            modelBuilder.Entity("Ismile.Models.Ordonnance", b =>
                {
                    b.HasOne("Ismile.Models.Consultation", "ConsultationConcernee")
                        .WithOne("Ordonnance")
                        .HasForeignKey("Ismile.Models.Ordonnance", "ConsultationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ismile.Models.DossierMedicale", null)
                        .WithMany("Ordonnances")
                        .HasForeignKey("DossierMedicaleId");

                    b.Navigation("ConsultationConcernee");
                });

            modelBuilder.Entity("Ismile.Models.Patient", b =>
                {
                    b.HasOne("Ismile.Models.DossierMedicale", "DossierMedicale")
                        .WithOne("Patient")
                        .HasForeignKey("Ismile.Models.Patient", "DossierMedicaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DossierMedicale");
                });

            modelBuilder.Entity("Ismile.Models.PrescriptionDeMedicament", b =>
                {
                    b.HasOne("Ismile.Models.Medicament", "Medicament")
                        .WithMany("Prescriptions")
                        .HasForeignKey("MedicamentAPrescrireId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ismile.Models.Ordonnance", "Ordonnance")
                        .WithMany("PrescriptionDeMedicaments")
                        .HasForeignKey("OrdonnanceId");

                    b.Navigation("Medicament");

                    b.Navigation("Ordonnance");
                });

            modelBuilder.Entity("Ismile.Models.RendezVous", b =>
                {
                    b.HasOne("Ismile.Models.Consultation", "Consultation")
                        .WithMany()
                        .HasForeignKey("ConsultationId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ismile.Models.DossierMedicale", "DossierMedicale")
                        .WithMany("Rdvs")
                        .HasForeignKey("DossierMedicaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Consultation");

                    b.Navigation("DossierMedicale");
                });

            modelBuilder.Entity("Ismile.Models.Role", b =>
                {
                    b.HasOne("Ismile.Models.Dentiste", null)
                        .WithMany("Roles")
                        .HasForeignKey("DentisteId");

                    b.HasOne("Ismile.Models.Secretaire", null)
                        .WithMany("Roles")
                        .HasForeignKey("SecretaireId");
                });

            modelBuilder.Entity("Ismile.Models.Secretaire", b =>
                {
                    b.HasOne("Ismile.Models.Cabinet", "CabinetDeTravail")
                        .WithMany("Secretaires")
                        .HasForeignKey("CabinetDeTravailId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CabinetDeTravail");
                });

            modelBuilder.Entity("Ismile.Models.SituationFinanciere", b =>
                {
                    b.HasOne("Ismile.Models.Caisse", null)
                        .WithMany("SituationFinancieres")
                        .HasForeignKey("CaisseId");

                    b.HasOne("Ismile.Models.DossierMedicale", "DossierMedicale")
                        .WithOne("SituationFinanciere")
                        .HasForeignKey("Ismile.Models.SituationFinanciere", "DossierMedicaleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DossierMedicale");
                });

            modelBuilder.Entity("Ismile.Models.Acte", b =>
                {
                    b.Navigation("Interventions");
                });

            modelBuilder.Entity("Ismile.Models.Cabinet", b =>
                {
                    b.Navigation("Caisse")
                        .IsRequired();

                    b.Navigation("Dentistes");

                    b.Navigation("Secretaires");
                });

            modelBuilder.Entity("Ismile.Models.Caisse", b =>
                {
                    b.Navigation("SituationFinancieres");
                });

            modelBuilder.Entity("Ismile.Models.Consultation", b =>
                {
                    b.Navigation("Factures");

                    b.Navigation("Interventions");

                    b.Navigation("Ordonnance")
                        .IsRequired();
                });

            modelBuilder.Entity("Ismile.Models.Dentiste", b =>
                {
                    b.Navigation("Disponibilites");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Ismile.Models.DossierMedicale", b =>
                {
                    b.Navigation("Ordonnances");

                    b.Navigation("Patient")
                        .IsRequired();

                    b.Navigation("Rdvs");

                    b.Navigation("SituationFinanciere")
                        .IsRequired();
                });

            modelBuilder.Entity("Ismile.Models.Medicament", b =>
                {
                    b.Navigation("Prescriptions");
                });

            modelBuilder.Entity("Ismile.Models.Ordonnance", b =>
                {
                    b.Navigation("PrescriptionDeMedicaments");
                });

            modelBuilder.Entity("Ismile.Models.Secretaire", b =>
                {
                    b.Navigation("Disponibilites");

                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Ismile.Models.SituationFinanciere", b =>
                {
                    b.Navigation("Factures");
                });
#pragma warning restore 612, 618
        }
    }
}
