using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ApiUser.Migrations
{
    /// <inheritdoc />
    public partial class secretcode : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Secret",
                table: "Users",
                newName: "SecretCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "SecretCode",
                table: "Users",
                newName: "Secret");
        }
    }
}
