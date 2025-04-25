using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Persistance.Data.Migrations
{
    /// <inheritdoc />
    public partial class AddRelations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategoryID",
                table: "Item",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "BidTime",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddColumn<int>(
                name: "Auctionid",
                table: "Bids",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "ItemID",
                table: "Auctions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "adminid",
                table: "Auctions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "sellerid",
                table: "Auctions",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Item_CategoryID",
                table: "Item",
                column: "CategoryID");

            migrationBuilder.CreateIndex(
                name: "IX_buyerPayments_BiddingID",
                table: "buyerPayments",
                column: "BiddingID");

            migrationBuilder.CreateIndex(
                name: "IX_Bids_Auctionid",
                table: "Bids",
                column: "Auctionid");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_adminid",
                table: "Auctions",
                column: "adminid");

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_ItemID",
                table: "Auctions",
                column: "ItemID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Auctions_sellerid",
                table: "Auctions",
                column: "sellerid");

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Admins_adminid",
                table: "Auctions",
                column: "adminid",
                principalTable: "Admins",
                principalColumn: "AdminID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Item_ItemID",
                table: "Auctions",
                column: "ItemID",
                principalTable: "Item",
                principalColumn: "ItemID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Auctions_Seller_sellerid",
                table: "Auctions",
                column: "sellerid",
                principalTable: "Seller",
                principalColumn: "SellerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Bids_Auctions_Auctionid",
                table: "Bids",
                column: "Auctionid",
                principalTable: "Auctions",
                principalColumn: "AuctionID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_buyerPayments_Bids_BiddingID",
                table: "buyerPayments",
                column: "BiddingID",
                principalTable: "Bids",
                principalColumn: "BiddingID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_buyerPayments_Buyer_BuyerId",
                table: "buyerPayments",
                column: "BuyerId",
                principalTable: "Buyer",
                principalColumn: "BuyerID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Item_Category_CategoryID",
                table: "Item",
                column: "CategoryID",
                principalTable: "Category",
                principalColumn: "CategoryID",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Admins_adminid",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Item_ItemID",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Auctions_Seller_sellerid",
                table: "Auctions");

            migrationBuilder.DropForeignKey(
                name: "FK_Bids_Auctions_Auctionid",
                table: "Bids");

            migrationBuilder.DropForeignKey(
                name: "FK_buyerPayments_Bids_BiddingID",
                table: "buyerPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_buyerPayments_Buyer_BuyerId",
                table: "buyerPayments");

            migrationBuilder.DropForeignKey(
                name: "FK_Item_Category_CategoryID",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_Item_CategoryID",
                table: "Item");

            migrationBuilder.DropIndex(
                name: "IX_buyerPayments_BiddingID",
                table: "buyerPayments");

            migrationBuilder.DropIndex(
                name: "IX_Bids_Auctionid",
                table: "Bids");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_adminid",
                table: "Auctions");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_ItemID",
                table: "Auctions");

            migrationBuilder.DropIndex(
                name: "IX_Auctions_sellerid",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "CategoryID",
                table: "Item");

            migrationBuilder.DropColumn(
                name: "Auctionid",
                table: "Bids");

            migrationBuilder.DropColumn(
                name: "ItemID",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "adminid",
                table: "Auctions");

            migrationBuilder.DropColumn(
                name: "sellerid",
                table: "Auctions");

            migrationBuilder.AlterColumn<DateTime>(
                name: "BidTime",
                table: "Bids",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");
        }
    }
}
