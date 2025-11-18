using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace NZWalks.API.Migrations
{
    /// <inheritdoc />
    public partial class ReseedBaselineData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Difficulties",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("191e67e3-118d-4a62-bd5d-a4fea9a50f34"), "Medium" },
                    { new Guid("24498ca7-e693-473a-b4d4-7abf51eee4f1"), "Hard" },
                    { new Guid("b7317d96-cf1b-4246-b911-ef42e616d7c7"), "Easy" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("191e67e3-118d-4a62-bd5d-a4fea9a50f34"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("24498ca7-e693-473a-b4d4-7abf51eee4f1"));

            migrationBuilder.DeleteData(
                table: "Difficulties",
                keyColumn: "Id",
                keyValue: new Guid("b7317d96-cf1b-4246-b911-ef42e616d7c7"));
        }
    }
}
