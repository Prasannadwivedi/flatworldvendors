using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace flatworldvendor.Migrations
{
    public partial class Mig : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partner",
                columns: table => new
                {
                    PartnersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PartnerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistredDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SPOCName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SPOCEmail = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skillset = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TemAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BillAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partner", x => x.PartnersID);
                });

            migrationBuilder.CreateTable(
                name: "ProjectManager",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeName = table.Column<int>(type: "int", nullable: false),
                    JoiningDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Qualification = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Exprience = table.Column<int>(type: "int", nullable: false),
                    Mobile = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProjectManager", x => x.EmployeeId);
                });

            migrationBuilder.CreateTable(
                name: "Requistion",
                columns: table => new
                {
                    ReqId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PotentialId = table.Column<int>(type: "int", nullable: false),
                    Complexity = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClientName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPerson = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProjectManager = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ExpectedStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tenurre = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MinExprience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaxExprience = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Resource = table.Column<int>(type: "int", nullable: false),
                    OpenPosition = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requistion", x => x.ReqId);
                });

            migrationBuilder.CreateTable(
                name: "Resource",
                columns: table => new
                {
                    ResourceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Pincode = table.Column<long>(type: "bigint", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Skills = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Startdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    University = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Language = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Resource", x => x.ResourceId);
                });

            migrationBuilder.CreateTable(
                name: "User1",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Mobile = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Role = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User1", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Partner");

            migrationBuilder.DropTable(
                name: "ProjectManager");

            migrationBuilder.DropTable(
                name: "Requistion");

            migrationBuilder.DropTable(
                name: "Resource");

            migrationBuilder.DropTable(
                name: "User1");
        }
    }
}
