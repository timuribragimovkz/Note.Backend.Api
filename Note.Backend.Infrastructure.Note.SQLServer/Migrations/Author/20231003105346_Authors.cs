﻿using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Note.Backend.Infrastructure.SQLServer.Migrations.Author
{
    /// <inheritdoc />
    public partial class Authors : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
           migrationBuilder.CreateTable(
           name: "AuthorData",
           columns: table => new
           {
               Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
               Name = table.Column<string>(type: "nvarchar(255)", nullable: true)
           },
           constraints: table =>
           {
               table.PrimaryKey("PK_AuthorData", x => x.Id);
           });

        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "AuthorData");
        }
    }
}
