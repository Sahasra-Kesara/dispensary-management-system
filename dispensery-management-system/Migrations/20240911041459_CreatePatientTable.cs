using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dispensery_management_system.Migrations
{
    /// <inheritdoc />
    public partial class CreatePatientTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patient_UserProfiles_UserID",
                table: "Patient");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patient",
                table: "Patient");

            migrationBuilder.RenameTable(
                name: "Patient",
                newName: "Patients");

            migrationBuilder.RenameIndex(
                name: "IX_Patient_UserID",
                table: "Patients",
                newName: "IX_Patients_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patients",
                table: "Patients",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patients_UserProfiles_UserID",
                table: "Patients",
                column: "UserID",
                principalTable: "UserProfiles",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Patients_UserProfiles_UserID",
                table: "Patients");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Patients",
                table: "Patients");

            migrationBuilder.RenameTable(
                name: "Patients",
                newName: "Patient");

            migrationBuilder.RenameIndex(
                name: "IX_Patients_UserID",
                table: "Patient",
                newName: "IX_Patient_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Patient",
                table: "Patient",
                column: "PatientID");

            migrationBuilder.AddForeignKey(
                name: "FK_Patient_UserProfiles_UserID",
                table: "Patient",
                column: "UserID",
                principalTable: "UserProfiles",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
