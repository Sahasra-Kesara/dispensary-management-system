using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace dispensery_management_system.Migrations
{
    /// <inheritdoc />
    public partial class CreateDoctorsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctor_UserProfiles_UserID",
                table: "Doctor");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor");

            migrationBuilder.RenameTable(
                name: "Doctor",
                newName: "Doctors");

            migrationBuilder.RenameIndex(
                name: "IX_Doctor_UserID",
                table: "Doctors",
                newName: "IX_Doctors_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctors_UserProfiles_UserID",
                table: "Doctors",
                column: "UserID",
                principalTable: "UserProfiles",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Doctors_UserProfiles_UserID",
                table: "Doctors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Doctors",
                table: "Doctors");

            migrationBuilder.RenameTable(
                name: "Doctors",
                newName: "Doctor");

            migrationBuilder.RenameIndex(
                name: "IX_Doctors_UserID",
                table: "Doctor",
                newName: "IX_Doctor_UserID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Doctor",
                table: "Doctor",
                column: "DoctorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Doctor_UserProfiles_UserID",
                table: "Doctor",
                column: "UserID",
                principalTable: "UserProfiles",
                principalColumn: "UserID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
