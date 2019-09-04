using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class SchoolsKrasnodar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "Title" },
                values: new object[,]
                {
                    { 2214, 72, "Школа № 1" },
                    { 225079, 72, "Школа № 169" },
                    { 169767, 72, "Лицей № 167" },
                    { 229916, 72, "Школа № 165" },
                    { 227268, 72, "Школа № 150" },
                    { 67016, 72, "Школа № 145" },
                    { 256983, 72, "Школа № 144" },
                    { 79181, 72, "Школа № 143" },
                    { 116365, 72, "Школа № 140" },
                    { 252669, 72, "Школа № 139" },
                    { 223690, 72, "Школа № 133" },
                    { 72405, 72, "Школа № 132" },
                    { 226020, 72, "Школа № 126" },
                    { 270776, 72, "Гимназия № 125" },
                    { 118271, 72, "Школа № 123" },
                    { 330480, 72, "Гимназия № 121" },
                    { 314327, 72, "Школа № 171" },
                    { 254629, 72, "Вечерняя школа № 119" },
                    { 150756, 72, "Школа № 172" },
                    { 231759, 72, "Школа № 178" },
                    { 192305, 72, "Школа № 567" },
                    { 222834, 72, "Школа № 447" },
                    { 210431, 72, "Школа № 428" },
                    { 125505, 72, "Школа № 286" },
                    { 163229, 72, "Школа № 282" },
                    { 198252, 72, "Школа № 259" },
                    { 289325, 72, "Детский сад № 217" },
                    { 271650, 72, "Гимназия № 213" },
                    { 151068, 72, "Школа № 213" },
                    { 157278, 72, "Гимназия № 209" },
                    { 204752, 72, "Школа № 197" },
                    { 127640, 72, "Школа № 189" },
                    { 1519695, 72, "Детский сад № 187" },
                    { 288651, 72, "Школа № 183" },
                    { 152080, 72, "Школа № 181" },
                    { 746918, 72, "Детский сад № 172 «Сказка»" },
                    { 346494, 72, "Детский сад № 117" },
                    { 342582, 72, "Школа № 115" },
                    { 196651, 72, "Школа № 110" },
                    { 262989, 72, "Гимназия № 88" },
                    { 254578, 72, "Гимназия № 87" },
                    { 7365, 72, "Школа № 87" },
                    { 27898, 72, "Школа № 86" },
                    { 49628, 72, "Школа № 85" },
                    { 23496, 72, "Школа № 84" },
                    { 21574, 72, "Школа № 83" },
                    { 28498, 72, "Гимназия № 82" },
                    { 152246, 72, "Школа № 81" },
                    { 28077, 72, "Школа № 80" },
                    { 52754, 72, "Школа № 79" },
                    { 4418, 72, "Гимназия № 78" },
                    { 122182, 72, "Школа № 78" },
                    { 40060, 72, "Школа № 77" },
                    { 70578, 72, "Школа № 76" },
                    { 5626, 72, "Школа № 89" },
                    { 4667, 72, "Лицей № 90" },
                    { 41699, 72, "Школа № 91" },
                    { 344022, 72, "Школа № 92" },
                    { 121713, 72, "Лицей № 105" },
                    { 1782243, 72, "Школа № 104" },
                    { 203873, 72, "Школа № 103" },
                    { 179629, 72, "Школа № 102" },
                    { 206143, 72, "Школа № 101" },
                    { 170950, 72, "Школа № 100" },
                    { 72434, 72, "Школа № 99" },
                    { 129164, 72, "Школа № 608" },
                    { 1691404, 72, "Школа № 98" },
                    { 32891, 72, "Школа № 97" },
                    { 11362, 72, "Школа № 96" },
                    { 232427, 72, "Лицей № 95" },
                    { 29475, 72, "Школа № 95" },
                    { 116092, 72, "Школа № 94" },
                    { 31887, 72, "Школа № 93" },
                    { 12328, 72, "Гимназия № 92" },
                    { 241184, 72, "Музыкальная школа № 97" },
                    { 196218, 72, "Профессиональный лицей № 75" },
                    { 176959, 72, "Школа № 815" },
                    { 144019, 72, "Архитектурно-строительный техникум (КАСТ)" },
                    { 285084, 72, "Торгово-технологический техникум Крайпотребсоюза (КТТТК)" },
                    { 131037, 72, "Технический колледж (КТК)" },
                    { 78402, 72, "Техникум экономики и недвижимости (КТЭиН)" },
                    { 194664, 72, "Техникум легкой промышленности (КВТЛП)" },
                    { 139579, 72, "Социально-экономический колледж (КСЭК)" },
                    { 112112, 72, "Северо-Кавказский техникум «Знание»" },
                    { 1759586, 72, "Санкт-Петербургская школа телевидения (филиал)" },
                    { 1780353, 72, "Санкт-Петербургская школа красоты" },
                    { 124123, 72, "Русская православная школа им. св. прп. Серафима Саровского" },
                    { 1750742, 72, "Российский институт комплексной сказкотерапии (РИКС)" },
                    { 1773440, 72, "Региональный немецкий образовательный центр КубГУ" },
                    { 1728840, 72, "Президентское кадетское училище (КПКУ)" },
                    { 1656549, 72, "Политехнический техникум" },
                    { 688028, 72, "Пашковский сельскохозяйственный колледж (ПСХК)" },
                    { 98479, 72, "Музыкальный колледж им. Римского-Корсакова (КМК)" },
                    { 45822, 72, "Торгово-экономический колледж (КТЭК)" },
                    { 179577, 72, "Музыкально-педагогический колледж (КМПК)" },
                    { 1759928, 72, "Факультет среднего профессионального образования (колледж) ККИ РУК" },
                    { 97743, 72, "Финансово-юридический колледж (КФЮК)" },
                    { 763372, 72, "Школа моделирования (КШМ)" },
                    { 1734027, 72, "Школа искусств им. Г. Ф. Пономаренко" },
                    { 121519, 72, "Школа искусств «Юбилейная»" },
                    { 100184, 72, "Школа искусств «Родник»" },
                    { 312342, 72, "Школа «Эрудит»" },
                    { 141174, 72, "Школа «Саманта»" },
                    { 85971, 72, "Школа «Новатор»" },
                    { 83111, 72, "Школа «Джулия»" },
                    { 1659784, 72, "Школа «Антарес»" },
                    { 78491, 72, "Центр профессионального образования (ЦПО (ЦО))" },
                    { 163427, 72, "Центр образования Карасунского административного округа (ЦОКАО)" },
                    { 190488, 72, "Художественное училище (КХУ)" },
                    { 104787, 72, "Художественная школа им. Филиппова" },
                    { 151422, 72, "Художественная школа им. Пташинского" },
                    { 136832, 72, "Хореографическое училище (КХУ)" },
                    { 1769473, 72, "Факультет среднего профессионального образования Академии маркетинга и социально-информационных технологий (ИМСИТ)" },
                    { 166408, 72, "Монтажный техникум (бывш. КММТ)" },
                    { 704581, 72, "Молодежная школа предпринимательства" },
                    { 162145, 72, "Многопрофильная школа при КубГУ" },
                    { 704582, 72, "Институт начального и среднего профессионального образования КубГУ (ИНСПО КубГУ)" },
                    { 1659493, 72, "Изостудия «Штрих»" },
                    { 1659497, 72, "Детско-юношеская спортивная школа олимпийского резерва по художественной гимнастике" },
                    { 1719037, 72, "Детско-юношеская спортивная школа олимпийского резерва  по легкой атлетике" },
                    { 267857, 72, "Детский сад «Светофорик»" },
                    { 179569, 72, "Детская экспериментальная школа народного творчества" },
                    { 1764202, 72, "Детская школа искусств им. С. В. Рахманинова" },
                    { 22604, 72, "Гуманитарный лицей" },
                    { 797906, 72, "Гуманитарный колледж при КГУФКСТ" },
                    { 243206, 72, "Гуманитарно-технологический колледж (КГТК)" },
                    { 97834, 72, "Гимназия «Альтернатива»" },
                    { 1776583, 72, "Высшая школа практической психологии" },
                    { 1675795, 72, "Волгоградский государственный экономико-технический колледж (филиал)" },
                    { 63542, 72, "Военно-технический лицей (ВТЛ)" },
                    { 1698703, 72, "Бизнес-колледж (ФСПО Института им. Россинского)" },
                    { 129536, 72, "Институт современных технологий и экономики (ИСТЭк при КубГТУ)" },
                    { 74739, 72, "Колледж «Бизнес и право» (БиП)" },
                    { 217357, 72, "Колледж культуры (КККК)" },
                    { 121699, 72, "Колледж культуры, экономики и права (КККЭиП)" },
                    { 1661234, 72, "Механико-технологический техникум (КМТТ)" },
                    { 163221, 72, "Межшкольный эстетический центр (МЭЦ)" },
                    { 1719673, 72, "Международный центр психологии и развития (МЦПИР)" },
                    { 810943, 72, "Медицинский специализированный колледж (КСМК)" },
                    { 200043, 72, "Машиностроительный колледж (КМСК)" },
                    { 32892, 72, "Лицей при ИнЭП" },
                    { 215785, 72, "Лицей «Исток»" },
                    { 1705593, 72, "Автошкола ДОСААФ" },
                    { 177948, 72, "Кубанский  кадетский корпус" },
                    { 1776992, 72, "Краснодарский многопрофильный институт дополнительного образования (КМИДО)" },
                    { 266206, 72, "Краевой базовый медицинский колледж (ККБМК)" },
                    { 29664, 72, "Краевая детская экспериментальная школа-лицей народного искусства (КДЭШЛНИ)" },
                    { 1770493, 72, "Компьютерная Академия ШАГ" },
                    { 129657, 72, "Колледж электронного приборостроения (ККЭП)" },
                    { 134972, 72, "Колледж управления, техники и технологий (ККУТТ)" },
                    { 269123, 72, "Колледж права, экономики и управления (КПЭУ)" },
                    { 172637, 72, "Краснодарский техникум управления, информатизации и сервиса (бывш. КУИС)" },
                    { 115172, 72, "Школа-интернат народного искусства для одаренных детей им. В. Г. Захарченко (КДЭСОШНИ)" },
                    { 118541, 72, "Лицей № 75" },
                    { 10452, 72, "Школа № 74" },
                    { 73113, 72, "Профессиональное училище № 10" },
                    { 317684, 72, "Школа искусств № 10" },
                    { 100553, 72, "Музыкальная школа № 10" },
                    { 330620, 72, "Школа № 10" },
                    { 50911, 72, "Гимназия № 9" },
                    { 75193, 72, "Школа № 9" },
                    { 193528, 72, "Школа искусств № 8" },
                    { 363253, 72, "Школа № 8" },
                    { 186240, 72, "Школа искусств № 7" },
                    { 225263, 72, "Школа № 7" },
                    { 291559, 72, "Школа искусств № 6" },
                    { 15845, 72, "Художественная школа № 6" },
                    { 175642, 72, "Детско-юношеская спортивная школа № 6 «Юность»" },
                    { 223953, 72, "Музыкальная школа № 6" },
                    { 1588004, 72, "Вечерняя школа № 6" },
                    { 20761, 72, "Школа № 11" },
                    { 222283, 72, "Школа № 6" },
                    { 174620, 72, "Музыкальная школа № 11" },
                    { 269594, 72, "Школа № 12" },
                    { 91913, 72, "Школа № 21" },
                    { 18157, 72, "Школа № 20" },
                    { 70367, 72, "Гимназия № 19" },
                    { 3497, 72, "Школа № 19" },
                    { 1776749, 72, "Среднее профессионально-техническое училище № 18" },
                    { 7739, 72, "Гимназия № 18" },
                    { 91886, 72, "Школа № 18" },
                    { 23586, 72, "Школа № 17" },
                    { 2478, 72, "Школа № 16" },
                    { 64913, 72, "Школа № 15" },
                    { 5004, 72, "Школа № 14" },
                    { 158587, 72, "Школа-интернат № 13" },
                    { 1766289, 72, "Детская школа искусств № 13" },
                    { 57732, 72, "Школа № 13" },
                    { 95844, 72, "Лицей № 12" },
                    { 340157, 72, "Школа искусств № 11" },
                    { 262672, 72, "Школа искусств № 5" },
                    { 102991, 72, "Детско-юношеская спортивная школа № 5" },
                    { 210149, 72, "Гимназия № 5" },
                    { 102662, 72, "Музыкальная школа № 2" },
                    { 203822, 72, "Вечерняя школа № 2" },
                    { 358451, 72, "Школа-интернат № 2" },
                    { 111989, 72, "Гимназия № 2" },
                    { 4393, 72, "Школа № 2" },
                    { 356038, 72, "Школа искусств № 1" },
                    { 317415, 72, "Профессионально-техническое училище № 1" },
                    { 342592, 72, "Колледж № 1" },
                    { 119656, 72, "Педагогический колледж № 1" },
                    { 331898, 72, "Художественная школа № 1" },
                    { 266285, 72, "Детско-юношеская спортивная школа № 1" },
                    { 71083, 72, "Музыкальная школа № 1" },
                    { 111308, 72, "Лицей № 1" },
                    { 132669, 72, "Гимназия № 1" },
                    { 104876, 72, "Частная школа № 1" },
                    { 133877, 72, "Педагогический колледж № 2" },
                    { 234195, 72, "Профессиональный лицей № 2" },
                    { 245343, 72, "Школа искусств № 2" },
                    { 263056, 72, "Школа № 3" },
                    { 110532, 72, "Школа № 5" },
                    { 242632, 72, "Школа искусств № 4" },
                    { 119024, 72, "Музыкальная школа № 4" },
                    { 329899, 72, "Школа-интернат № 4" },
                    { 86266, 72, "Лицей № 4" },
                    { 49972, 72, "Гимназия № 4" },
                    { 317101, 72, "Школа № 4" },
                    { 21571, 72, "Школа № 22" },
                    { 197637, 72, "Школа искусств № 3" },
                    { 197504, 72, "Художественная школа № 3" },
                    { 122986, 72, "Детско-юношеская спортивная школа № 3" },
                    { 140399, 72, "Музыкальная школа № 3" },
                    { 116435, 72, "Вечерняя школа № 3" },
                    { 112965, 72, "Школа-интернат № 3" },
                    { 94678, 72, "Лицей № 3" },
                    { 5293, 72, "Гимназия № 3" },
                    { 234530, 72, "Педагогический колледж № 3" },
                    { 185645, 72, "Школа № 75" },
                    { 102502, 72, "Школа № 23" },
                    { 10245, 72, "Школа № 24" },
                    { 322842, 72, "Школа № 60" },
                    { 63087, 72, "Лицей № 59" },
                    { 65694, 72, "Школа № 59" },
                    { 42249, 72, "Школа № 58" },
                    { 15186, 72, "Школа № 57" },
                    { 317622, 72, "Школа № 56" },
                    { 113248, 72, "Школа № 55" },
                    { 268490, 72, "Гимназия № 54" },
                    { 319748, 72, "Школа № 54" },
                    { 239926, 72, "Профессиональное училище № 53" },
                    { 237766, 72, "Школа № 53" },
                    { 282163, 72, "Гимназия № 52" },
                    { 143551, 72, "Школа № 52" },
                    { 172499, 72, "Школа № 51" },
                    { 14405, 72, "Школа № 50" },
                    { 70429, 72, "Школа № 61" },
                    { 344471, 72, "Детский сад № 49" },
                    { 16803, 72, "Школа № 62" },
                    { 222757, 72, "Детский центр № 63 (прогимназия)" },
                    { 353610, 72, "Школа № 73" },
                    { 13049, 72, "Гимназия № 72" },
                    { 131535, 72, "Школа № 72" },
                    { 323418, 72, "Гимназия № 71" },
                    { 353384, 72, "Школа № 71" },
                    { 735, 72, "Гимназия № 70" },
                    { 266273, 72, "Школа № 70" },
                    { 657, 72, "Гимназия № 69" },
                    { 186311, 72, "Школа № 69" },
                    { 211618, 72, "Профессиональное училище № 68" },
                    { 48462, 72, "Школа № 68" },
                    { 77782, 72, "Школа № 67" },
                    { 45814, 72, "Школа № 66" },
                    { 272973, 72, "Школа № 65" },
                    { 211252, 72, "Лицей № 64 (бывш. шк. № 64)" },
                    { 357531, 72, "Школа № 63" },
                    { 17413, 72, "Школа № 49" },
                    { 365866, 72, "Лицей № 48" },
                    { 27261, 72, "Гимназия № 47" },
                    { 5211, 72, "Школа № 34" },
                    { 250037, 72, "Гимназия № 33" },
                    { 250044, 72, "Школа № 33" },
                    { 15188, 72, "Школа № 32" },
                    { 10363, 72, "Школа № 31" },
                    { 360097, 72, "Школа № 30" },
                    { 22526, 72, "Школа № 29" },
                    { 3658, 72, "Школа № 28" },
                    { 74599, 72, "Школа № 27" },
                    { 60449, 72, "Школа № 26" },
                    { 26770, 72, "Гимназия № 25" },
                    { 60903, 72, "Школа № 25" },
                    { 351173, 72, "Школа-интернат № 24" },
                    { 126114, 72, "Профессиональный лицей № 24" },
                    { 115459, 72, "Лицей № 24" },
                    { 15211, 72, "Школа № 35" },
                    { 905826, 72, "Детский сад № 35" },
                    { 72325, 72, "Школа № 36" },
                    { 229891, 72, "Гимназия № 36" },
                    { 7733, 72, "Школа № 46" },
                    { 277005, 72, "Лицей № 45" },
                    { 28704, 72, "Школа № 45" },
                    { 311818, 72, "Гимназия № 44" },
                    { 179954, 72, "Школа № 44" },
                    { 257528, 72, "Школа № 43" },
                    { 359177, 72, "Школа № 42" },
                    { 553, 72, "Гимназия № 23" },
                    { 74741, 72, "Информационно-технологический техникум (КИТТ, бывш. ПЛ № 41, ПТУ № 41)" },
                    { 291690, 72, "Гимназия № 40" },
                    { 7922, 72, "Школа № 40" },
                    { 8746, 72, "Школа № 39" },
                    { 40974, 72, "Школа № 38" },
                    { 25020, 72, "Лицей № 37" },
                    { 115165, 72, "Школа № 37" },
                    { 335816, 72, "Детский сад № 36 «Журавушка»" },
                    { 175678, 72, "Школа № 41" },
                    { 1677219, 72, "Школа-интернат ФК «Краснодар»" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 553);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 657);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 735);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2214);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2478);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3497);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3658);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4393);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4418);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4667);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5004);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5211);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5293);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5626);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7365);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7733);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7739);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7922);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8746);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10245);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10363);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10452);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11362);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12328);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13049);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14405);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15186);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15188);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15211);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15845);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16803);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17413);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18157);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20761);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21571);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21574);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22526);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22604);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23496);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23586);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25020);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26770);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27261);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27898);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28077);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28498);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28704);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 29475);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 29664);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31887);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 32891);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 32892);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40060);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40974);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41699);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42249);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45814);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45822);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 48462);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49628);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49972);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 50911);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 52754);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 57732);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 60449);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 60903);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63087);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63542);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64913);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 65694);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67016);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70367);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70429);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70578);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71083);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 72325);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 72405);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 72434);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 73113);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 74599);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 74739);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 74741);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 75193);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 77782);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78402);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78491);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 79181);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 83111);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 85971);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 86266);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91886);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91913);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 94678);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 95844);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97743);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97834);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98479);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 100184);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 100553);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 102502);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 102662);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 102991);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 104787);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 104876);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 110532);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 111308);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 111989);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 112112);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 112965);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113248);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 115165);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 115172);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 115459);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116092);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116365);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116435);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 118271);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 118541);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 119024);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 119656);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 121519);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 121699);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 121713);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 122182);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 122986);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 124123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 125505);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 126114);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127640);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129164);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129536);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129657);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131037);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131535);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 132669);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 133877);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 134972);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 136832);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 139579);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140399);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 141174);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 143551);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 144019);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 150756);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 151068);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 151422);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 152080);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 152246);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 157278);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 158587);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 162145);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163221);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163229);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163427);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 166408);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169767);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 170950);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172499);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172637);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 174620);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 175642);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 175678);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 176959);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 177948);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179569);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179577);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179629);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179954);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 185645);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 186240);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 186311);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 190488);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 192305);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 193528);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 194664);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 196218);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 196651);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 197504);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 197637);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 198252);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 200043);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203822);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203873);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 204752);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206143);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 210149);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 210431);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 211252);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 211618);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 215785);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217357);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 222283);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 222757);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 222834);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 223690);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 223953);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 225079);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 225263);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 226020);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 227268);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 229891);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 229916);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 231759);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 232427);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 234195);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 234530);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 237766);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 239926);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 241184);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 242632);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 243206);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 245343);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 250037);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 250044);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 252669);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 254578);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 254629);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 256983);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 257528);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 262672);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 262989);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 263056);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 266206);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 266273);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 266285);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 267857);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 268490);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 269123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 269594);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 270776);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 271650);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 272973);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 277005);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 282163);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 285084);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 288651);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 289325);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 291559);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 291690);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 311818);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 312342);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 314327);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 317101);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 317415);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 317622);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 317684);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 319748);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 322842);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 323418);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 329899);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 330480);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 330620);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 331898);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 335816);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 340157);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 342582);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 342592);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 344022);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 344471);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 346494);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 351173);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 353384);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 353610);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 356038);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 357531);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 358451);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 359177);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 360097);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 363253);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 365866);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 688028);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 704581);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 704582);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 746918);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 763372);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 797906);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 810943);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 905826);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1519695);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1588004);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1656549);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1659493);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1659497);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1659784);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1661234);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1675795);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1677219);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1691404);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1698703);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1705593);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1719037);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1719673);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1728840);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1734027);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1750742);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1759586);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1759928);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764202);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1766289);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1769473);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1770493);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1773440);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1776583);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1776749);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1776992);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1780353);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1782243);
        }
    }
}
