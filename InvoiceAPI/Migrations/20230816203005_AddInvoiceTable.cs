using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InvoiceAPI.Migrations
{
    /// <inheritdoc />
    public partial class AddInvoiceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Invoices",
                columns: table => new
                {
                    UUID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DatumVytvoreni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumPosledniVyzvy = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Castka = table.Column<double>(type: "float", nullable: false),
                    JmenoDodavatele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IcoDodavatele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    JmenoOdberatele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IcoOdberatele = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatumVystaveni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumSplatnosti = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DatumUskutecneniPlneni = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FormaUhrady = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Invoices", x => x.UUID);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Invoices");
        }
    }
}
