using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TaskManager.Migrations
{
    /// <inheritdoc />
    public partial class AddTaskItemRelationWUserAndCateg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategId",
                table: "TaskItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsrId",
                table: "TaskItems",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_CategId",
                table: "TaskItems",
                column: "CategId");

            migrationBuilder.CreateIndex(
                name: "IX_TaskItems_UsrId",
                table: "TaskItems",
                column: "UsrId");

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Categories_CategId",
                table: "TaskItems",
                column: "CategId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_TaskItems_Users_UsrId",
                table: "TaskItems",
                column: "UsrId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Categories_CategId",
                table: "TaskItems");

            migrationBuilder.DropForeignKey(
                name: "FK_TaskItems_Users_UsrId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_CategId",
                table: "TaskItems");

            migrationBuilder.DropIndex(
                name: "IX_TaskItems_UsrId",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "CategId",
                table: "TaskItems");

            migrationBuilder.DropColumn(
                name: "UsrId",
                table: "TaskItems");
        }
    }
}
