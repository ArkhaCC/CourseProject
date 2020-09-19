using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace CookbookApp.Model.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Posts",
                columns: table => new
                {
                    TagName = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.TagName);
                });

            migrationBuilder.CreateTable(
                name: "Recipes",
                columns: table => new
                {
                    RecipeNameId = table.Column<string>(nullable: false),
                    SavedRecipe = table.Column<byte[]>(nullable: true),
                    DateSaved = table.Column<DateTime>(nullable: false),
                    AppliedTagsTagName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Recipes", x => x.RecipeNameId);
                    table.ForeignKey(
                        name: "FK_Recipes_Posts_AppliedTagsTagName",
                        column: x => x.AppliedTagsTagName,
                        principalTable: "Posts",
                        principalColumn: "TagName",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Recipes_AppliedTagsTagName",
                table: "Recipes",
                column: "AppliedTagsTagName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Recipes");

            migrationBuilder.DropTable(
                name: "Posts");
        }
    }
}
