using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SolutionReact.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Activities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ActivityName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    MinimumAge = table.Column<int>(type: "int", nullable: true),
                    MaximumAge = table.Column<int>(type: "int", nullable: true),
                    AdditionalRequirements = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationInMinutes = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    PhoneNumberExtra = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Destination",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Country = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Region = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    City = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PaymentMethods",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentMethods", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "StatusOfEntities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusName = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    StatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StatusOfEntities", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tours",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DestinationId = table.Column<int>(type: "int", nullable: false),
                    LengthInDays = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    MaxParticipants = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Destination_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TourActivities",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    ActivityId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DayScheduled = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourActivities", x => x.Id);
                    table.ForeignKey(
                        name: "FK_TourActivities_Activities_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourActivities_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ToursSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    TourStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourStatusId = table.Column<int>(type: "int", nullable: false),
                    AvailablePax = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToursSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToursSchedule_StatusOfEntities_TourStatusId",
                        column: x => x.TourStatusId,
                        principalTable: "StatusOfEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ToursSchedule_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    CustomTourScheduleId = table.Column<int>(type: "int", nullable: false),
                    NoPax = table.Column<int>(type: "int", nullable: false),
                    TotalPrice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    BookingStatusId = table.Column<int>(type: "int", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_StatusOfEntities_BookingStatusId",
                        column: x => x.BookingStatusId,
                        principalTable: "StatusOfEntities",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Bookings_ToursSchedule_CustomTourScheduleId",
                        column: x => x.CustomTourScheduleId,
                        principalTable: "ToursSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "BookingsParticipant",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingsParticipant", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BookingsParticipant_Bookings_BookingId",
                        column: x => x.BookingId,
                        principalTable: "Bookings",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingsParticipant_Customers_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    DateInvoice = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountInvoice = table.Column<decimal>(type: "decimal(10,2)", nullable: false),
                    DatePayment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "decimal(10,2)", nullable: true),
                    PaymentMethodId = table.Column<int>(type: "int", nullable: false),
                    TransactionReference = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true)
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

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityName", "AddedBy", "AddedDate", "AdditionalRequirements", "Comments", "DeletedBy", "DeletedDate", "Description", "DurationInMinutes", "IsActive", "MaximumAge", "MinimumAge", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Sightseeing", "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2997), "Swimming Certificate", null, null, null, "Visit famous landmarks", 120, true, null, null, null, null },
                    { 2, "Hiking", "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3000), "None", null, null, null, "Mountain trek", 180, true, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddedBy", "AddedDate", "City", "Comments", "Country", "DateOfBirth", "DeletedBy", "DeletedDate", "EmailAddress", "FirstName", "HomeAddress", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "PhoneNumber", "PhoneNumberExtra", "PostCode" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3064), "Paris", null, "France", new DateTime(1990, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "alice.johnson@example.com", "Alice", "789 Elm St", true, "Johnson", null, null, "555-1234", null, "12345" },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3069), "Florence", null, "Italy", new DateTime(1988, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "bob.williams@example.com", "Bob", "456 Oak Ave", true, "Williams", null, null, "555-5678", null, "67890" }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "AddedBy", "AddedDate", "City", "Comments", "Country", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Region" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2930), "Paris", null, "France", null, null, true, null, null, "Ile-de-France" },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2933), "Florence", null, "Italy", null, null, true, null, null, "Tuscany" }
                });

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

            migrationBuilder.InsertData(
                table: "StatusOfEntities",
                columns: new[] { "Id", "AddedBy", "AddedDate", "Comments", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "StatusDescription", "StatusName" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2893), null, null, null, true, null, null, "Pending confirmation", "Pending" },
                    { 2, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2897), null, null, null, true, null, null, "Confirmed", "Confirmed" },
                    { 3, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2899), null, null, null, true, null, null, "Cancelled", "Cancelled" },
                    { 4, "System", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2902), null, null, null, true, null, null, "Completed", "Completed" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "AddedBy", "AddedDate", "Comments", "DeletedBy", "DeletedDate", "Description", "DestinationId", "IsActive", "LengthInDays", "MaxParticipants", "ModifiedBy", "ModifiedDate", "Price", "TourCode" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2966), null, null, null, null, 1, true, 7, 20, null, null, 1500m, "ADV-001" },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(2970), null, null, null, null, 2, true, 5, 15, null, null, 1200m, "CUL-001" }
                });

            migrationBuilder.InsertData(
                table: "TourActivities",
                columns: new[] { "Id", "ActivityId", "AddedBy", "AddedDate", "Comments", "DayScheduled", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "TourId" },
                values: new object[,]
                {
                    { 1, 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3381), null, null, null, null, true, null, null, 1 },
                    { 2, 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3384), null, null, null, null, true, null, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ToursSchedule",
                columns: new[] { "Id", "AddedBy", "AddedDate", "AvailablePax", "Comments", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "TourId", "TourStartDate", "TourStatusId" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3026), 0, null, null, null, true, null, null, 1, new DateTime(2025, 12, 3, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3023), 2 },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3031), 0, null, null, null, true, null, null, 2, new DateTime(2025, 12, 13, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3029), 1 }
                });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BookingDate", "BookingStatusId", "Comments", "CustomTourScheduleId", "CustomerId", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "NoPax", "TotalPrice" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3095), new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3092), 2, null, 1, 1, null, null, true, null, null, 2, 3000m },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3099), new DateTime(2025, 11, 22, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3098), 1, null, 2, 2, null, null, true, null, null, 1, 1200m }
                });

            migrationBuilder.InsertData(
                table: "BookingsParticipant",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BookingId", "Comments", "CustomerId", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3410), 1, null, 1, null, null, true, null, null },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3412), 1, null, 2, null, null, true, null, null }
                });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AddedBy", "AddedDate", "AmountInvoice", "AmountPaid", "BookingId", "Comments", "DateInvoice", "DatePayment", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "PaymentMethodId", "TransactionReference" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3353), 1500m, 1500m, 1, null, new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3345), new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3348), null, null, true, null, null, 1, "TX12345" },
                    { 2, "Admin", new DateTime(2025, 11, 23, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3358), 1200m, null, 2, null, new DateTime(2025, 11, 22, 22, 0, 34, 484, DateTimeKind.Local).AddTicks(3355), null, null, null, true, null, null, 2, "TX54321" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BookingStatusId",
                table: "Bookings",
                column: "BookingStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomerId",
                table: "Bookings",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_CustomTourScheduleId",
                table: "Bookings",
                column: "CustomTourScheduleId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingsParticipant_BookingId",
                table: "BookingsParticipant",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingsParticipant_CustomerId",
                table: "BookingsParticipant",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_BookingId",
                table: "Payments",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_PaymentMethodId",
                table: "Payments",
                column: "PaymentMethodId");

            migrationBuilder.CreateIndex(
                name: "IX_TourActivities_ActivityId",
                table: "TourActivities",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_TourActivities_TourId",
                table: "TourActivities",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Tours_DestinationId",
                table: "Tours",
                column: "DestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_ToursSchedule_TourId",
                table: "ToursSchedule",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_ToursSchedule_TourStatusId",
                table: "ToursSchedule",
                column: "TourStatusId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookingsParticipant");

            migrationBuilder.DropTable(
                name: "Payments");

            migrationBuilder.DropTable(
                name: "TourActivities");

            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "PaymentMethods");

            migrationBuilder.DropTable(
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ToursSchedule");

            migrationBuilder.DropTable(
                name: "StatusOfEntities");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Destination");
        }
    }
}
