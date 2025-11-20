using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SolutionReact.Server.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
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
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinimumAge = table.Column<int>(type: "int", nullable: true),
                    MaximumAge = table.Column<int>(type: "int", nullable: true),
                    FitnessLevel = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberExtra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Region = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Destination", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumberExtra = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HomeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HiredFrom = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HiredUntil = table.Column<DateTime>(type: "datetime2", nullable: true),
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
                    table.PrimaryKey("PK_Guides", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Hotel",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EMailAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CheckInTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    CheckOutTime = table.Column<TimeSpan>(type: "time", nullable: false),
                    HotelType = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hotel", x => x.Id);
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
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaxParticipants = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TourCode = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tours", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tours_Destination_DestinationId",
                        column: x => x.DestinationId,
                        principalTable: "Destination",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourActivities_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ToursSchedule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TourId = table.Column<int>(type: "int", nullable: false),
                    GuideId = table.Column<int>(type: "int", nullable: true),
                    HotelId = table.Column<int>(type: "int", nullable: true),
                    FlightDepartureId = table.Column<int>(type: "int", nullable: true),
                    FlightReturnId = table.Column<int>(type: "int", nullable: true),
                    TourStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    AddedBy = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AddedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ModifiedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    DeletedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Comments = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AvailablePax = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ToursSchedule", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ToursSchedule_Guides_GuideId",
                        column: x => x.GuideId,
                        principalTable: "Guides",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ToursSchedule_Hotel_HotelId",
                        column: x => x.HotelId,
                        principalTable: "Hotel",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ToursSchedule_Tours_TourId",
                        column: x => x.TourId,
                        principalTable: "Tours",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                    TotalPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BookingStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Bookings_ToursSchedule_CustomTourScheduleId",
                        column: x => x.CustomTourScheduleId,
                        principalTable: "ToursSchedule",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingId = table.Column<int>(type: "int", nullable: false),
                    DateInvoice = table.Column<DateTime>(type: "datetime2", nullable: false),
                    AmountInvoice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    DatePayment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AmountPaid = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    PaymentMethod = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionReference = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                });

            migrationBuilder.InsertData(
                table: "Activities",
                columns: new[] { "Id", "ActivityName", "AddedBy", "AddedDate", "Comments", "DeletedBy", "DeletedDate", "Description", "DurationInMinutes", "FitnessLevel", "IsActive", "MaximumAge", "MinimumAge", "ModifiedBy", "ModifiedDate" },
                values: new object[,]
                {
                    { 1, "Sightseeing", "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3306), null, null, null, "Visit famous landmarks", 120, "Low", true, null, null, null, null },
                    { 2, "Hiking", "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3309), null, null, null, "Mountain trek", 180, "High", true, null, null, null, null }
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "Id", "AddedBy", "AddedDate", "City", "Comments", "Country", "DateOfBirth", "DeletedBy", "DeletedDate", "EmailAddress", "FirstName", "HomeAddress", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "PhoneNumber", "PhoneNumberExtra", "PostCode" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3417), "Paris", null, "France", new DateTime(1990, 7, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "alice.johnson@example.com", "Alice", "789 Elm St", true, "Johnson", null, null, "555-1234", null, "12345" },
                    { 2, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3422), "Florence", null, "Italy", new DateTime(1988, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "bob.williams@example.com", "Bob", "456 Oak Ave", true, "Williams", null, null, "555-5678", null, "67890" }
                });

            migrationBuilder.InsertData(
                table: "Destination",
                columns: new[] { "Id", "AddedBy", "AddedDate", "City", "Comments", "Country", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "Region", "TimeZone" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3084), "Paris", null, "France", null, null, true, null, null, "Ile-de-France", null },
                    { 2, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3134), "Florence", null, "Italy", null, null, true, null, null, "Tuscany", null }
                });

            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "Id", "AddedBy", "AddedDate", "City", "Comments", "Country", "DateOfBirth", "DeletedBy", "DeletedDate", "EmailAddress", "FirstName", "HiredFrom", "HiredUntil", "HomeAddress", "IsActive", "LastName", "ModifiedBy", "ModifiedDate", "PhoneNumber", "PhoneNumberExtra", "PostCode" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3330), "", null, "", new DateTime(1980, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "john.doe@example.com", "John", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3332), null, "", true, "Doe", null, null, "123-456-7890", null, "" },
                    { 2, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3335), "", null, "", new DateTime(1985, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, "jane.smith@example.com", "Jane", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3337), null, "", true, "Smith", null, null, "987-654-3210", null, "" }
                });

            migrationBuilder.InsertData(
                table: "Hotel",
                columns: new[] { "Id", "AddedBy", "AddedDate", "Address", "CheckInTime", "CheckOutTime", "City", "Comments", "Country", "DeletedBy", "DeletedDate", "EMailAddress", "HotelType", "IsActive", "ModifiedBy", "ModifiedDate", "Name", "PhoneNumber", "PostCode" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3363), "123 Champs-Elysees", new TimeSpan(0, 14, 0, 0, 0), new TimeSpan(0, 11, 0, 0, 0), "Paris", null, "France", null, null, "contact@hotelparis.com", "Luxury", true, null, null, "Hotel Paris", "123-456-7890", "75008" },
                    { 2, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3367), "456 Via Firenze", new TimeSpan(0, 15, 0, 0, 0), new TimeSpan(0, 10, 0, 0, 0), "Florence", null, "Italy", null, null, "info@florenceinn.com", "Boutique", true, null, null, "Florence Inn", "987-654-3210", "50123" }
                });

            migrationBuilder.InsertData(
                table: "Tours",
                columns: new[] { "Id", "AddedBy", "AddedDate", "Comments", "DeletedBy", "DeletedDate", "Description", "DestinationId", "IsActive", "LengthInDays", "MaxParticipants", "ModifiedBy", "ModifiedDate", "Price", "TourCode", "TourType" },
                values: new object[,]
                {
                    { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3279), null, null, null, null, 1, true, 7, 20, null, null, 1500m, "ADV-001", "Adventure" },
                    { 2, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3283), null, null, null, null, 2, true, 5, 15, null, null, 1200m, "CUL-001", "Cultural" }
                });

            migrationBuilder.InsertData(
                table: "ToursSchedule",
                columns: new[] { "Id", "AddedBy", "AddedDate", "AvailablePax", "Comments", "DeletedBy", "DeletedDate", "FlightDepartureId", "FlightReturnId", "GuideId", "HotelId", "IsActive", "ModifiedBy", "ModifiedDate", "TourId", "TourStartDate", "TourStatus" },
                values: new object[] { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3470), 0, null, null, null, 1, 1, 1, 1, true, null, null, 1, new DateTime(2025, 11, 24, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3466), "" });

            migrationBuilder.InsertData(
                table: "Bookings",
                columns: new[] { "Id", "AddedBy", "AddedDate", "BookingDate", "BookingStatus", "Comments", "CustomTourScheduleId", "CustomerId", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "NoPax", "TotalPrice" },
                values: new object[] { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3445), new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3443), "Confirmed", null, 1, 1, null, null, true, null, null, 2, 3000m });

            migrationBuilder.InsertData(
                table: "Payments",
                columns: new[] { "Id", "AddedBy", "AddedDate", "AmountInvoice", "AmountPaid", "BookingId", "Comments", "DateInvoice", "DatePayment", "DeletedBy", "DeletedDate", "IsActive", "ModifiedBy", "ModifiedDate", "PaymentMethod", "TransactionReference" },
                values: new object[] { 1, "Admin", new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3396), 1500m, 1500m, 1, null, new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3385), new DateTime(2025, 11, 19, 18, 39, 53, 997, DateTimeKind.Local).AddTicks(3389), null, null, true, null, null, "Credit Card", "TX12345" });

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
                name: "IX_ToursSchedule_GuideId",
                table: "ToursSchedule",
                column: "GuideId");

            migrationBuilder.CreateIndex(
                name: "IX_ToursSchedule_HotelId",
                table: "ToursSchedule",
                column: "HotelId");

            migrationBuilder.CreateIndex(
                name: "IX_ToursSchedule_TourId",
                table: "ToursSchedule",
                column: "TourId");
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
                name: "Activities");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "ToursSchedule");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropTable(
                name: "Hotel");

            migrationBuilder.DropTable(
                name: "Tours");

            migrationBuilder.DropTable(
                name: "Destination");
        }
    }
}
