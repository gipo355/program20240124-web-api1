using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ItsWdfs.Csharp._20240124.Program20240124WebApi1.Migrations
{
  /// <inheritdoc />
  public partial class Initial : Migration
  {
    /// <inheritdoc />
    protected override void Up(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.CreateTable(
        name: "Blog",
        columns: table => new
        {
          BlogId = table
            .Column<int>(type: "integer", nullable: false)
            .Annotation(
              "Npgsql:ValueGenerationStrategy",
              NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
            ),
          Url = table.Column<string>(type: "text", nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_Blog", x => x.BlogId);
        }
      );

      migrationBuilder.CreateTable(
        name: "Posts",
        columns: table => new
        {
          PostId = table
            .Column<int>(type: "integer", nullable: false)
            .Annotation(
              "Npgsql:ValueGenerationStrategy",
              NpgsqlValueGenerationStrategy.IdentityByDefaultColumn
            ),
          Title = table.Column<string>(type: "text", nullable: false),
          Content = table.Column<string>(type: "text", nullable: false),
          BlogId = table.Column<int>(type: "integer", nullable: false)
        },
        constraints: table =>
        {
          table.PrimaryKey("PK_Posts", x => x.PostId);
          table.ForeignKey(
            name: "FK_Posts_Blog_BlogId",
            column: x => x.BlogId,
            principalTable: "Blog",
            principalColumn: "BlogId",
            onDelete: ReferentialAction.Cascade
          );
        }
      );

      migrationBuilder.CreateIndex(name: "IX_Posts_BlogId", table: "Posts", column: "BlogId");
    }

    /// <inheritdoc />
    protected override void Down(MigrationBuilder migrationBuilder)
    {
      migrationBuilder.DropTable(name: "Posts");

      migrationBuilder.DropTable(name: "Blog");
    }
  }
}
