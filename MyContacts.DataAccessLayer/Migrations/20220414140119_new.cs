using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MyContacts.DataAccessLayer.Migrations
{
    public partial class @new : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Labels",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Labels", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContactDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsPublished = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DateUpdated = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LabelId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ContactDetails_Labels_LabelId",
                        column: x => x.LabelId,
                        principalTable: "Labels",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContactDetailId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PhoneNumbers_ContactDetails_ContactDetailId",
                        column: x => x.ContactDetailId,
                        principalTable: "ContactDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Labels",
                columns: new[] { "Id", "Title" },
                values: new object[,]
                {
                    { 1, "Site Furnishings" },
                    { 2, "Elevator" },
                    { 3, "Roofing (Asphalt)" },
                    { 4, "Drilled Shafts" },
                    { 5, "Site Furnishings" }
                });

            migrationBuilder.InsertData(
                table: "ContactDetails",
                columns: new[] { "Id", "Address", "DateCreated", "DateUpdated", "FirstName", "Image", "IsDeleted", "IsPublished", "LabelId", "LastName", "Notes" },
                values: new object[,]
                {
                    { 1, "6th", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(7875), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Beryl", "http://dummyimage.com/228x100.png/5fa2dd/ffffff", false, true, 4, "Krug", "Stanley Black & Decker, Inc." },
                    { 2, "Messerschmidt", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(8328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Nerissa", "http://dummyimage.com/105x100.png/ff4444/ffffff", false, true, 1, "Cammocke", "PPlus Trust" },
                    { 3, "Coleman", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(8502), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Saloma", "http://dummyimage.com/144x100.png/5fa2dd/ffffff", false, true, 5, "Partington", "Fuwei Films (Holdings) Co., Ltd." },
                    { 4, "Beilfuss", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(8663), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Coreen", "http://dummyimage.com/102x100.png/dddddd/000000", false, true, 2, "Domelow", "Allegheny Technologies Incorporated" },
                    { 5, "Tony", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(8820), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brook", "http://dummyimage.com/123x100.png/ff4444/ffffff", false, true, 5, "Tommaseo", "Core Laboratories N.V." },
                    { 6, "Shelley", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(8984), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Brunhilda", "http://dummyimage.com/176x100.png/dddddd/000000", false, true, 3, "Flanner", "Francesca's Holdings Corporation" },
                    { 7, "Esch", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(9162), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Channa", "http://dummyimage.com/100x100.png/ff4444/ffffff", false, true, 1, "De Vere", "Ingersoll-Rand plc (Ireland)" },
                    { 8, "Loomis", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(9317), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Carolann", "http://dummyimage.com/161x100.png/dddddd/000000", false, true, 2, "Hamblin", "PowerShares DWA Emerging Markets Momentum Portfolio" },
                    { 9, "Truax", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(9473), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Darbie", "http://dummyimage.com/240x100.png/cc0000/ffffff", false, true, 5, "Charon", "ZAGG Inc" },
                    { 10, "Dovetail", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(9632), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shellie", "http://dummyimage.com/141x100.png/5fa2dd/ffffff", false, true, 1, "Keightley", "American Public Education, Inc." },
                    { 11, "La Follette", new DateTime(2022, 4, 14, 15, 1, 19, 594, DateTimeKind.Local).AddTicks(9848), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Tomasine", "http://dummyimage.com/222x100.png/dddddd/000000", false, true, 1, "Baly", "Treehouse Foods, Inc." },
                    { 12, "Eliot", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(15), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Barton", "http://dummyimage.com/112x100.png/ff4444/ffffff", false, true, 2, "Boorer", "RealPage, Inc." },
                    { 13, "Steensland", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(172), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Amata", "http://dummyimage.com/178x100.png/ff4444/ffffff", false, true, 4, "Middle", "Capital One Financial Corporation" },
                    { 14, "Gina", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(328), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Eal", "http://dummyimage.com/210x100.png/cc0000/ffffff", false, true, 2, "Yurocjhin", "PAVmed Inc." },
                    { 15, "Barnett", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(537), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hildagard", "http://dummyimage.com/171x100.png/cc0000/ffffff", false, true, 5, "Aimeric", "Great Elm Capital Corp." },
                    { 16, "Mitchell", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(693), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Liva", "http://dummyimage.com/178x100.png/5fa2dd/ffffff", false, true, 2, "Birds", "Galena Biopharma, Inc." },
                    { 17, "Grayhawk", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(852), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wash", "http://dummyimage.com/248x100.png/5fa2dd/ffffff", false, true, 1, "Crowthe", "DoubleLine Income Solutions Fund" },
                    { 18, "Kropf", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(1017), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ursala", "http://dummyimage.com/210x100.png/ff4444/ffffff", false, true, 4, "Ousley", "Nova Measuring Instruments Ltd." },
                    { 19, "Mesta", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(1172), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Codi", "http://dummyimage.com/168x100.png/ff4444/ffffff", false, true, 1, "Kensy", "REV Group, Inc." },
                    { 20, "3rd", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(1327), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Daisi", "http://dummyimage.com/161x100.png/dddddd/000000", false, true, 2, "Hegarty", "Old Second Bancorp, Inc." },
                    { 21, "Crest Line", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(1481), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Menard", "http://dummyimage.com/139x100.png/cc0000/ffffff", false, true, 5, "Katte", "Primo Water Corporation" },
                    { 22, "Arizona", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(1638), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jermaine", "http://dummyimage.com/200x100.png/ff4444/ffffff", false, true, 4, "Tithacott", "Vantage Energy Acquisition Corp." },
                    { 23, "Aberg", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(1797), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Leelah", "http://dummyimage.com/180x100.png/dddddd/000000", false, true, 2, "Saing", "ARC Group Worldwide, Inc." },
                    { 24, "Grover", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(1952), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Durante", "http://dummyimage.com/125x100.png/5fa2dd/ffffff", false, true, 2, "Huddleston", "Saban Capital Acquisition Corp." },
                    { 25, "Sachs", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(2107), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Rudy", "http://dummyimage.com/210x100.png/5fa2dd/ffffff", false, true, 1, "Wardle", "Landstar System, Inc." },
                    { 26, "Lindbergh", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(2260), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Marion", "http://dummyimage.com/205x100.png/ff4444/ffffff", false, true, 4, "Dilnot", "Aegion Corp" },
                    { 27, "Homewood", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(2413), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Effie", "http://dummyimage.com/246x100.png/dddddd/000000", false, true, 2, "Eddow", "Nuveen Maryland Quality Municipal Income Fund" },
                    { 28, "Lillian", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(2617), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kinsley", "http://dummyimage.com/210x100.png/dddddd/000000", false, true, 4, "Rolph", "Ion Geophysical Corporation" },
                    { 29, "Blaine", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(2771), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Martie", "http://dummyimage.com/216x100.png/dddddd/000000", false, true, 5, "Keave", "Danaos Corporation" },
                    { 30, "Doe Crossing", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(2924), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hamilton", "http://dummyimage.com/207x100.png/cc0000/ffffff", false, true, 4, "Penney", "QIWI plc" },
                    { 31, "Schiller", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(3075), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Niles", "http://dummyimage.com/181x100.png/5fa2dd/ffffff", false, true, 4, "Bottrill", "Arbor Realty Trust" },
                    { 32, "Kings", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(3228), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sallie", "http://dummyimage.com/209x100.png/cc0000/ffffff", false, true, 3, "Firbanks", "Nuveen Preferred Income Opportunites Fund" },
                    { 33, "Lyons", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(3388), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Felice", "http://dummyimage.com/247x100.png/ff4444/ffffff", false, true, 2, "Goddard", "Walgreens Boots Alliance, Inc." },
                    { 34, "Grim", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(3548), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Gale", "http://dummyimage.com/209x100.png/ff4444/ffffff", false, true, 2, "Cholwell", "Coach, Inc." },
                    { 35, "Vermont", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(3701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Teresina", "http://dummyimage.com/155x100.png/5fa2dd/ffffff", false, true, 1, "Arnold", "Vertex Pharmaceuticals Incorporated" },
                    { 36, "Cardinal", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(3953), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Shayne", "http://dummyimage.com/120x100.png/cc0000/ffffff", false, true, 3, "Bankhurst", "BLACKROCK INTERNATIONAL, LTD." },
                    { 37, "Thierer", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(4108), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Emlyn", "http://dummyimage.com/235x100.png/cc0000/ffffff", false, true, 3, "Gheorghescu", "eHealth, Inc." },
                    { 38, "Basil", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(4268), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Ricoriki", "http://dummyimage.com/237x100.png/5fa2dd/ffffff", false, true, 2, "Olivetta", "Moody's Corporation" },
                    { 39, "Muir", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(4423), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lowrance", "http://dummyimage.com/161x100.png/dddddd/000000", false, true, 5, "Steart", "Lifetime Brands, Inc." },
                    { 40, "Arkansas", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(4577), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Jens", "http://dummyimage.com/164x100.png/5fa2dd/ffffff", false, true, 5, "Purcell", "Advanced Micro Devices, Inc." },
                    { 41, "Charing Cross", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(4731), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Wash", "http://dummyimage.com/124x100.png/dddddd/000000", false, true, 5, "Setterington", "Workhorse Group, Inc." },
                    { 42, "Hovde", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(4884), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Andris", "http://dummyimage.com/104x100.png/5fa2dd/ffffff", false, true, 2, "Benford", "Nuveen Missouri Quality Municipal Income Fund" }
                });

            migrationBuilder.InsertData(
                table: "ContactDetails",
                columns: new[] { "Id", "Address", "DateCreated", "DateUpdated", "FirstName", "Image", "IsDeleted", "IsPublished", "LabelId", "LastName", "Notes" },
                values: new object[,]
                {
                    { 43, "Delaware", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(5041), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Colman", "http://dummyimage.com/173x100.png/dddddd/000000", false, true, 4, "Jaggli", "iRobot Corporation" },
                    { 44, "Buena Vista", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(5198), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Elka", "http://dummyimage.com/119x100.png/5fa2dd/ffffff", false, true, 2, "Fontel", "Easterly Acquisition Corp." },
                    { 45, "North", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(5353), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hyacinthia", "http://dummyimage.com/156x100.png/5fa2dd/ffffff", false, true, 1, "Dine-Hart", "Cray Inc" },
                    { 46, "Susan", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(5547), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Reynold", "http://dummyimage.com/214x100.png/ff4444/ffffff", false, true, 3, "Simonson", "iShares MSCI New Zealand Capped ETF" },
                    { 47, "Morning", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(5701), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lorene", "http://dummyimage.com/107x100.png/cc0000/ffffff", false, true, 5, "Almeida", "China TechFaith Wireless Communication Technology Limited" },
                    { 48, "Troy", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(5858), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Hubie", "http://dummyimage.com/142x100.png/ff4444/ffffff", false, true, 1, "Lapthorn", "Vornado Realty Trust" },
                    { 49, "American Ash", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(6017), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Thor", "http://dummyimage.com/249x100.png/5fa2dd/ffffff", false, true, 5, "Muzzini", "Southwest Bancorp, Inc." },
                    { 50, "Coolidge", new DateTime(2022, 4, 14, 15, 1, 19, 595, DateTimeKind.Local).AddTicks(6170), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Artair", "http://dummyimage.com/205x100.png/5fa2dd/ffffff", false, true, 1, "Rowsell", "Champions Oncology, Inc." }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "ContactDetailId", "ContactNumber", "Title" },
                values: new object[,]
                {
                    { 1, 15, "627-665-0678", "Hummer" },
                    { 2, 17, "453-900-2333", "Chevrolet" },
                    { 3, 9, "675-324-9212", "BMW" },
                    { 4, 1, "834-902-4183", "Chevrolet" },
                    { 5, 1, "963-206-2352", "Dodge" },
                    { 6, 35, "231-566-7124", "Hyundai" },
                    { 7, 3, "573-657-8555", "Mercury" },
                    { 8, 21, "546-950-5986", "GMC" },
                    { 9, 40, "618-452-5965", "Morgan" },
                    { 10, 28, "723-253-6389", "Buick" },
                    { 11, 14, "306-362-5238", "Toyota" },
                    { 12, 6, "274-641-5926", "Holden" },
                    { 13, 11, "307-482-6522", "GMC" },
                    { 14, 39, "404-203-3548", "Tesla" },
                    { 15, 7, "225-249-6710", "Volkswagen" },
                    { 16, 33, "646-996-7798", "Chevrolet" },
                    { 17, 30, "226-168-9195", "Chevrolet" },
                    { 18, 18, "133-792-3686", "GMC" },
                    { 19, 26, "416-141-7934", "Saab" },
                    { 20, 48, "835-851-6003", "Mitsubishi" },
                    { 21, 28, "398-893-8147", "Nissan" },
                    { 22, 9, "369-990-3510", "Nissan" },
                    { 23, 25, "326-298-1347", "Isuzu" },
                    { 24, 8, "517-438-2579", "Toyota" },
                    { 25, 15, "172-926-5800", "Volkswagen" },
                    { 26, 5, "565-552-2967", "GMC" },
                    { 27, 3, "436-684-3121", "Mercury" },
                    { 28, 8, "376-557-2386", "Ford" },
                    { 29, 10, "970-307-3888", "Volkswagen" },
                    { 30, 9, "430-452-8703", "BMW" },
                    { 31, 22, "727-311-0828", "Saturn" },
                    { 32, 34, "757-245-9053", "Mitsubishi" },
                    { 33, 20, "291-414-7260", "BMW" },
                    { 34, 7, "155-324-8356", "Mercedes-Benz" },
                    { 35, 45, "642-856-8367", "Ford" },
                    { 36, 28, "350-909-2389", "Mitsubishi" },
                    { 37, 13, "423-101-8028", "Chevrolet" },
                    { 38, 44, "687-530-1672", "Chevrolet" },
                    { 39, 3, "636-329-1306", "Pontiac" },
                    { 40, 4, "315-693-5581", "Mazda" },
                    { 41, 47, "793-993-8568", "Ford" },
                    { 42, 48, "224-387-5371", "Saturn" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "ContactDetailId", "ContactNumber", "Title" },
                values: new object[,]
                {
                    { 43, 46, "769-133-2247", "Mercedes-Benz" },
                    { 44, 37, "996-455-1897", "Aston Martin" },
                    { 45, 10, "624-205-2657", "GMC" },
                    { 46, 41, "226-226-9425", "Jaguar" },
                    { 47, 22, "415-314-2321", "Mitsubishi" },
                    { 48, 14, "628-570-4878", "Lexus" },
                    { 49, 13, "999-860-5185", "Mercedes-Benz" },
                    { 50, 12, "904-246-6413", "MINI" },
                    { 51, 41, "201-566-1980", "Mercedes-Benz" },
                    { 52, 41, "599-253-6458", "Pontiac" },
                    { 53, 41, "967-306-0532", "Pontiac" },
                    { 54, 3, "970-556-8902", "Lamborghini" },
                    { 55, 33, "663-354-5146", "Audi" },
                    { 56, 3, "880-643-5283", "Land Rover" },
                    { 57, 11, "170-917-8444", "Oldsmobile" },
                    { 58, 2, "251-630-2392", "Audi" },
                    { 59, 50, "777-252-9683", "Chevrolet" },
                    { 60, 3, "284-320-4015", "GMC" },
                    { 61, 32, "699-524-2695", "Jaguar" },
                    { 62, 24, "760-707-2719", "Subaru" },
                    { 63, 32, "334-242-6040", "Subaru" },
                    { 64, 30, "328-950-1599", "Suzuki" },
                    { 65, 12, "553-289-8678", "GMC" },
                    { 66, 12, "473-707-8438", "BMW" },
                    { 67, 36, "271-416-3302", "GMC" },
                    { 68, 31, "904-965-7567", "GMC" },
                    { 69, 50, "869-671-4096", "Saturn" },
                    { 70, 46, "235-894-9238", "Acura" },
                    { 71, 36, "142-240-7198", "Maybach" },
                    { 72, 25, "485-947-0473", "Toyota" },
                    { 73, 50, "550-208-6192", "Honda" },
                    { 74, 23, "495-884-4643", "Plymouth" },
                    { 75, 30, "822-174-3464", "Toyota" },
                    { 76, 3, "799-334-7709", "Lincoln" },
                    { 77, 3, "804-991-4613", "BMW" },
                    { 78, 9, "639-745-1091", "Lamborghini" },
                    { 79, 49, "358-356-5098", "Maybach" },
                    { 80, 25, "572-886-2023", "Toyota" },
                    { 81, 15, "280-567-9893", "Mazda" },
                    { 82, 13, "871-785-2891", "Chrysler" },
                    { 83, 36, "976-669-9091", "Saab" },
                    { 84, 23, "130-978-6875", "Cadillac" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "ContactDetailId", "ContactNumber", "Title" },
                values: new object[,]
                {
                    { 85, 45, "763-746-1557", "Mercedes-Benz" },
                    { 86, 23, "593-244-4192", "Acura" },
                    { 87, 26, "328-787-6694", "Volkswagen" },
                    { 88, 14, "300-945-2391", "Infiniti" },
                    { 89, 3, "479-423-7764", "Chevrolet" },
                    { 90, 18, "328-130-9937", "Toyota" },
                    { 91, 12, "295-163-6862", "Ford" },
                    { 92, 16, "537-207-7129", "Pontiac" },
                    { 93, 31, "548-657-4352", "Chevrolet" },
                    { 94, 12, "520-251-6769", "Mercedes-Benz" },
                    { 95, 26, "855-792-4948", "Volkswagen" },
                    { 96, 12, "332-682-2990", "Chevrolet" },
                    { 97, 50, "141-709-7411", "Chevrolet" },
                    { 98, 40, "136-266-6516", "Porsche" },
                    { 99, 30, "625-680-8992", "Mercedes-Benz" },
                    { 100, 2, "340-687-7098", "Volvo" },
                    { 101, 35, "314-801-1158", "Pontiac" },
                    { 102, 36, "830-570-8542", "Buick" },
                    { 103, 33, "253-582-3970", "Lexus" },
                    { 104, 31, "239-530-7488", "Cadillac" },
                    { 105, 22, "919-705-4021", "Acura" },
                    { 106, 27, "812-730-1567", "Honda" },
                    { 107, 32, "276-580-7772", "Morgan" },
                    { 108, 47, "456-535-5168", "Lexus" },
                    { 109, 42, "927-499-6495", "Land Rover" },
                    { 110, 18, "720-371-5333", "Nissan" },
                    { 111, 3, "319-558-2759", "Aston Martin" },
                    { 112, 31, "960-875-4009", "Mitsubishi" },
                    { 113, 23, "678-836-3442", "Nissan" },
                    { 114, 34, "191-164-9460", "Chevrolet" },
                    { 115, 12, "460-471-5226", "Ford" },
                    { 116, 34, "716-904-2654", "Suzuki" },
                    { 117, 46, "976-671-1081", "BMW" },
                    { 118, 35, "294-841-4639", "Honda" },
                    { 119, 1, "516-242-9457", "GMC" },
                    { 120, 46, "537-258-4554", "Saab" },
                    { 121, 1, "197-664-0956", "Audi" },
                    { 122, 45, "147-391-1583", "Mercedes-Benz" },
                    { 123, 25, "482-135-5504", "Acura" },
                    { 124, 13, "439-940-7805", "Toyota" },
                    { 125, 34, "532-324-7186", "BMW" },
                    { 126, 9, "208-994-1505", "Kia" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "ContactDetailId", "ContactNumber", "Title" },
                values: new object[,]
                {
                    { 127, 44, "373-986-4768", "Porsche" },
                    { 128, 44, "594-444-2967", "Mercedes-Benz" },
                    { 129, 10, "907-916-3956", "Mercedes-Benz" },
                    { 130, 35, "296-381-9769", "Pontiac" },
                    { 131, 47, "151-215-4523", "Audi" },
                    { 132, 31, "532-539-8198", "Mitsubishi" },
                    { 133, 34, "231-324-4233", "Pontiac" },
                    { 134, 6, "224-740-9436", "Hillman" },
                    { 135, 4, "691-868-5507", "Ford" },
                    { 136, 49, "987-544-1076", "BMW" },
                    { 137, 38, "298-785-5863", "Hyundai" },
                    { 138, 46, "766-927-6857", "Lincoln" },
                    { 139, 43, "404-167-0926", "Oldsmobile" },
                    { 140, 6, "770-827-0153", "Infiniti" },
                    { 141, 29, "263-994-0271", "Mercury" },
                    { 142, 45, "620-185-9930", "Buick" },
                    { 143, 29, "310-305-3616", "Chrysler" },
                    { 144, 33, "433-983-4858", "GMC" },
                    { 145, 25, "509-949-0724", "Volkswagen" },
                    { 146, 34, "395-290-0542", "Mercedes-Benz" },
                    { 147, 23, "428-347-0136", "Ford" },
                    { 148, 6, "211-546-6585", "Subaru" },
                    { 149, 3, "654-369-6742", "Toyota" },
                    { 150, 1, "527-346-1864", "Lexus" },
                    { 151, 16, "181-661-7391", "Cadillac" },
                    { 152, 4, "612-446-6785", "Lincoln" },
                    { 153, 38, "977-523-5909", "Honda" },
                    { 154, 30, "125-675-5360", "GMC" },
                    { 155, 31, "129-736-5272", "Daewoo" },
                    { 156, 39, "574-559-2339", "Ford" },
                    { 157, 32, "677-565-6890", "Acura" },
                    { 158, 34, "379-655-8365", "Hyundai" },
                    { 159, 16, "237-837-2120", "Chevrolet" },
                    { 160, 24, "528-523-7443", "Alfa Romeo" },
                    { 161, 19, "922-751-9424", "Volkswagen" },
                    { 162, 22, "702-801-3973", "Volvo" },
                    { 163, 43, "884-401-2793", "Ford" },
                    { 164, 27, "554-259-4204", "GMC" },
                    { 165, 2, "689-846-8929", "Hyundai" },
                    { 166, 1, "226-506-0668", "BMW" },
                    { 167, 34, "789-476-6014", "Audi" },
                    { 168, 38, "800-557-6114", "BMW" }
                });

            migrationBuilder.InsertData(
                table: "PhoneNumbers",
                columns: new[] { "Id", "ContactDetailId", "ContactNumber", "Title" },
                values: new object[,]
                {
                    { 169, 36, "159-792-2219", "Mercedes-Benz" },
                    { 170, 25, "801-700-0002", "Mercury" },
                    { 171, 16, "407-173-2383", "GMC" },
                    { 172, 36, "827-395-5702", "Ford" },
                    { 173, 44, "951-986-9157", "Ford" },
                    { 174, 45, "202-422-6406", "Audi" },
                    { 175, 36, "239-104-1608", "Dodge" },
                    { 176, 17, "602-528-0641", "Chevrolet" },
                    { 177, 17, "568-375-8204", "Suzuki" },
                    { 178, 21, "489-213-2781", "Mazda" },
                    { 179, 1, "848-287-3230", "Suzuki" },
                    { 180, 35, "445-625-2093", "Ford" },
                    { 181, 24, "901-306-4372", "Chevrolet" },
                    { 182, 24, "176-697-1898", "Ford" },
                    { 183, 14, "618-286-0745", "Acura" },
                    { 184, 46, "180-335-1507", "Mercedes-Benz" },
                    { 185, 34, "612-189-1954", "Nissan" },
                    { 186, 4, "520-746-5147", "Nissan" },
                    { 187, 41, "664-291-4141", "GMC" },
                    { 188, 39, "643-635-8231", "Toyota" },
                    { 189, 46, "376-117-1426", "Mazda" },
                    { 190, 4, "350-661-5646", "Mitsubishi" },
                    { 191, 40, "457-572-2190", "Toyota" },
                    { 192, 17, "877-945-0372", "Mercury" },
                    { 193, 3, "641-827-1470", "Subaru" },
                    { 194, 34, "427-513-1901", "Acura" },
                    { 195, 35, "729-532-7107", "Suzuki" },
                    { 196, 35, "429-759-0361", "Buick" },
                    { 197, 50, "206-895-4678", "Land Rover" },
                    { 198, 13, "445-719-1398", "Saab" },
                    { 199, 5, "580-613-8368", "Lexus" },
                    { 200, 16, "809-279-7941", "Toyota" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ContactDetails_LabelId",
                table: "ContactDetails",
                column: "LabelId");

            migrationBuilder.CreateIndex(
                name: "IX_PhoneNumbers_ContactDetailId",
                table: "PhoneNumbers",
                column: "ContactDetailId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PhoneNumbers");

            migrationBuilder.DropTable(
                name: "ContactDetails");

            migrationBuilder.DropTable(
                name: "Labels");
        }
    }
}
