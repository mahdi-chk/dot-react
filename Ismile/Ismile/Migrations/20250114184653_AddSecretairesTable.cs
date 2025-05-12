using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ismile.Migrations
{
    /// <inheritdoc />
    public partial class AddSecretairesTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilites_Secretaire_SecretaireId",
                table: "Disponibilites");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Secretaire_SecretaireId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Secretaire_Cabinets_CabinetDeTravailId",
                table: "Secretaire");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Secretaire",
                table: "Secretaire");

            migrationBuilder.RenameTable(
                name: "Secretaire",
                newName: "Secretaires");

            migrationBuilder.RenameIndex(
                name: "IX_Secretaire_CabinetDeTravailId",
                table: "Secretaires",
                newName: "IX_Secretaires_CabinetDeTravailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Secretaires",
                table: "Secretaires",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilites_Secretaires_SecretaireId",
                table: "Disponibilites",
                column: "SecretaireId",
                principalTable: "Secretaires",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Secretaires_SecretaireId",
                table: "Roles",
                column: "SecretaireId",
                principalTable: "Secretaires",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Secretaires_Cabinets_CabinetDeTravailId",
                table: "Secretaires",
                column: "CabinetDeTravailId",
                principalTable: "Cabinets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Disponibilites_Secretaires_SecretaireId",
                table: "Disponibilites");

            migrationBuilder.DropForeignKey(
                name: "FK_Roles_Secretaires_SecretaireId",
                table: "Roles");

            migrationBuilder.DropForeignKey(
                name: "FK_Secretaires_Cabinets_CabinetDeTravailId",
                table: "Secretaires");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Secretaires",
                table: "Secretaires");

            migrationBuilder.RenameTable(
                name: "Secretaires",
                newName: "Secretaire");

            migrationBuilder.RenameIndex(
                name: "IX_Secretaires_CabinetDeTravailId",
                table: "Secretaire",
                newName: "IX_Secretaire_CabinetDeTravailId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Secretaire",
                table: "Secretaire",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Disponibilites_Secretaire_SecretaireId",
                table: "Disponibilites",
                column: "SecretaireId",
                principalTable: "Secretaire",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Roles_Secretaire_SecretaireId",
                table: "Roles",
                column: "SecretaireId",
                principalTable: "Secretaire",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Secretaire_Cabinets_CabinetDeTravailId",
                table: "Secretaire",
                column: "CabinetDeTravailId",
                principalTable: "Cabinets",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
