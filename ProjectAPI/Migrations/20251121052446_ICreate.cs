using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectAPI.Migrations
{
    /// <inheritdoc />
    public partial class ICreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BreakfastsFoods",
                columns: table => new
                {
                    Food_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Calories = table.Column<int>(type: "int", nullable: false),
                    Food_Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Is_Hot = table.Column<bool>(type: "bit", nullable: false),
                    Recommended_Drink = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BreakfastsFoods", x => x.Food_Id);
                });

            migrationBuilder.CreateTable(
                name: "FavoriteGames",
                columns: table => new
                {
                    Game_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Hours_Played = table.Column<int>(type: "int", nullable: false),
                    Platform = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Release_Year = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FavoriteGames", x => x.Game_Id);
                });

            migrationBuilder.CreateTable(
                name: "Hobbies",
                columns: table => new
                {
                    Hobby_ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hobby_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skill_Level = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Weekly_Hours = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Category = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hobbies", x => x.Hobby_ID);
                });

            migrationBuilder.CreateTable(
                name: "TeamMembers",
                columns: table => new
                {
                    Team_Member_Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Full_Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Birthdate = table.Column<DateOnly>(type: "date", nullable: false),
                    College_Program = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Year_In_Program = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Favorite_Color = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TeamMembers", x => x.Team_Member_Id);
                });

            migrationBuilder.InsertData(
                table: "BreakfastsFoods",
                columns: new[] { "Food_Id", "Calories", "Food_Type", "Is_Hot", "Name", "Recommended_Drink" },
                values: new object[,]
                {
                    { 1, 670, "Wrap", true, "Breakfast Crunchwrap", "Orange Juice" },
                    { 2, 250, "?", true, "?", "?" },
                    { 3, 250, "?", true, "?", "?" },
                    { 4, 250, "?", true, "?", "?" }
                });

            migrationBuilder.InsertData(
                table: "FavoriteGames",
                columns: new[] { "Game_Id", "Genre", "Hours_Played", "Platform", "Release_Year", "Title" },
                values: new object[,]
                {
                    { 1, "Action-Adventure", 210, "PC", 2018, "Red Dead Redemption 2" },
                    { 2, "?", 300, "?", 2017, "?" },
                    { 3, "?", 300, "?", 2017, "?" },
                    { 4, "?", 300, "?", 2017, "?" }
                });

            migrationBuilder.InsertData(
                table: "Hobbies",
                columns: new[] { "Hobby_ID", "Category", "Description", "Hobby_Name", "Skill_Level", "Weekly_Hours" },
                values: new object[,]
                {
                    { 1, "Indoor", "Playing video games with friends", "Gaming", "Intermediate", 17 },
                    { 2, "?", "?", "?", "?", 4 },
                    { 3, "?", "?", "?", "?", 4 },
                    { 4, "?", "?", "?", "?", 4 }
                });

            migrationBuilder.InsertData(
                table: "TeamMembers",
                columns: new[] { "Team_Member_Id", "Birthdate", "College_Program", "Email", "Favorite_Color", "Full_Name", "Year_In_Program" },
                values: new object[,]
                {
                    { 1, new DateOnly(2005, 1, 20), "Information Technology", "imsickia@mail.uc.edu", "Red", "Ian Imsicke", "2nd Year" },
                    { 2, new DateOnly(2000, 9, 2), "?", "?", "?", "?", "?" },
                    { 3, new DateOnly(2000, 9, 2), "?", "?", "?", "?", "?" },
                    { 4, new DateOnly(2000, 9, 2), "?", "?", "?", "?", "?" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BreakfastsFoods");

            migrationBuilder.DropTable(
                name: "FavoriteGames");

            migrationBuilder.DropTable(
                name: "Hobbies");

            migrationBuilder.DropTable(
                name: "TeamMembers");
        }
    }
}
