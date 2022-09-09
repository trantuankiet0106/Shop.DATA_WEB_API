using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_shop.Data.Migrations
{
    public partial class seedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "0c01caec-3e6b-498c-b1d3-61e2043ed259");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cdeb23ab-7f55-4c46-8600-cb4a40e5bfd2", "AQAAAAEAACcQAAAAEJT69G+O/Qh6xaPaWHvXpYcIaO1+KXQLJOzjZ+i+WIQSJ158MlxMNjXCq+PBu9XHIQ==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 8, 14, 32, 47, 906, DateTimeKind.Local).AddTicks(6742));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "e9f078dc-89d6-4321-a9d1-376cd0ea83dd");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7160d4cf-422b-44bb-913a-d4ec7ef91c23", "AQAAAAEAACcQAAAAEKMps7keJJ+zD9+/7iB0QeEsijiEI5H+KwhysWh9gAI9ZrV7qIGq4GFgHBuSXhLU2A==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2022, 9, 8, 14, 29, 49, 410, DateTimeKind.Local).AddTicks(2624));
        }
    }
}
