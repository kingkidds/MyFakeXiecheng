using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FakeXiecheng.Migrations
{
    public partial class DataSeeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "TouristRoutes",
                columns: new[] { "Id", "CreateTime", "DepartureTime", "Descrption", "DiscountPresent", "Features", "Fees", "Notes", "OriginalPrice", "Title", "UpdateTime" },
                values: new object[] { new Guid("f12b5758-4ff1-4d5d-81e8-d643123c3a31"), new DateTime(2021, 4, 24, 2, 59, 29, 588, DateTimeKind.Utc).AddTicks(9607), null, "shuoming", null, null, null, null, 0m, "ceshititle", null });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "TouristRoutes",
                keyColumn: "Id",
                keyValue: new Guid("f12b5758-4ff1-4d5d-81e8-d643123c3a31"));
        }
    }
}
