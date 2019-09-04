using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class SchoolsKaliningrad : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "Title" },
                values: new object[,]
                {
                    { 64432, 61, "Школа № 1" },
                    { 1775988, 61, "Калининградская специальная средняя школа милиции МВД СССР" },
                    { 1782193, 61, "Калининградский казачий институт технологий и дизайна МГУТУ им. Разумовского" },
                    { 101342, 61, "Кениг-колледж" },
                    { 340137, 61, "Колледж Академии народного хозяйства (АНХ)" },
                    { 88595, 61, "Колледж Академия акмеологии, менеджмента и бизнес-образования" },
                    { 317121, 61, "Колледж градостроительства (КГКГ)" },
                    { 345267, 61, "Колледж Калининградского филиала МУМ" },
                    { 1718619, 61, "Колледж Калининградского филиала МФЮА" },
                    { 112788, 61, "Колледж Калининградского филиала Российского университета кооперации" },
                    { 130123, 61, "Колледж МЭСИ (Калининградский филиал)" },
                    { 1447898, 61, "Колледж сервиса и туризма" },
                    { 1703642, 61, "Колледж СПО ЕАОИ (Калининградский филиал)" },
                    { 243968, 61, "Колледж туризма и ресторанно-гостиничного бизнеса (КТиРГБ)" },
                    { 159158, 61, "Колледж экономики и права (КЭП)" },
                    { 318364, 61, "Коммунально-строительный техникум (ККСТ)" },
                    { 359500, 61, "Кооперативный техникум (ККТ)" },
                    { 146946, 61, "Лицей «Альма-Матер»" },
                    { 2211, 61, "Лицей «Ганзейская ладья»" },
                    { 75033, 61, "Лицей милиции" },
                    { 195619, 61, "Лицей-интернат (ШИЛИ)" },
                    { 233145, 61, "Медицинский колледж (КМК)" },
                    { 109919, 61, "Кадетский корпус им. А. Невского" },
                    { 93476, 61, "Интерлицей" },
                    { 32479, 61, "Детско-юношеская спортивная школа «Юность»" },
                    { 261560, 61, "Гуманитарный колледж (КГК)" },
                    { 134522, 61, "Школа № 53" },
                    { 85985, 61, "Школа № 54" },
                    { 101611, 61, "Школа № 55" },
                    { 1689607, 61, "Школа № 56" },
                    { 190018, 61, "Школа № 58" },
                    { 59711, 61, "Школа № 69" },
                    { 1781638, 61, "Школа-детский сад № 72" },
                    { 265321, 61, "Школа № 79" },
                    { 273575, 61, "Детский сад № 99" },
                    { 163768, 61, "Детский сад № 106" },
                    { 227080, 61, "Механико-технологический техникум (КМТТ)" },
                    { 358033, 61, "Детский сад № 118" },
                    { 872561, 61, "Детский сад № 127" },
                    { 868586, 61, "Детский сад № 133" },
                    { 1705615, 61, "Автошкола ДОСААФ" },
                    { 264166, 61, "Балтийский информационный техникум (БИТ)" },
                    { 264664, 61, "Балтийский колледж экономики и туризма (БКЭТ)" },
                    { 294126, 61, "Балтийский лицей менеджмента и права (БЛМП)" },
                    { 223351, 61, "Бизнес-колледж (КБК)" },
                    { 67819, 61, "Военное авиационно-техническое училище (КВАТУ)" },
                    { 221701, 61, "Высшая школа управления (КВШУ)" },
                    { 1652668, 61, "Гимназия «Альбертина»" },
                    { 362826, 61, "Гимназия № 121" },
                    { 346969, 61, "Механический техникум (КМТ)" },
                    { 182049, 61, "Мореходное училище (КМУ)" },
                    { 138224, 61, "Морской кадетский корпус при БВМИ" },
                    { 184541, 61, "Техникум при БВМИ им. Ф. Ф. Ушакова" },
                    { 143690, 61, "Техникум советской торговли (КТСТ)" },
                    { 319595, 61, "Технический колледж (КТК)" },
                    { 230463, 61, "Торгово-экономический колледж (КТЭК)" },
                    { 1771544, 61, "Учебно-методический образовательный центр" },
                    { 332560, 61, "Училище (техникум) олимпийского резерва (УОР)" },
                    { 216301, 61, "Художественная школа" },
                    { 1779549, 61, "Художественно-промышленный техникум (бывш. лицей)" },
                    { 1737652, 61, "Центр дополнительного образования «Калининград»" },
                    { 229053, 61, "Центр дошкольного развития «Знайка»" },
                    { 1764849, 61, "Спортивный клуб «Союз»" },
                    { 1562880, 61, "Центр образования и культуры – языковая школа" },
                    { 1749338, 61, "Центр реабилитации и коррекции детей с ограниченными возможностями здоровья" },
                    { 64427, 61, "Школа «Росток»" },
                    { 136565, 61, "Школа искусств «Гармония»" },
                    { 245321, 61, "Школа искусств «Солнечный сад»" },
                    { 41765, 61, "Школа искусств им. П. И. Чайковского" },
                    { 237314, 61, "Школа искусств им. Ф. Ф. Шопена" },
                    { 287537, 61, "Школа муниципального управления" },
                    { 181633, 61, "Школа техников морской авиации" },
                    { 310318, 61, "Школа-интернат «Андрея Первозванного Кадетский морской корпус»" },
                    { 125920, 61, "Школа-интернат для слабовидящих детей" },
                    { 113270, 61, "Центр образования Московского района" },
                    { 78405, 61, "Школа № 52" },
                    { 119178, 61, "Спортивно-гуманитарная школа «Ангерона»" },
                    { 327564, 61, "Спортивная школа олимпийского резерва по водным видам спорта" },
                    { 216734, 61, "Морской лицей (КМЛ)" },
                    { 266352, 61, "Морской рыбопромышленный колледж (КМРК)" },
                    { 242385, 61, "Московский колледж железнодорожного транспорта (Калининградский филиал)" },
                    { 349025, 61, "Музыкальная школа им. Д. Д. Шостаковича" },
                    { 246578, 61, "Музыкальная школа им. М. И. Глинки" },
                    { 244475, 61, "Музыкальная школа им. Р. М. Глиэра" },
                    { 43547, 61, "Музыкальная школа им. Э. Т. А. Гофмана" },
                    { 63418, 61, "Музыкальная школа при КОМК им. С. В. Рахманинова" },
                    { 317827, 61, "Музыкально-хоровая школа мальчиков" },
                    { 184257, 61, "Областная школа высшего спортивного мастерства" },
                    { 86248, 61, "Спортивная школа олимпийского резерва по современному пятиборью" },
                    { 69318, 61, "Областной колледж культуры и искусств" },
                    { 66207, 61, "Областной педагогический лицей-интернат" },
                    { 1662569, 61, "Общество «Знание»" },
                    { 83661, 61, "Педагогический колледж" },
                    { 131452, 61, "Политехникум" },
                    { 203685, 61, "Православная гимназия г. Калининграда" },
                    { 155333, 61, "Прибалтийский судостроительный техникум" },
                    { 1775330, 61, "Прогимназия «Пересвет»" },
                    { 255119, 61, "Региональный социально-педагогический колледж (КРСПК)" },
                    { 1601145, 61, "Республиканский заочный автотранспортный техникум (РЗАТТ КФ)" },
                    { 118391, 61, "Социально-экономический колледж" },
                    { 256771, 61, "Областной музыкальный колледж им. С. В. Рахманинова (КОМК)" },
                    { 758097, 61, "Экологический философско-гуманитарный лицей" },
                    { 172491, 61, "Школа № 51" },
                    { 1595, 61, "Лицей № 49" },
                    { 62345, 61, "Школа № 7" },
                    { 135269, 61, "Детско-юношеская спортивная школа № 7 по теннису и настольному теннису" },
                    { 45784, 61, "Профессиональный лицей № 7" },
                    { 17097, 61, "Школа № 8" },
                    { 1658205, 61, "Колледж информационных технологий и строительства (бывш. ПСТ, ПТУ №  8)" },
                    { 20907, 61, "Школа № 9" },
                    { 199577, 61, "Спортивная школа олимпийского резерва № 9 по баскетболу" },
                    { 212364, 61, "Профессионально-техническое училище № 9" },
                    { 281653, 61, "Школа искусств № 9" },
                    { 2118, 61, "Школа № 10" },
                    { 246604, 61, "Музыкальная школа при шк. 10" },
                    { 140854, 61, "Спортивная школа олимпийского резерва № 10 по волейболу" },
                    { 46004, 61, "Профессиональный лицей №  10" },
                    { 174800, 61, "Среднее профессионально-техническое училище № 10" },
                    { 9442, 61, "Школа № 11" },
                    { 319929, 61, "Спортивная школа №  11 по авиационным и техническим видам спорта" },
                    { 2712, 61, "Школа № 12" },
                    { 230899, 61, "Профессиональный лицей № 12" },
                    { 73265, 61, "Школа № 13" },
                    { 40343, 61, "Лицей № 13" },
                    { 101551, 61, "Профессионально-техническое училище № 13" },
                    { 101550, 61, "Вечерняя школа № 6" },
                    { 2711, 61, "Школа № 6" },
                    { 170245, 61, "Профессионально-техническое училище № 5" },
                    { 151186, 61, "Спортивная школа олимпийского резерва № 5 по футболу" },
                    { 3058, 61, "Гимназия № 1" },
                    { 69388, 61, "Музыкальная школа при гимн. 1" },
                    { 136610, 61, "Спортивная школа олимпийского резерва № 1 по спортивной гимнастике" },
                    { 170673, 61, "Детско-юношеская спортивная школа №  1" },
                    { 320118, 61, "Техникум № 1" },
                    { 238070, 61, "Школа искусств № 1" },
                    { 195383, 61, "Школа № 2" },
                    { 12221, 61, "Лицей № 2" },
                    { 58607, 61, "Школа-интернат № 2" },
                    { 81138, 61, "Вечерняя школа № 2" },
                    { 364344, 61, "Школа искусств № 13" },
                    { 178067, 61, "Детско-юношеская спортивная школа олимпийского резерва «Балтика-2»" },
                    { 207343, 61, "Профессиональное училище № 2" },
                    { 203619, 61, "Школа № 3" },
                    { 16835, 61, "Школа-интернат № 3" },
                    { 177649, 61, "Вечерняя школа № 3" },
                    { 158546, 61, "Техникум отраслевых технологий (бывш. ПТУ № 3)" },
                    { 895365, 61, "Детский сад № 3 «Золотая рыбка»" },
                    { 394, 61, "Школа № 4" },
                    { 137028, 61, "Спортивная школа олимпийского резерва № 4 по лёгкой атлетике" },
                    { 6741, 61, "Школа № 5" },
                    { 192862, 61, "Вечерняя школа № 5" },
                    { 125200, 61, "Специализированная детско-юношеская спортивная школа олимпийского резерва № 2 по художественной гимнастике" },
                    { 16547, 61, "Школа № 14" },
                    { 326560, 61, "Вечерняя школа № 14" },
                    { 26719, 61, "Школа № 15" },
                    { 2762, 61, "Школа № 30" },
                    { 16808, 61, "Школа № 31" },
                    { 251322, 61, "Школа № 32" },
                    { 1552, 61, "Гимназия № 32" },
                    { 341809, 61, "Детский сад № 32" },
                    { 214920, 61, "Школа № 33" },
                    { 30572, 61, "Школа № 34" },
                    { 29918, 61, "Лицей № 35" },
                    { 7554, 61, "Школа № 36" },
                    { 27056, 61, "Школа № 37" },
                    { 166669, 61, "Школа № 29" },
                    { 6824, 61, "Школа № 38" },
                    { 7085, 61, "Гимназия № 40" },
                    { 206132, 61, "Школа № 41" },
                    { 30540, 61, "Школа № 42" },
                    { 4806, 61, "Школа № 43" },
                    { 17057, 61, "Школа № 44" },
                    { 127752, 61, "Школа № 45" },
                    { 187797, 61, "Школа № 46" },
                    { 6750, 61, "Школа № 47" },
                    { 17363, 61, "Школа № 48" },
                    { 172295, 61, "Школа № 49" },
                    { 48004, 61, "Школа № 39" },
                    { 26423, 61, "Школа № 50" },
                    { 6918, 61, "Школа № 28" },
                    { 8030, 61, "Школа № 27" },
                    { 196226, 61, "Школа № 16" },
                    { 165546, 61, "Школа № 17" },
                    { 12889, 61, "Лицей № 17" },
                    { 272168, 61, "Школа искусств № 17" },
                    { 92001, 61, "Школа № 18" },
                    { 2713, 61, "Лицей № 18" },
                    { 1163, 61, "Школа № 19" },
                    { 41847, 61, "Школа № 20" },
                    { 172509, 61, "Школа № 21" },
                    { 10673, 61, "Школа № 22" },
                    { 743964, 61, "Детский сад № 27" },
                    { 74034, 61, "Гимназия № 22" },
                    { 71445, 61, "Профессиональный лицей № 22" },
                    { 348978, 61, "Школа искусств № 22" },
                    { 214761, 61, "Школа № 23" },
                    { 5065, 61, "Лицей № 23" },
                    { 109532, 61, "Профессиональный ресторанно-гостиничного хозяйства лицей №  23" },
                    { 212708, 61, "Школа № 24" },
                    { 217601, 61, "Профессиональное училище №   24 «Калининградская мореходная школа»" },
                    { 2947, 61, "Школа № 25" },
                    { 311360, 61, "Профессиональный лицей № 25 «Лицей Моды»" },
                    { 1732, 61, "Школа № 26" },
                    { 239177, 61, "Колледж предпринимательства (бывш. Колледж технологии и предпринимательства, ПЛ №  22)" },
                    { 960797, 61, "Экономико-юридическая гимназия «ПЕЦ»" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 394);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1163);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1552);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1595);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1732);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2118);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2211);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2711);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2712);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2713);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2762);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2947);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3058);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4806);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5065);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6741);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6750);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6824);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6918);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7085);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7554);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8030);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9442);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10673);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12221);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12889);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16547);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16808);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16835);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17057);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17097);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17363);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20907);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26423);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26719);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27056);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 29918);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 30540);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 30572);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 32479);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40343);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41765);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41847);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43547);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45784);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 46004);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 48004);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 58607);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 59711);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 62345);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63418);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64427);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64432);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 66207);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67819);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 69318);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 69388);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71445);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 73265);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 74034);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 75033);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78405);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81138);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 83661);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 85985);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 86248);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 88595);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 92001);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 93476);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101342);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101550);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101551);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101611);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109532);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109919);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 112788);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113270);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 118391);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 119178);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 125200);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 125920);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127752);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 130123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131452);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 134522);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 135269);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 136565);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 136610);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 137028);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 138224);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140854);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 143690);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 146946);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 151186);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 155333);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 158546);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 159158);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163768);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165546);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 166669);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 170245);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 170673);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172295);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172491);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172509);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 174800);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 177649);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 178067);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 181633);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 182049);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 184257);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 184541);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 187797);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 190018);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 192862);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 195383);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 195619);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 196226);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 199577);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203619);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203685);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206132);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 207343);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 212364);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 212708);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 214761);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 214920);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 216301);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 216734);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217601);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 221701);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 223351);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 227080);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 229053);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 230463);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 230899);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 233145);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 237314);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 238070);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 239177);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 242385);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 243968);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 244475);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 245321);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 246578);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 246604);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 251322);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 255119);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 256771);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 261560);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 264166);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 264664);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 265321);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 266352);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 272168);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 273575);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 281653);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 287537);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 294126);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 310318);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 311360);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 317121);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 317827);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 318364);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 319595);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 319929);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 320118);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 326560);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 327564);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 332560);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 340137);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 341809);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 345267);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 346969);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 348978);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 349025);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 358033);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 359500);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 362826);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 364344);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 743964);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 758097);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 868586);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 872561);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 895365);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 960797);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1447898);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1562880);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1601145);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1652668);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1658205);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1662569);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1689607);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1703642);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1705615);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1718619);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1737652);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1749338);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764849);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1771544);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1775330);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1775988);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1779549);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1781638);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1782193);
        }
    }
}
