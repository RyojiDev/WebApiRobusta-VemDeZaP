using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace VemDeZap.Infra.Migrations
{
    public partial class criandotables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    FirstName = table.Column<string>(maxLength: 150, nullable: false),
                    Email = table.Column<string>(maxLength: 200, nullable: false),
                    Password = table.Column<string>(maxLength: 36, nullable: false),
                    LastName = table.Column<string>(maxLength: 150, nullable: false),
                    DateRegister = table.Column<DateTime>(nullable: false),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Campaign",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    IdUsuario = table.Column<Guid>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Campaign", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Campaign_User_IdUsuario",
                        column: x => x.IdUsuario,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdUser = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: false),
                    Phone = table.Column<int>(maxLength: 50, nullable: false),
                    Niche = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contact", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Contact_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdUser = table.Column<Guid>(nullable: true),
                    Name = table.Column<string>(maxLength: 150, nullable: true),
                    Niche = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_User_IdUser",
                        column: x => x.IdUser,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Send",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    IdCampaign = table.Column<Guid>(nullable: true),
                    IdGroup = table.Column<Guid>(nullable: true),
                    IdContact = table.Column<Guid>(nullable: true),
                    Sent = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Send", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Send_Campaign_IdCampaign",
                        column: x => x.IdCampaign,
                        principalTable: "Campaign",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Send_Contact_IdContact",
                        column: x => x.IdContact,
                        principalTable: "Contact",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Send_Group_IdGroup",
                        column: x => x.IdGroup,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Campaign_IdUsuario",
                table: "Campaign",
                column: "IdUsuario");

            migrationBuilder.CreateIndex(
                name: "IX_Contact_IdUser",
                table: "Contact",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Group_IdUser",
                table: "Group",
                column: "IdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Send_IdCampaign",
                table: "Send",
                column: "IdCampaign");

            migrationBuilder.CreateIndex(
                name: "IX_Send_IdContact",
                table: "Send",
                column: "IdContact");

            migrationBuilder.CreateIndex(
                name: "IX_Send_IdGroup",
                table: "Send",
                column: "IdGroup");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Send");

            migrationBuilder.DropTable(
                name: "Campaign");

            migrationBuilder.DropTable(
                name: "Contact");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "User");
        }
    }
}
