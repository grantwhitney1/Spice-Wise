using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Spice_Wise.Migrations
{
    /// <inheritdoc />
    public partial class CategoriesToStatic : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RecipeCategories");

            migrationBuilder.RenameColumn(
                name: "IngredientCategory",
                table: "Ingredients",
                newName: "Category");

            migrationBuilder.AddColumn<int>(
                name: "Order",
                table: "Steps",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Category",
                table: "Recipes",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Order",
                table: "Steps");

            migrationBuilder.DropColumn(
                name: "Category",
                table: "Recipes");

            migrationBuilder.RenameColumn(
                name: "Category",
                table: "Ingredients",
                newName: "IngredientCategory");

            migrationBuilder.CreateTable(
                name: "RecipeCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RecipeId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RecipeCategories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RecipeCategories_Recipes_RecipeId",
                        column: x => x.RecipeId,
                        principalTable: "Recipes",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_RecipeCategories_RecipeId",
                table: "RecipeCategories",
                column: "RecipeId");
        }
    }
}
