using Microsoft.EntityFrameworkCore.Migrations;

namespace Mob_Killer.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    IdItem = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameItem = table.Column<string>(nullable: false),
                    BaseAttack = table.Column<double>(nullable: false),
                    BonusEvasion = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.IdItem);
                });

            migrationBuilder.CreateTable(
                name: "Monstre",
                columns: table => new
                {
                    IdMonstre = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameMonstre = table.Column<string>(nullable: true),
                    HealthMonste = table.Column<double>(nullable: false),
                    EvasionMonstre = table.Column<double>(nullable: false),
                    AttackMonstre = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monstre", x => x.IdMonstre);
                });

            migrationBuilder.CreateTable(
                name: "Joueur",
                columns: table => new
                {
                    IdJoueur = table.Column<int>(nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    NameJoueur = table.Column<string>(nullable: true),
                    HealthJoueur = table.Column<double>(nullable: false),
                    EvasionJoueur = table.Column<double>(nullable: false),
                    ItemId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Joueur", x => x.IdJoueur);
                    table.ForeignKey(
                        name: "FK_Joueur_Item_ItemId",
                        column: x => x.ItemId,
                        principalTable: "Item",
                        principalColumn: "IdItem",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Joueur_ItemId",
                table: "Joueur",
                column: "ItemId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Joueur");

            migrationBuilder.DropTable(
                name: "Monstre");

            migrationBuilder.DropTable(
                name: "Item");
        }
    }
}
