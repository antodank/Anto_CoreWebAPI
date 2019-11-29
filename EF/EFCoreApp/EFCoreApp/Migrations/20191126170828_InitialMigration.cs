using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EFCoreApp.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    StudentId = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Age = table.Column<int>(nullable: true),
                    IsRegularStudent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.StudentId);
                });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[] { new Guid("e8054ed6-6a97-479a-ab9a-0747473d7807"), 30, false, "John Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[] { new Guid("33ddbe94-3b88-418c-8dd7-64175864eb58"), 25, false, "Jane Doe" });

            migrationBuilder.InsertData(
                table: "Students",
                columns: new[] { "StudentId", "Age", "IsRegularStudent", "Name" },
                values: new object[] { new Guid("5806a7e7-cc4d-4731-8f71-94af4373231c"), 28, false, "Mike Miles" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Students");
        }
    }
}
