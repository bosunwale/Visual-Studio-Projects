using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace To_Do_WebApp.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "toDo",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    isDone = table.Column<bool>(type: "INTEGER", nullable: false),
                    AddDate = table.Column<DateTime>(type: "TEXT", nullable: false),
                    ToDoId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_toDo", x => x.Id);
                    table.ForeignKey(
                        name: "FK_toDo_toDo_ToDoId",
                        column: x => x.ToDoId,
                        principalTable: "toDo",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_toDo_ToDoId",
                table: "toDo",
                column: "ToDoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "toDo");
        }
    }
}
