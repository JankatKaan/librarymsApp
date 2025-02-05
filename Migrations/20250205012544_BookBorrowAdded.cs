using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace librarymsApp.Migrations
{
    /// <inheritdoc />
    public partial class BookBorrowAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BookBorrows",
                columns: table => new
                {
                    BorrowId = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    BookId = table.Column<int>(type: "INTEGER", nullable: false),
                    MemberId = table.Column<int>(type: "INTEGER", nullable: false),
                    BorrowDate = table.Column<DateTime>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookBorrows", x => x.BorrowId);
                    table.ForeignKey(
                        name: "FK_BookBorrows_Books_BookId",
                        column: x => x.BookId,
                        principalTable: "Books",
                        principalColumn: "BookId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookBorrows_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "MemberId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrows_BookId",
                table: "BookBorrows",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookBorrows_MemberId",
                table: "BookBorrows",
                column: "MemberId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "BookBorrows");
        }
    }
}
