using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HouseRentingSystem.Infrastructure.Migrations
{
    public partial class UniqueConstraintForPhoneNumberAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f0cc825c-1c23-402e-950a-0a31518172a3", "AQAAAAEAACcQAAAAEHgSoti3Jmhh53GpSrRfIQg4EX4FQAYQpdWzb7xQVwgQDLMMzNQm1zoAocNyrVJYbw==", "e0e21285-4048-4f59-9d6f-c3d3ccaaf5c7" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04234685-9acb-4719-b2e6-8852f48e7981", "AQAAAAEAACcQAAAAEJmHixarznQA9e8Q6gsFIYyfRLHQ6BNQbLRRG+sqjAE59M/d7VBuWserDu6uMowV/w==", "f8440b0d-96c5-44d4-b026-9ce013abedfc" });

            migrationBuilder.CreateIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents",
                column: "PhoneNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Agents_PhoneNumber",
                table: "Agents");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6d5800ce-d726-4fc8-83d9-d6b3ac1f591e",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e5cd6b-385e-4ffa-ae7b-16e782532880", "AQAAAAEAACcQAAAAEGzO0Jd6owpEbnfGZyWp7qXtNI5I040TA2eG03uXou16yOtXzH2BWwRvaNleMeK5DQ==", "25d2d5fa-95dd-4634-a2ea-7bd702f10c85" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "dea12856-c198-4129-b3f3-b893d8395082",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2230231c-7dce-4104-bfc0-06d6fe9d835c", "AQAAAAEAACcQAAAAEI/0UYa1IWd0u+frbZnG632qv3vjEIC48XSNFzCRY05kaJpbpfCn+D6ssuAQwu7V3w==", "df8d04c4-bf0a-4aa5-94c4-fb5f28efda9f" });
        }
    }
}
