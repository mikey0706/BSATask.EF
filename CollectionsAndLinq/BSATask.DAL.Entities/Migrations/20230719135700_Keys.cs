using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BSATask.DAL.Migrations
{
    /// <inheritdoc />
    public partial class Keys : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 9, new DateTime(2020, 7, 14, 5, 46, 52, 130, DateTimeKind.Utc).AddTicks(887), new DateTime(7888, 7, 9, 22, 17, 44, 652, DateTimeKind.Utc).AddTicks(9309), "ullam", "Francisca Schaefer", 16 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 1, new DateTime(2014, 6, 8, 21, 26, 47, 485, DateTimeKind.Utc).AddTicks(7928), new DateTime(5260, 7, 23, 20, 11, 44, 426, DateTimeKind.Utc).AddTicks(5263), "Aut repellendus nihil iusto qui distinctio necessitatibus.\nConsectetur unde velit blanditiis repellat dolores minima.\nAd et qui dicta.", "Ladarius Hane", 7 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 8, new DateTime(2019, 12, 10, 13, 27, 10, 831, DateTimeKind.Utc).AddTicks(4863), new DateTime(6700, 3, 26, 21, 43, 52, 359, DateTimeKind.Utc).AddTicks(7654), "Sequi nostrum fugit.", "Arjun Langosh", 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 13, new DateTime(2018, 12, 29, 6, 4, 56, 469, DateTimeKind.Utc).AddTicks(6452), new DateTime(6602, 6, 28, 2, 32, 39, 44, DateTimeKind.Utc).AddTicks(8507), "Harum in amet deleniti. Maiores expedita alias consectetur est et. Aut provident quae ea temporibus assumenda ratione consectetur repudiandae. Sed blanditiis aut beatae nulla mollitia.", "Queenie Moen", 11 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 19, new DateTime(2017, 7, 9, 20, 10, 46, 325, DateTimeKind.Utc).AddTicks(8384), new DateTime(6698, 11, 5, 10, 45, 0, 536, DateTimeKind.Utc).AddTicks(5563), "Ea similique natus similique perferendis assumenda voluptas adipisci. Quos eos minima quasi doloribus optio. Modi quia suscipit quas qui reiciendis.", "Reina Johns", 9 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 19, new DateTime(2022, 2, 22, 12, 25, 34, 910, DateTimeKind.Utc).AddTicks(6005), new DateTime(2890, 8, 30, 13, 1, 12, 580, DateTimeKind.Utc).AddTicks(9393), "Similique deleniti ullam.\nOmnis error sit eum et quibusdam suscipit atque.\nQuas omnis et officia ipsa esse.\nEos voluptates dolores mollitia esse consequuntur sint cum nostrum voluptatem.", "Elliott Graham", 18 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 12, new DateTime(2018, 5, 5, 9, 45, 45, 844, DateTimeKind.Utc).AddTicks(4883), new DateTime(5815, 6, 6, 18, 18, 10, 317, DateTimeKind.Utc).AddTicks(3176), "Neque at omnis nam dolore ipsum dicta dolorem eos.\nOmnis similique ut id eos rerum.", "Torey Witting", 19 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 18, new DateTime(2014, 12, 19, 22, 48, 46, 755, DateTimeKind.Utc).AddTicks(1977), new DateTime(3622, 2, 17, 10, 18, 48, 959, DateTimeKind.Utc).AddTicks(854), "aut", "Daryl Effertz", 7 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 12, new DateTime(2016, 11, 28, 10, 52, 54, 40, DateTimeKind.Utc).AddTicks(8555), new DateTime(4235, 3, 13, 19, 14, 2, 348, DateTimeKind.Utc).AddTicks(4869), "Perferendis repellendus aliquid aspernatur reiciendis. Labore iste facilis tempore et. Autem et nam qui nemo repellat consequatur placeat est ipsum. Repellat nisi temporibus facere. Saepe possimus et in reprehenderit et sequi.", "Heather Abbott", 2 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 9, new DateTime(2015, 8, 17, 7, 46, 13, 787, DateTimeKind.Utc).AddTicks(5874), new DateTime(4405, 3, 20, 10, 35, 37, 323, DateTimeKind.Utc).AddTicks(6482), "Doloribus aperiam aliquid veritatis et culpa qui dolores dicta unde.", "Dino Tremblay", 6 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 20, new DateTime(2015, 12, 23, 10, 0, 32, 211, DateTimeKind.Utc).AddTicks(2929), new DateTime(5645, 10, 1, 0, 23, 37, 196, DateTimeKind.Utc).AddTicks(8059), "Perferendis explicabo veritatis architecto facere aut dolorem.\nDeleniti eum temporibus ipsam itaque.", "Birdie Bayer", 10 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 10, new DateTime(2020, 1, 1, 2, 20, 37, 254, DateTimeKind.Utc).AddTicks(3735), new DateTime(6685, 7, 2, 13, 54, 34, 960, DateTimeKind.Utc).AddTicks(7600), "Deserunt atque minus.", "Griffin Hamill", 1 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 7, new DateTime(2020, 1, 21, 14, 47, 4, 279, DateTimeKind.Utc).AddTicks(6038), new DateTime(3078, 5, 26, 4, 47, 14, 554, DateTimeKind.Utc).AddTicks(3991), "Sequi nemo blanditiis veniam autem quis veniam id quas.", "Myrtle Reynolds", 18 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 13, new DateTime(2020, 3, 31, 4, 48, 16, 616, DateTimeKind.Utc).AddTicks(2515), new DateTime(8822, 6, 21, 21, 14, 54, 511, DateTimeKind.Utc).AddTicks(2767), "Molestias voluptate ex ipsa est quia. Unde similique ab voluptas. Eum vel neque omnis est omnis aut. Porro velit tenetur illum accusantium ut. Laudantium non qui nemo fugit possimus.", "Jerrold Abbott", 12 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 4, new DateTime(2017, 5, 20, 1, 6, 47, 156, DateTimeKind.Utc).AddTicks(9958), new DateTime(3978, 1, 23, 14, 47, 55, 327, DateTimeKind.Utc).AddTicks(4385), "nobis", "Karli Donnelly", 7 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 11, new DateTime(2020, 3, 16, 2, 1, 9, 162, DateTimeKind.Utc).AddTicks(1767), new DateTime(6205, 4, 13, 12, 31, 33, 837, DateTimeKind.Utc).AddTicks(9223), "Culpa consectetur ut dolorem velit dolore non omnis voluptates est.\nRepudiandae quia quo nam.\nEos possimus eos.", "Antwan McDermott", 14 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 14, new DateTime(2013, 9, 3, 18, 40, 10, 660, DateTimeKind.Utc).AddTicks(4225), new DateTime(5373, 2, 3, 17, 26, 35, 604, DateTimeKind.Utc).AddTicks(9821), "at", "Eliza Rohan", 20 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name" },
                values: new object[] { 5, new DateTime(2016, 4, 14, 18, 44, 2, 771, DateTimeKind.Utc).AddTicks(2940), new DateTime(3936, 2, 12, 10, 36, 7, 773, DateTimeKind.Utc).AddTicks(9408), "non", "Verlie Pollich" });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 11, new DateTime(2022, 11, 6, 10, 20, 45, 375, DateTimeKind.Utc).AddTicks(7400), new DateTime(6233, 9, 29, 13, 58, 4, 135, DateTimeKind.Utc).AddTicks(1632), "minima", "Maude Beahan", 4 });

            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 14, new DateTime(2015, 6, 11, 19, 23, 16, 43, DateTimeKind.Utc).AddTicks(36), new DateTime(7990, 7, 25, 15, 55, 29, 702, DateTimeKind.Utc).AddTicks(9276), "Explicabo rerum dolorem debitis aut fuga provident nesciunt aut.\nCum exercitationem corporis aspernatur aut sapiente.\nEnim voluptatem laboriosam sit error commodi occaecati quo.\nPariatur id quo.\nPerspiciatis eius atque explicabo cum.\nNeque est qui aut quaerat nam libero amet rerum quia.", "Jonas Fadel", 16 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2020, 3, 30, 15, 7, 44, 271, DateTimeKind.Utc).AddTicks(4827), "Voluptatem aut quas ipsum et provident vero voluptatem.\nDolorem excepturi fugiat.\nMollitia ad occaecati.", new DateTime(4516, 4, 4, 20, 9, 55, 996, DateTimeKind.Utc).AddTicks(3159), "Eleanore Treutel", 15, 4, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2015, 4, 15, 11, 26, 12, 726, DateTimeKind.Utc).AddTicks(8441), "Soluta doloribus rerum molestiae deserunt ad ea tempore.\nItaque doloribus et cumque sunt.", new DateTime(2179, 9, 28, 21, 47, 51, 537, DateTimeKind.Utc).AddTicks(7407), "Efren Morissette", 15, 15 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2020, 6, 26, 14, 39, 51, 705, DateTimeKind.Utc).AddTicks(7374), "Aut molestias fuga veniam ratione tempore esse nulla nesciunt illum. Pariatur explicabo possimus hic eius quo hic quas. Mollitia in illo non non quasi. Sequi fuga deserunt dolor dolores quasi iusto necessitatibus.", new DateTime(2264, 11, 20, 3, 15, 46, 795, DateTimeKind.Utc).AddTicks(4011), "Eldora Trantow", 5, 18, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2018, 9, 21, 15, 35, 47, 775, DateTimeKind.Utc).AddTicks(1624), "Corporis itaque unde rerum rerum enim et veritatis aperiam iusto.\nSaepe est omnis explicabo et a.", new DateTime(4151, 12, 20, 18, 24, 18, 205, DateTimeKind.Utc).AddTicks(8281), "Humberto McDermott", 19, 13, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2019, 3, 25, 20, 41, 3, 635, DateTimeKind.Utc).AddTicks(7362), "neque", new DateTime(3078, 4, 7, 7, 24, 15, 580, DateTimeKind.Utc).AddTicks(4730), "Porter Hodkiewicz", 16, 17 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2022, 12, 29, 1, 30, 59, 449, DateTimeKind.Utc).AddTicks(8349), "Quaerat quia dolores dignissimos sunt doloribus sint odit velit.\nQuasi magnam est voluptate.\nUllam modi animi mollitia accusantium fugit ipsa aut exercitationem.\nSaepe suscipit ducimus autem repudiandae necessitatibus ex eum.", new DateTime(3711, 4, 10, 19, 19, 15, 422, DateTimeKind.Utc).AddTicks(5461), "Eliza Bradtke", 15, 5, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2019, 3, 4, 17, 27, 17, 979, DateTimeKind.Utc).AddTicks(3710), "nam", new DateTime(5165, 11, 25, 9, 44, 30, 300, DateTimeKind.Utc).AddTicks(8649), "Jocelyn Hamill", 3, 15, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2023, 2, 22, 8, 29, 53, 857, DateTimeKind.Utc).AddTicks(3269), "Optio natus nihil repellat. Ut iusto vel. Molestias ipsum architecto. Consequuntur vel amet ipsam in facere. Suscipit molestias voluptatibus.", new DateTime(9657, 6, 26, 9, 30, 4, 660, DateTimeKind.Utc).AddTicks(2216), "Retta Reichert", 9, 6, 1 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2017, 1, 20, 23, 49, 56, 538, DateTimeKind.Utc).AddTicks(670), "Qui nulla quo rerum ut voluptas nemo. Veniam possimus excepturi qui nulla cum aliquam ut aut. Quibusdam illo commodi rerum et non voluptatibus. Voluptas odio itaque et iure in exercitationem vel autem perspiciatis. Doloribus dicta quod sunt ex ut et.", new DateTime(9886, 9, 18, 19, 8, 57, 719, DateTimeKind.Utc).AddTicks(1819), "Melvina Reynolds", 8, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId" },
                values: new object[] { new DateTime(2019, 6, 30, 14, 47, 4, 642, DateTimeKind.Utc).AddTicks(9199), "odio", new DateTime(7772, 1, 27, 2, 55, 56, 209, DateTimeKind.Utc).AddTicks(7141), "Naomie Monahan", 20 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "State" },
                values: new object[] { new DateTime(2016, 9, 13, 1, 33, 17, 392, DateTimeKind.Utc).AddTicks(3049), "Nesciunt sequi aliquam aut ea enim est et vitae et.", new DateTime(7941, 7, 16, 6, 6, 51, 313, DateTimeKind.Utc).AddTicks(670), "Marilie Veum", 8, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2013, 7, 24, 23, 56, 36, 688, DateTimeKind.Utc).AddTicks(1127), "Perferendis dolorum vero.", new DateTime(2484, 9, 26, 8, 49, 31, 625, DateTimeKind.Utc).AddTicks(8174), "Lucienne Fay", 18, 18 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2020, 2, 17, 15, 50, 51, 861, DateTimeKind.Utc).AddTicks(8462), "Iure dolorem reprehenderit quas similique voluptatem.\nNihil eos sed voluptatibus nam illum distinctio consequatur sequi autem.", new DateTime(8678, 9, 16, 13, 54, 43, 429, DateTimeKind.Utc).AddTicks(2692), "Selmer Murray", 2, 12, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2020, 9, 24, 18, 22, 7, 197, DateTimeKind.Utc).AddTicks(1726), "Perferendis consequatur rerum sit laborum cumque aut ex hic voluptatem.\nPorro non ut.\nEt blanditiis nostrum.\nAut molestias ut tempore vitae qui perferendis itaque sed.", new DateTime(7805, 7, 11, 1, 17, 48, 540, DateTimeKind.Utc).AddTicks(8251), "Unique Strosin", 13, 4, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2014, 5, 30, 15, 3, 52, 54, DateTimeKind.Utc).AddTicks(9041), "Eos expedita cupiditate placeat omnis odio aut harum iure.", new DateTime(5180, 9, 2, 8, 21, 7, 917, DateTimeKind.Utc).AddTicks(4787), "Mikayla Balistreri", 4, 17 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2016, 7, 15, 6, 18, 53, 536, DateTimeKind.Utc).AddTicks(1801), "Vel facilis rerum asperiores.", new DateTime(2633, 9, 15, 4, 6, 28, 660, DateTimeKind.Utc).AddTicks(9128), "Samson Buckridge", 19, 13 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2017, 6, 8, 16, 17, 32, 131, DateTimeKind.Utc).AddTicks(820), "Ut ea dolore perspiciatis rerum minima asperiores facilis. Consequatur odio accusamus sapiente. Ea aut et dolorum aut. Delectus ea natus.", new DateTime(9056, 2, 15, 13, 19, 22, 5, DateTimeKind.Utc).AddTicks(9629), "Emily Wehner", 8, 10 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2019, 9, 20, 12, 33, 50, 563, DateTimeKind.Utc).AddTicks(14), "Autem qui unde facilis sint veniam impedit. Sit et placeat id repudiandae impedit. Fugiat harum consectetur omnis aspernatur laudantium velit qui sit.", new DateTime(2197, 8, 9, 10, 3, 20, 820, DateTimeKind.Utc).AddTicks(7297), "Maverick Johnston", 18, 16 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "State" },
                values: new object[] { new DateTime(2020, 7, 21, 1, 52, 14, 903, DateTimeKind.Utc).AddTicks(5516), "Facere similique aut sed enim. Qui eos et voluptas alias ratione voluptates. Harum veritatis quibusdam labore qui doloremque. Quia ea sit error. Unde aut voluptatum quibusdam qui nam dolore natus pariatur ea. Qui et velit optio dolorum magni nostrum totam.", new DateTime(4832, 6, 4, 4, 29, 11, 171, DateTimeKind.Utc).AddTicks(1069), "Darrell Abshire", 16, 0 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2021, 5, 26, 10, 7, 38, 527, DateTimeKind.Utc).AddTicks(6296), "Nesciunt quisquam laudantium aliquid aut placeat eum.", new DateTime(7426, 6, 18, 19, 58, 31, 511, DateTimeKind.Utc).AddTicks(1387), "Filiberto Braun", 20, 11, 0 });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2015, 11, 20, 3, 14, 6, 31, DateTimeKind.Utc).AddTicks(857), "Jaylon Harber" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2015, 10, 17, 23, 38, 14, 187, DateTimeKind.Utc).AddTicks(8394), "Edison Toy" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 5, 22, 3, 47, 14, 602, DateTimeKind.Utc).AddTicks(534), "Boris Swaniawski" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 11, 17, 7, 44, 16, 111, DateTimeKind.Utc).AddTicks(672), "London Koelpin" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2023, 1, 29, 19, 34, 8, 233, DateTimeKind.Utc).AddTicks(6692), "Felicity Predovic" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2020, 6, 27, 2, 49, 13, 664, DateTimeKind.Utc).AddTicks(1165), "Boris O'Kon" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 4, 1, 20, 36, 57, 215, DateTimeKind.Utc).AddTicks(4159), "Ana Cummerata" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2015, 4, 16, 13, 23, 4, 713, DateTimeKind.Utc).AddTicks(5428), "Gerson Torphy" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2016, 1, 9, 21, 44, 15, 331, DateTimeKind.Utc).AddTicks(4686), "Pearl Wunsch" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 7, 14, 22, 44, 1, 913, DateTimeKind.Utc).AddTicks(190), "Aimee Koelpin" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 8, 13, 10, 42, 10, 927, DateTimeKind.Utc).AddTicks(9352), "Retta Conroy" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2022, 3, 31, 4, 24, 47, 117, DateTimeKind.Utc).AddTicks(4769), "Florencio Funk" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2016, 11, 25, 4, 38, 6, 157, DateTimeKind.Utc).AddTicks(7354), "Efrain Zemlak" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2021, 5, 4, 19, 2, 33, 166, DateTimeKind.Utc).AddTicks(2309), "Madonna Herzog" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2013, 10, 25, 1, 59, 19, 47, DateTimeKind.Utc).AddTicks(7704), "Zachariah Rutherford" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 5, 5, 18, 22, 14, 339, DateTimeKind.Utc).AddTicks(7139), "Allison Hermiston" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2014, 6, 5, 14, 0, 8, 902, DateTimeKind.Utc).AddTicks(3316), "Mike Wunsch" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 1, 8, 21, 56, 42, 472, DateTimeKind.Utc).AddTicks(5567), "Mckenna Kirlin" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2019, 1, 7, 15, 18, 27, 9, DateTimeKind.Utc).AddTicks(2652), "Ignacio Carter" });

            migrationBuilder.UpdateData(
                table: "Teams",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Name" },
                values: new object[] { new DateTime(2013, 11, 21, 15, 3, 14, 658, DateTimeKind.Utc).AddTicks(9359), "Lucy Braun" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2008, 6, 21, 4, 4, 25, 102, DateTimeKind.Utc).AddTicks(4122), "Lucienne.Heaney@yahoo.com", "Nora", "Altenwerth", new DateTime(2017, 12, 18, 11, 24, 30, 646, DateTimeKind.Utc).AddTicks(911), 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2013, 5, 21, 13, 1, 11, 461, DateTimeKind.Utc).AddTicks(5338), "Norris.Hoeger@hotmail.com", "Dahlia", "Reynolds", new DateTime(2013, 11, 20, 2, 27, 20, 273, DateTimeKind.Utc).AddTicks(1927), 6 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2008, 11, 13, 3, 3, 3, 846, DateTimeKind.Utc).AddTicks(1189), "Rowland99@yahoo.com", "Stephania", "O'Reilly", new DateTime(2016, 5, 7, 6, 5, 15, 332, DateTimeKind.Utc).AddTicks(213), 18 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2017, 2, 1, 9, 19, 30, 908, DateTimeKind.Utc).AddTicks(7127), "Josiane_Rempel@gmail.com", "Gonzalo", "Connelly", new DateTime(2019, 8, 23, 3, 54, 46, 310, DateTimeKind.Utc).AddTicks(4037), 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2021, 12, 12, 0, 28, 40, 51, DateTimeKind.Utc).AddTicks(8643), "Kathlyn_Becker@hotmail.com", "Tiara", "Russel", new DateTime(2021, 10, 7, 5, 36, 53, 620, DateTimeKind.Utc).AddTicks(3776), 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2008, 4, 18, 18, 11, 14, 773, DateTimeKind.Utc).AddTicks(2920), "Janiya_Mueller@yahoo.com", "Jayson", "Vandervort", new DateTime(2013, 10, 7, 14, 56, 5, 469, DateTimeKind.Utc).AddTicks(8368), 20 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt" },
                values: new object[] { new DateTime(2008, 10, 29, 20, 50, 2, 6, DateTimeKind.Utc).AddTicks(7453), "Hector_Little@yahoo.com", "Al", "Kuhlman", new DateTime(2023, 1, 29, 6, 37, 25, 756, DateTimeKind.Utc).AddTicks(2913) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2002, 10, 15, 21, 40, 10, 34, DateTimeKind.Utc).AddTicks(7156), "Jo20@gmail.com", "Era", "Marks", new DateTime(2019, 7, 27, 12, 30, 6, 94, DateTimeKind.Utc).AddTicks(7777), 11 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt" },
                values: new object[] { new DateTime(2003, 7, 12, 11, 58, 4, 605, DateTimeKind.Utc).AddTicks(9937), "Elsa.Ritchie10@yahoo.com", "Presley", "Hessel", new DateTime(2015, 7, 3, 2, 7, 52, 397, DateTimeKind.Utc).AddTicks(7173) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2006, 6, 21, 5, 42, 53, 217, DateTimeKind.Utc).AddTicks(1816), "Candace_Langworth6@yahoo.com", "Orval", "Kunze", new DateTime(2022, 5, 24, 1, 6, 3, 764, DateTimeKind.Utc).AddTicks(8884), 8 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(1994, 4, 1, 14, 29, 3, 760, DateTimeKind.Utc).AddTicks(9670), "Sherman_Huel@hotmail.com", "Sven", "Quigley", new DateTime(2017, 6, 16, 8, 20, 27, 869, DateTimeKind.Utc).AddTicks(155), 11 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2001, 4, 20, 20, 54, 36, 819, DateTimeKind.Utc).AddTicks(5312), "Carrie91@hotmail.com", "Audreanne", "Schinner", new DateTime(2019, 10, 19, 14, 43, 22, 867, DateTimeKind.Utc).AddTicks(3727), 7 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2018, 3, 1, 3, 5, 22, 234, DateTimeKind.Utc).AddTicks(6823), "Nicolette.Crona@yahoo.com", "Zander", "Stark", new DateTime(2021, 4, 7, 6, 4, 57, 931, DateTimeKind.Utc).AddTicks(3404), 6 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(1998, 2, 6, 21, 12, 40, 349, DateTimeKind.Utc).AddTicks(7450), "Vidal_Stanton@hotmail.com", "Liana", "Kuhn", new DateTime(2014, 3, 12, 21, 4, 2, 348, DateTimeKind.Utc).AddTicks(4061), 15 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2022, 11, 15, 3, 28, 56, 539, DateTimeKind.Utc).AddTicks(2783), "Mario_Grant69@hotmail.com", "Uriel", "Mante", new DateTime(2016, 3, 1, 21, 12, 20, 155, DateTimeKind.Utc).AddTicks(899), 14 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2008, 12, 31, 1, 12, 3, 107, DateTimeKind.Utc).AddTicks(1565), "Celestino_Gibson32@yahoo.com", "Narciso", "Quitzon", new DateTime(2018, 4, 25, 8, 2, 28, 557, DateTimeKind.Utc).AddTicks(8157), 11 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2003, 12, 25, 19, 15, 2, 233, DateTimeKind.Utc).AddTicks(1578), "Aubree84@yahoo.com", "Dagmar", "Cummings", new DateTime(2022, 2, 7, 19, 18, 32, 371, DateTimeKind.Utc).AddTicks(9055), 12 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2010, 11, 25, 6, 34, 37, 95, DateTimeKind.Utc).AddTicks(967), "Imogene.Schaden@yahoo.com", "Ashton", "Hayes", new DateTime(2015, 6, 8, 16, 0, 22, 671, DateTimeKind.Utc).AddTicks(3345), 9 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2018, 5, 13, 21, 27, 48, 73, DateTimeKind.Utc).AddTicks(239), "Carley_Kassulke@yahoo.com", "Isidro", "Kassulke", new DateTime(2021, 10, 4, 16, 28, 58, 238, DateTimeKind.Utc).AddTicks(2424), 17 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2000, 11, 9, 4, 59, 43, 96, DateTimeKind.Utc).AddTicks(4852), "Sonny_Rempel@gmail.com", "Ova", "Bartoletti", new DateTime(2019, 6, 22, 23, 2, 9, 121, DateTimeKind.Utc).AddTicks(58), 3 });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Projects",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 7, new DateTime(2016, 12, 22, 20, 32, 9, 433, DateTimeKind.Utc).AddTicks(1252), new DateTime(9508, 4, 12, 13, 20, 7, 544, DateTimeKind.Utc).AddTicks(6372), "qui", "Lexie Schaefer", 4 });

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
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 14, new DateTime(2017, 11, 24, 11, 47, 45, 895, DateTimeKind.Utc).AddTicks(2989), new DateTime(4523, 10, 19, 16, 41, 17, 614, DateTimeKind.Utc).AddTicks(7866), "Ea est nam ea qui reiciendis consectetur est iure.", "Ramon Stark", 20 });

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
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 8, new DateTime(2018, 10, 16, 3, 35, 9, 971, DateTimeKind.Utc).AddTicks(1312), new DateTime(9398, 12, 29, 7, 49, 3, 254, DateTimeKind.Utc).AddTicks(6669), "Quas quis in molestiae ut.\nQui nisi provident qui nesciunt aut eligendi recusandae.\nPorro autem a beatae ullam recusandae qui.\nConsequatur voluptas repudiandae quisquam.", "Concepcion Grady", 12 });

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
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 11, new DateTime(2023, 2, 22, 0, 52, 2, 76, DateTimeKind.Utc).AddTicks(7858), new DateTime(2246, 3, 20, 13, 17, 54, 52, DateTimeKind.Utc).AddTicks(6481), "Soluta voluptatem modi non.", "Kitty Feest", 17 });

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
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name" },
                values: new object[] { 8, new DateTime(2020, 4, 6, 8, 53, 27, 809, DateTimeKind.Utc).AddTicks(4876), new DateTime(4839, 5, 28, 2, 12, 44, 610, DateTimeKind.Utc).AddTicks(6583), "Consequuntur quo incidunt animi fuga et officia voluptates qui. Est ut et et vel qui quod veniam. Inventore rerum inventore et officiis quidem nemo mollitia laborum voluptatem. Corrupti earum alias soluta non et culpa. Ut maxime exercitationem explicabo et vitae qui nesciunt.", "Dee Schiller" });

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
                columns: new[] { "AuthorId", "CreatedAt", "Deadline", "Description", "Name", "TeamId" },
                values: new object[] { 19, new DateTime(2021, 12, 11, 2, 47, 29, 895, DateTimeKind.Utc).AddTicks(5295), new DateTime(7067, 5, 20, 19, 27, 25, 641, DateTimeKind.Utc).AddTicks(2050), "Dolorum quaerat molestiae at voluptate aut velit consequatur veniam quia. Quaerat fuga magni voluptates deleniti. Et rem nesciunt ea non quis odio. Magni quis quia laboriosam nam assumenda iusto voluptas ut. Rerum fuga nobis quis consequatur esse. Non sapiente fuga.", "Jacynthe Batz", 17 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2015, 12, 19, 22, 58, 54, 61, DateTimeKind.Utc).AddTicks(7482), "libero", new DateTime(8109, 3, 18, 15, 17, 41, 169, DateTimeKind.Utc).AddTicks(5271), "Isobel King", 12, 5, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2017, 3, 27, 22, 3, 48, 838, DateTimeKind.Utc).AddTicks(8445), "esse", new DateTime(5333, 12, 9, 12, 22, 2, 690, DateTimeKind.Utc).AddTicks(5672), "Mac Herman", 20, 16 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2019, 3, 9, 1, 1, 55, 427, DateTimeKind.Utc).AddTicks(4158), "Inventore qui quas accusantium sunt eum ab.", new DateTime(7315, 3, 21, 2, 31, 29, 966, DateTimeKind.Utc).AddTicks(7167), "Desmond Casper", 15, 20, 0 });

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
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2018, 11, 13, 11, 20, 59, 993, DateTimeKind.Utc).AddTicks(1969), "Sint quisquam impedit laborum qui tempore qui delectus reiciendis. Perspiciatis tempora quasi voluptatem rerum porro rerum dolores recusandae ipsa. Id ipsa consequatur consequuntur quidem illum voluptas.", new DateTime(4140, 6, 12, 6, 56, 34, 984, DateTimeKind.Utc).AddTicks(9898), "Augustus Kilback", 9, 19 });

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
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2015, 5, 30, 1, 50, 32, 526, DateTimeKind.Utc).AddTicks(2022), "Consequatur quis commodi.", new DateTime(9838, 12, 27, 6, 19, 40, 219, DateTimeKind.Utc).AddTicks(9313), "Rex Aufderhar", 5, 10, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2013, 8, 26, 17, 33, 37, 115, DateTimeKind.Utc).AddTicks(288), "Nulla blanditiis architecto alias itaque maxime omnis qui iure sunt. Facere iusto quod velit eos sunt. Aliquam hic hic sed quasi expedita iure quis voluptas. Praesentium ipsa cumque voluptatem harum. Accusantium dolores explicabo tempore cum aperiam iusto.", new DateTime(7327, 9, 12, 8, 11, 29, 640, DateTimeKind.Utc).AddTicks(7114), "Elijah Walsh", 10, 20 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId" },
                values: new object[] { new DateTime(2015, 12, 14, 13, 58, 31, 305, DateTimeKind.Utc).AddTicks(3849), "At et est. Quisquam nam et consequuntur. Pariatur quod dicta occaecati. Ipsa occaecati sapiente recusandae sapiente unde perspiciatis qui. Dicta dolores natus id tempore voluptate impedit consequuntur ipsum voluptatem. Est eum culpa vitae natus magnam quidem ratione porro cumque.", new DateTime(5911, 11, 10, 1, 44, 43, 421, DateTimeKind.Utc).AddTicks(5411), "Lesley Reichert", 5 });

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
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2020, 7, 7, 15, 56, 56, 702, DateTimeKind.Utc).AddTicks(2981), "Enim nam reprehenderit debitis molestiae voluptas quaerat numquam qui. Sunt ipsa quia. Libero sunt libero nihil. Assumenda saepe occaecati id qui fugiat est.", new DateTime(3365, 9, 8, 13, 56, 2, 615, DateTimeKind.Utc).AddTicks(6958), "Jonathon Lind", 6, 9 });

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
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2023, 2, 10, 1, 53, 34, 541, DateTimeKind.Utc).AddTicks(4317), "Quod autem qui autem necessitatibus consequatur quaerat eius et voluptas. Et autem adipisci. Eveniet fugiat nesciunt voluptatem consequuntur omnis. Quam adipisci qui.", new DateTime(6405, 2, 8, 13, 17, 48, 498, DateTimeKind.Utc).AddTicks(4075), "Dominique Gislason", 18, 7 });

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
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2021, 5, 18, 9, 4, 51, 220, DateTimeKind.Utc).AddTicks(3095), "distinctio", new DateTime(5853, 12, 25, 23, 53, 48, 265, DateTimeKind.Utc).AddTicks(5462), "Jefferey Casper", 15, 14 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId" },
                values: new object[] { new DateTime(2019, 3, 15, 8, 38, 53, 157, DateTimeKind.Utc).AddTicks(6182), "At voluptate et eveniet corporis inventore nihil. Aut aut quia assumenda. Eius quasi natus consequatur dolores assumenda et. Quia officiis ut aliquid veniam inventore odio.", new DateTime(9847, 11, 23, 23, 41, 39, 606, DateTimeKind.Utc).AddTicks(4235), "Janet Daniel", 19, 8 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "State" },
                values: new object[] { new DateTime(2021, 7, 11, 7, 21, 10, 133, DateTimeKind.Utc).AddTicks(1850), "Ipsum laborum officia hic ratione sunt natus ullam.\nEst iste sed alias ut tempora.\nNostrum nemo qui id.\nQuia pariatur eos deserunt.", new DateTime(4804, 5, 5, 13, 58, 59, 217, DateTimeKind.Utc).AddTicks(2816), "Kelsie Prohaska", 13, 2 });

            migrationBuilder.UpdateData(
                table: "Tasks",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "CreatedAt", "Description", "FinishedAt", "Name", "PerformerId", "ProjectId", "State" },
                values: new object[] { new DateTime(2020, 10, 29, 17, 37, 50, 944, DateTimeKind.Utc).AddTicks(4448), "quas", new DateTime(5588, 7, 26, 3, 54, 34, 304, DateTimeKind.Utc).AddTicks(7524), "Casey Frami", 16, 19, 2 });

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
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt", "TeamId" },
                values: new object[] { new DateTime(2010, 12, 12, 11, 53, 4, 379, DateTimeKind.Utc).AddTicks(9277), "Albert.Kling@gmail.com", "Alize", "Quitzon", new DateTime(2018, 1, 28, 0, 25, 48, 641, DateTimeKind.Utc).AddTicks(7389), 10 });

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
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt" },
                values: new object[] { new DateTime(2018, 7, 24, 7, 8, 15, 650, DateTimeKind.Utc).AddTicks(7415), "Serena73@yahoo.com", "Maudie", "Heller", new DateTime(2023, 7, 8, 13, 50, 54, 72, DateTimeKind.Utc).AddTicks(9108) });

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
                columns: new[] { "BirthDay", "Email", "FirstName", "LastName", "RegisteredAt" },
                values: new object[] { new DateTime(2004, 6, 5, 9, 27, 8, 62, DateTimeKind.Utc).AddTicks(5059), "Kelley_Ernser90@yahoo.com", "Kameron", "Reichel", new DateTime(2017, 4, 19, 16, 11, 0, 241, DateTimeKind.Utc).AddTicks(2583) });

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
    }
}
