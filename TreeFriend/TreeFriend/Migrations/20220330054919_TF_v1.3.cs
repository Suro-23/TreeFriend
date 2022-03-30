using Microsoft.EntityFrameworkCore.Migrations;

namespace TreeFriend.Migrations
{
    public partial class TF_v13 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserDetail_users_UserId",
                table: "UserDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserDetail",
                table: "UserDetail");

            migrationBuilder.RenameTable(
                name: "UserDetail",
                newName: "usersDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_usersDetail",
                table: "usersDetail",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_usersDetail_users_UserId",
                table: "usersDetail",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_usersDetail_users_UserId",
                table: "usersDetail");

            migrationBuilder.DropPrimaryKey(
                name: "PK_usersDetail",
                table: "usersDetail");

            migrationBuilder.RenameTable(
                name: "usersDetail",
                newName: "UserDetail");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserDetail",
                table: "UserDetail",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_UserDetail_users_UserId",
                table: "UserDetail",
                column: "UserId",
                principalTable: "users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
