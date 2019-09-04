using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class SchoolsVoronez : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "Title" },
                values: new object[,]
                {
                    { 94982, 42, "Школа № 1" },
                    { 219022, 42, "Школа № 92" },
                    { 343882, 42, "Школа № 91" },
                    { 248752, 42, "Школа № 90" },
                    { 97074, 42, "Школа № 89" },
                    { 31780, 42, "Школа № 88" },
                    { 294046, 42, "Школа искусств № 88" },
                    { 33461, 42, "Школа № 93" },
                    { 24918, 42, "Школа № 87" },
                    { 21008, 42, "Школа № 85" },
                    { 181061, 42, "Школа № 84" },
                    { 236118, 42, "Школа искусств № 83" },
                    { 195605, 42, "Школа № 83" },
                    { 82172, 42, "Школа № 82" },
                    { 23007, 42, "Школа № 81" },
                    { 144127, 42, "Школа № 86" },
                    { 7191, 42, "Школа № 80" },
                    { 124070, 42, "Школа № 94" },
                    { 98285, 42, "Школа № 96" },
                    { 127875, 42, "Школа № 165" },
                    { 1483262, 42, "Детский сад № 150" },
                    { 340886, 42, "Школа № 148" },
                    { 165640, 42, "Детский сад № 145" },
                    { 91671, 42, "Школа № 138" },
                    { 163305, 42, "Детский сад № 129" },
                    { 9894, 42, "Школа № 95" },
                    { 1781414, 42, "Школа № 104" },
                    { 1777183, 42, "Школа № 102" },
                    { 1764773, 42, "Школа № 101" },
                    { 1762137, 42, "Школа № 100" },
                    { 65112, 42, "Школа № 99" },
                    { 1671782, 42, "Школа № 98" },
                    { 11104, 42, "Школа № 97" },
                    { 1778202, 42, "Школа № 103" },
                    { 109568, 42, "Школа № 166" },
                    { 279260, 42, "Школа № 79" },
                    { 103492, 42, "Школа № 78" },
                    { 180841, 42, "Школа № 60" },
                    { 146918, 42, "Школа № 59" },
                    { 172278, 42, "Школа № 58" },
                    { 24526, 42, "Школа № 57" },
                    { 180665, 42, "Школа № 56" },
                    { 30325, 42, "Школа № 55" },
                    { 2213, 42, "Школа № 61" },
                    { 33419, 42, "Школа № 54" },
                    { 16341, 42, "Школа № 53" },
                    { 28046, 42, "Школа № 52" },
                    { 31850, 42, "Школа № 51" },
                    { 281777, 42, "Школа № 50" },
                    { 109687, 42, "Школа № 49" },
                    { 262994, 42, "Детский сад № 48" },
                    { 310790, 42, "Воронежский техникум пищевой и перерабатывающей промышленности (бывш. ПЛ № 53)" },
                    { 5619, 42, "Гимназия № 78" },
                    { 19420, 42, "Школа № 62" },
                    { 52795, 42, "Школа № 64" },
                    { 211198, 42, "Школа № 77" },
                    { 23366, 42, "Школа № 76" },
                    { 13514, 42, "Школа № 75" },
                    { 51079, 42, "Школа № 74" },
                    { 18716, 42, "Школа № 73 им. Чернонога" },
                    { 22997, 42, "Школа № 72" },
                    { 140801, 42, "Школа № 63" },
                    { 350369, 42, "Школа № 71" },
                    { 150252, 42, "Школа № 69" },
                    { 8216, 42, "Школа № 68" },
                    { 284506, 42, "Школа № 67" },
                    { 92139, 42, "Школа № 66" },
                    { 3392, 42, "Лицей (бывш. школа) № 65" },
                    { 320882, 42, "Школа искусств № 65" },
                    { 7854, 42, "Школа № 70" },
                    { 20248, 42, "Школа № 48" },
                    { 200723, 42, "Детский сад № 168" },
                    { 47167, 42, "Авиационный техникум им. Чкалова (ВАТ)" },
                    { 1764946, 42, "Факультет СПО ВГУИТ" },
                    { 1740036, 42, "Факультет СПО  Воронежского ГАСУ" },
                    { 1781503, 42, "Факультет дополнительного профессионального образования ВГИФК" },
                    { 245395, 42, "Техникум строительных технологий (ВТСТ)" },
                    { 1752007, 42, "Техникум моды и дизайна" },
                    { 1764307, 42, "Специальная музыкальная школа (Колледж)" },
                    { 1779814, 42, "Филиал РГУПС в г. Воронеж (Факультет СПО)" },
                    { 34841, 42, "Социально-педагогический колледж при ВГПУ" },
                    { 159635, 42, "Профессионально-педагогический колледж (ВГППК)" },
                    { 105784, 42, "Промышленно-технологический колледж (ВГПТК)" },
                    { 201207, 42, "Промышленно-гуманитарный колледж (ВГПГК)" },
                    { 1752361, 42, "Православная гимназия во имя святителя Митрофана Воронежского" },
                    { 1759867, 42, "Политехнический техникум" },
                    { 134150, 42, "Музыкальный колледж им. Ростроповичей" },
                    { 1742075, 42, "Региональный банковский учебный центр (РБУЦ)" },
                    { 1270521, 42, "Музыкальный колледж (ВМК)" },
                    { 518037, 42, "Финансово-экономический техникум (ВФЭТ)" },
                    { 141880, 42, "Художественная школа" },
                    { 185266, 42, "Электромеханический колледж железнодорожного транспорта (ВЭМК)" },
                    { 1647524, 42, "Школа прав человека/ прав студентов" },
                    { 1647523, 42, "Школа прав человека и правовых механизмов защиты" },
                    { 168832, 42, "Школа иностранных языков «Interlingua»" },
                    { 1647522, 42, "Школа гуманитарного антифашизма и просвещения" },
                    { 162049, 42, "Школа «Светлана»" },
                    { 151661, 42, "Хореографическое училище (ВХУ)" },
                    { 181195, 42, "Школа «Радуга»" },
                    { 129407, 42, "Школа «Гармония»" },
                    { 117650, 42, "Школа «Альтернатива»" },
                    { 84431, 42, "Школа «Assist»" },
                    { 1716670, 42, "Центр моды Николая Харьковского" },
                    { 1657416, 42, "Центр делового образования А. Ф. Конто (филиал)" },
                    { 198113, 42, "Художественное училище (ВХУ)" },
                    { 1762308, 42, "Школа «Мариоль»" },
                    { 1764122, 42, "Отделение СПО ​ВФ РЭУ им. Плеханова" },
                    { 370846, 42, "Морская школа (ВОМШ)" },
                    { 359688, 42, "Механический техникум (ВМТ)" },
                    { 1595808, 42, "Губернский педагогический колледж (бывш. Музыкально-педагогический колледж)" },
                    { 327335, 42, "Гимназия им. Платонова" },
                    { 24515, 42, "Гимназия им. Никитина" },
                    { 119201, 42, "Гимназия им. Кольцова" },
                    { 144124, 42, "Гимназия им. академика Н. Г. Басова" },
                    { 1778732, 42, "Воронежский учебный комбинат (ВУК)" },
                    { 1768417, 42, "Дворец творчества детей и молодежи" },
                    { 199735, 42, "Воронежский институт ГПС МЧС России (бывш. Пожарно-техническое училище МЧС РФ)" },
                    { 152327, 42, "Великого Князя Михаила Павловича Кадетский корпус (ВВКМПКК)" },
                    { 68209, 42, "Балетное училище" },
                    { 1689573, 42, "Автошкола ДОСААФ" },
                    { 1764248, 42, "Автошкола «Ягуар»" },
                    { 1764936, 42, "Автошкола «Форсаж»" },
                    { 1728842, 42, "Автошкола «Лидер»" },
                    { 1778504, 42, "Воронежский индустриальный колледж" },
                    { 211110, 42, "Монтажный техникум (ВМТ)" },
                    { 1781522, 42, "Детский технопарк «Кванториум»" },
                    { 265548, 42, "Индустриально-педагогический техникум (ВИПТ)" },
                    { 212407, 42, "Медицинский колледж (ВБМК)" },
                    { 1660760, 42, "Лицей одаренных детей" },
                    { 140607, 42, "Кооперативный техникум (ВКТ)" },
                    { 154406, 42, "Колледж экономики, менеджмента и права (ВКЭМП)" },
                    { 1671666, 42, "Колледж ЦФ РАП Воронеж" },
                    { 1779818, 42, "Колледж физической культуры ВГИФК" },
                    { 131672, 42, "Естественно-технический колледж (ЕТК ВГТУ)" },
                    { 534956, 42, "Колледж профессиональных технологий, экономики и сервиса (ВГК ПТЭиС)" },
                    { 168934, 42, "Колледж железнодорожного транспорта (ВКЖДТ)" },
                    { 1772188, 42, "Колледж ВИВТ" },
                    { 1374019, 42, "Классический лицей" },
                    { 1773996, 42, "Кадетский корпус (инженерная школа) ВУНЦ ВВС «ВВА»" },
                    { 1577118, 42, "Кадетская школа им. А. В. Суворова" },
                    { 1759122, 42, "Институт профессиональных технологий и сервиса «ФиЗ»" },
                    { 129658, 42, "Колледж НОМОС" },
                    { 10226, 42, "Школа № 47" },
                    { 157151, 42, "Детско-юношеская спортивная школа № 47" },
                    { 33969, 42, "Школа № 46" },
                    { 118760, 42, "Детско-юношеская спортивная школа № 5" },
                    { 1728841, 42, "Вечерняя школа № 5" },
                    { 70193, 42, "Колледж № 5" },
                    { 140479, 42, "Промышленно-экономический колледж (ВГПЭК, бывш. ВПУ № 5)" },
                    { 208810, 42, "Школа № 5 им. Феоктистова" },
                    { 84762, 42, "Профессионально-техническое училище № 4" },
                    { 326745, 42, "Школа искусств № 5" },
                    { 1274, 42, "Лицей № 4" },
                    { 244012, 42, "Профессиональный лицей № 4" },
                    { 141764, 42, "Музыкальная школа № 4" },
                    { 178972, 42, "Школа искусств № 4" },
                    { 332160, 42, "Школа-интернат № 4" },
                    { 53153, 42, "Школа № 4" },
                    { 172639, 42, "Профессиональное училище № 3" },
                    { 77336, 42, "Гимназия № 4" },
                    { 353137, 42, "Лицей № 3" },
                    { 88022, 42, "Школа-интернат № 5" },
                    { 101531, 42, "Гимназия № 5 при ВГУ" },
                    { 162855, 42, "Школа искусств № 8" },
                    { 240869, 42, "Лицей № 7 при ВГПУ" },
                    { 225114, 42, "Гимназия № 7 им. Воронцова" },
                    { 19157, 42, "Музыкальная школа № 7" },
                    { 141313, 42, "Школа № 7" },
                    { 286209, 42, "Профессиональный лицей № 7" },
                    { 113825, 42, "Музыкальная школа № 5" },
                    { 156105, 42, "Школа искусств № 7" },
                    { 44901, 42, "Гимназия № 6" },
                    { 71588, 42, "Музыкальная школа № 6" },
                    { 58473, 42, "Школа № 6" },
                    { 1334414, 42, "Вечерняя школа № 6" },
                    { 658709, 42, "Школа-интернат № 6" },
                    { 80966, 42, "Лицей № 5" },
                    { 118003, 42, "Лицей № 6" },
                    { 202083, 42, "Школа № 8" },
                    { 45787, 42, "Гимназия № 3" },
                    { 237990, 42, "Детско-юношеская спортивная школа № 3" },
                    { 252399, 42, "Детский сад № 1" },
                    { 1779742, 42, "Спортивная школа олимпийского резерва № 1" },
                    { 350950, 42, "Лицей № 1" },
                    { 140647, 42, "Гимназия № 1" },
                    { 116619, 42, "Школа № 1 (Военный городок)" },
                    { 29167, 42, "Многоуровневый образовательный комплекс № 1 (ММОК 1)" },
                    { 213434, 42, "Школа № 2" },
                    { 254166, 42, "Профессиональное училище № 1" },
                    { 498565, 42, "Школа-интернат № 1" },
                    { 199853, 42, "Учебно-воспитательный комплекс № 1" },
                    { 188512, 42, "Колледж № 1" },
                    { 49863, 42, "Художественная школа № 1" },
                    { 78101, 42, "Музыкальная школа № 1 при ВГАИ" },
                    { 80399, 42, "Школа искусств № 1" },
                    { 407157, 42, "Центр образования № 1" },
                    { 330809, 42, "Школа искусств № 3" },
                    { 322310, 42, "Колледж № 2" },
                    { 1698189, 42, "Прогимназия № 2" },
                    { 335823, 42, "Школа № 3" },
                    { 170443, 42, "Музыкальная школа № 3" },
                    { 96091, 42, "Художественная школа № 3" },
                    { 174112, 42, "Колледж № 3" },
                    { 211290, 42, "Школа-интернат № 3" },
                    { 213795, 42, "Профессионально-техническое училище № 2" },
                    { 1659738, 42, "Центр образования № 2" },
                    { 207275, 42, "Лицей № 2" },
                    { 134549, 42, "Детско-юношеская спортивная школа № 2" },
                    { 187099, 42, "Школа-интернат № 2" },
                    { 121720, 42, "Школа искусств № 2" },
                    { 116222, 42, "Учебно-воспитательный комплекс № 2 им. Киселёва (ВУВК 2)" },
                    { 83886, 42, "Лицей «Многоуровневый образовательный комплекс № 2»" },
                    { 131428, 42, "Музыкальная школа № 2" },
                    { 45203, 42, "Гимназия № 2" },
                    { 53542, 42, "Музыкальная школа № 8" },
                    { 13566, 42, "Гимназия № 8" },
                    { 49807, 42, "Лицей № 8" },
                    { 137113, 42, "Детско-юношеская спортивная школа № 33" },
                    { 99699, 42, "Школа № 32" },
                    { 1665447, 42, "Школа № 31" },
                    { 1560111, 42, "Профессиональное училище № 30" },
                    { 18658, 42, "Школа № 30" },
                    { 7446, 42, "Школа № 29" },
                    { 23553, 42, "Школа № 33" },
                    { 19099, 42, "Школа № 28" },
                    { 71581, 42, "Школа № 26" },
                    { 174892, 42, "Школа № 25" },
                    { 2224, 42, "Школа № 24" },
                    { 67500, 42, "Школа № 23" },
                    { 47168, 42, "Школа № 22" },
                    { 206510, 42, "Детско-юношеская спортивная школа № 22" },
                    { 36380, 42, "Школа № 27" },
                    { 58203, 42, "Школа № 21" },
                    { 232048, 42, "Профессионально-техническое училище № 33" },
                    { 10469, 42, "Школа № 35" },
                    { 15527, 42, "Школа № 45" },
                    { 39049, 42, "Школа № 44" },
                    { 9284, 42, "Школа № 43" },
                    { 168964, 42, "Школа № 42" },
                    { 22073, 42, "Школа № 41" },
                    { 14239, 42, "Школа № 40" },
                    { 40369, 42, "Школа № 34" },
                    { 217733, 42, "Детско-юношеская спортивная школа № 40" },
                    { 109113, 42, "Школа иностранных языков «N'ecole»" },
                    { 213072, 42, "Школа № 38" },
                    { 363993, 42, "Профессионально-техническое училище № 37" },
                    { 13513, 42, "Школа № 37" },
                    { 155662, 42, "Профессиональное училище № 36" },
                    { 26534, 42, "Школа № 36" },
                    { 57613, 42, "Школа № 39" },
                    { 17949, 42, "Школа № 20" },
                    { 16930, 42, "Школа № 19" },
                    { 102056, 42, "Школа искусств № 18" },
                    { 204919, 42, "Школа № 12" },
                    { 161429, 42, "Школа искусств № 12" },
                    { 1152689, 42, "Профессиональное училище № 11" },
                    { 8314, 42, "Школа № 11 им. Пушкина" },
                    { 133684, 42, "Вечерняя школа № 11" },
                    { 57140, 42, "Музыкальная школа № 11" },
                    { 78781, 42, "Лицей № 12" },
                    { 107722, 42, "Школа искусств № 11" },
                    { 43402, 42, "Школа № 10" },
                    { 294117, 42, "Школа искусств № 10" },
                    { 209492, 42, "Гимназия № 9" },
                    { 257039, 42, "Школа искусств № 9" },
                    { 45343, 42, "Школа № 9" },
                    { 1757105, 42, "Лицей № 9" },
                    { 6073, 42, "Гимназия № 10" },
                    { 4848, 42, "Школа № 13" },
                    { 171387, 42, "Музыкальная школа № 13" },
                    { 65109, 42, "Детско-юношеская спортивная школа № 13" },
                    { 28821, 42, "Школа № 18" },
                    { 49633, 42, "Школа № 17" },
                    { 105218, 42, "Детско-юношеская спортивная школа № 17" },
                    { 209397, 42, "Школа искусств № 16" },
                    { 55285, 42, "Школа № 16" },
                    { 68706, 42, "Музыкальная школа № 16" },
                    { 152039, 42, "Профессиональное училище № 15" },
                    { 25937, 42, "Лицей № 15" },
                    { 85095, 42, "Вечерняя школа № 15" },
                    { 129802, 42, "Школа искусств № 15" },
                    { 25512, 42, "Школа № 14" },
                    { 71430, 42, "Музыкальная школа № 14" },
                    { 109307, 42, "Детско-юношеская спортивная школа № 14" },
                    { 117708, 42, "Вечерняя школа № 14" },
                    { 265293, 42, "Школа искусств № 14" },
                    { 217486, 42, "Энергетический техникум (ВЭТ)" },
                    { 260127, 42, "Юридический техникум (ВЮТ)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1274);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2213);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2224);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3392);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4848);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5619);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6073);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7191);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7446);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7854);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8216);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8314);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9284);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9894);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10226);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10469);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11104);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13513);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13514);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13566);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14239);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15527);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16341);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16930);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17949);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18658);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18716);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19099);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19157);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19420);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20248);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21008);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22073);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22997);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23007);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23366);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23553);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24515);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24526);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24918);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25512);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25937);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26534);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28046);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28821);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 29167);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 30325);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31780);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31850);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 33419);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 33461);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 33969);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34841);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 36380);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 39049);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40369);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43402);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44901);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45203);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45343);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45787);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 47167);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 47168);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49633);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49807);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49863);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51079);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 52795);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 53153);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 53542);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55285);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 57140);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 57613);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 58203);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 58473);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 65109);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 65112);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67500);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68209);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68706);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70193);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71430);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71581);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71588);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 77336);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78101);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78781);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 80399);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 80966);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 82172);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 83886);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 84431);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 84762);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 85095);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 88022);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91671);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 92139);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 94982);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 96091);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97074);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98285);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 99699);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101531);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 102056);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 103492);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 105218);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 105784);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 107722);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109113);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109307);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109568);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109687);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113825);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116222);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116619);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 117650);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 117708);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 118003);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 118760);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 119201);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 121720);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 124070);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127875);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129407);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129658);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129802);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131428);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131672);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 133684);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 134150);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 134549);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 137113);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140479);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140607);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140647);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140801);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 141313);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 141764);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 141880);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 144124);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 144127);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 146918);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 150252);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 151661);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 152039);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 152327);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 154406);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 155662);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 156105);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 157151);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 159635);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 161429);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 162049);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 162855);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163305);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165640);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168832);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168934);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168964);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 170443);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 171387);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172278);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172639);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 174112);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 174892);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 178972);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 180665);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 180841);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 181061);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 181195);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 185266);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 187099);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 188512);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 195605);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 198113);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 199735);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 199853);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 200723);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 201207);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 202083);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 204919);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206510);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 207275);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 208810);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 209397);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 209492);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 211110);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 211198);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 211290);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 212407);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 213072);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 213434);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 213795);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217486);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217733);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 219022);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 225114);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 232048);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 236118);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 237990);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 240869);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 244012);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 245395);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 248752);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 252399);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 254166);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 257039);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 260127);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 262994);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 265293);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 265548);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 279260);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 281777);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 284506);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 286209);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 294046);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 294117);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 310790);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 320882);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 322310);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 326745);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 327335);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 330809);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 332160);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 335823);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 340886);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 343882);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 350369);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 350950);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 353137);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 359688);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 363993);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 370846);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 407157);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 498565);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 518037);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 534956);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 658709);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1152689);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1270521);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1334414);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1374019);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1483262);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1560111);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1577118);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1595808);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1647522);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1647523);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1647524);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1657416);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1659738);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1660760);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1665447);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1671666);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1671782);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1689573);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1698189);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1716670);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1728841);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1728842);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1740036);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1742075);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1752007);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1752361);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1757105);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1759122);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1759867);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1762137);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1762308);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764122);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764248);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764307);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764773);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764936);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764946);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1768417);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1772188);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1773996);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1777183);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1778202);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1778504);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1778732);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1779742);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1779814);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1779818);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1781414);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1781503);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1781522);
        }
    }
}
