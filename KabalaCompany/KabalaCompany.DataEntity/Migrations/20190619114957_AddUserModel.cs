using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace KabalaCompany.DataEntity.Migrations
{
    public partial class AddUserModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "Application");

            migrationBuilder.AddColumn<int>(
                name: "UserId",
                schema: "HR",
                table: "Employee",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "User",
                schema: "Application",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Username = table.Column<string>(maxLength: 20, nullable: false),
                    Password = table.Column<string>(maxLength: 60, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Employee_UserId",
                schema: "HR",
                table: "Employee",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Employee_User_UserId",
                schema: "HR",
                table: "Employee",
                column: "UserId",
                principalSchema: "Application",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Employee_User_UserId",
                schema: "HR",
                table: "Employee");

            migrationBuilder.DropTable(
                name: "User",
                schema: "Application");

            migrationBuilder.DropIndex(
                name: "IX_Employee_UserId",
                schema: "HR",
                table: "Employee");

            migrationBuilder.DropColumn(
                name: "UserId",
                schema: "HR",
                table: "Employee");
        }
    }
}
