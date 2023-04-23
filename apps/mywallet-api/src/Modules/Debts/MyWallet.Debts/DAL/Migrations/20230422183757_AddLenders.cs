using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace MyWallet.Debts.DAL.Migrations
{
    public partial class AddLenders : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "id",
                schema: "debts",
                table: "loans",
                newName: "loan_id");

            migrationBuilder.AddColumn<int>(
                name: "lender_id",
                schema: "debts",
                table: "loans",
                type: "integer",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "lenders",
                schema: "debts",
                columns: table => new
                {
                    lender_id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_lenders", x => x.lender_id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_loans_lender_id",
                schema: "debts",
                table: "loans",
                column: "lender_id");

            migrationBuilder.AddForeignKey(
                name: "FK_loans_lenders_lender_id",
                schema: "debts",
                table: "loans",
                column: "lender_id",
                principalSchema: "debts",
                principalTable: "lenders",
                principalColumn: "lender_id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_loans_lenders_lender_id",
                schema: "debts",
                table: "loans");

            migrationBuilder.DropTable(
                name: "lenders",
                schema: "debts");

            migrationBuilder.DropIndex(
                name: "IX_loans_lender_id",
                schema: "debts",
                table: "loans");

            migrationBuilder.DropColumn(
                name: "lender_id",
                schema: "debts",
                table: "loans");

            migrationBuilder.RenameColumn(
                name: "loan_id",
                schema: "debts",
                table: "loans",
                newName: "id");
        }
    }
}
