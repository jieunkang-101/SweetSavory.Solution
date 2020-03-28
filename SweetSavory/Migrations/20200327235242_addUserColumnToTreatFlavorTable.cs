using Microsoft.EntityFrameworkCore.Migrations;

namespace SweetSavory.Migrations
{
    public partial class addUserColumnToTreatFlavorTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "TreatFlavors",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_TreatFlavors_UserId",
                table: "TreatFlavors",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_TreatFlavors_AspNetUsers_UserId",
                table: "TreatFlavors",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TreatFlavors_AspNetUsers_UserId",
                table: "TreatFlavors");

            migrationBuilder.DropIndex(
                name: "IX_TreatFlavors_UserId",
                table: "TreatFlavors");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "TreatFlavors");
        }
    }
}
