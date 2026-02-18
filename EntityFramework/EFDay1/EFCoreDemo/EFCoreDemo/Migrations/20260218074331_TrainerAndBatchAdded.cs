using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCoreDemo.Migrations
{
    /// <inheritdoc />
    public partial class TrainerAndBatchAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batch_Courses_CourseId",
                table: "Batch");

            migrationBuilder.DropForeignKey(
                name: "FK_Batch_Trainer_TrainerId",
                table: "Batch");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batch",
                table: "Batch");

            migrationBuilder.RenameTable(
                name: "Trainer",
                newName: "Trainers");

            migrationBuilder.RenameTable(
                name: "Batch",
                newName: "Batchs");

            migrationBuilder.RenameIndex(
                name: "IX_Batch_TrainerId",
                table: "Batchs",
                newName: "IX_Batchs_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Batch_CourseId",
                table: "Batchs",
                newName: "IX_Batchs_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainers",
                table: "Trainers",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batchs",
                table: "Batchs",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Courses_CourseId",
                table: "Batchs",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batchs_Trainers_TrainerId",
                table: "Batchs",
                column: "TrainerId",
                principalTable: "Trainers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Courses_CourseId",
                table: "Batchs");

            migrationBuilder.DropForeignKey(
                name: "FK_Batchs_Trainers_TrainerId",
                table: "Batchs");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Trainers",
                table: "Trainers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Batchs",
                table: "Batchs");

            migrationBuilder.RenameTable(
                name: "Trainers",
                newName: "Trainer");

            migrationBuilder.RenameTable(
                name: "Batchs",
                newName: "Batch");

            migrationBuilder.RenameIndex(
                name: "IX_Batchs_TrainerId",
                table: "Batch",
                newName: "IX_Batch_TrainerId");

            migrationBuilder.RenameIndex(
                name: "IX_Batchs_CourseId",
                table: "Batch",
                newName: "IX_Batch_CourseId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Trainer",
                table: "Trainer",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Batch",
                table: "Batch",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Batch_Courses_CourseId",
                table: "Batch",
                column: "CourseId",
                principalTable: "Courses",
                principalColumn: "CourseId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Batch_Trainer_TrainerId",
                table: "Batch",
                column: "TrainerId",
                principalTable: "Trainer",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
