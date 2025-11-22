using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NZWalks.API.Migrations.NZWalksAuthDb
{
    /// <inheritdoc />
    public partial class SeedConcurrencyStamp : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "680b60d1-fbd4-4796-8911-a690fd2eed7c",
                column: "ConcurrencyStamp",
                value: "680b60d1-fbd4-4796-8911-a690fd2eed7c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3e95a58-bce3-4d1a-8984-e44ffade7f6b",
                column: "ConcurrencyStamp",
                value: "b3e95a58-bce3-4d1a-8984-e44ffade7f6b");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "680b60d1-fbd4-4796-8911-a690fd2eed7c",
                column: "ConcurrencyStamp",
                value: null);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3e95a58-bce3-4d1a-8984-e44ffade7f6b",
                column: "ConcurrencyStamp",
                value: null);
        }
    }
}
