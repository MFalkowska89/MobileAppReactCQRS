using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SolutionReact.Server.Migrations
{
    /// <inheritdoc />
    public partial class FotoURL : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FotoURL",
                table: "Tours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6921));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6925));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7057), new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7054) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7061), new DateTime(2025, 12, 8, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7060) });

            migrationBuilder.UpdateData(
                table: "BookingsParticipant",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7105));

            migrationBuilder.UpdateData(
                table: "BookingsParticipant",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6977));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7028));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6863));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6866));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6606));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6657));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6659));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6662));

            migrationBuilder.UpdateData(
                table: "TourActivities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7082));

            migrationBuilder.UpdateData(
                table: "TourActivities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(7085));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "FotoURL" },
                values: new object[] { new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6891), "" });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "FotoURL" },
                values: new object[] { new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6894), "" });

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "TourStartDate" },
                values: new object[] { new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6948), new DateTime(2025, 12, 19, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6944) });

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "TourStartDate" },
                values: new object[] { new DateTime(2025, 12, 9, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6953), new DateTime(2025, 12, 29, 20, 50, 25, 463, DateTimeKind.Local).AddTicks(6951) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FotoURL",
                table: "Tours");

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3865));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3869));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3964), new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3961) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3968), new DateTime(2025, 12, 8, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3967) });

            migrationBuilder.UpdateData(
                table: "BookingsParticipant",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(4019));

            migrationBuilder.UpdateData(
                table: "BookingsParticipant",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(4021));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3933));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3939));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3802));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3805));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3593));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3638));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3641));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3643));

            migrationBuilder.UpdateData(
                table: "TourActivities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3991));

            migrationBuilder.UpdateData(
                table: "TourActivities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3994));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3836));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3840));

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "TourStartDate" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3898), new DateTime(2025, 12, 19, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3894) });

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "TourStartDate" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3903), new DateTime(2025, 12, 29, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3901) });
        }
    }
}
