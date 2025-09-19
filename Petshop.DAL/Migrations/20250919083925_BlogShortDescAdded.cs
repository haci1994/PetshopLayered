using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Petshop.DAL.Migrations
{
    /// <inheritdoc />
    public partial class BlogShortDescAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ShortDescription",
                table: "Blogs",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ShortDescription",
                table: "Blogs");
        }
    }
}
