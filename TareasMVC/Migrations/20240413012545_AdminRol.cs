using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TareasMVC.Migrations
{
    /// <inheritdoc />
    public partial class AdminRol : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
            IF NOT EXISTS (SELECT Id FROM AspNetRoles WHERE Id = '1d6f98ee-fb6b-4c07-8266-7db02b7297a8')
            BEGIN
	            INSERT INTO AspNetRoles (Id, [Name], [NormalizedName])
	            VALUES ('1d6f98ee-fb6b-4c07-8266-7db02b7297a8','admin','ADMIN')
            END");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE AspNetRoles WHERE Id='1d6f98ee-fb6b-4c07-8266-7db02b7297a8'");
        }
    }
}
