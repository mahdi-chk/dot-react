using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ismile.Migrations
{
    /// <inheritdoc />
    public partial class M1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cabinets",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone1 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Telephone2 = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Tel = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cabinets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CategoriesActe",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoriesActe", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HistoriquesMedicale",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Categorie = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriquesMedicale", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Revenues",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Amount = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenues", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Caisses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RecetteDuMois = table.Column<double>(type: "float", nullable: false),
                    RecetteDeLAnnee = table.Column<double>(type: "float", nullable: false),
                    RecetteDuJour = table.Column<double>(type: "float", nullable: false),
                    CabinetId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Caisses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Caisses_Cabinets_CabinetId",
                        column: x => x.CabinetId,
                        principalTable: "Cabinets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dentistes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexe = table.Column<int>(type: "int", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoDeProfile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDerniereConnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CabinetDeTravailId = table.Column<long>(type: "bigint", nullable: false),
                    StatusActuel = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalaireDeBase = table.Column<double>(type: "float", nullable: false),
                    DateRetourConge = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Specialite = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dentistes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Dentistes_Cabinets_CabinetDeTravailId",
                        column: x => x.CabinetDeTravailId,
                        principalTable: "Cabinets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Secretaire",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexe = table.Column<int>(type: "int", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhotoDeProfile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDerniereConnexion = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MotDePasse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeModification = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NomUtilisateur = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateDeCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CabinetDeTravailId = table.Column<long>(type: "bigint", nullable: false),
                    StatusActuel = table.Column<int>(type: "int", nullable: false),
                    SalaireDeBase = table.Column<double>(type: "float", nullable: false),
                    DateRetourConge = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prime = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Secretaire", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Secretaire_Cabinets_CabinetDeTravailId",
                        column: x => x.CabinetDeTravailId,
                        principalTable: "Cabinets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Actes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Libelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PrixDeBase = table.Column<double>(type: "float", nullable: false),
                    CategorieId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Actes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Actes_CategoriesActe_CategorieId",
                        column: x => x.CategorieId,
                        principalTable: "CategoriesActe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DossiersMedicale",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    StatutPaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NumeroDossier = table.Column<long>(type: "bigint", nullable: false),
                    MedecinTraitantId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DossiersMedicale", x => x.Id);
                    table.ForeignKey(
                        name: "FK_DossiersMedicale_Dentistes_MedecinTraitantId",
                        column: x => x.MedecinTraitantId,
                        principalTable: "Dentistes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Disponibilites",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HeureDebut = table.Column<TimeSpan>(type: "time", nullable: false),
                    HeureFin = table.Column<TimeSpan>(type: "time", nullable: false),
                    EstDisponible = table.Column<bool>(type: "bit", nullable: false),
                    DentisteId = table.Column<long>(type: "bigint", nullable: true),
                    SecretaireId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disponibilites", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Disponibilites_Dentistes_DentisteId",
                        column: x => x.DentisteId,
                        principalTable: "Dentistes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Disponibilites_Secretaire_SecretaireId",
                        column: x => x.SecretaireId,
                        principalTable: "Secretaire",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Privileges = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DentisteId = table.Column<long>(type: "bigint", nullable: true),
                    SecretaireId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Roles_Dentistes_DentisteId",
                        column: x => x.DentisteId,
                        principalTable: "Dentistes",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Roles_Secretaire_SecretaireId",
                        column: x => x.SecretaireId,
                        principalTable: "Secretaire",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Medicaments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteMedecin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActeId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medicaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Medicaments_Actes_ActeId",
                        column: x => x.ActeId,
                        principalTable: "Actes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Consultations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TypeConsultation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateConsultation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DossierMedicaleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Consultations", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Consultations_DossiersMedicale_DossierMedicaleId",
                        column: x => x.DossierMedicaleId,
                        principalTable: "DossiersMedicale",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Patients",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Telephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Sexe = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Adresse = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateNaissance = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GroupeSanguin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mutuelle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Profession = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DossierMedicaleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patients", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Patients_DossiersMedicale_DossierMedicaleId",
                        column: x => x.DossierMedicaleId,
                        principalTable: "DossiersMedicale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SituationsFinancieres",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DossierMedicaleId = table.Column<long>(type: "bigint", nullable: false),
                    DateCreation = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontantGlobalRestant = table.Column<double>(type: "float", nullable: false),
                    MontantGlobalPaye = table.Column<double>(type: "float", nullable: false),
                    CaisseId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SituationsFinancieres", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SituationsFinancieres_Caisses_CaisseId",
                        column: x => x.CaisseId,
                        principalTable: "Caisses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SituationsFinancieres_DossiersMedicale_DossierMedicaleId",
                        column: x => x.DossierMedicaleId,
                        principalTable: "DossiersMedicale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InterventionsMedecins",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NoteMedecin = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ActeId = table.Column<long>(type: "bigint", nullable: false),
                    ConsultationId = table.Column<long>(type: "bigint", nullable: false),
                    Dent = table.Column<long>(type: "bigint", nullable: false),
                    PrixPatient = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InterventionsMedecins", x => x.Id);
                    table.ForeignKey(
                        name: "FK_InterventionsMedecins_Actes_ActeId",
                        column: x => x.ActeId,
                        principalTable: "Actes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InterventionsMedecins_Consultations_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Ordonnances",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ConsultationId = table.Column<long>(type: "bigint", nullable: false),
                    DossierMedicaleId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ordonnances", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Ordonnances_Consultations_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Ordonnances_DossiersMedicale_DossierMedicaleId",
                        column: x => x.DossierMedicaleId,
                        principalTable: "DossiersMedicale",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "RendezVous",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Motif = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Temps = table.Column<TimeSpan>(type: "time", nullable: false),
                    DossierMedicaleId = table.Column<long>(type: "bigint", nullable: false),
                    ConsultationId = table.Column<long>(type: "bigint", nullable: false),
                    TypeRDV = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateRDV = table.Column<TimeSpan>(type: "time", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RendezVous", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RendezVous_Consultations_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RendezVous_DossiersMedicale_DossierMedicaleId",
                        column: x => x.DossierMedicaleId,
                        principalTable: "DossiersMedicale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HistoriqueMedicalePatient",
                columns: table => new
                {
                    HistoriqueMedicaleId = table.Column<long>(type: "bigint", nullable: false),
                    PatientsAvecHistoriqueMedicaleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HistoriqueMedicalePatient", x => new { x.HistoriqueMedicaleId, x.PatientsAvecHistoriqueMedicaleId });
                    table.ForeignKey(
                        name: "FK_HistoriqueMedicalePatient_HistoriquesMedicale_HistoriqueMedicaleId",
                        column: x => x.HistoriqueMedicaleId,
                        principalTable: "HistoriquesMedicale",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HistoriqueMedicalePatient_Patients_PatientsAvecHistoriqueMedicaleId",
                        column: x => x.PatientsAvecHistoriqueMedicaleId,
                        principalTable: "Patients",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Factures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MontantTotal = table.Column<double>(type: "float", nullable: false),
                    ConsultationId = table.Column<long>(type: "bigint", nullable: false),
                    TypePaiement = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MontantReste = table.Column<double>(type: "float", nullable: false),
                    SituationFinanciereId = table.Column<long>(type: "bigint", nullable: false),
                    DateFacture = table.Column<DateTime>(type: "datetime2", nullable: false),
                    MontantPaye = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Factures", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Factures_Consultations_ConsultationId",
                        column: x => x.ConsultationId,
                        principalTable: "Consultations",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Factures_SituationsFinancieres_SituationFinanciereId",
                        column: x => x.SituationFinanciereId,
                        principalTable: "SituationsFinancieres",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PrescriptionsDeMedicaments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UnitesMinAPrendre = table.Column<int>(type: "int", nullable: false),
                    UnitesMaxAPrendre = table.Column<int>(type: "int", nullable: false),
                    ContraintesAlimentation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContraintesTemps = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrdonnanceId = table.Column<long>(type: "bigint", nullable: true),
                    MedicamentAPrescrireId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PrescriptionsDeMedicaments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PrescriptionsDeMedicaments_Medicaments_MedicamentAPrescrireId",
                        column: x => x.MedicamentAPrescrireId,
                        principalTable: "Medicaments",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PrescriptionsDeMedicaments_Ordonnances_OrdonnanceId",
                        column: x => x.OrdonnanceId,
                        principalTable: "Ordonnances",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Actes_CategorieId",
                table: "Actes",
                column: "CategorieId");

            migrationBuilder.CreateIndex(
                name: "IX_Caisses_CabinetId",
                table: "Caisses",
                column: "CabinetId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Consultations_DossierMedicaleId",
                table: "Consultations",
                column: "DossierMedicaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Dentistes_CabinetDeTravailId",
                table: "Dentistes",
                column: "CabinetDeTravailId");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilites_DentisteId",
                table: "Disponibilites",
                column: "DentisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Disponibilites_SecretaireId",
                table: "Disponibilites",
                column: "SecretaireId");

            migrationBuilder.CreateIndex(
                name: "IX_DossiersMedicale_MedecinTraitantId",
                table: "DossiersMedicale",
                column: "MedecinTraitantId");

            migrationBuilder.CreateIndex(
                name: "IX_Factures_ConsultationId",
                table: "Factures",
                column: "ConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_Factures_SituationFinanciereId",
                table: "Factures",
                column: "SituationFinanciereId");

            migrationBuilder.CreateIndex(
                name: "IX_HistoriqueMedicalePatient_PatientsAvecHistoriqueMedicaleId",
                table: "HistoriqueMedicalePatient",
                column: "PatientsAvecHistoriqueMedicaleId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionsMedecins_ActeId",
                table: "InterventionsMedecins",
                column: "ActeId");

            migrationBuilder.CreateIndex(
                name: "IX_InterventionsMedecins_ConsultationId",
                table: "InterventionsMedecins",
                column: "ConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_Medicaments_ActeId",
                table: "Medicaments",
                column: "ActeId");

            migrationBuilder.CreateIndex(
                name: "IX_Ordonnances_ConsultationId",
                table: "Ordonnances",
                column: "ConsultationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Ordonnances_DossierMedicaleId",
                table: "Ordonnances",
                column: "DossierMedicaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Patients_DossierMedicaleId",
                table: "Patients",
                column: "DossierMedicaleId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionsDeMedicaments_MedicamentAPrescrireId",
                table: "PrescriptionsDeMedicaments",
                column: "MedicamentAPrescrireId");

            migrationBuilder.CreateIndex(
                name: "IX_PrescriptionsDeMedicaments_OrdonnanceId",
                table: "PrescriptionsDeMedicaments",
                column: "OrdonnanceId");

            migrationBuilder.CreateIndex(
                name: "IX_RendezVous_ConsultationId",
                table: "RendezVous",
                column: "ConsultationId");

            migrationBuilder.CreateIndex(
                name: "IX_RendezVous_DossierMedicaleId",
                table: "RendezVous",
                column: "DossierMedicaleId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_DentisteId",
                table: "Roles",
                column: "DentisteId");

            migrationBuilder.CreateIndex(
                name: "IX_Roles_SecretaireId",
                table: "Roles",
                column: "SecretaireId");

            migrationBuilder.CreateIndex(
                name: "IX_Secretaire_CabinetDeTravailId",
                table: "Secretaire",
                column: "CabinetDeTravailId");

            migrationBuilder.CreateIndex(
                name: "IX_SituationsFinancieres_CaisseId",
                table: "SituationsFinancieres",
                column: "CaisseId");

            migrationBuilder.CreateIndex(
                name: "IX_SituationsFinancieres_DossierMedicaleId",
                table: "SituationsFinancieres",
                column: "DossierMedicaleId",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Disponibilites");

            migrationBuilder.DropTable(
                name: "Factures");

            migrationBuilder.DropTable(
                name: "HistoriqueMedicalePatient");

            migrationBuilder.DropTable(
                name: "InterventionsMedecins");

            migrationBuilder.DropTable(
                name: "PrescriptionsDeMedicaments");

            migrationBuilder.DropTable(
                name: "RendezVous");

            migrationBuilder.DropTable(
                name: "Revenues");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SituationsFinancieres");

            migrationBuilder.DropTable(
                name: "HistoriquesMedicale");

            migrationBuilder.DropTable(
                name: "Patients");

            migrationBuilder.DropTable(
                name: "Medicaments");

            migrationBuilder.DropTable(
                name: "Ordonnances");

            migrationBuilder.DropTable(
                name: "Secretaire");

            migrationBuilder.DropTable(
                name: "Caisses");

            migrationBuilder.DropTable(
                name: "Actes");

            migrationBuilder.DropTable(
                name: "Consultations");

            migrationBuilder.DropTable(
                name: "CategoriesActe");

            migrationBuilder.DropTable(
                name: "DossiersMedicale");

            migrationBuilder.DropTable(
                name: "Dentistes");

            migrationBuilder.DropTable(
                name: "Cabinets");
        }
    }
}
