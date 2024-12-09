using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MacWebApi.Migrations
{
    /// <inheritdoc />
    public partial class ADDIsDeliveryFieldForOrder : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<bool>(
                name: "IsDelivery",
                table: "Orders",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDelivery",
                table: "Orders");
        }
    }
}
