using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Otus.Teaching.PromoCodeFactory.DataAccess.Migrations
{
    /// <inheritdoc />
    public partial class change : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "BeginDate",
                table: "PromoCodes",
                newName: "StartDate");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "PromoCodes",
                newName: "BeginDate");
        }
    }
}
