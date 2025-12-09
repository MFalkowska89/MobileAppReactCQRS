using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SolutionReact.Server.Migrations
{
    /// <inheritdoc />
    public partial class removingPayment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.AddColumn<int>(
                name: "MinParticipants",
                table: "Tours",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "TourName",
                table: "Tours",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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
                columns: new[] { "AddedDate", "MinParticipants", "TourName" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3836), 0, "" });

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "MinParticipants", "TourName" },
                values: new object[] { new DateTime(2025, 12, 9, 19, 37, 40, 346, DateTimeKind.Local).AddTicks(3840), 0, "" });

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MinParticipants",
                table: "Tours");

            migrationBuilder.DropColumn(
                name: "TourName",
                table: "Tours");

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountInvoice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    AmountPaid = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateInvoice = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatePayment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TransactionReference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Payments_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Payments_PaymentMethods_PaymentMethodId",
                        column: x => x.PaymentMethodId,
                        principalTable: "PaymentMethods",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2997));

            migrationBuilder.UpdateData(
                table: "Activities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3000));

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3095), new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3092) });

            migrationBuilder.UpdateData(
                table: "Bookings",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "BookingDate" },
                values: new object[] { new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 11, 22, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3098) });

            migrationBuilder.UpdateData(
                table: "BookingsParticipant",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "BookingsParticipant",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3412));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3064));

            migrationBuilder.UpdateData(
                table: "Customers",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3069));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2930));

            migrationBuilder.UpdateData(
                table: "Destination",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2933));

            migrationBuilder.InsertData(
                table: "PaymentMethods",
                columns: new[] { "Id", "AddedBy", "AddedDate", "Comments", "DeletedBy", "DeletedDate", "Description", "IsActive", "ModifiedBy", "ModifiedDate", "Name" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2569), null, null, null, "Payment via major credit cards", true, null, null, "Credit Card" },
                    { 2, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2628), null, null, null, "Payment via PayPal account", true, null, null, "PayPal" },
                    { 3, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2630), null, null, null, "Direct bank transfer", true, null, null, "Bank Transfer" },
                    { 4, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2632), null, null, null, "Cash payment at counter", true, null, null, "Cash" }
                });

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2893));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2897));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 3,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2899));

            migrationBuilder.UpdateData(
                table: "StatusOfEntities",
                keyColumn: "Id",
                keyValue: 4,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2902));

            migrationBuilder.UpdateData(
                table: "TourActivities",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "TourActivities",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 1,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2966));

            migrationBuilder.UpdateData(
                table: "Tours",
                keyColumn: "Id",
                keyValue: 2,
                column: "AddedDate",
                value: new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2970));

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AddedDate", "TourStartDate" },
                values: new object[] { new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3026), new DateTime(2025, 12, 3, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3023) });

            migrationBuilder.UpdateData(
                table: "ToursSchedule",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AddedDate", "TourStartDate" },
                values: new object[] { new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3031), new DateTime(2025, 12, 13, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3029) });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AddedBy", "AddedDate", "AmountInvoice", "AmountPaid", "BookingId", "Comments", "DateInvoice", "DatePayment", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "PaymentMethodId", "TransactionReference" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3353), 1500m, 1500m, 1, null, new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3345), new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3348), null, null, true, null, null, 1, "TX12345" },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3358), 1200m, null, 2, null, new DateTime(2025, 11, 22, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3355), null, null, null, true, null, null, 2, "TX54321" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");
        }
    }
}
