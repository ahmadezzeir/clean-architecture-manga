namespace Infrastructure.EntityFrameworkDataAccess.Migrations
{
    using System;
    using Microsoft.EntityFrameworkCore.Migrations;

    public partial class ExternalUserIdAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                "ExternalUserId",
                "Customer",
                nullable: false,
                defaultValue: string.Empty);

            migrationBuilder.UpdateData(
                "Credit",
                "Id",
                new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                "TransactionDate",
                new DateTime(2019, 11, 16, 22, 15, 10, 176, DateTimeKind.Utc).AddTicks(4260));

            migrationBuilder.UpdateData(
                "Customer",
                "Id",
                new Guid("197d0438-e04b-453d-b5de-eca05960c6ae"),
                "ExternalUserId",
                "42");

            migrationBuilder.UpdateData(
                "Debit",
                "Id",
                new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                "TransactionDate",
                new DateTime(2019, 11, 16, 22, 15, 10, 176, DateTimeKind.Utc).AddTicks(5200));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                "ExternalUserId",
                "Customer");

            migrationBuilder.UpdateData(
                "Credit",
                "Id",
                new Guid("f5117315-e789-491a-b662-958c37237f9b"),
                "TransactionDate",
                new DateTime(2019, 9, 28, 21, 51, 12, 605, DateTimeKind.Utc).AddTicks(4990));

            migrationBuilder.UpdateData(
                "Debit",
                "Id",
                new Guid("3d6032df-7a3b-46e6-8706-be971e3d539f"),
                "TransactionDate",
                new DateTime(2019, 9, 28, 21, 51, 12, 605, DateTimeKind.Utc).AddTicks(5890));
        }
    }
}
