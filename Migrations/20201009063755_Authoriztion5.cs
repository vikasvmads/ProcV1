using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Procuerment.Migrations
{
    public partial class Authoriztion5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BaselineType",
                columns: table => new
                {
                    BaselineID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BaselineType", x => x.BaselineID);
                });

            migrationBuilder.CreateTable(
                name: "CompanyCode",
                columns: table => new
                {
                    POCompanyCode = table.Column<int>(nullable: false),
                    POCompanyName = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("CompanyCode_pk", x => x.POCompanyCode);
                });

            migrationBuilder.CreateTable(
                name: "FinancialStatementArea",
                columns: table => new
                {
                    FinancialStatementAreaID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FinancialStatementArea", x => x.FinancialStatementAreaID);
                });

            migrationBuilder.CreateTable(
                name: "InitiativeStatus",
                columns: table => new
                {
                    InitiativeStatusId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InitiativeStatus", x => x.InitiativeStatusId);
                });

            migrationBuilder.CreateTable(
                name: "MaterialGroup",
                columns: table => new
                {
                    UnspscMaterial = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MaterialGroup_pk", x => x.UnspscMaterial);
                });

            migrationBuilder.CreateTable(
                name: "MaterialGroupDesccription",
                columns: table => new
                {
                    MaterialType = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    MaterialTypeDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MaterialGroupDesccription_pk", x => x.MaterialType);
                });

            migrationBuilder.CreateTable(
                name: "MaterialMater",
                columns: table => new
                {
                    MaterialId = table.Column<int>(nullable: false),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    MaterialType = table.Column<string>(unicode: false, maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("MaterialMater_pk", x => x.MaterialId);
                });

            migrationBuilder.CreateTable(
                name: "MilestoneStatus",
                columns: table => new
                {
                    MilestoneStatusID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MilestoneStatus", x => x.MilestoneStatusID);
                });

            migrationBuilder.CreateTable(
                name: "Period",
                columns: table => new
                {
                    PeriodID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Period", x => x.PeriodID);
                });

            migrationBuilder.CreateTable(
                name: "PlantName",
                columns: table => new
                {
                    PlantId = table.Column<int>(nullable: false),
                    PlantName = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PlantName_pk", x => x.PlantId);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseOrganization",
                columns: table => new
                {
                    PurchaseOrganization = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    OrganizationDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PurchaseOrganization_pk", x => x.PurchaseOrganization);
                });

            migrationBuilder.CreateTable(
                name: "Role",
                columns: table => new
                {
                    RoleId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleName = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    MODIFY_DATE = table.Column<DateTime>(nullable: false),
                    ROWSTATE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Role", x => x.RoleId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    RoleID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.RoleID);
                });

            migrationBuilder.CreateTable(
                name: "Supplier",
                columns: table => new
                {
                    VendorId = table.Column<int>(nullable: false),
                    VendorName = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    VendorType = table.Column<string>(unicode: false, maxLength: 100, nullable: false),
                    VendorCountry = table.Column<string>(unicode: false, maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Supplier_pk", x => x.VendorId);
                });

            migrationBuilder.CreateTable(
                name: "UserInfo",
                columns: table => new
                {
                    UserId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    MODIFY_DATE = table.Column<DateTime>(nullable: false),
                    MODIFY_BY = table.Column<string>(nullable: true),
                    ROWSTATE = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserInfo", x => x.UserId);
                });

            migrationBuilder.CreateTable(
                name: "ValueContribution",
                columns: table => new
                {
                    ValueContributionID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueContribution", x => x.ValueContributionID);
                });

            migrationBuilder.CreateTable(
                name: "ValueLever",
                columns: table => new
                {
                    ValueLeverID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Description = table.Column<string>(unicode: false, maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ValueLever", x => x.ValueLeverID);
                });

            migrationBuilder.CreateTable(
                name: "UserRoleMapping",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<int>(nullable: false),
                    UserId = table.Column<int>(nullable: false),
                    MODIFY_BY = table.Column<string>(nullable: true),
                    CreatedDate = table.Column<DateTime>(nullable: true),
                    MODIFY_DATE = table.Column<DateTime>(nullable: true),
                    ROWSTATE = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoleMapping", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserRoleMapping_Role_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Role",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoleMapping_UserInfo_UserId",
                        column: x => x.UserId,
                        principalTable: "UserInfo",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "procurement",
                columns: table => new
                {
                    ProcurementID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InitiativeTitle = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    InitiativeDescription = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    BaselineID = table.Column<int>(nullable: false),
                    ValueLeverID = table.Column<int>(nullable: false),
                    Methods = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    LeverDescription = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    PriceIncrease = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Discountgiven = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    MaterialSubstitution = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    VolumeIncrease = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    CurrencyImpact = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    IndexsavingConsideration = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    InitiativeStatusId = table.Column<int>(nullable: false),
                    ValueContributionID = table.Column<int>(nullable: false),
                    FinancialStatementAreaID = table.Column<int>(nullable: false),
                    RoleID = table.Column<int>(nullable: false),
                    PeriodID = table.Column<int>(nullable: false),
                    Material = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    PurchaseOrganization = table.Column<string>(unicode: false, maxLength: 4, nullable: false),
                    Division = table.Column<string>(unicode: false, maxLength: 2, nullable: false),
                    MilestoneStatusID = table.Column<int>(nullable: false),
                    MilestoneDescription = table.Column<string>(unicode: false, maxLength: 50, nullable: false),
                    MilestoneStartdatemilestone = table.Column<DateTime>(type: "datetime", nullable: false),
                    MilestonePlannedDuedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MilestoneActualDuedate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Milestonestatuspercentage = table.Column<int>(nullable: false),
                    Remarks = table.Column<string>(unicode: false, maxLength: 250, nullable: false),
                    Currency = table.Column<string>(unicode: false, maxLength: 3, nullable: false),
                    CurrencyType = table.Column<string>(unicode: false, maxLength: 10, nullable: false),
                    Periodofsaving = table.Column<int>(nullable: false),
                    FiscalYear = table.Column<int>(nullable: false),
                    ExternalCost = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    InternalCost = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    EstimatedSavings = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    NetSavings = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    BaselinedetailsPrice = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    BaselinedetailsQty = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    BaselinedetailsUOM = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    BaselinedetailsPriceunit = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    InitiativedetailsNewSpendvalue = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    InitiativedetailsNewprice = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    InitiativedetailsPriceIncrease = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    Initiativedetails = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    InitiativedetailsDiscountgiven = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    NewMaterial = table.Column<string>(unicode: false, maxLength: 40, nullable: false),
                    UOM = table.Column<string>(unicode: false, maxLength: 5, nullable: false),
                    QTY = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    CostReduction = table.Column<decimal>(type: "decimal(20, 4)", nullable: false),
                    Creationdate = table.Column<DateTime>(type: "datetime", nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 25, nullable: false),
                    MaterialGroup = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    MaterialDescription = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    CompanyCode = table.Column<int>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true),
                    PlantId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_procurement", x => x.ProcurementID);
                    table.ForeignKey(
                        name: "FK__procureme__Basel__4E88ABD4",
                        column: x => x.BaselineID,
                        principalTable: "BaselineType",
                        principalColumn: "BaselineID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Compa__09A971A2",
                        column: x => x.CompanyCode,
                        principalTable: "CompanyCode",
                        principalColumn: "POCompanyCode",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Finan__52593CB8",
                        column: x => x.FinancialStatementAreaID,
                        principalTable: "FinancialStatementArea",
                        principalColumn: "FinancialStatementAreaID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Initi__5070F446",
                        column: x => x.InitiativeStatusId,
                        principalTable: "InitiativeStatus",
                        principalColumn: "InitiativeStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Mater__07C12930",
                        column: x => x.MaterialDescription,
                        principalTable: "MaterialGroupDesccription",
                        principalColumn: "MaterialType",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Mater__7C4F7684",
                        column: x => x.MaterialGroup,
                        principalTable: "MaterialGroup",
                        principalColumn: "UnspscMaterial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Miles__5535A963",
                        column: x => x.MilestoneStatusID,
                        principalTable: "MilestoneStatus",
                        principalColumn: "MilestoneStatusID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Perio__5441852A",
                        column: x => x.PeriodID,
                        principalTable: "Period",
                        principalColumn: "PeriodID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Plant__0F624AF8",
                        column: x => x.PlantId,
                        principalTable: "PlantName",
                        principalColumn: "PlantId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__RoleI__534D60F1",
                        column: x => x.RoleID,
                        principalTable: "Roles",
                        principalColumn: "RoleID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Suppl__0E6E26BF",
                        column: x => x.SupplierId,
                        principalTable: "Supplier",
                        principalColumn: "VendorId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Value__5165187F",
                        column: x => x.ValueContributionID,
                        principalTable: "ValueContribution",
                        principalColumn: "ValueContributionID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK__procureme__Value__4F7CD00D",
                        column: x => x.ValueLeverID,
                        principalTable: "ValueLever",
                        principalColumn: "ValueLeverID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_procurement_BaselineID",
                table: "procurement",
                column: "BaselineID");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_CompanyCode",
                table: "procurement",
                column: "CompanyCode");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_FinancialStatementAreaID",
                table: "procurement",
                column: "FinancialStatementAreaID");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_InitiativeStatusId",
                table: "procurement",
                column: "InitiativeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_MaterialDescription",
                table: "procurement",
                column: "MaterialDescription");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_MaterialGroup",
                table: "procurement",
                column: "MaterialGroup");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_MilestoneStatusID",
                table: "procurement",
                column: "MilestoneStatusID");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_PeriodID",
                table: "procurement",
                column: "PeriodID");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_PlantId",
                table: "procurement",
                column: "PlantId");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_RoleID",
                table: "procurement",
                column: "RoleID");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_SupplierId",
                table: "procurement",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_ValueContributionID",
                table: "procurement",
                column: "ValueContributionID");

            migrationBuilder.CreateIndex(
                name: "IX_procurement_ValueLeverID",
                table: "procurement",
                column: "ValueLeverID");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMapping_RoleId",
                table: "UserRoleMapping",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoleMapping_UserId",
                table: "UserRoleMapping",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialMater");

            migrationBuilder.DropTable(
                name: "procurement");

            migrationBuilder.DropTable(
                name: "PurchaseOrganization");

            migrationBuilder.DropTable(
                name: "UserRoleMapping");

            migrationBuilder.DropTable(
                name: "BaselineType");

            migrationBuilder.DropTable(
                name: "CompanyCode");

            migrationBuilder.DropTable(
                name: "FinancialStatementArea");

            migrationBuilder.DropTable(
                name: "InitiativeStatus");

            migrationBuilder.DropTable(
                name: "MaterialGroupDesccription");

            migrationBuilder.DropTable(
                name: "MaterialGroup");

            migrationBuilder.DropTable(
                name: "MilestoneStatus");

            migrationBuilder.DropTable(
                name: "Period");

            migrationBuilder.DropTable(
                name: "PlantName");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Supplier");

            migrationBuilder.DropTable(
                name: "ValueContribution");

            migrationBuilder.DropTable(
                name: "ValueLever");

            migrationBuilder.DropTable(
                name: "Role");

            migrationBuilder.DropTable(
                name: "UserInfo");
        }
    }
}
