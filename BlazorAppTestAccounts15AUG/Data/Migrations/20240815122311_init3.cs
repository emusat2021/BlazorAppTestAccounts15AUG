using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorAppTestAccounts15AUG.Migrations
{
    /// <inheritdoc />
    public partial class init3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebPage_WebSite_WebSiteId",
                table: "WebPage");

            migrationBuilder.AlterColumn<int>(
                name: "WebSiteId",
                table: "WebPage",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_WebPage_WebSite_WebSiteId",
                table: "WebPage",
                column: "WebSiteId",
                principalTable: "WebSite",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_WebPage_WebSite_WebSiteId",
                table: "WebPage");

            migrationBuilder.AlterColumn<int>(
                name: "WebSiteId",
                table: "WebPage",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_WebPage_WebSite_WebSiteId",
                table: "WebPage",
                column: "WebSiteId",
                principalTable: "WebSite",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
