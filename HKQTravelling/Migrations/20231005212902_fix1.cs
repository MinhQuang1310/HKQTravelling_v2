using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HKQTravelling.Migrations
{
    /// <inheritdoc />
    public partial class fix1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_feedbacks_discount_Discount_Id",
                table: "feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_feedbacks_tours_TourId",
                table: "feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_feedbacks_users_UserId",
                table: "feedbacks");

            migrationBuilder.DropIndex(
                name: "IX_feedbacks_Discount_Id",
                table: "feedbacks");

            migrationBuilder.DropColumn(
                name: "Discount_Id",
                table: "feedbacks");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "feedbacks",
                newName: "user_id");

            migrationBuilder.RenameColumn(
                name: "TourId",
                table: "feedbacks",
                newName: "tour_id");

            migrationBuilder.RenameIndex(
                name: "IX_feedbacks_UserId",
                table: "feedbacks",
                newName: "IX_feedbacks_user_id");

            migrationBuilder.RenameIndex(
                name: "IX_feedbacks_TourId",
                table: "feedbacks",
                newName: "IX_feedbacks_tour_id");

            migrationBuilder.AddForeignKey(
                name: "FK_feedbacks_tours_tour_id",
                table: "feedbacks",
                column: "tour_id",
                principalTable: "tours",
                principalColumn: "tour_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_feedbacks_users_user_id",
                table: "feedbacks",
                column: "user_id",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_feedbacks_tours_tour_id",
                table: "feedbacks");

            migrationBuilder.DropForeignKey(
                name: "FK_feedbacks_users_user_id",
                table: "feedbacks");

            migrationBuilder.RenameColumn(
                name: "user_id",
                table: "feedbacks",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "tour_id",
                table: "feedbacks",
                newName: "TourId");

            migrationBuilder.RenameIndex(
                name: "IX_feedbacks_user_id",
                table: "feedbacks",
                newName: "IX_feedbacks_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_feedbacks_tour_id",
                table: "feedbacks",
                newName: "IX_feedbacks_TourId");

            migrationBuilder.AddColumn<long>(
                name: "Discount_Id",
                table: "feedbacks",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_feedbacks_Discount_Id",
                table: "feedbacks",
                column: "Discount_Id");

            migrationBuilder.AddForeignKey(
                name: "FK_feedbacks_discount_Discount_Id",
                table: "feedbacks",
                column: "Discount_Id",
                principalTable: "discount",
                principalColumn: "dis_id");

            migrationBuilder.AddForeignKey(
                name: "FK_feedbacks_tours_TourId",
                table: "feedbacks",
                column: "TourId",
                principalTable: "tours",
                principalColumn: "tour_id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_feedbacks_users_UserId",
                table: "feedbacks",
                column: "UserId",
                principalTable: "users",
                principalColumn: "user_id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
