using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class SchoolsVladivostok : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "Title" },
                values: new object[,]
                {
                    { 71720, 37, "Школа №1" },
                    { 51771, 37, "Восточная гимназия ВГУЭС" },
                    { 59458, 37, "Всероссийский детский центр «Океан»" },
                    { 63477, 37, "Гидрометеорологический колледж" },
                    { 231522, 37, "Гимназия «Паровоз»" },
                    { 7585, 37, "Гимназия ДВГУ" },
                    { 268305, 37, "Гимназия ДВФУ (бывш. Гуманитарная педагогическая гимназия ИЭИ ДВГТУ)" },
                    { 129608, 37, "Гимназия при Педагогическом колледже" },
                    { 284122, 37, "Гуманитарно-коммерческий колледж (ВГКК)" },
                    { 99687, 37, "Гуманитарно-технический колледж (ДГГТК)" },
                    { 1707317, 37, "Дальневосточный центр производительности" },
                    { 49349, 37, "Дворец детского (юношеского) творчества (ДДЮТ)" },
                    { 323882, 37, "Детская хореографическая студия-театр" },
                    { 162611, 37, "Детский сад «Белочка»" },
                    { 127482, 37, "Вокально-хоровая студия «До-ре-ми»" },
                    { 143688, 37, "Детский сад «Родничок»" },
                    { 1719767, 37, "Детско-юношеская спортивная школа «Бастион»" },
                    { 196793, 37, "Детско-юношеская спортивная школа «Олимпиец» при УОР" },
                    { 93141, 37, "Детско-юношеская спортивная школа олимпийского резерва" },
                    { 974394, 37, "Духовное училище (ВДУ)" },
                    { 152002, 37, "Евро-Азиатский лицей" },
                    { 227767, 37, "Классическая гимназия" },
                    { 108745, 37, "Колледж «Астро»" },
                    { 76200, 37, "Колледж Дальрыбвтуз" },
                    { 1046242, 37, "Колледж ДВГУ" },
                    { 1782196, 37, "Колледж индустрии моды и красоты ВГУЭС" },
                    { 222510, 37, "Колледж искусств (ПККИ, бывш. ВМУ)" },
                    { 1756692, 37, "Колледж машиностроения и транспорта «КМТ»" },
                    { 128758, 37, "Колледж МИ МГУ им. адм. Г. И. Невельского" },
                    { 310626, 37, "Детский сад «Сказка»" },
                    { 122777, 37, "Банковский колледж ТГЭУ" },
                    { 184166, 37, "Базовый медицинский колледж" },
                    { 1763697, 37, "Академия профессионального роста ВГУЭС" },
                    { 18077, 37, "Школа №77" },
                    { 11437, 37, "Школа №78" },
                    { 108491, 37, "Детско-юношеская спортивная школа №78" },
                    { 11476, 37, "Школа №79" },
                    { 10993, 37, "Школа №80" },
                    { 9855, 37, "Школа №81 (СОХЭШ)" },
                    { 1689866, 37, "Школа №82" },
                    { 1719768, 37, "Школа №83" },
                    { 285925, 37, "Школа №90" },
                    { 203572, 37, "Школа №111" },
                    { 1501588, 37, "Детский сад №130 «Тополёк»" },
                    { 335832, 37, "Школа №134" },
                    { 1671507, 37, "Детский сад №144 «Веснянка»" },
                    { 55911, 37, "Школа №152" },
                    { 134430, 37, "Школа №168" },
                    { 69289, 37, "Мореходная школа ВМФ №185" },
                    { 66989, 37, "Лицей №251" },
                    { 118820, 37, "Школа №253" },
                    { 24960, 37, "Школа №256" },
                    { 43548, 37, "Школа №257" },
                    { 55998, 37, "Школа №258" },
                    { 195362, 37, "Школа №259" },
                    { 73613, 37, "Школа №359" },
                    { 78813, 37, "Школа №421" },
                    { 170247, 37, "Автошкола «АНИК»" },
                    { 1756517, 37, "Автошкола «Профи Центр»" },
                    { 1705590, 37, "Автошкола ДОСААФ" },
                    { 94067, 37, "Азиатско-тихоокеанская школа культурной политики" },
                    { 965334, 37, "Академический колледж ВГУЭС" },
                    { 115893, 37, "Колледж морской рыбопромышленный (ВМРК)" },
                    { 16133, 37, "Школа №76" },
                    { 246690, 37, "Колледж сервиса и дизайна ВГУЭС" },
                    { 506172, 37, "Кооперативный техникум (ВКТ)" },
                    { 1672299, 37, "Фотошкола Максима Комарова" },
                    { 199688, 37, "Хореографическая школа" },
                    { 233404, 37, "Хоровая студия «Камертон»" },
                    { 31109, 37, "Частная школа Комашинского" },
                    { 175880, 37, "Школа «Major Production»" },
                    { 11637, 37, "Школа «Pacific Line School»" },
                    { 252265, 37, "Школа «Red Star»" },
                    { 42173, 37, "Школа «Wise College»" },
                    { 9965, 37, "Школа «Атланта»" },
                    { 96262, 37, "Школа «Гармония»" },
                    { 221576, 37, "Школа «Гермес»" },
                    { 56610, 37, "Школа «Дарина»" },
                    { 190990, 37, "Школа «Конкордия»" },
                    { 174997, 37, "Училище олимпийского резерва" },
                    { 1046243, 37, "Школа «Открытый мир»" },
                    { 1728556, 37, "Школа «Сеол»" },
                    { 328830, 37, "Школа «Тезаурус»" },
                    { 10267, 37, "Школа «Терра»" },
                    { 58244, 37, "Школа «Эврика»" },
                    { 330402, 37, "Школа иностранных языков «Advance English»" },
                    { 213674, 37, "Школа иностранных языков «English First»" },
                    { 195877, 37, "Школа операционного консалтинга" },
                    { 279984, 37, "Школа парикмахерского искусства «Pivot Point»" },
                    { 130572, 37, "Школа техников ВМФ (ШТ ВМФ)" },
                    { 290565, 37, "Школа-интернат «Сад-город»" },
                    { 239036, 37, "Школа-интернат для детей с нарушением опорно-двигательного аппарата" },
                    { 61060, 37, "Школа-интернат для одаренных детей им. Н. Н. Дубинина (ШИОД)" },
                    { 79383, 37, "Школа-пансион «Святая Ольга»" },
                    { 165971, 37, "Школа «Родник»" },
                    { 315992, 37, "Учебно-производственный комбинат" },
                    { 132261, 37, "Технический лицей" },
                    { 82127, 37, "Судостроительный колледж (ВСК)" },
                    { 253679, 37, "Краевая санаторная школа-интернат" },
                    { 328724, 37, "Краевая хореографическая школа" },
                    { 168226, 37, "Лицей «Буревестник»" },
                    { 1344435, 37, "Лицей ВГУЭС" },
                    { 1661171, 37, "Лицей Дальрыбвтуз" },
                    { 33741, 37, "Лицей ДВГАЭУ" },
                    { 140638, 37, "Лицей ДВГТУ" },
                    { 122354, 37, "Лицей информационных технологий" },
                    { 101186, 37, "Лицей при МГУ им. адмирала Невельского" },
                    { 101202, 37, "Лицей ТГЭУ" },
                    { 246333, 37, "Малая академия морской биологии (МАМБ)" },
                    { 278327, 37, "Малая восточная академия при ДВГТУ (МВА)" },
                    { 217990, 37, "Медицинский лицей ВГМУ" },
                    { 1778843, 37, "Международная лингвистическая школа ВГУЭС" },
                    { 1752865, 37, "Международная средняя школа (ВМСОШ)" },
                    { 145369, 37, "Мореходное училище" },
                    { 40362, 37, "Морской колледж" },
                    { 987719, 37, "Музыкальный колледж при ДВГАИ" },
                    { 125645, 37, "Политехнический техникум" },
                    { 239935, 37, "Православная гимназия" },
                    { 1741757, 37, "Президентское кадетское училище (ВПКУ)" },
                    { 123918, 37, "Приморский краевой специализированный учебно-научный центр (ПК СУНЦ ШИОД при ВГУЭС)" },
                    { 163485, 37, "Приморский краевой художественный колледж (бывш. ВХУ)" },
                    { 249961, 37, "Приморский политехнический колледж" },
                    { 1774288, 37, "Профессиональный колледж ДВФУ" },
                    { 1737650, 37, "Региональный технический колледж" },
                    { 165117, 37, "Русский колледж" },
                    { 194982, 37, "Строительный техникум" },
                    { 228925, 37, "Суворовское училище" },
                    { 1780465, 37, "Колледж технологии и сервиса (КТИС)" },
                    { 775, 37, "Школа №75" },
                    { 49988, 37, "Школа №74" },
                    { 10163, 37, "Школа №73" },
                    { 123699, 37, "Профессиональное морское училище №5" },
                    { 120292, 37, "Школа искусств №5" },
                    { 2585, 37, "Школа №6" },
                    { 138988, 37, "Музыкальная школа №6" },
                    { 207559, 37, "Школа №7" },
                    { 255413, 37, "Технический лицей №7" },
                    { 163608, 37, "Художественная школа №7" },
                    { 224556, 37, "Профессионально-техническое училище №7" },
                    { 86108, 37, "Профессиональное морское училище №7" },
                    { 236181, 37, "Профессиональное училище №7" },
                    { 208990, 37, "Школа №8" },
                    { 270586, 37, "Вечерняя школа №8" },
                    { 129584, 37, "Музыкальная школа №8" },
                    { 292416, 37, "Колледж №5" },
                    { 129589, 37, "Художественная школа №8" },
                    { 253825, 37, "Школа искусств №8" },
                    { 4840, 37, "Школа №9" },
                    { 225542, 37, "Школа №10" },
                    { 167977, 37, "Вечерняя школа №10" },
                    { 40604, 37, "Колледж №10" },
                    { 8837, 37, "Школа №11" },
                    { 169063, 37, "Лицей №11" },
                    { 251873, 37, "Профессионально-техническое училище №11" },
                    { 227402, 37, "Профессиональный лицей №11" },
                    { 11169, 37, "Школа №12" },
                    { 7189, 37, "Школа №13" },
                    { 6534, 37, "Школа №14" },
                    { 2946, 37, "Школа №15" },
                    { 283604, 37, "Училище связи №8" },
                    { 173194, 37, "Профессионально-техническое училище №5" },
                    { 131794, 37, "Лицей при музыкальной школе №5" },
                    { 100654, 37, "Школа №5" },
                    { 225800, 37, "Школа «Полюс №1»" },
                    { 120188, 37, "Гимназия №1" },
                    { 65371, 37, "Гимназия при ВПК №1" },
                    { 281441, 37, "Школа-интернат №1" },
                    { 175672, 37, "Вечерняя школа №1" },
                    { 62331, 37, "Музыкальная школа №1" },
                    { 41331, 37, "Художественная школа №1" },
                    { 203734, 37, "Педагогический колледж №1" },
                    { 192989, 37, "Колледж №1" },
                    { 114850, 37, "Профессионально-техническое училище №1" },
                    { 237488, 37, "Школа искусств №1 им. Прокофьева" },
                    { 60961, 37, "Профессиональное училище №1" },
                    { 133414, 37, "Профессиональное училище №2" },
                    { 55452, 37, "Школа №2" },
                    { 217232, 37, "Школа иностранных языков при Лицее №2" },
                    { 186511, 37, "Гимназия №2" },
                    { 112113, 37, "Технический лицей №2" },
                    { 223265, 37, "Школа-интернат №2" },
                    { 266842, 37, "Вечерняя школа №2" },
                    { 40610, 37, "Музыкальная школа №2" },
                    { 243926, 37, "Экономико-правовой колледж «Лидер-2»" },
                    { 131036, 37, "Педагогический колледж №2" },
                    { 60446, 37, "Школа №3" },
                    { 1759033, 37, "Школа искусств №3" },
                    { 61538, 37, "Музыкальная школа №3" },
                    { 225121, 37, "Художественная школа №3" },
                    { 56820, 37, "Школа №4" },
                    { 317840, 37, "Школа-интернат №4" },
                    { 39506, 37, "Детская школа искусств №4 (бывш. ДМШ №4 и ДХШ №2)" },
                    { 9458, 37, "Школа №16" },
                    { 116641, 37, "Вечерняя школа №16" },
                    { 5608, 37, "Школа №17" },
                    { 17518, 37, "Школа №18" },
                    { 34030, 37, "Школа №44" },
                    { 1769, 37, "Школа №45" },
                    { 8821, 37, "Школа №46" },
                    { 106565, 37, "Школа №47" },
                    { 4674, 37, "Школа №48" },
                    { 207644, 37, "Профессионально-техническое училище №49" },
                    { 200174, 37, "Школа №50" },
                    { 8742, 37, "Школа №51" },
                    { 5344, 37, "Школа №52" },
                    { 27785, 37, "Школа №53" },
                    { 61542, 37, "Школа №54" },
                    { 29078, 37, "Школа №55" },
                    { 25116, 37, "Школа №56" },
                    { 4859, 37, "Школа №57" },
                    { 26572, 37, "Школа №58" },
                    { 6427, 37, "Школа №59" },
                    { 2221, 37, "Школа №60" },
                    { 17444, 37, "Школа №61" },
                    { 2073, 37, "Школа №62" },
                    { 2229, 37, "Школа №63" },
                    { 43019, 37, "Школа №64" },
                    { 22412, 37, "Школа №65" },
                    { 42174, 37, "Школа №66" },
                    { 22251, 37, "Школа №67" },
                    { 45039, 37, "Школа №68" },
                    { 1382, 37, "Школа №69" },
                    { 45841, 37, "Школа №70" },
                    { 63189, 37, "Школа №71" },
                    { 17131, 37, "Школа №72" },
                    { 1310776, 37, "Профессиональный лицей №43" },
                    { 129967, 37, "Энергетический лицей" },
                    { 179205, 37, "Лицей №43" },
                    { 26626, 37, "Школа №42" },
                    { 35409, 37, "Школа №19" },
                    { 22306, 37, "Школа №20" },
                    { 6971, 37, "Школа №21" },
                    { 3135, 37, "Школа №22" },
                    { 2297, 37, "Школа №23" },
                    { 67918, 37, "Школа №24" },
                    { 20094, 37, "Школа №25" },
                    { 88406, 37, "Школа №26" },
                    { 27847, 37, "Лицей №26" },
                    { 7878, 37, "Школа №27" },
                    { 14236, 37, "Школа №28" },
                    { 97716, 37, "Школа №29" },
                    { 219988, 37, "Гимназия №29" },
                    { 55471, 37, "Школа №30" },
                    { 27799, 37, "Школа №31" },
                    { 131919, 37, "Гимназия №31" },
                    { 24931, 37, "Школа №32" },
                    { 1179, 37, "Школа №33" },
                    { 47352, 37, "Школа №34" },
                    { 11069, 37, "Школа №35" },
                    { 109593, 37, "Школа №36" },
                    { 27297, 37, "Школа №37" },
                    { 276128, 37, "Лицей №37" },
                    { 14325, 37, "Школа №38" },
                    { 125863, 37, "Лицей №38" },
                    { 5342, 37, "Школа №39" },
                    { 1535, 37, "Школа №40" },
                    { 9296, 37, "Лицей №41" },
                    { 135033, 37, "Профессиональный лицей №41" },
                    { 169072, 37, "Школа №43" },
                    { 88040, 37, "Энергетический техникум (ДВЭТ)" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 775);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1179);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1382);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1535);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1769);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2073);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2221);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2229);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2297);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2585);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2946);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3135);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4674);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4840);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4859);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5342);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5344);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5608);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6427);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6534);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6971);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7189);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7585);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7878);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8742);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8821);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8837);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9296);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9458);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9855);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9965);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10163);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10267);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10993);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11069);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11169);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11437);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11476);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11637);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14236);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14325);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16133);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17131);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17444);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17518);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18077);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20094);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22251);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22306);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22412);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24931);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24960);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25116);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26572);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26626);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27297);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27785);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27799);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27847);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 29078);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31109);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 33741);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34030);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 35409);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 39506);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40362);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40604);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40610);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41331);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42173);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42174);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43019);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43548);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45039);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45841);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 47352);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49349);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49988);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51771);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55452);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55471);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55911);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55998);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 56610);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 56820);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 58244);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 59458);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 60446);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 60961);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 61060);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 61538);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 61542);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 62331);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63189);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63477);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 65371);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 66989);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67918);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 69289);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71720);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 73613);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 76200);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78813);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 79383);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 82127);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 86108);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 88040);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 88406);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 93141);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 94067);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 96262);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97716);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 99687);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 100654);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101186);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101202);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 106565);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 108491);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 108745);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 109593);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 112113);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 114850);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 115893);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116641);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 118820);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 120188);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 120292);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 122354);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 122777);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 123699);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 123918);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 125645);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 125863);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127482);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 128758);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129584);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129589);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129608);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129967);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 130572);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131036);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131794);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 131919);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 132261);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 133414);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 134430);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 135033);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 138988);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 140638);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 143688);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 145369);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 152002);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 162611);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163485);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163608);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165117);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165971);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 167977);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168226);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169063);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169072);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 170247);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 173194);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 174997);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 175672);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 175880);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179205);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 184166);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 186511);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 190990);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 192989);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 194982);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 195362);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 195877);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 196793);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 199688);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 200174);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203572);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203734);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 207559);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 207644);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 208990);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 213674);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217232);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217990);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 219988);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 221576);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 222510);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 223265);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 224556);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 225121);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 225542);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 225800);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 227402);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 227767);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 228925);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 231522);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 233404);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 236181);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 237488);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 239036);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 239935);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 243926);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 246333);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 246690);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 249961);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 251873);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 252265);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 253679);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 253825);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 255413);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 266842);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 268305);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 270586);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 276128);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 278327);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 279984);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 281441);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 283604);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 284122);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 285925);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 290565);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 292416);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 310626);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 315992);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 317840);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 323882);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 328724);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 328830);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 330402);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 335832);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 506172);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 965334);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 974394);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 987719);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1046242);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1046243);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1310776);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1344435);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1501588);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1661171);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1671507);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1672299);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1689866);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1705590);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1707317);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1719767);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1719768);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1728556);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1737650);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1741757);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1752865);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1756517);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1756692);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1759033);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1763697);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1774288);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1778843);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1780465);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1782196);
        }
    }
}
