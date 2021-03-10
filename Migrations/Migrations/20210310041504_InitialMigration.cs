using Microsoft.EntityFrameworkCore.Migrations;
using MySql.Data.EntityFrameworkCore.Metadata;

namespace Migrations.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Boards",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    BoardName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Boards", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PassingYears",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    Year = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PassingYears", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Programss",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    ProgramName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Programss", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Students",
                columns: table => new
                {
                    id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    FullName = table.Column<string>(nullable: true),
                    ProgramsId = table.Column<int>(nullable: false),
                    ImagePath = table.Column<string>(nullable: true),
                    FatherName = table.Column<string>(nullable: true),
                    MotherName = table.Column<string>(nullable: true),
                    GuardianName = table.Column<string>(nullable: true),
                    ContactNo = table.Column<string>(nullable: true),
                    GuardianContactNo = table.Column<string>(nullable: true),
                    NationalId = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PresentAddress = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Students", x => x.id);
                    table.ForeignKey(
                        name: "FK_Students_Programss_ProgramsId",
                        column: x => x.ProgramsId,
                        principalTable: "Programss",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AcademicInfos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    StudentId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcademicInfos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AcademicInfos_Students_StudentId",
                        column: x => x.StudentId,
                        principalTable: "Students",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ExamTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    AcademicInfoID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExamTypes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExamTypes_AcademicInfos_AcademicInfoID",
                        column: x => x.AcademicInfoID,
                        principalTable: "AcademicInfos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "HscEquivalents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    HscExamNames = table.Column<int>(nullable: false),
                    RegNumber = table.Column<string>(nullable: true),
                    PassingYearId = table.Column<int>(nullable: true),
                    BoardId = table.Column<int>(nullable: true),
                    GPA = table.Column<float>(nullable: false),
                    ExamTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HscEquivalents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_HscEquivalents_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_HscEquivalents_ExamTypes_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HscEquivalents_PassingYears_PassingYearId",
                        column: x => x.PassingYearId,
                        principalTable: "PassingYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SscEquivalents",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:ValueGenerationStrategy", MySQLValueGenerationStrategy.IdentityColumn),
                    SscExamNames = table.Column<int>(nullable: false),
                    RegNumber = table.Column<string>(nullable: true),
                    PassingYearId = table.Column<int>(nullable: true),
                    BoardId = table.Column<int>(nullable: true),
                    GPA = table.Column<float>(nullable: false),
                    ExamTypeId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SscEquivalents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_SscEquivalents_Boards_BoardId",
                        column: x => x.BoardId,
                        principalTable: "Boards",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_SscEquivalents_ExamTypes_ExamTypeId",
                        column: x => x.ExamTypeId,
                        principalTable: "ExamTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SscEquivalents_PassingYears_PassingYearId",
                        column: x => x.PassingYearId,
                        principalTable: "PassingYears",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AcademicInfos_StudentId",
                table: "AcademicInfos",
                column: "StudentId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExamTypes_AcademicInfoID",
                table: "ExamTypes",
                column: "AcademicInfoID",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HscEquivalents_BoardId",
                table: "HscEquivalents",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_HscEquivalents_ExamTypeId",
                table: "HscEquivalents",
                column: "ExamTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_HscEquivalents_PassingYearId",
                table: "HscEquivalents",
                column: "PassingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_SscEquivalents_BoardId",
                table: "SscEquivalents",
                column: "BoardId");

            migrationBuilder.CreateIndex(
                name: "IX_SscEquivalents_ExamTypeId",
                table: "SscEquivalents",
                column: "ExamTypeId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SscEquivalents_PassingYearId",
                table: "SscEquivalents",
                column: "PassingYearId");

            migrationBuilder.CreateIndex(
                name: "IX_Students_ProgramsId",
                table: "Students",
                column: "ProgramsId",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HscEquivalents");

            migrationBuilder.DropTable(
                name: "SscEquivalents");

            migrationBuilder.DropTable(
                name: "Boards");

            migrationBuilder.DropTable(
                name: "ExamTypes");

            migrationBuilder.DropTable(
                name: "PassingYears");

            migrationBuilder.DropTable(
                name: "AcademicInfos");

            migrationBuilder.DropTable(
                name: "Students");

            migrationBuilder.DropTable(
                name: "Programss");
        }
    }
}
