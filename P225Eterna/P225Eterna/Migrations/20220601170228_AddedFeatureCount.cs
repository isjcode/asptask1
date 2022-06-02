using Microsoft.EntityFrameworkCore.Migrations;

namespace P225Eterna.Migrations
{
    public partial class AddedFeatureCount : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "FeatureCount",
                table: "Plans",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FeatureCount",
                table: "Plans");
        }
    }
}
