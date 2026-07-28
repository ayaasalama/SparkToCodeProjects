using System;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EFCore_Part1_.Migrations
{
    /// <inheritdoc />
    public partial class initialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "departments",
                columns: table => new
                {
                    DepartmentNumber = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DepartmentId = table.Column<int>(type: "int", nullable: false),
                    DepartmentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MsgStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeSsn = table.Column<int>(type: "int", nullable: false),
                    ManageStartDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_departments", x => x.DepartmentNumber);
                });

            migrationBuilder.CreateTable(
                name: "deptLocations",
                columns: table => new
                {
                    DepartmentID = table.Column<int>(type: "int", nullable: false),
                    DepartmentLocation = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_deptLocations", x => new { x.DepartmentID, x.DepartmentLocation });
                    table.ForeignKey(
                        name: "FK_deptLocations_departments_DepartmentID",
                        column: x => x.DepartmentID,
                        principalTable: "departments",
                        principalColumn: "DepartmentNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "employees",
                columns: table => new
                {
                    EmployeeSsn = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EmployeeId = table.Column<int>(type: "int", nullable: false),
                    EmployeeFirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeMinit = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    EmployeeLastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Bdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeSalary = table.Column<double>(type: "float", nullable: false),
                    SupervisorID = table.Column<int>(type: "int", nullable: false),
                    DepartmentNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employees", x => x.EmployeeSsn);
                    table.ForeignKey(
                        name: "FK_employees_departments_DepartmentNumber",
                        column: x => x.DepartmentNumber,
                        principalTable: "departments",
                        principalColumn: "DepartmentNumber",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_employees_employees_SupervisorID",
                        column: x => x.SupervisorID,
                        principalTable: "employees",
                        principalColumn: "EmployeeSsn",
                        onDelete: ReferentialAction.NoAction,
                        onUpdate: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateTable(
                name: "projects",
                columns: table => new
                {
                    ProjectName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProjectNumber = table.Column<int>(type: "int", nullable: false),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    ProjectLocation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DepartmentNumber = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_projects", x => new { x.ProjectNumber, x.ProjectName });
                    table.ForeignKey(
                        name: "FK_projects_departments_DepartmentNumber",
                        column: x => x.DepartmentNumber,
                        principalTable: "departments",
                        principalColumn: "DepartmentNumber",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "dependents",
                columns: table => new
                {
                    DependentName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    EmployeeSsn = table.Column<int>(type: "int", nullable: false),
                    DependentId = table.Column<int>(type: "int", nullable: false),
                    DependentSex = table.Column<string>(type: "nvarchar(1)", nullable: false),
                    DependentBdate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DependentRelationship = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_dependents", x => new { x.EmployeeSsn, x.DependentName });
                    table.ForeignKey(
                        name: "FK_dependents_employees_EmployeeSsn",
                        column: x => x.EmployeeSsn,
                        principalTable: "employees",
                        principalColumn: "EmployeeSsn",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "worksOns",
                columns: table => new
                {
                    EmployeeSsn = table.Column<int>(type: "int", nullable: false),
                    ProjectNumber = table.Column<int>(type: "int", nullable: false),
                    ProjectName = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Hours = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_worksOns", x => new { x.EmployeeSsn, x.ProjectNumber, x.ProjectName });
                    table.ForeignKey(
                        name: "FK_worksOns_employees_EmployeeSsn",
                        column: x => x.EmployeeSsn,
                        principalTable: "employees",
                        principalColumn: "EmployeeSsn",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_worksOns_projects_ProjectNumber_ProjectName",
                        columns: x => new { x.ProjectNumber, x.ProjectName },
                        principalTable: "projects",
                        principalColumns: new[] { "ProjectNumber", "ProjectName" },
                        onDelete: ReferentialAction.NoAction,
                        onUpdate: ReferentialAction.NoAction);
                });

            migrationBuilder.CreateIndex(
                name: "IX_departments_EmployeeSsn",
                table: "departments",
                column: "EmployeeSsn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_dependents_EmployeeSsn",
                table: "dependents",
                column: "EmployeeSsn",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_DepartmentNumber",
                table: "employees",
                column: "DepartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_employees_SupervisorID",
                table: "employees",
                column: "SupervisorID");

            migrationBuilder.CreateIndex(
                name: "IX_projects_DepartmentNumber",
                table: "projects",
                column: "DepartmentNumber");

            migrationBuilder.CreateIndex(
                name: "IX_worksOns_ProjectNumber_ProjectName",
                table: "worksOns",
                columns: new[] { "ProjectNumber", "ProjectName" });

            migrationBuilder.AddForeignKey(
                name: "FK_departments_employees_EmployeeSsn",
                table: "departments",
                column: "EmployeeSsn",
                principalTable: "employees",
                principalColumn: "EmployeeSsn",
                onDelete: ReferentialAction.NoAction,
                onUpdate: ReferentialAction.NoAction);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_departments_employees_EmployeeSsn",
                table: "departments"
            );

            migrationBuilder.DropTable(
                name: "dependents");

            migrationBuilder.DropTable(
                name: "deptLocations");

            migrationBuilder.DropTable(
                name: "worksOns");

            migrationBuilder.DropTable(
                name: "projects");

            migrationBuilder.DropTable(
                name: "employees");

            migrationBuilder.DropTable(
                name: "departments");
        }
    }
}
