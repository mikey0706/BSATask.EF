using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BSATask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Teams",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Teams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TeamId = table.Column<int>(type: "int", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RegisteredAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BirthDay = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Users_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Projects",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: true),
                    TeamId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Deadline = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Projects", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Projects_Teams_TeamId",
                        column: x => x.TeamId,
                        principalTable: "Teams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Projects_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tasks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProjectId = table.Column<int>(type: "int", nullable: false),
                    PerformerId = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    State = table.Column<int>(type: "int", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FinishedAt = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tasks", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tasks_Projects_ProjectId",
                        column: x => x.ProjectId,
                        principalTable: "Projects",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Tasks_Users_PerformerId",
                        column: x => x.PerformerId,
                        principalTable: "Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Teams",
                columns: new[] { "Id", "CreatedAt", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2016, 10, 4, 7, 44, 0, 313, DateTimeKind.Utc).AddTicks(2711), "Alfreda Gulgowski" },
                    { 2, new DateTime(2015, 8, 3, 4, 26, 49, 185, DateTimeKind.Utc).AddTicks(1003), "Fausto Brown" },
                    { 3, new DateTime(2017, 12, 9, 3, 41, 36, 905, DateTimeKind.Utc).AddTicks(2992), "Casimir Quigley" },
                    { 4, new DateTime(2016, 11, 13, 23, 46, 43, 4, DateTimeKind.Utc).AddTicks(5832), "Ellen Wyman" },
                    { 5, new DateTime(2021, 8, 22, 15, 55, 59, 509, DateTimeKind.Utc).AddTicks(8744), "Mariah Berge" },
                    { 6, new DateTime(2017, 3, 12, 10, 43, 44, 73, DateTimeKind.Utc).AddTicks(8908), "Salma Ratke" },
                    { 7, new DateTime(2019, 11, 7, 22, 42, 46, 233, DateTimeKind.Utc).AddTicks(9700), "Golda Funk" },
                    { 8, new DateTime(2014, 1, 14, 19, 48, 26, 479, DateTimeKind.Utc).AddTicks(4932), "Earlene Gerlach" },
                    { 9, new DateTime(2019, 7, 18, 3, 41, 42, 970, DateTimeKind.Utc).AddTicks(2054), "Nils McClure" },
                    { 10, new DateTime(2023, 5, 9, 5, 22, 18, 93, DateTimeKind.Utc).AddTicks(5142), "Madaline Bogan" },
                    { 11, new DateTime(2013, 10, 10, 10, 11, 49, 55, DateTimeKind.Utc).AddTicks(5880), "Amy Mertz" },
                    { 12, new DateTime(2020, 5, 8, 2, 13, 3, 299, DateTimeKind.Utc).AddTicks(3889), "Montana Kuhlman" },
                    { 13, new DateTime(2019, 7, 5, 23, 41, 36, 864, DateTimeKind.Utc).AddTicks(4389), "Garrett Lakin" },
                    { 14, new DateTime(2018, 1, 26, 19, 7, 43, 917, DateTimeKind.Utc).AddTicks(6527), "Bobby Hartmann" },
                    { 15, new DateTime(2017, 4, 4, 4, 12, 48, 111, DateTimeKind.Utc).AddTicks(3162), "Kris Padberg" },
                    { 16, new DateTime(2019, 7, 31, 11, 51, 58, 27, DateTimeKind.Utc).AddTicks(3151), "Arnold Casper" },
                    { 17, new DateTime(2015, 7, 3, 19, 20, 22, 375, DateTimeKind.Utc).AddTicks(6358), "Diego Sporer" },
                    { 18, new DateTime(2015, 4, 23, 20, 56, 43, 247, DateTimeKind.Utc).AddTicks(1939), "Danyka Collins" },
                    { 19, new DateTime(2019, 12, 31, 2, 0, 10, 631, DateTimeKind.Utc).AddTicks(8142), "Sherwood Hartmann" },
                    { 20, new DateTime(2014, 2, 8, 13, 12, 58, 134, DateTimeKind.Utc).AddTicks(3590), "Mathias Bernhard" }
                });

            migrationBuilder.InsertData(
                table: "Projects",
                columns: new[] { "Id", "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId", "UserId" },
                values: new object[,]
                {
                    { 1, 20, new DateTime(2017, 9, 19, 20, 53, 6, 112, DateTimeKind.Utc).AddTicks(1854), new DateTime(9696, 1, 9, 4, 9, 45, 77, DateTimeKind.Utc).AddTicks(4438), "voluptates", "Wilma Walsh", 4, null },
                    { 2, 3, new DateTime(2017, 8, 8, 7, 19, 13, 749, DateTimeKind.Utc).AddTicks(6996), new DateTime(5095, 5, 6, 6, 24, 1, 991, DateTimeKind.Utc).AddTicks(7441), "Expedita possimus culpa necessitatibus tempore omnis quod ut dignissimos. Beatae est nostrum dolores. Fuga voluptates doloremque alias ut. Aut aut soluta sit. Iste dolor voluptates molestiae fugit ullam doloribus dicta est.", "Lonzo Bednar", 18, null },
                    { 3, 2, new DateTime(2020, 5, 22, 20, 39, 19, 191, DateTimeKind.Utc).AddTicks(3742), new DateTime(5718, 10, 2, 17, 41, 31, 833, DateTimeKind.Utc).AddTicks(4676), "Provident ea et voluptates quaerat aut.\nEst dolores ut libero nisi ipsa.\nDolorem ipsam omnis eum fugiat harum possimus qui.\nVoluptatem quae ad soluta eum.\nEa quo maxime exercitationem excepturi eligendi natus expedita.\nDoloremque eveniet ipsa velit quia et suscipit molestias harum.", "Janessa Koch", 15, null },
                    { 4, 11, new DateTime(2020, 2, 11, 5, 50, 34, 617, DateTimeKind.Utc).AddTicks(2074), new DateTime(3758, 4, 7, 5, 50, 13, 957, DateTimeKind.Utc).AddTicks(980), "Molestiae voluptate ut sit doloremque quo odit doloribus.\nEt non amet dolores.", "Mario Anderson", 16, null },
                    { 5, 20, new DateTime(2017, 12, 3, 3, 29, 55, 443, DateTimeKind.Utc).AddTicks(1622), new DateTime(5756, 1, 1, 2, 45, 6, 441, DateTimeKind.Utc).AddTicks(2185), "Placeat deserunt qui aut incidunt veniam voluptatum molestias eos mollitia. Vitae illum blanditiis beatae eligendi consequatur et. Placeat culpa perspiciatis perferendis eius. Delectus doloribus quia repudiandae atque et illo beatae. Aut rerum voluptatem accusamus magnam id vel adipisci doloribus.", "Stevie Hoeger", 15, null },
                    { 6, 12, new DateTime(2021, 6, 27, 20, 27, 13, 680, DateTimeKind.Utc).AddTicks(4338), new DateTime(2203, 3, 28, 11, 39, 44, 980, DateTimeKind.Utc).AddTicks(9065), "Et autem dignissimos voluptatem nemo.", "Elian Weimann", 19, null },
                    { 7, 6, new DateTime(2019, 9, 20, 1, 42, 5, 904, DateTimeKind.Utc).AddTicks(8722), new DateTime(8129, 1, 5, 6, 22, 36, 48, DateTimeKind.Utc).AddTicks(4079), "et", "Cory Kerluke", 12, null },
                    { 8, 19, new DateTime(2019, 7, 22, 14, 49, 35, 834, DateTimeKind.Utc).AddTicks(3911), new DateTime(5885, 3, 31, 6, 56, 26, 454, DateTimeKind.Utc).AddTicks(3050), "Nemo omnis debitis neque exercitationem minus cumque neque.", "Cecelia Torphy", 8, null },
                    { 9, 4, new DateTime(2014, 4, 23, 8, 36, 47, 431, DateTimeKind.Utc).AddTicks(1265), new DateTime(4607, 5, 27, 19, 42, 29, 626, DateTimeKind.Utc).AddTicks(5085), "et", "Palma Zulauf", 12, null },
                    { 10, 6, new DateTime(2020, 6, 29, 15, 29, 38, 571, DateTimeKind.Utc).AddTicks(6794), new DateTime(2620, 11, 10, 2, 12, 34, 688, DateTimeKind.Utc).AddTicks(3377), "sed", "Pedro Runolfsdottir", 1, null },
                    { 11, 19, new DateTime(2021, 2, 28, 5, 40, 34, 664, DateTimeKind.Utc).AddTicks(1083), new DateTime(2701, 8, 29, 10, 47, 4, 418, DateTimeKind.Utc).AddTicks(2580), "Laudantium id et cupiditate maxime laboriosam quibusdam magni rerum.", "Carli Gutkowski", 18, null },
                    { 12, 6, new DateTime(2015, 1, 7, 9, 23, 41, 68, DateTimeKind.Utc).AddTicks(4880), new DateTime(5435, 7, 2, 5, 22, 9, 820, DateTimeKind.Utc).AddTicks(6761), "Laboriosam aut voluptas non facilis exercitationem vel.", "Alba Casper", 11, null },
                    { 13, 18, new DateTime(2018, 7, 5, 21, 5, 44, 176, DateTimeKind.Utc).AddTicks(849), new DateTime(4642, 10, 2, 17, 18, 33, 86, DateTimeKind.Utc).AddTicks(4737), "Earum facilis exercitationem excepturi est consequatur maxime tempore illum quia. Cum illo odio molestias quibusdam aliquid et. Consequatur et et sit dolores ipsum ut voluptate.", "Adalberto Lindgren", 12, null },
                    { 14, 3, new DateTime(2016, 7, 11, 4, 16, 48, 558, DateTimeKind.Utc).AddTicks(4391), new DateTime(3978, 5, 8, 10, 45, 7, 296, DateTimeKind.Utc).AddTicks(8124), "Laudantium qui sed dolor voluptatibus quia facere.", "Carmel O'Reilly", 6, null },
                    { 15, 13, new DateTime(2018, 3, 18, 9, 10, 45, 541, DateTimeKind.Utc).AddTicks(9109), new DateTime(3854, 3, 13, 9, 49, 54, 594, DateTimeKind.Utc).AddTicks(8492), "Est et optio illo reiciendis illo alias numquam vitae dolores. Illum aspernatur veritatis quia dolores repellat. Eius sed doloribus nostrum eaque pariatur.", "Zella Roob", 13, null },
                    { 16, 16, new DateTime(2013, 12, 17, 17, 40, 37, 340, DateTimeKind.Utc).AddTicks(2710), new DateTime(8445, 8, 7, 3, 32, 5, 299, DateTimeKind.Utc).AddTicks(1030), "Alias sequi non tenetur possimus ullam qui sint laboriosam.", "Felipa Mosciski", 2, null },
                    { 17, 12, new DateTime(2022, 9, 13, 0, 45, 41, 961, DateTimeKind.Utc).AddTicks(7982), new DateTime(6316, 6, 5, 11, 11, 11, 374, DateTimeKind.Utc).AddTicks(7063), "Non et omnis error veritatis tenetur corrupti laborum commodi voluptatem. Autem eaque quod in necessitatibus adipisci. Ipsa eos quod tempore vel suscipit. Est illo praesentium aliquam sed beatae et tempore aut voluptate. Vitae facilis nihil.", "Lauretta Fay", 20, null },
                    { 18, 17, new DateTime(2019, 1, 18, 8, 33, 37, 387, DateTimeKind.Utc).AddTicks(4740), new DateTime(2372, 5, 6, 19, 37, 3, 192, DateTimeKind.Utc).AddTicks(5873), "Provident aut error velit libero odio corrupti alias nisi.\nEt nostrum doloremque qui quo.\nMinima qui illum harum officia magnam maiores qui.\nQui iure occaecati velit eum corrupti est id enim et.\nAdipisci maxime amet asperiores eos animi.\nIncidunt voluptatum aut.", "Geovany Hackett", 8, null },
                    { 19, 4, new DateTime(2022, 10, 21, 18, 19, 16, 730, DateTimeKind.Utc).AddTicks(3333), new DateTime(3137, 1, 24, 3, 32, 54, 680, DateTimeKind.Utc).AddTicks(8897), "exercitationem", "Broderick Douglas", 14, null },
                    { 20, 9, new DateTime(2019, 4, 21, 17, 54, 58, 883, DateTimeKind.Utc).AddTicks(8348), new DateTime(3732, 2, 10, 7, 10, 4, 289, DateTimeKind.Utc).AddTicks(2788), "Harum corrupti nemo et laudantium. Nulla sed illum ratione itaque ratione assumenda. Corporis sapiente reiciendis hic architecto soluta quis accusantium nesciunt recusandae.", "Beulah Hayes", 9, null }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[,]
                {
                    { 1, new DateTime(1994, 12, 11, 3, 53, 31, 415, DateTimeKind.Utc).AddTicks(9651), "Sophia.Sporer30@gmail.com", "Marcelina", "Dare", new DateTime(2019, 1, 3, 6, 12, 34, 502, DateTimeKind.Utc).AddTicks(5614), 17 },
                    { 2, new DateTime(2001, 6, 6, 4, 1, 43, 310, DateTimeKind.Utc).AddTicks(9463), "Ollie_Torphy42@yahoo.com", "Marques", "Schmitt", new DateTime(2022, 5, 17, 15, 26, 47, 638, DateTimeKind.Utc).AddTicks(1631), 5 },
                    { 3, new DateTime(2014, 10, 12, 0, 3, 46, 286, DateTimeKind.Utc).AddTicks(2699), "Dayna.Connelly1@gmail.com", "Cristal", "Reinger", new DateTime(2015, 7, 20, 2, 51, 59, 605, DateTimeKind.Utc).AddTicks(6551), 1 },
                    { 4, new DateTime(2015, 4, 3, 6, 34, 32, 715, DateTimeKind.Utc).AddTicks(7275), "Makayla_Dibbert@gmail.com", "Bo", "Bogan", new DateTime(2021, 4, 18, 17, 52, 47, 417, DateTimeKind.Utc).AddTicks(3252), 5 },
                    { 5, new DateTime(1996, 1, 10, 21, 52, 44, 947, DateTimeKind.Utc).AddTicks(7889), "Raphaelle.Flatley@hotmail.com", "Evalyn", "DuBuque", new DateTime(2017, 5, 4, 11, 9, 28, 85, DateTimeKind.Utc).AddTicks(5541), 4 },
                    { 6, new DateTime(2012, 10, 29, 22, 56, 14, 843, DateTimeKind.Utc).AddTicks(3789), "Shaylee63@yahoo.com", "Jerod", "Kemmer", new DateTime(2019, 3, 18, 2, 13, 37, 325, DateTimeKind.Utc).AddTicks(4805), 6 },
                    { 7, new DateTime(2003, 3, 12, 2, 11, 13, 538, DateTimeKind.Utc).AddTicks(5808), "Orrin71@gmail.com", "Lola", "Barrows", new DateTime(2023, 1, 11, 15, 2, 18, 678, DateTimeKind.Utc).AddTicks(6042), 12 },
                    { 8, new DateTime(2003, 3, 31, 22, 24, 58, 557, DateTimeKind.Utc).AddTicks(5481), "Andreane_Stark@gmail.com", "Sophia", "Bogisich", new DateTime(2019, 3, 10, 3, 12, 17, 117, DateTimeKind.Utc).AddTicks(5669), 6 },
                    { 9, new DateTime(2018, 2, 3, 21, 10, 36, 453, DateTimeKind.Utc).AddTicks(8277), "Deon_Kunde@hotmail.com", "Evelyn", "Vandervort", new DateTime(2020, 2, 10, 20, 16, 35, 309, DateTimeKind.Utc).AddTicks(3265), 13 },
                    { 10, new DateTime(2000, 11, 19, 13, 44, 26, 497, DateTimeKind.Utc).AddTicks(3508), "Cortney_OKon22@gmail.com", "Otha", "Lemke", new DateTime(2017, 2, 10, 7, 23, 36, 439, DateTimeKind.Utc).AddTicks(9673), 6 },
                    { 11, new DateTime(2016, 3, 10, 9, 26, 47, 872, DateTimeKind.Utc).AddTicks(2869), "Naomie4@hotmail.com", "Letitia", "Kshlerin", new DateTime(2019, 7, 7, 2, 39, 42, 884, DateTimeKind.Utc).AddTicks(9792), 3 },
                    { 12, new DateTime(2018, 11, 4, 8, 53, 34, 167, DateTimeKind.Utc).AddTicks(201), "Asa75@gmail.com", "Faustino", "Cronin", new DateTime(2020, 10, 19, 12, 10, 28, 869, DateTimeKind.Utc).AddTicks(3144), 20 },
                    { 13, new DateTime(2011, 7, 6, 23, 8, 38, 906, DateTimeKind.Utc).AddTicks(5416), "Randall.Schneider93@yahoo.com", "Jannie", "Willms", new DateTime(2014, 10, 11, 10, 13, 31, 351, DateTimeKind.Utc).AddTicks(6967), 13 },
                    { 14, new DateTime(2008, 10, 18, 2, 5, 24, 118, DateTimeKind.Utc).AddTicks(835), "Haskell37@hotmail.com", "Rosie", "Huel", new DateTime(2017, 8, 10, 21, 17, 0, 730, DateTimeKind.Utc).AddTicks(9119), 15 },
                    { 15, new DateTime(2023, 6, 22, 23, 18, 44, 422, DateTimeKind.Utc).AddTicks(2066), "Blaze.Carroll@hotmail.com", "Tyler", "Berge", new DateTime(2018, 1, 6, 22, 25, 23, 56, DateTimeKind.Utc).AddTicks(6405), 14 },
                    { 16, new DateTime(2013, 5, 2, 13, 17, 16, 97, DateTimeKind.Utc).AddTicks(8987), "Raul.Haley47@yahoo.com", "Kimberly", "Prosacco", new DateTime(2022, 11, 18, 18, 4, 56, 993, DateTimeKind.Utc).AddTicks(6328), 18 },
                    { 17, new DateTime(2004, 11, 28, 9, 59, 37, 103, DateTimeKind.Utc).AddTicks(876), "Dorian73@gmail.com", "Rita", "Aufderhar", new DateTime(2021, 10, 11, 7, 53, 5, 315, DateTimeKind.Utc).AddTicks(5317), 3 },
                    { 18, new DateTime(2004, 2, 18, 10, 20, 0, 581, DateTimeKind.Utc).AddTicks(5370), "Jamel.Bednar@gmail.com", "Reginald", "Haag", new DateTime(2020, 9, 1, 16, 31, 12, 44, DateTimeKind.Utc).AddTicks(7441), 16 },
                    { 19, new DateTime(2019, 5, 24, 16, 42, 8, 452, DateTimeKind.Utc).AddTicks(8326), "Liliane87@yahoo.com", "Callie", "Robel", new DateTime(2022, 10, 9, 23, 19, 32, 947, DateTimeKind.Utc).AddTicks(8502), 3 },
                    { 20, new DateTime(1993, 11, 20, 21, 55, 9, 942, DateTimeKind.Utc).AddTicks(6076), "Dorothy.Corkery@hotmail.com", "Elvera", "McCullough", new DateTime(2013, 9, 23, 21, 43, 33, 854, DateTimeKind.Utc).AddTicks(3896), 8 }
                });

            migrationBuilder.InsertData(
                table: "Tasks",
                columns: new[] { "Id", "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 2, 22, 3, 31, 7, 63, DateTimeKind.Utc).AddTicks(1909), "Rerum quia libero rerum iste quibusdam optio optio.", new DateTime(7109, 10, 29, 4, 15, 25, 833, DateTimeKind.Utc).AddTicks(4129), "Anika Smith", 5, 9, 0 },
                    { 2, new DateTime(2020, 3, 29, 6, 7, 34, 524, DateTimeKind.Utc).AddTicks(8329), "laudantium", new DateTime(8337, 5, 28, 20, 37, 45, 379, DateTimeKind.Utc).AddTicks(8294), "Grace Reichel", 3, 10, 1 },
                    { 3, new DateTime(2014, 2, 24, 14, 38, 17, 750, DateTimeKind.Utc).AddTicks(4185), "Sapiente nihil quae dolorem reiciendis.\nUt a repellat aut dolor quia harum ullam non.\nPorro voluptas alias sint.", new DateTime(8505, 7, 16, 0, 42, 37, 77, DateTimeKind.Utc).AddTicks(5190), "Maria Powlowski", 2, 3, 1 },
                    { 4, new DateTime(2021, 6, 30, 2, 23, 44, 121, DateTimeKind.Utc).AddTicks(1651), "rerum", new DateTime(2666, 11, 11, 10, 36, 39, 9, DateTimeKind.Utc).AddTicks(9742), "Lonzo Jast", 9, 15, 0 },
                    { 5, new DateTime(2017, 6, 29, 21, 56, 47, 825, DateTimeKind.Utc).AddTicks(4012), "Nostrum nihil sit eveniet id.\nAut cum sint enim enim voluptatem.\nDoloribus et qui ab quae minima qui animi.\nOccaecati dolorem minus consequuntur deleniti qui est dolores.\nConsequatur omnis et.", new DateTime(7477, 8, 3, 7, 7, 35, 942, DateTimeKind.Utc).AddTicks(5771), "Sarah Reynolds", 17, 8, 1 },
                    { 6, new DateTime(2021, 12, 1, 23, 29, 33, 485, DateTimeKind.Utc).AddTicks(2956), "quis", new DateTime(8854, 5, 4, 14, 8, 30, 147, DateTimeKind.Utc).AddTicks(838), "Clarissa Parisian", 1, 1, 0 },
                    { 7, new DateTime(2019, 4, 1, 10, 59, 25, 40, DateTimeKind.Utc).AddTicks(3346), "Suscipit officia pariatur unde aliquid.\nEsse recusandae fugit mollitia minus accusantium nemo neque.\nVoluptas ex omnis esse aperiam.\nNihil consequatur dolorem ut ut id enim saepe sint architecto.\nDoloribus ut odit fugiat non eos aliquid optio molestiae quia.", new DateTime(8628, 3, 25, 3, 12, 13, 618, DateTimeKind.Utc).AddTicks(7000), "Clifton Torphy", 17, 19, 1 },
                    { 8, new DateTime(2017, 11, 13, 2, 58, 45, 29, DateTimeKind.Utc).AddTicks(3033), "Consequatur quo sunt incidunt velit et voluptatibus eum nobis ab. Perferendis dolorem nobis officiis eius eum. Velit similique expedita ea blanditiis corrupti. Aut vero dolores quam voluptatum voluptas ipsa pariatur tempora velit. Doloremque consequuntur aut et.", new DateTime(7042, 10, 22, 4, 29, 22, 739, DateTimeKind.Utc).AddTicks(4004), "Lonnie Dare", 17, 5, 2 },
                    { 9, new DateTime(2013, 12, 1, 5, 46, 2, 200, DateTimeKind.Utc).AddTicks(3109), "Quasi rerum aspernatur id.", new DateTime(9238, 4, 9, 0, 46, 23, 414, DateTimeKind.Utc).AddTicks(7893), "Nicolette Jast", 17, 6, 0 },
                    { 10, new DateTime(2014, 9, 8, 5, 21, 43, 575, DateTimeKind.Utc).AddTicks(9742), "Iusto dolore expedita sit harum molestiae sapiente error vel. Beatae totam incidunt eum. Molestiae voluptatum harum. Aliquid assumenda ullam quaerat veniam at sed aut. Natus et eos voluptates qui saepe. Et rerum ea sit occaecati sunt voluptatem tempore numquam excepturi.", new DateTime(3946, 4, 6, 16, 35, 46, 549, DateTimeKind.Utc).AddTicks(9634), "Urban Okuneva", 8, 8, 0 },
                    { 11, new DateTime(2014, 6, 16, 23, 29, 52, 357, DateTimeKind.Utc).AddTicks(2260), "Quos accusantium est qui ullam ut culpa sunt.\nLibero sunt omnis assumenda ad doloribus.\nDolores voluptatibus corporis eos qui molestias.", new DateTime(8614, 3, 14, 3, 33, 21, 369, DateTimeKind.Utc).AddTicks(6849), "Devin Johnson", 15, 1, 1 },
                    { 12, new DateTime(2020, 10, 25, 17, 35, 12, 682, DateTimeKind.Utc).AddTicks(7118), "dolores", new DateTime(2847, 1, 21, 11, 43, 21, 935, DateTimeKind.Utc).AddTicks(936), "Letitia Fahey", 6, 17, 2 },
                    { 13, new DateTime(2023, 5, 7, 17, 9, 35, 594, DateTimeKind.Utc).AddTicks(3618), "Alias nesciunt illo eum et cumque. Omnis ipsum reiciendis. Quia vel et doloremque sed pariatur. Magni aut cum dolores. Qui dolorum deleniti cupiditate maiores doloribus.", new DateTime(9233, 8, 9, 7, 32, 31, 130, DateTimeKind.Utc).AddTicks(8374), "Cary Boyer", 16, 16, 2 },
                    { 14, new DateTime(2019, 3, 2, 11, 45, 55, 629, DateTimeKind.Utc).AddTicks(4664), "Cum et id laboriosam sed voluptatem dolorum.", new DateTime(9474, 3, 27, 13, 17, 5, 779, DateTimeKind.Utc).AddTicks(9095), "Marjory Gleason", 7, 17, 0 },
                    { 15, new DateTime(2017, 10, 16, 23, 26, 27, 273, DateTimeKind.Utc).AddTicks(3732), "Eos assumenda eos aut aut quibusdam autem. Qui delectus quisquam sequi sed et. Suscipit minima est in autem cupiditate adipisci quidem. Incidunt adipisci non. Voluptatibus voluptatem debitis deserunt.", new DateTime(5061, 1, 10, 15, 29, 41, 532, DateTimeKind.Utc).AddTicks(8702), "Helmer Wintheiser", 20, 20, 2 },
                    { 16, new DateTime(2015, 6, 7, 15, 48, 24, 914, DateTimeKind.Utc).AddTicks(7884), "Sint praesentium et.\nRepellat et voluptas nesciunt molestiae voluptas.\nDolor reiciendis esse maiores repellat maiores in dolore quo.\nFugiat aut accusamus voluptatem quos et.", new DateTime(9518, 12, 21, 5, 52, 9, 240, DateTimeKind.Utc).AddTicks(9780), "Devonte Powlowski", 17, 11, 0 },
                    { 17, new DateTime(2014, 12, 24, 6, 20, 16, 671, DateTimeKind.Utc).AddTicks(9947), "Expedita id sed earum quam eveniet.\nTemporibus aliquam animi ea aspernatur dolorem laborum officia autem.\nEx quo sapiente tempore aspernatur odio quae ut.\nNon totam et ipsa nam accusantium repudiandae.\nCum rerum perferendis quisquam aperiam voluptatibus expedita veniam.\nMaxime consequatur temporibus illo a quidem.", new DateTime(7549, 5, 15, 10, 13, 45, 265, DateTimeKind.Utc).AddTicks(9448), "Reginald Ferry", 5, 12, 0 },
                    { 18, new DateTime(2017, 6, 28, 8, 53, 12, 702, DateTimeKind.Utc).AddTicks(6147), "reprehenderit", new DateTime(5865, 8, 8, 2, 51, 37, 331, DateTimeKind.Utc).AddTicks(2323), "Coralie Pfeffer", 11, 12, 2 },
                    { 19, new DateTime(2019, 1, 14, 19, 26, 18, 460, DateTimeKind.Utc).AddTicks(2303), "harum", new DateTime(2418, 12, 20, 0, 2, 54, 911, DateTimeKind.Utc).AddTicks(9662), "Rosina Kilback", 18, 12, 2 },
                    { 20, new DateTime(2015, 11, 2, 1, 10, 18, 12, DateTimeKind.Utc).AddTicks(5446), "Possimus perferendis expedita fuga iusto perspiciatis quos omnis.", new DateTime(2065, 6, 10, 13, 24, 43, 874, DateTimeKind.Utc).AddTicks(7888), "Jennings Zemlak", 4, 8, 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Projects_TeamId",
                table: "Projects",
                column: "TeamId");

            migrationBuilder.CreateIndex(
                name: "IX_Projects_UserId",
                table: "Projects",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_PerformerId",
                table: "Tasks",
                column: "PerformerId");

            migrationBuilder.CreateIndex(
                name: "IX_Tasks_ProjectId",
                table: "Tasks",
                column: "ProjectId");

            migrationBuilder.CreateIndex(
                name: "IX_Users_TeamId",
                table: "Users",
                column: "TeamId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Tasks");

            migrationBuilder.DropTable(
                name: "Projects");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Teams");
        }
    }
}
