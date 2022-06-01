using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace test.Migrations
{
    public partial class addingdata : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Propetario",
                columns: new[] { "Id", "LastName", "Name" },
                values: new object[,]
                {
                    { 1, "Perez", "Fulano" },
                    { 2, "Perez", "Fulano" },
                    { 3, "Perez", "Fulano" },
                    { 4, "Perez", "Fulano" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Propetario",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Propetario",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Propetario",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Propetario",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
