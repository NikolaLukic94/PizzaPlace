﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace PizzaPlace.Migrations
{
    public partial class NotesAddedOnPizza : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Notes",
                table: "Pizzas",
                type: "nvarchar(max)",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Notes",
                table: "Pizzas");
        }
    }
}
