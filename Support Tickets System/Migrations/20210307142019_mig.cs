using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Support_Tickets_System.Migrations
{
    public partial class mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ClientsType",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NameType = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ClientsType", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Clients",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    ClientTypeId = table.Column<int>(type: "int", nullable: false),
                    ClientAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Clients", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Clients_ClientsType_ClientTypeId",
                        column: x => x.ClientTypeId,
                        principalTable: "ClientsType",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Tickets",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClientId = table.Column<int>(type: "int", nullable: false),
                    TicketName = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    TicketNumber = table.Column<int>(type: "int", nullable: false),
                    TicketType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreationDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tickets", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Tickets_Clients_ClientId",
                        column: x => x.ClientId,
                        principalTable: "Clients",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ClientsType",
                columns: new[] { "ID", "NameType" },
                values: new object[] { 1, "Admin" });

            migrationBuilder.InsertData(
                table: "ClientsType",
                columns: new[] { "ID", "NameType" },
                values: new object[] { 2, "Client" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "ClientAddress", "ClientName", "ClientPhone", "ClientTypeId", "CreationDate", "Password", "UserName" },
                values: new object[] { 1, "jenin", "Admin", "059538212", 1, new DateTime(2021, 3, 7, 16, 20, 19, 45, DateTimeKind.Local).AddTicks(8254), "123456", "admin" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "ClientAddress", "ClientName", "ClientPhone", "ClientTypeId", "CreationDate", "Password", "UserName" },
                values: new object[] { 2, "jenin", "Areej haj", "059538212", 2, new DateTime(2021, 3, 7, 16, 20, 19, 51, DateTimeKind.Local).AddTicks(7060), "123456", "areej77" });

            migrationBuilder.InsertData(
                table: "Clients",
                columns: new[] { "ID", "ClientAddress", "ClientName", "ClientPhone", "ClientTypeId", "CreationDate", "Password", "UserName" },
                values: new object[] { 3, "tulkarm", "Ahmad haj", "059538212", 2, new DateTime(2021, 3, 7, 16, 20, 19, 51, DateTimeKind.Local).AddTicks(7185), "123456", "ahmad11h" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "ID", "ClientId", "CreationDate", "EndDate", "Note", "StartDate", "TicketName", "TicketNumber", "TicketType" },
                values: new object[] { 1, 2, new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(5595), new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(6081), "vip", new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(6544), "Franch", 100001, "Round-trip" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "ID", "ClientId", "CreationDate", "EndDate", "Note", "StartDate", "TicketName", "TicketNumber", "TicketType" },
                values: new object[] { 2, 2, new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(8489), new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(8515), "vip", new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(8527), "jordan", 100002, "Round-trip" });

            migrationBuilder.InsertData(
                table: "Tickets",
                columns: new[] { "ID", "ClientId", "CreationDate", "EndDate", "Note", "StartDate", "TicketName", "TicketNumber", "TicketType" },
                values: new object[] { 3, 3, new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(8575), new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(8578), "normal", new DateTime(2021, 3, 7, 16, 20, 19, 54, DateTimeKind.Local).AddTicks(8581), "iraq", 100003, "On way only" });

            migrationBuilder.CreateIndex(
                name: "IX_Clients_ClientTypeId",
                table: "Clients",
                column: "ClientTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Clients_UserName",
                table: "Clients",
                column: "UserName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ClientsType_NameType",
                table: "ClientsType",
                column: "NameType",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_ClientId",
                table: "Tickets",
                column: "ClientId");

            migrationBuilder.CreateIndex(
                name: "IX_Tickets_TicketNumber",
                table: "Tickets",
                column: "TicketNumber",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tickets");

            migrationBuilder.DropTable(
                name: "Clients");

            migrationBuilder.DropTable(
                name: "ClientsType");
        }
    }
}
