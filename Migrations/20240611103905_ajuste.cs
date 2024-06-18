using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiMissing.Migrations
{
    /// <inheritdoc />
    public partial class ajuste : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioName",
                table: "Usuario",
                newName: "UsuarioNome");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UsuarioNome",
                table: "Usuario",
                newName: "UsuarioName");
        }
    }
}
