using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SolutionReact.Server.Migrations
{
    /// <inheritdoc />
    public partial class REmoveGuide : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ToursSchedule_Guides_GuideId",
                table: "ToursSchedule");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropIndex(
                name: "IX_ToursSchedule_GuideId",
                table: "ToursSchedule");

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "ToursSchedule");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9921));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9925));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 11, 23, 13, 37, 22, 391, DateTimeKind.Local).AddTicks(37), new DateTime(2025, 11, 23, 13, 37, 22, 391, DateTimeKind.Local).AddTicks(35) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 391, DateTimeKind.Local).AddTicks(8));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 391, DateTimeKind.Local).AddTicks(13));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9565));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9618));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9951));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9956));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "DateInvoice", "DatePayment" },
                values: new object[] { new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9984), new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9976), new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9978) });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9852));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 13, 37, 22, 390, DateTimeKind.Local).AddTicks(9855));

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "TourStartDate" },
                values: new object[] { new DateTime(2025, 11, 23, 13, 37, 22, 391, DateTimeKind.Local).AddTicks(61), new DateTime(2025, 11, 28, 13, 37, 22, 391, DateTimeKind.Local).AddTicks(58) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "ToursSchedule",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    HiredFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HiredUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
                    HomeAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumberExtra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1623));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1627));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1787), new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1785) });

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1751));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1756));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1101));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1165));

            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "Id", "AddedBy", "AddedDate", "City", "Comments", "Country", "DateOfBirth", "DeletedBy", "DeletedDate", "EmailAddress", "FirstName", "HiredFrom", "HiredUntil", "HomeAddress", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "PhoneNumber", "PhoneNumberExtra", "PostCode" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1653), "", null, "", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "john.doe@example.com", "John", new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1655), null, "", true, "Doe", null, null, "123-456-7890", null, "" },
                    { 2, "Admin", new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1658), "", null, "", new DateTime(1985, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "jane.smith@example.com", "Jane", new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1660), null, "", true, "Smith", null, null, "987-654-3210", null, "" }
                });

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1685));

            migrationBuilder.UpdateData(
                table: "Hotel",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1689));

            migrationBuilder.UpdateData(
                table: "Payments",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "DateInvoice", "DatePayment" },
                values: new object[] { new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1725), new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1715), new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1718) });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1591));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "GuideId", "TourStartDate" },
                values: new object[] { new DateTime(2025, 11, 21, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1814), 1, new DateTime(2025, 11, 26, 17, 12, 16, 19, DateTimeKind.Local).AddTicks(1809) });

            migrationBuilder.CreateIndex(
                name: "IX_ToursSchedule_GuideId",
                table: "ToursSchedule",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_ToursSchedule_Guides_GuideId",
                table: "ToursSchedule",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "Id");
        }
    }
}
