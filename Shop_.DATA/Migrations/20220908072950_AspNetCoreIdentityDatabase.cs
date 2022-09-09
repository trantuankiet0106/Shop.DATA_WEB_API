using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace My_shop.Data.Migrations
{
    public partial class AspNetCoreIdentityDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "37fd1c7e-8d85-4375-bd3f-49e05e4884e9");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c2c5adf8-c610-4388-9ef4-0c5ee53521eb", "AQAAAAEAACcQAAAAEM5W4ig7ZLu7IAktKOmfztVsluwsNuyJahpY+292T0amym6WRWUGph8oBP/mo7KSxw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2020, 9, 2, 22, 8, 8, 182, DateTimeKind.Local).AddTicks(7084));
        }
    }
}
