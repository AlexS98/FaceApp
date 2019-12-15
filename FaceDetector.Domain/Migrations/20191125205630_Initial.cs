﻿using System;

using Microsoft.EntityFrameworkCore.Migrations;

namespace FaceDetector.Domain.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaseUser",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Created = table.Column<DateTime>(nullable: false),
                    CreatedId = table.Column<int>(nullable: false),
                    LastUpdated = table.Column<DateTime>(nullable: false),
                    UpdatedId = table.Column<int>(nullable: false),
                    Discriminator = table.Column<string>(nullable: false),
                    Username = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PasswordHash = table.Column<string>(nullable: true),
                    PasswordSalt = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaseUser", x => x.Id);
                    table.ForeignKey(
                        name: "FK_BaseUser_BaseUser_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "BaseUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_BaseUser_BaseUser_UpdatedId",
                        column: x => x.UpdatedId,
                        principalTable: "BaseUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Faces",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Created = table.Column<DateTime>(nullable: true),
                    CreatedId = table.Column<int>(nullable: true),
                    LastUpdated = table.Column<DateTime>(nullable: true),
                    UpdatedId = table.Column<int>(nullable: true),
                    FileExtension = table.Column<string>(nullable: false),
                    ImageBase64 = table.Column<string>(nullable: false),
                    ImageBase64Length = table.Column<int>(nullable: true),
                    PictureWidth = table.Column<int>(nullable: true),
                    PictureHeight = table.Column<int>(nullable: true),
                    AnalyzeResult = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Faces", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Faces_BaseUser_CreatedId",
                        column: x => x.CreatedId,
                        principalTable: "BaseUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Faces_BaseUser_UpdatedId",
                        column: x => x.UpdatedId,
                        principalTable: "BaseUser",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_BaseUser_CreatedId",
                table: "BaseUser",
                column: "CreatedId",
                unique: true,
                filter: "[CreatedId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_BaseUser_UpdatedId",
                table: "BaseUser",
                column: "UpdatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Faces_CreatedId",
                table: "Faces",
                column: "CreatedId");

            migrationBuilder.CreateIndex(
                name: "IX_Faces_UpdatedId",
                table: "Faces",
                column: "UpdatedId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Faces");

            migrationBuilder.DropTable(
                name: "BaseUser");
        }
    }
}
