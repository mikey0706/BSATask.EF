using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSATask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class UserWithProjects : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2016, 12, 22, 20, 32, 9, 433, DateTimeKind.Utc).AddTicks(1252), new DateTime(9508, 4, 12, 13, 20, 7, 544, DateTimeKind.Utc).AddTicks(6372), "qui", "Lexie Schaefer", 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 8, new DateTime(2013, 11, 23, 1, 20, 56, 63, DateTimeKind.Utc).AddTicks(1767), new DateTime(7376, 7, 1, 1, 39, 23, 53, DateTimeKind.Utc).AddTicks(9878), "Ipsum perspiciatis voluptatum et.", "Giuseppe D'Amore", 18 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 3, new DateTime(2022, 3, 3, 16, 54, 37, 810, DateTimeKind.Utc).AddTicks(8495), new DateTime(8928, 6, 30, 13, 17, 27, 565, DateTimeKind.Utc).AddTicks(9228), "Quidem veniam iure aliquam sequi cumque.", "Alexis Block", 10 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2017, 11, 24, 11, 47, 45, 895, DateTimeKind.Utc).AddTicks(2989), new DateTime(4523, 10, 19, 16, 41, 17, 614, DateTimeKind.Utc).AddTicks(7866), "Ea est nam ea qui reiciendis consectetur est iure.", "Ramon Stark", 20 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 6, new DateTime(2014, 9, 5, 2, 34, 17, 22, DateTimeKind.Utc).AddTicks(9169), new DateTime(5775, 10, 13, 0, 23, 59, 954, DateTimeKind.Utc).AddTicks(1460), "Cumque vitae dolor et in possimus.\nUllam voluptas sed rerum est nulla nostrum dolores aut.\nEt et et ut aperiam aperiam libero pariatur.", "Al Jones", 16 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 16, new DateTime(2022, 11, 4, 1, 19, 2, 949, DateTimeKind.Utc).AddTicks(5140), new DateTime(5461, 3, 29, 19, 9, 29, 283, DateTimeKind.Utc).AddTicks(3287), "Rerum enim in minima. Deserunt atque odio ipsa modi corporis voluptatem. Rem rerum autem officiis rerum et similique quam eveniet. Tempora dolorum dicta exercitationem ea dicta est aut nemo dolorem.", "Raquel O'Conner", 14 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 14, new DateTime(2022, 4, 21, 6, 4, 45, 202, DateTimeKind.Utc).AddTicks(941), new DateTime(9748, 8, 11, 14, 44, 5, 440, DateTimeKind.Utc).AddTicks(8177), "Repellat dolorem eum.", "Brett Gaylord", 20 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name" },
                values: new object[] { 8, new DateTime(2018, 10, 16, 3, 35, 9, 971, DateTimeKind.Utc).AddTicks(1312), new DateTime(9398, 12, 29, 7, 49, 3, 254, DateTimeKind.Utc).AddTicks(6669), "Quas quis in molestiae ut.\nQui nisi provident qui nesciunt aut eligendi recusandae.\nPorro autem a beatae ullam recusandae qui.\nConsequatur voluptas repudiandae quisquam.", "Concepcion Grady" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 9, new DateTime(2015, 12, 8, 21, 26, 19, 813, DateTimeKind.Utc).AddTicks(8653), new DateTime(2072, 9, 10, 19, 58, 33, 751, DateTimeKind.Utc).AddTicks(1351), "Nesciunt sit velit eius.\nDeleniti perferendis aut qui voluptas in dolore ex nemo sunt.\nConsequatur sed animi quisquam qui et qui soluta nostrum.\nId ea quia quia.", "Carson Koelpin", 17 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 17, new DateTime(2014, 4, 6, 10, 5, 31, 711, DateTimeKind.Utc).AddTicks(5432), new DateTime(6631, 3, 3, 11, 57, 47, 799, DateTimeKind.Utc).AddTicks(3239), "doloremque", "Enoch Brekke", 11 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 8, new DateTime(2022, 1, 9, 0, 47, 53, 655, DateTimeKind.Utc).AddTicks(5480), new DateTime(2588, 11, 22, 17, 31, 53, 415, DateTimeKind.Utc).AddTicks(3905), "Voluptatem exercitationem et labore occaecati nihil quae minima provident.\nPerspiciatis error repudiandae.\nEst incidunt modi sit ea.\nTempore eaque libero architecto sit temporibus explicabo numquam.\nRem explicabo dignissimos vitae.\nAutem et consectetur fugiat.", "Emile Waters", 11 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 17, new DateTime(2020, 3, 16, 7, 54, 57, 744, DateTimeKind.Utc).AddTicks(3161), new DateTime(5903, 12, 30, 0, 32, 10, 198, DateTimeKind.Utc).AddTicks(5149), "nam", "Maryse Kirlin", 11 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2023, 2, 22, 0, 52, 2, 76, DateTimeKind.Utc).AddTicks(7858), new DateTime(2246, 3, 20, 13, 17, 54, 52, DateTimeKind.Utc).AddTicks(6481), "Soluta voluptatem modi non.", "Kitty Feest", 17 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 18, new DateTime(2020, 10, 18, 17, 31, 49, 693, DateTimeKind.Utc).AddTicks(3859), new DateTime(7935, 1, 7, 11, 22, 5, 749, DateTimeKind.Utc).AddTicks(2519), "Sed autem consectetur voluptate illo expedita excepturi.\nIllo voluptas et aliquid amet consequatur eveniet.\nVoluptas aliquam quo blanditiis in cumque maiores.", "Eileen Hirthe", 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 3, new DateTime(2022, 5, 27, 21, 3, 2, 716, DateTimeKind.Utc).AddTicks(1593), new DateTime(3981, 8, 12, 6, 45, 19, 944, DateTimeKind.Utc).AddTicks(9709), "Quae quos tenetur omnis atque odit sequi sed voluptatem doloremque.\nRecusandae quasi maxime et placeat odit vero eaque sit ex.\nAlias debitis mollitia provident quia impedit est.\nId officia dolorum ut.", "Guadalupe Tillman", 18 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 7, new DateTime(2016, 4, 14, 10, 35, 4, 573, DateTimeKind.Utc).AddTicks(7095), new DateTime(7909, 3, 28, 14, 49, 9, 695, DateTimeKind.Utc).AddTicks(8441), "Provident dolores pariatur consequuntur dolorem est.\nVoluptas ullam facere et inventore aut consequatur ut.\nVoluptatum qui vel ea quasi occaecati odio.\nDolorem sit laboriosam non corporis.\nOccaecati eos autem odio.\nEligendi ipsa maxime labore eaque est.", "Creola Schowalter", 19 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 4, new DateTime(2018, 3, 21, 0, 55, 13, 755, DateTimeKind.Utc).AddTicks(7220), new DateTime(2108, 9, 11, 3, 32, 28, 765, DateTimeKind.Utc).AddTicks(1826), "Cum ut consectetur cupiditate quia velit. Ducimus est incidunt non consequatur nihil. Reiciendis aut non beatae assumenda quasi quae blanditiis.", "Nona Pacocha", 13 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 8, new DateTime(2020, 4, 6, 8, 53, 27, 809, DateTimeKind.Utc).AddTicks(4876), new DateTime(4839, 5, 28, 2, 12, 44, 610, DateTimeKind.Utc).AddTicks(6583), "Consequuntur quo incidunt animi fuga et officia voluptates qui. Est ut et et vel qui quod veniam. Inventore rerum inventore et officiis quidem nemo mollitia laborum voluptatem. Corrupti earum alias soluta non et culpa. Ut maxime exercitationem explicabo et vitae qui nesciunt.", "Dee Schiller", 9 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 9, new DateTime(2015, 4, 23, 0, 15, 32, 561, DateTimeKind.Utc).AddTicks(4358), new DateTime(8159, 3, 1, 8, 59, 4, 97, DateTimeKind.Utc).AddTicks(5166), "Ea qui fugit atque. Beatae at dolorem soluta qui nihil sequi. Ipsum aperiam porro.", "Eliezer Miller", 11 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2021, 12, 11, 2, 47, 29, 895, DateTimeKind.Utc).AddTicks(5295), new DateTime(7067, 5, 20, 19, 27, 25, 641, DateTimeKind.Utc).AddTicks(2050), "Dolorum quaerat molestiae at voluptate aut velit consequatur veniam quia. Quaerat fuga magni voluptates deleniti. Et rem nesciunt ea non quis odio. Magni quis quia laboriosam nam assumenda iusto voluptas ut. Rerum fuga nobis quis consequatur esse. Non sapiente fuga.", "Jacynthe Batz", 17 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2015, 12, 19, 22, 58, 54, 61, DateTimeKind.Utc).AddTicks(7482), "libero", new DateTime(8109, 3, 18, 15, 17, 41, 169, DateTimeKind.Utc).AddTicks(5271), "Isobel King", 12, 5 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2017, 3, 27, 22, 3, 48, 838, DateTimeKind.Utc).AddTicks(8445), "esse", new DateTime(5333, 12, 9, 12, 22, 2, 690, DateTimeKind.Utc).AddTicks(5672), "Mac Herman", 20, 16, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2019, 3, 9, 1, 1, 55, 427, DateTimeKind.Utc).AddTicks(4158), "Inventore qui quas accusantium sunt eum ab.", new DateTime(7315, 3, 21, 2, 31, 29, 966, DateTimeKind.Utc).AddTicks(7167), "Desmond Casper", 15, 20 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 12, 17, 16, 22, 8, 247, DateTimeKind.Utc).AddTicks(1280), "consequatur", new DateTime(3345, 2, 9, 11, 54, 8, 111, DateTimeKind.Utc).AddTicks(9405), "Amie Littel", 3, 9, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 11, 13, 11, 20, 59, 993, DateTimeKind.Utc).AddTicks(1969), "Sint quisquam impedit laborum qui tempore qui delectus reiciendis. Perspiciatis tempora quasi voluptatem rerum porro rerum dolores recusandae ipsa. Id ipsa consequatur consequuntur quidem illum voluptas.", new DateTime(4140, 6, 12, 6, 56, 34, 984, DateTimeKind.Utc).AddTicks(9898), "Augustus Kilback", 9, 19, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2017, 12, 29, 8, 21, 24, 234, DateTimeKind.Utc).AddTicks(5226), "Voluptas autem velit dolorem. Omnis quia doloribus quidem voluptatem enim. Itaque deleniti necessitatibus aliquid sunt eaque numquam voluptates occaecati. Non ratione ratione sit incidunt.", new DateTime(6190, 5, 18, 16, 24, 30, 152, DateTimeKind.Utc).AddTicks(9435), "Dan Windler", 17, 20, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 10, 4, 14, 52, 50, 503, DateTimeKind.Utc).AddTicks(4189), "Tenetur numquam quas inventore recusandae dolore laboriosam excepturi unde.\nVitae ex magni non autem nulla expedita ut.\nSit numquam repudiandae.\nUnde dolor amet qui molestiae temporibus sed dolorum est.", new DateTime(6346, 2, 28, 7, 57, 41, 78, DateTimeKind.Utc).AddTicks(6202), "Godfrey Halvorson", 7, 3, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2015, 5, 30, 1, 50, 32, 526, DateTimeKind.Utc).AddTicks(2022), "Consequatur quis commodi.", new DateTime(9838, 12, 27, 6, 19, 40, 219, DateTimeKind.Utc).AddTicks(9313), "Rex Aufderhar", 5, 10 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2013, 8, 26, 17, 33, 37, 115, DateTimeKind.Utc).AddTicks(288), "Nulla blanditiis architecto alias itaque maxime omnis qui iure sunt. Facere iusto quod velit eos sunt. Aliquam hic hic sed quasi expedita iure quis voluptas. Praesentium ipsa cumque voluptatem harum. Accusantium dolores explicabo tempore cum aperiam iusto.", new DateTime(7327, 9, 12, 8, 11, 29, 640, DateTimeKind.Utc).AddTicks(7114), "Elijah Walsh", 10, 20, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2015, 12, 14, 13, 58, 31, 305, DateTimeKind.Utc).AddTicks(3849), "At et est. Quisquam nam et consequuntur. Pariatur quod dicta occaecati. Ipsa occaecati sapiente recusandae sapiente unde perspiciatis qui. Dicta dolores natus id tempore voluptate impedit consequuntur ipsum voluptatem. Est eum culpa vitae natus magnam quidem ratione porro cumque.", new DateTime(5911, 11, 10, 1, 44, 43, 421, DateTimeKind.Utc).AddTicks(5411), "Lesley Reichert", 5, 4, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "State" },
                values: new object[] { new DateTime(2022, 4, 27, 8, 19, 3, 475, DateTimeKind.Utc).AddTicks(640), "Fugiat est molestiae quia quae vel sunt omnis id.\nDolorem atque quia dolores reiciendis quia mollitia.", new DateTime(2792, 1, 30, 21, 12, 50, 874, DateTimeKind.Utc).AddTicks(426), "Heaven Jones", 17, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 56, 56, 702, DateTimeKind.Utc).AddTicks(2981), "Enim nam reprehenderit debitis molestiae voluptas quaerat numquam qui. Sunt ipsa quia. Libero sunt libero nihil. Assumenda saepe occaecati id qui fugiat est.", new DateTime(3365, 9, 8, 13, 56, 2, 615, DateTimeKind.Utc).AddTicks(6958), "Jonathon Lind", 6, 9, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2021, 6, 16, 16, 52, 59, 876, DateTimeKind.Utc).AddTicks(4451), "voluptatem", new DateTime(9408, 6, 1, 13, 14, 32, 347, DateTimeKind.Utc).AddTicks(9084), "Justice Murphy", 5, 7, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2022, 4, 24, 12, 38, 50, 904, DateTimeKind.Utc).AddTicks(741), "Atque et delectus. Nostrum qui illum ipsam amet est illum sapiente doloribus quam. Molestias similique voluptatem provident nisi eos quia. Et veritatis aut architecto omnis blanditiis non numquam. Officia vel qui. Consequatur eligendi quam eveniet.", new DateTime(3568, 2, 8, 18, 32, 36, 424, DateTimeKind.Utc).AddTicks(7354), "Connie Okuneva", 5, 18, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 53, 34, 541, DateTimeKind.Utc).AddTicks(4317), "Quod autem qui autem necessitatibus consequatur quaerat eius et voluptas. Et autem adipisci. Eveniet fugiat nesciunt voluptatem consequuntur omnis. Quam adipisci qui.", new DateTime(6405, 2, 8, 13, 17, 48, 498, DateTimeKind.Utc).AddTicks(4075), "Dominique Gislason", 18, 7, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2014, 4, 29, 20, 14, 17, 30, DateTimeKind.Utc).AddTicks(8810), "Natus fugit ea neque necessitatibus.", new DateTime(4938, 11, 30, 12, 32, 34, 139, DateTimeKind.Utc).AddTicks(2409), "Susanna Murphy", 17, 3 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "ProjectId", "State" },
                values: new object[] { new DateTime(2021, 5, 18, 9, 4, 51, 220, DateTimeKind.Utc).AddTicks(3095), "distinctio", new DateTime(5853, 12, 25, 23, 53, 48, 265, DateTimeKind.Utc).AddTicks(5462), "Jefferey Casper", 14, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2019, 3, 15, 8, 38, 53, 157, DateTimeKind.Utc).AddTicks(6182), "At voluptate et eveniet corporis inventore nihil. Aut aut quia assumenda. Eius quasi natus consequatur dolores assumenda et. Quia officiis ut aliquid veniam inventore odio.", new DateTime(9847, 11, 23, 23, 41, 39, 606, DateTimeKind.Utc).AddTicks(4235), "Janet Daniel", 19, 8, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 21, 10, 133, DateTimeKind.Utc).AddTicks(1850), "Ipsum laborum officia hic ratione sunt natus ullam.\nEst iste sed alias ut tempora.\nNostrum nemo qui id.\nQuia pariatur eos deserunt.", new DateTime(4804, 5, 5, 13, 58, 59, 217, DateTimeKind.Utc).AddTicks(2816), "Kelsie Prohaska", 13, 1, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "State" },
                values: new object[] { new DateTime(2020, 10, 29, 17, 37, 50, 944, DateTimeKind.Utc).AddTicks(4448), "quas", new DateTime(5588, 7, 26, 3, 54, 34, 304, DateTimeKind.Utc).AddTicks(7524), "Casey Frami", 16, 2 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 5, 31, 15, 28, 17, 317, DateTimeKind.Utc).AddTicks(8091), "Christiana Cronin" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2017, 4, 23, 6, 37, 31, 754, DateTimeKind.Utc).AddTicks(2037), "Vernice Doyle" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 2, 5, 20, 10, 55, 872, DateTimeKind.Utc).AddTicks(8573), "Rafael Jerde" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2018, 11, 25, 13, 16, 6, 321, DateTimeKind.Utc).AddTicks(9765), "Harold Koelpin" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2016, 9, 19, 19, 6, 48, 300, DateTimeKind.Utc).AddTicks(2305), "Myrtie Carter" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2015, 11, 18, 3, 50, 14, 338, DateTimeKind.Utc).AddTicks(7485), "Matilde Wilderman" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2015, 9, 8, 8, 17, 25, 485, DateTimeKind.Utc).AddTicks(2914), "Macy Luettgen" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 8, 6, 19, 29, 30, 246, DateTimeKind.Utc).AddTicks(4721), "Alexandrea McGlynn" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 5, 17, 12, 58, 1, 52, DateTimeKind.Utc).AddTicks(7921), "Jefferey Leffler" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 6, 15, 17, 50, 10, 326, DateTimeKind.Utc).AddTicks(9314), "Antonina Lang" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2017, 8, 20, 11, 56, 53, 146, DateTimeKind.Utc).AddTicks(1109), "Raymundo Tremblay" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2015, 12, 14, 10, 25, 29, 56, DateTimeKind.Utc).AddTicks(8084), "Else Wunsch" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2018, 10, 21, 1, 32, 4, 363, DateTimeKind.Utc).AddTicks(3400), "Amely Wehner" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2015, 2, 7, 20, 37, 34, 222, DateTimeKind.Utc).AddTicks(3524), "Albina Metz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2017, 4, 19, 23, 48, 7, 930, DateTimeKind.Utc).AddTicks(8937), "Jeffrey Harber" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 4, 1, 14, 49, 57, 891, DateTimeKind.Utc).AddTicks(1186), "Daryl Gusikowski" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 11, 26, 0, 40, 52, 256, DateTimeKind.Utc).AddTicks(7583), "Genesis Herman" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 1, 7, 8, 22, 26, 899, DateTimeKind.Utc).AddTicks(73), "Barton Witting" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2017, 12, 2, 13, 7, 37, 99, DateTimeKind.Utc).AddTicks(8754), "Timmy Lemke" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 5, 17, 16, 40, 43, 882, DateTimeKind.Utc).AddTicks(6663), "Kenny Wolff" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2015, 12, 11, 15, 48, 27, 267, DateTimeKind.Utc).AddTicks(7529), "Erna_Kovacek@gmail.com", "Braden", "Kuhlman", new DateTime(2014, 2, 24, 2, 44, 29, 127, DateTimeKind.Utc).AddTicks(5696), 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2020, 8, 3, 6, 59, 24, 211, DateTimeKind.Utc).AddTicks(2446), "Nella_Collins@yahoo.com", "Shaylee", "Wuckert", new DateTime(2016, 1, 14, 21, 36, 52, 731, DateTimeKind.Utc).AddTicks(5573), 18 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2021, 4, 25, 2, 33, 12, 659, DateTimeKind.Utc).AddTicks(9275), "Lydia32@gmail.com", "Iliana", "Cummings", new DateTime(2022, 10, 25, 18, 50, 2, 570, DateTimeKind.Utc).AddTicks(2647), 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2009, 1, 31, 9, 40, 0, 85, DateTimeKind.Utc).AddTicks(1189), "Abagail_Hermiston54@hotmail.com", "Vernice", "Walter", new DateTime(2017, 5, 7, 10, 55, 46, 186, DateTimeKind.Utc).AddTicks(2796), 13 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt" },
                values: new object[] { new DateTime(2010, 12, 12, 11, 53, 4, 379, DateTimeKind.Utc).AddTicks(9277), "Albert.Kling@gmail.com", "Alize", "Quitzon", new DateTime(2018, 1, 28, 0, 25, 48, 641, DateTimeKind.Utc).AddTicks(7389) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2018, 9, 3, 18, 51, 23, 429, DateTimeKind.Utc).AddTicks(412), "Gillian_Mitchell65@yahoo.com", "Libbie", "Ratke", new DateTime(2014, 10, 13, 8, 3, 53, 581, DateTimeKind.Utc).AddTicks(8924), 18 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2018, 7, 24, 7, 8, 15, 650, DateTimeKind.Utc).AddTicks(7415), "Serena73@yahoo.com", "Maudie", "Heller", new DateTime(2023, 7, 8, 13, 50, 54, 72, DateTimeKind.Utc).AddTicks(9108), 17 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2008, 8, 13, 6, 56, 38, 873, DateTimeKind.Utc).AddTicks(8021), "Camron_Kutch@hotmail.com", "Deborah", "Hand", new DateTime(2018, 2, 24, 14, 28, 2, 500, DateTimeKind.Utc).AddTicks(3156), 14 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2004, 6, 5, 9, 27, 8, 62, DateTimeKind.Utc).AddTicks(5059), "Kelley_Ernser90@yahoo.com", "Kameron", "Reichel", new DateTime(2017, 4, 19, 16, 11, 0, 241, DateTimeKind.Utc).AddTicks(2583), 11 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2011, 10, 16, 8, 3, 5, 103, DateTimeKind.Utc).AddTicks(6684), "Nettie.Lind@hotmail.com", "Lenny", "Ward", new DateTime(2018, 5, 10, 7, 57, 6, 111, DateTimeKind.Utc).AddTicks(4685), 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(1995, 8, 5, 20, 14, 25, 388, DateTimeKind.Utc).AddTicks(2211), "Ray31@yahoo.com", "Torey", "Stokes", new DateTime(2021, 4, 23, 8, 42, 9, 32, DateTimeKind.Utc).AddTicks(3785), 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2000, 6, 29, 11, 23, 14, 627, DateTimeKind.Utc).AddTicks(1792), "Chasity.Johnston97@gmail.com", "Gino", "Kilback", new DateTime(2017, 1, 13, 1, 11, 41, 611, DateTimeKind.Utc).AddTicks(8108), 15 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2020, 2, 11, 5, 49, 1, 669, DateTimeKind.Utc).AddTicks(2238), "Felicity54@gmail.com", "Ladarius", "Trantow", new DateTime(2023, 2, 18, 5, 59, 31, 542, DateTimeKind.Utc).AddTicks(6954), 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2020, 5, 9, 9, 14, 21, 186, DateTimeKind.Utc).AddTicks(7857), "Shad_Gislason31@yahoo.com", "Edyth", "Emmerich", new DateTime(2018, 12, 14, 14, 1, 48, 985, DateTimeKind.Utc).AddTicks(9951), 6 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(1994, 11, 6, 3, 25, 51, 569, DateTimeKind.Utc).AddTicks(4331), "Larry_Abernathy@yahoo.com", "Evie", "Gutkowski", new DateTime(2015, 5, 18, 2, 18, 24, 534, DateTimeKind.Utc).AddTicks(9089), 6 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2007, 5, 11, 12, 59, 20, 768, DateTimeKind.Utc).AddTicks(6750), "Alisa63@yahoo.com", "Nathanial", "Huel", new DateTime(2019, 9, 3, 16, 37, 16, 696, DateTimeKind.Utc).AddTicks(5959), 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2005, 5, 19, 4, 47, 1, 169, DateTimeKind.Utc).AddTicks(3200), "Adela32@gmail.com", "Nick", "Weimann", new DateTime(2015, 10, 1, 22, 7, 29, 82, DateTimeKind.Utc).AddTicks(5947), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2013, 4, 22, 19, 19, 31, 623, DateTimeKind.Utc).AddTicks(3034), "Geovanny_Gleichner@gmail.com", "Maegan", "Rowe", new DateTime(2020, 2, 1, 8, 35, 45, 845, DateTimeKind.Utc).AddTicks(2244), 8 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2023, 5, 2, 12, 22, 19, 390, DateTimeKind.Utc).AddTicks(857), "Randi.Rolfson59@yahoo.com", "Pattie", "Heathcote", new DateTime(2018, 5, 29, 3, 28, 17, 149, DateTimeKind.Utc).AddTicks(4997), 12 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2004, 3, 4, 19, 26, 3, 63, DateTimeKind.Utc).AddTicks(9444), "Henry.Jaskolski@gmail.com", "Lori", "Cummerata", new DateTime(2022, 2, 3, 18, 6, 28, 995, DateTimeKind.Utc).AddTicks(440), 12 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2021, 8, 17, 12, 36, 12, 319, DateTimeKind.Utc).AddTicks(4012), new DateTime(5148, 12, 14, 16, 21, 25, 489, DateTimeKind.Utc).AddTicks(1447), "Saepe odit dolores eum non.", "Efrain Davis", 8 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 3, new DateTime(2021, 4, 20, 12, 21, 18, 877, DateTimeKind.Utc).AddTicks(828), new DateTime(7382, 12, 2, 4, 41, 15, 293, DateTimeKind.Utc).AddTicks(7514), "Cupiditate modi ipsa expedita beatae voluptates delectus rerum.", "Elisabeth Legros", 11 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 2, new DateTime(2020, 10, 8, 12, 32, 23, 69, DateTimeKind.Utc).AddTicks(6384), new DateTime(9087, 6, 3, 17, 7, 26, 365, DateTimeKind.Utc).AddTicks(739), "Cum voluptas est voluptas. Repellat voluptatem et est quis non sed. Aspernatur recusandae eaque sit occaecati omnis alias quia. Quod quia inventore ipsa beatae adipisci. Et omnis ex aut maiores.", "Prudence Farrell", 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2021, 1, 7, 20, 46, 45, 528, DateTimeKind.Utc).AddTicks(2799), new DateTime(8843, 11, 6, 11, 35, 51, 862, DateTimeKind.Utc).AddTicks(2336), "Facilis qui odio et aut. Repellendus culpa eligendi dolorum. Quo voluptatem dolore repellendus occaecati velit qui ut.", "Johanna Hand", 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 16, new DateTime(2020, 2, 8, 4, 27, 37, 428, DateTimeKind.Utc).AddTicks(9745), new DateTime(3675, 5, 5, 16, 1, 2, 473, DateTimeKind.Utc).AddTicks(9134), "Possimus et velit et.", "Mathilde Renner", 19 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 14, new DateTime(2016, 12, 20, 17, 25, 59, 567, DateTimeKind.Utc).AddTicks(8810), new DateTime(3205, 10, 8, 1, 36, 49, 60, DateTimeKind.Utc).AddTicks(7802), "Sunt explicabo quia nobis reiciendis cupiditate ipsam ullam vel.", "Lloyd Goldner", 13 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 6, new DateTime(2014, 1, 28, 15, 4, 0, 390, DateTimeKind.Utc).AddTicks(158), new DateTime(5705, 2, 20, 2, 32, 53, 337, DateTimeKind.Utc).AddTicks(3185), "dolor", "Providenci Rice", 12 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name" },
                values: new object[] { 7, new DateTime(2022, 7, 28, 12, 40, 57, 829, DateTimeKind.Utc).AddTicks(200), new DateTime(2343, 6, 16, 19, 35, 57, 32, DateTimeKind.Utc).AddTicks(6773), "Omnis eveniet est iste. Ex quam hic. Minima temporibus possimus molestiae sit accusantium quod tempora.", "Roberto Huel" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 7, new DateTime(2014, 11, 14, 4, 52, 32, 908, DateTimeKind.Utc).AddTicks(8022), new DateTime(5133, 11, 4, 6, 7, 37, 307, DateTimeKind.Utc).AddTicks(7402), "Amet incidunt nam labore iusto excepturi. Perferendis in sit. Rerum rerum sed dolores repellendus.", "Dayton Nicolas", 16 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 20, new DateTime(2014, 9, 4, 19, 35, 14, 655, DateTimeKind.Utc).AddTicks(5046), new DateTime(8137, 5, 16, 0, 49, 20, 799, DateTimeKind.Utc).AddTicks(3045), "Neque sint provident sequi rerum officiis molestiae occaecati totam iste. Eveniet veniam enim ipsum et commodi reiciendis. Repellat odit unde quo laudantium distinctio quidem facilis sit. Adipisci a ipsum vel.", "Myriam Schumm", 12 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 19, new DateTime(2023, 4, 13, 17, 5, 13, 221, DateTimeKind.Utc).AddTicks(3109), new DateTime(8643, 10, 17, 8, 34, 33, 274, DateTimeKind.Utc).AddTicks(3393), "Sit ex illum illo in officia. Numquam et magni esse est recusandae incidunt aspernatur aliquam praesentium. Repellendus aut saepe facilis enim.", "Zakary Lakin", 5 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 18, new DateTime(2017, 1, 30, 2, 32, 33, 273, DateTimeKind.Utc).AddTicks(4702), new DateTime(7172, 6, 14, 2, 25, 52, 869, DateTimeKind.Utc).AddTicks(1370), "Aut ipsam quia qui non tempora nihil aliquid velit.\nIn autem omnis a repellat.", "Kadin Johnson", 13 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2023, 7, 17, 12, 24, 12, 70, DateTimeKind.Utc).AddTicks(1829), new DateTime(5339, 1, 19, 10, 26, 44, 189, DateTimeKind.Utc).AddTicks(8864), "adipisci", "Skylar Stark", 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 11, new DateTime(2017, 8, 2, 19, 17, 2, 495, DateTimeKind.Utc).AddTicks(3552), new DateTime(8223, 3, 20, 1, 29, 37, 814, DateTimeKind.Utc).AddTicks(5069), "exercitationem", "Gerald Reichert", 20 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 9, new DateTime(2023, 1, 16, 21, 23, 49, 859, DateTimeKind.Utc).AddTicks(1031), new DateTime(3740, 3, 7, 18, 29, 15, 265, DateTimeKind.Utc).AddTicks(5088), "Officiis itaque sed quia corporis et officiis perspiciatis. Sit vitae quia repudiandae. Rerum rerum fugit.", "Gina Fritsch", 15 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 2, new DateTime(2020, 2, 14, 5, 19, 58, 521, DateTimeKind.Utc).AddTicks(1397), new DateTime(6334, 7, 24, 16, 6, 53, 710, DateTimeKind.Utc).AddTicks(7363), "Maiores nobis voluptatem ut totam.", "Cali Hills", 13 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 3, new DateTime(2016, 9, 18, 12, 1, 9, 441, DateTimeKind.Utc).AddTicks(7060), new DateTime(7226, 10, 24, 14, 26, 12, 407, DateTimeKind.Utc).AddTicks(3097), "Eum aut sit ut laudantium neque sit nulla.\nConsequuntur nobis molestiae id cum doloremque vel aspernatur.\nVero delectus quia doloribus expedita numquam delectus qui voluptas.", "Rosemarie Ziemann", 5 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 19, new DateTime(2015, 12, 17, 20, 25, 8, 430, DateTimeKind.Utc).AddTicks(1847), new DateTime(4922, 9, 10, 10, 35, 31, 27, DateTimeKind.Utc).AddTicks(8222), "recusandae", "Burdette Donnelly", 20 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 7, new DateTime(2018, 8, 10, 17, 28, 43, 657, DateTimeKind.Utc).AddTicks(7477), new DateTime(4064, 5, 18, 23, 5, 0, 636, DateTimeKind.Utc).AddTicks(4312), "Neque ducimus iure amet velit sed.\nQuidem ut sequi eos quia.\nSit commodi repellendus.\nEt sint doloribus voluptatem distinctio qui cum neque dolorem.", "Tom Bailey", 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { new DateTime(2020, 6, 20, 17, 47, 8, 651, DateTimeKind.Utc).AddTicks(3465), new DateTime(4299, 8, 30, 14, 32, 48, 62, DateTimeKind.Utc).AddTicks(3080), "molestias", "Elena Hane", 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2019, 3, 29, 14, 50, 27, 911, DateTimeKind.Utc).AddTicks(5244), "Molestiae sequi beatae est minus adipisci id minus qui. Perspiciatis ullam officia ipsa similique voluptate. Enim corrupti vero voluptas iste voluptates dignissimos ducimus. Voluptas delectus illo sint ducimus omnis impedit fugit. Suscipit tempore autem est ut nobis.", new DateTime(4194, 3, 8, 0, 51, 39, 643, DateTimeKind.Utc).AddTicks(48), "Queenie Connelly", 10, 6 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2016, 11, 25, 9, 10, 31, 575, DateTimeKind.Utc).AddTicks(813), "Cumque molestiae recusandae corrupti enim tempore earum. Est et voluptatem illum. Vel incidunt repellat totam quo natus corporis. Rem necessitatibus eius optio ratione ea quos repudiandae nulla. Voluptatibus at consequatur non.", new DateTime(5859, 2, 16, 1, 50, 36, 317, DateTimeKind.Utc).AddTicks(6043), "Jordan Kassulke", 16, 14, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2022, 2, 28, 20, 35, 44, 650, DateTimeKind.Utc).AddTicks(8066), "Blanditiis nihil quis quae.\nHarum debitis nulla officiis sed corporis iste.\nIllum harum distinctio praesentium corrupti tempora dolor magni nam.\nEt aut iure amet non.\nVoluptatibus odit consectetur ea.\nCorrupti incidunt tempore quis ex qui omnis non iusto laborum.", new DateTime(5435, 7, 29, 11, 53, 54, 529, DateTimeKind.Utc).AddTicks(9264), "Anika Upton", 7, 8 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2021, 7, 6, 5, 9, 15, 413, DateTimeKind.Utc).AddTicks(5817), "Sed molestiae facilis modi. Eos saepe alias aut. Pariatur animi itaque iste et.", new DateTime(5296, 1, 17, 11, 59, 48, 509, DateTimeKind.Utc).AddTicks(5172), "Douglas Lindgren", 8, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 9, 6, 3, 49, 32, 141, DateTimeKind.Utc).AddTicks(8711), "Explicabo eos provident et quo consequatur cum delectus esse repudiandae.", new DateTime(7788, 11, 28, 21, 13, 47, 267, DateTimeKind.Utc).AddTicks(9154), "Noemi Kassulke", 16, 17, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 11, 29, 12, 52, 44, 306, DateTimeKind.Utc).AddTicks(486), "perferendis", new DateTime(9445, 1, 23, 17, 39, 37, 400, DateTimeKind.Utc).AddTicks(5837), "Dianna Monahan", 5, 10, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 4, 6, 15, 22, 28, 776, DateTimeKind.Utc).AddTicks(4022), "Quia possimus quam praesentium ut reprehenderit est molestias sed sed.\nBlanditiis reprehenderit ad facilis aut quasi.\nQuia laborum vero qui maiores omnis.\nAliquid tempore rerum quibusdam reiciendis et eaque doloribus.", new DateTime(4111, 7, 30, 21, 1, 51, 308, DateTimeKind.Utc).AddTicks(8076), "Emmy Graham", 19, 16, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2017, 7, 10, 15, 53, 40, 151, DateTimeKind.Utc).AddTicks(2913), "Mollitia est dolor a id.\nEarum veniam tempora.\nConsequatur nisi illum et labore tenetur atque libero commodi.\nNesciunt quo nulla sed nemo enim sed tempora vero hic.\nEos quis veritatis saepe iure totam dolorum id aspernatur voluptate.\nUt eveniet possimus harum vel.", new DateTime(7360, 6, 15, 11, 51, 27, 791, DateTimeKind.Utc).AddTicks(2795), "Loyal Nienow", 7, 15 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2022, 2, 24, 2, 13, 48, 978, DateTimeKind.Utc).AddTicks(5382), "Quia corrupti ut incidunt sunt.", new DateTime(3709, 6, 21, 4, 56, 29, 157, DateTimeKind.Utc).AddTicks(5448), "Carli Fisher", 16, 9, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2014, 10, 22, 14, 24, 29, 157, DateTimeKind.Utc).AddTicks(4134), "Id illum sit error dolorum.", new DateTime(3077, 11, 2, 12, 6, 41, 462, DateTimeKind.Utc).AddTicks(2809), "Monroe Robel", 15, 12, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "State" },
                values: new object[] { new DateTime(2020, 9, 17, 12, 14, 16, 33, DateTimeKind.Utc).AddTicks(3349), "Impedit et sint minima vero maiores.", new DateTime(3136, 11, 1, 15, 2, 15, 618, DateTimeKind.Utc).AddTicks(7463), "Viola Bartoletti", 14, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2020, 2, 4, 11, 39, 37, 588, DateTimeKind.Utc).AddTicks(4573), "Recusandae officia voluptatem omnis aut rerum sunt.\nRerum soluta nisi rerum voluptatem et dolorum odio aut.\nFugiat sunt in eos similique non odio dolore.\nSunt quae velit.\nCommodi tempora sunt nesciunt sit dolor voluptas ut aut dolor.\nEveniet nisi aut possimus sed voluptatem aut veritatis est et.", new DateTime(6334, 11, 11, 3, 50, 24, 921, DateTimeKind.Utc).AddTicks(4811), "Loyal Beahan", 19, 20, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2023, 6, 2, 21, 9, 46, 937, DateTimeKind.Utc).AddTicks(8520), "Et dolor quia sed sit et cum.", new DateTime(5382, 4, 5, 8, 45, 16, 388, DateTimeKind.Utc).AddTicks(9893), "Erin O'Hara", 15, 8, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2017, 9, 30, 5, 43, 46, 291, DateTimeKind.Utc).AddTicks(6018), "Aspernatur nihil sed debitis accusamus est modi quis. Sed qui recusandae reiciendis. Autem et aut reprehenderit architecto. Quia dolores voluptate. Qui nulla voluptatem voluptate quisquam quas officiis natus quam officiis.", new DateTime(6874, 12, 17, 13, 5, 36, 111, DateTimeKind.Utc).AddTicks(7929), "Johnny Hamill", 12, 16, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2015, 6, 2, 17, 26, 11, 399, DateTimeKind.Utc).AddTicks(3001), "Sapiente consequatur harum error consectetur qui consequatur laboriosam aut.", new DateTime(9270, 3, 25, 19, 0, 53, 771, DateTimeKind.Utc).AddTicks(9722), "Marquis Kling", 13, 18, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2019, 5, 28, 12, 55, 10, 10, DateTimeKind.Utc).AddTicks(8181), "Molestias blanditiis in est labore sed est placeat impedit. Pariatur molestiae autem natus. Est voluptate commodi soluta soluta. Officia quisquam animi voluptas incidunt temporibus deserunt assumenda. Minus excepturi ut tempore quia aut temporibus porro autem. Error corporis reprehenderit.", new DateTime(6596, 1, 31, 11, 1, 53, 744, DateTimeKind.Utc).AddTicks(6626), "Ronaldo Larkin", 14, 18 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "ProjectId", "State" },
                values: new object[] { new DateTime(2019, 1, 9, 4, 39, 32, 771, DateTimeKind.Utc).AddTicks(1486), "dolores", new DateTime(2248, 10, 3, 23, 50, 16, 466, DateTimeKind.Utc).AddTicks(2920), "Heber Conroy", 19, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 8, 21, 19, 8, 17, 16, DateTimeKind.Utc).AddTicks(7320), "quo", new DateTime(7485, 12, 7, 1, 5, 1, 886, DateTimeKind.Utc).AddTicks(5598), "Tiara Vandervort", 16, 3, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2023, 4, 9, 3, 14, 59, 372, DateTimeKind.Utc).AddTicks(3427), "ut", new DateTime(9033, 11, 24, 16, 59, 56, 970, DateTimeKind.Utc).AddTicks(5223), "Lorena Lynch", 10, 8, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "State" },
                values: new object[] { new DateTime(2023, 3, 20, 0, 50, 59, 937, DateTimeKind.Utc).AddTicks(4069), "distinctio", new DateTime(2897, 12, 20, 21, 5, 19, 960, DateTimeKind.Utc).AddTicks(3789), "Stanford Parisian", 15, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2017, 2, 4, 21, 56, 57, 112, DateTimeKind.Utc).AddTicks(7105), "Leonardo Champlin" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2018, 1, 28, 19, 44, 9, 775, DateTimeKind.Utc).AddTicks(2964), "Eusebio Kessler" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2018, 10, 26, 11, 40, 48, 698, DateTimeKind.Utc).AddTicks(8077), "Newton Wolff" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2016, 6, 13, 23, 22, 6, 99, DateTimeKind.Utc).AddTicks(58), "Garnet Batz" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2013, 11, 24, 1, 33, 38, 332, DateTimeKind.Utc).AddTicks(3992), "Arlie Klein" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 9, 25, 4, 45, 19, 146, DateTimeKind.Utc).AddTicks(8667), "Emmie Bayer" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2017, 8, 28, 15, 34, 18, 752, DateTimeKind.Utc).AddTicks(4096), "Carmella Kerluke" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2016, 11, 19, 21, 27, 49, 947, DateTimeKind.Utc).AddTicks(5173), "Miles Ledner" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2018, 7, 1, 6, 19, 25, 235, DateTimeKind.Utc).AddTicks(4357), "Xavier Schroeder" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 4, 14, 17, 55, 52, 429, DateTimeKind.Utc).AddTicks(394), "Carleton Brown" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 12, 9, 5, 44, 31, 974, DateTimeKind.Utc).AddTicks(3856), "Percival Botsford" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 24, 12, 53, 27, 714, DateTimeKind.Utc).AddTicks(2225), "Frankie Grimes" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 8, 17, 17, 56, 45, 263, DateTimeKind.Utc).AddTicks(6552), "Effie Tremblay" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2013, 7, 23, 8, 26, 32, 947, DateTimeKind.Utc).AddTicks(5514), "Gudrun Kub" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2016, 5, 26, 10, 40, 17, 521, DateTimeKind.Utc).AddTicks(7657), "Keeley Gusikowski" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 2, 25, 17, 49, 40, 939, DateTimeKind.Utc).AddTicks(5386), "Jordan Bashirian" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 6, 2, 20, 57, 10, 123, DateTimeKind.Utc).AddTicks(2483), "Donald Cassin" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 7, 1, 21, 50, 49, 664, DateTimeKind.Utc).AddTicks(4628), "Kennith Gerlach" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 1, 3, 12, 9, 31, 401, DateTimeKind.Utc).AddTicks(3528), "Alexie Wyman" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 7, 3, 7, 2, 41, 471, DateTimeKind.Utc).AddTicks(9380), "Erwin Connelly" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2004, 11, 16, 7, 13, 18, 16, DateTimeKind.Utc).AddTicks(1838), "Ana_Goyette2@hotmail.com", "Carolyne", "Keeling", new DateTime(2019, 9, 22, 1, 45, 50, 296, DateTimeKind.Utc).AddTicks(2862), 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2002, 12, 12, 16, 32, 38, 819, DateTimeKind.Utc).AddTicks(4083), "Randal52@yahoo.com", "Amari", "Mraz", new DateTime(2019, 7, 11, 0, 23, 33, 946, DateTimeKind.Utc).AddTicks(3229), 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2012, 1, 3, 23, 27, 37, 572, DateTimeKind.Utc).AddTicks(1702), "Cielo95@gmail.com", "Noemie", "Bailey", new DateTime(2014, 11, 13, 20, 34, 37, 815, DateTimeKind.Utc).AddTicks(3623), 19 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2000, 12, 28, 5, 40, 34, 253, DateTimeKind.Utc).AddTicks(8190), "Roma28@hotmail.com", "Mariane", "Labadie", new DateTime(2013, 12, 13, 17, 5, 43, 596, DateTimeKind.Utc).AddTicks(6257), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt" },
                values: new object[] { new DateTime(1994, 3, 25, 23, 54, 30, 852, DateTimeKind.Utc).AddTicks(1409), "Dallas.Kertzmann58@yahoo.com", "Mozell", "Kemmer", new DateTime(2022, 5, 30, 19, 4, 41, 10, DateTimeKind.Utc).AddTicks(2128) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2020, 11, 3, 2, 32, 53, 199, DateTimeKind.Utc).AddTicks(2548), "Jordi.Macejkovic63@hotmail.com", "Patsy", "Cummings", new DateTime(2017, 10, 14, 14, 9, 53, 599, DateTimeKind.Utc).AddTicks(8454), 16 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2013, 4, 9, 18, 57, 36, 403, DateTimeKind.Utc).AddTicks(4330), "Nyasia2@hotmail.com", "Alberta", "Swaniawski", new DateTime(2013, 10, 21, 19, 26, 10, 356, DateTimeKind.Utc).AddTicks(1343), 19 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(1995, 11, 29, 23, 56, 11, 696, DateTimeKind.Utc).AddTicks(5692), "Lorenza77@yahoo.com", "Efren", "Grady", new DateTime(2015, 9, 17, 7, 40, 26, 867, DateTimeKind.Utc).AddTicks(9827), 6 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2001, 1, 12, 3, 10, 39, 481, DateTimeKind.Utc).AddTicks(4935), "Leta97@yahoo.com", "Wilfrid", "Lemke", new DateTime(2023, 2, 21, 19, 34, 12, 808, DateTimeKind.Utc).AddTicks(9567), 3 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2016, 7, 21, 21, 13, 58, 511, DateTimeKind.Utc).AddTicks(9268), "Landen_Mosciski@gmail.com", "Anna", "Wiegand", new DateTime(2017, 11, 8, 15, 58, 25, 83, DateTimeKind.Utc).AddTicks(2633), 11 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(1994, 11, 5, 0, 11, 51, 929, DateTimeKind.Utc).AddTicks(5396), "Conrad63@hotmail.com", "Abelardo", "Sporer", new DateTime(2014, 1, 21, 10, 26, 52, 658, DateTimeKind.Utc).AddTicks(6394), 20 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2021, 5, 30, 5, 4, 12, 162, DateTimeKind.Utc).AddTicks(644), "Antoinette_Hane20@yahoo.com", "Betty", "Kertzmann", new DateTime(2018, 12, 4, 9, 29, 45, 139, DateTimeKind.Utc).AddTicks(6228), 10 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2005, 1, 22, 15, 28, 18, 547, DateTimeKind.Utc).AddTicks(445), "Loyce.Murazik@gmail.com", "Vita", "Graham", new DateTime(2022, 10, 13, 19, 9, 23, 821, DateTimeKind.Utc).AddTicks(2490), 13 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2014, 8, 17, 5, 19, 5, 939, DateTimeKind.Utc).AddTicks(3946), "Arnold.Lubowitz15@yahoo.com", "Davonte", "Rice", new DateTime(2017, 1, 6, 9, 17, 17, 605, DateTimeKind.Utc).AddTicks(1874), 2 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2006, 7, 24, 19, 53, 39, 938, DateTimeKind.Utc).AddTicks(3932), "Conor_Miller20@gmail.com", "Chelsie", "Abbott", new DateTime(2015, 3, 21, 20, 52, 29, 314, DateTimeKind.Utc).AddTicks(949), 17 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2002, 2, 4, 6, 5, 53, 470, DateTimeKind.Utc).AddTicks(7950), "Brown.Bode@gmail.com", "Taylor", "Torp", new DateTime(2018, 2, 22, 3, 11, 11, 202, DateTimeKind.Utc).AddTicks(5287), 20 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2009, 6, 3, 4, 10, 24, 792, DateTimeKind.Utc).AddTicks(9230), "Scottie.Cremin66@yahoo.com", "Garland", "Little", new DateTime(2021, 3, 21, 7, 10, 38, 468, DateTimeKind.Utc).AddTicks(4617), 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2006, 7, 10, 18, 38, 27, 811, DateTimeKind.Utc).AddTicks(3511), "Margret_Wiegand6@gmail.com", "Pinkie", "Hamill", new DateTime(2020, 2, 27, 13, 36, 14, 403, DateTimeKind.Utc).AddTicks(7213), 5 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2007, 1, 29, 19, 34, 4, 61, DateTimeKind.Utc).AddTicks(3659), "Juvenal_Hoppe52@hotmail.com", "Julia", "Konopelski", new DateTime(2016, 2, 27, 5, 8, 14, 863, DateTimeKind.Utc).AddTicks(4208), 20 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2012, 1, 29, 22, 48, 30, 187, DateTimeKind.Utc).AddTicks(9404), "Haleigh.Cruickshank@yahoo.com", "Vilma", "Fay", new DateTime(2019, 8, 29, 21, 14, 1, 794, DateTimeKind.Utc).AddTicks(5029), 7 });
        }
    }
}
