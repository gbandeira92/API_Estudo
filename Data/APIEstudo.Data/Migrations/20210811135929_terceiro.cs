using Microsoft.EntityFrameworkCore.Migrations;

namespace APIEstudo.Data.Migrations
{
    public partial class terceiro : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "TipoCliente",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nome",
                value: "Desenvolvedor");

            migrationBuilder.UpdateData(
                table: "TipoCliente",
                keyColumn: "ID",
                keyValue: 2,
                column: "Nome",
                value: "Jogador");

            migrationBuilder.InsertData(
                table: "TipoCliente",
                columns: new[] { "ID", "Nome" },
                values: new object[] { 3, "Allien" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TipoCliente",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.UpdateData(
                table: "TipoCliente",
                keyColumn: "ID",
                keyValue: 1,
                column: "Nome",
                value: "Jogador");

            migrationBuilder.UpdateData(
                table: "TipoCliente",
                keyColumn: "ID",
                keyValue: 2,
                column: "Nome",
                value: "Allien");
        }
    }
}
