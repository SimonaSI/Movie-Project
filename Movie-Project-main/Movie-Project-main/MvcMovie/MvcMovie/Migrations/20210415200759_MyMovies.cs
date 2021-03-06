using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace MvcMovie.Migrations
{
    public partial class MyMovies : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
               name: "Movies",
               columns: table => new
               {
                   Id = table.Column<int>(type: "int", nullable: false)
                       .Annotation("SqlServer:Identity", "1, 1"),
                   Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   ReleaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                   Genre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                   DirectedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   DistributedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   RunningTime = table.Column<string>(type: "nvarchar(max)", nullable: true),
                   Language = table.Column<string>(type: "nvarchar(max)", nullable: true)
               },
               constraints: table =>
               {
                   table.PrimaryKey("PK_Movies", x => x.Id);
               });


            migrationBuilder.CreateTable(
            name: "Reviews",
            columns: table => new
            {
                Id1 = table.Column<int>(type: "int", nullable: false)
                    .Annotation("SqlServer:Identity", "1, 1"),
                Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                ReviewDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                Message = table.Column<string>(type: "nvarchar(max)", nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Reviews", x => x.Id1);
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Movies");
            migrationBuilder.DropTable(
                name: "Reviews");
        }
    }
}
