using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class HabarovskSchools : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "Title" },
                values: new object[,]
                {
                    { 174115, 153, "Школа №1" },
                    { 91491, 153, "Военно-пограничный лицей (ВПЛ)" },
                    { 169057, 153, "Гуманитарный лицей" },
                    { 237492, 153, "Дальневосточный театр моды" },
                    { 241456, 153, "Дальневосточный центр «Знания плюс»" },
                    { 89478, 153, "Детская школа культуры" },
                    { 180854, 153, "Детский сад «Малинка»" },
                    { 217366, 153, "Детско-юношеская спортивная школа «Дельфин»" },
                    { 155802, 153, "Дом художественного творчества детей «Амурские ребята»" },
                    { 1746005, 153, "Дорожно-строительный техникум" },
                    { 143556, 153, "Заочная физико-математическая школа (ЗФМШ)" },
                    { 314171, 153, "Индустриально-экономический колледж" },
                    { 165970, 153, "Инженерно-физический лицей при ХГТУ" },
                    { 195606, 153, "Колледж моды и дизайна" },
                    { 98004, 153, "Военно-морской лицей (ВМЛ)" },
                    { 165691, 153, "Колледж отраслевых технологий и сферы обслуживания (бывш. ДВГМИЭК)" },
                    { 168482, 153, "Кооперативный техникум" },
                    { 81617, 153, "Краевой колледж искусств" },
                    { 1749083, 153, "Краевой центр образования" },
                    { 87632, 153, "Лицей «Вектор»" },
                    { 1781366, 153, "Лицей «Звездный»" },
                    { 157563, 153, "Лицей «Ритм»" },
                    { 93958, 153, "Лицей «Ступени»" },
                    { 70488, 153, "Лицей ДВГУПС" },
                    { 195015, 153, "Лицей инновационных технологий" },
                    { 227285, 153, "Лицей информационных технологий" },
                    { 158769, 153, "Лицей искусств" },
                    { 63589, 153, "Лицей переводчиков" },
                    { 65372, 153, "Лицей психологии и психиатрии" },
                    { 70096, 153, "Колледж связи и информатики (СПО ХИИК СибГУТИ)" },
                    { 227710, 153, "Математический лицей" },
                    { 67533, 153, "Банковский колледж Банка России (бывш. Банковская школа ЦБ РФ)" },
                    { 145760, 153, "Ансамбль танца «Радость»" },
                    { 5205, 153, "Школа №77" },
                    { 38595, 153, "Школа №78" },
                    { 98995, 153, "Школа №79" },
                    { 78158, 153, "Школа №80" },
                    { 2528, 153, "Гимназия №80" },
                    { 64813, 153, "Школа №81" },
                    { 27447, 153, "Школа №83" },
                    { 73623, 153, "Школа №84" },
                    { 34217, 153, "Школа №85" },
                    { 224350, 153, "Школа №86" },
                    { 23898, 153, "Школа №87" },
                    { 136796, 153, "Школа №88" },
                    { 142671, 153, "Школа №89" },
                    { 320615, 153, "Архитектурно-художественный лицей" },
                    { 194877, 153, "Школа №90" },
                    { 1080594, 153, "Детский сад №137" },
                    { 80492, 153, "Школа №162" },
                    { 155850, 153, "Гимназия №165" },
                    { 181005, 153, "Школа №167" },
                    { 165557, 153, "Школа №171" },
                    { 579782, 153, "Детский сад №179" },
                    { 1080595, 153, "Детский сад №202" },
                    { 318270, 153, "Детский сад №210" },
                    { 196596, 153, "Школа «Поколение 2000»" },
                    { 169097, 153, "Автодорожный техникум (ХАДТ)" },
                    { 1705601, 153, "Автошкола ДОСААФ" },
                    { 111726, 153, "Автошкола СТК «Автомобилист»" },
                    { 213385, 153, "Ансамбль «Самоцветы»" },
                    { 203454, 153, "Школа №136" },
                    { 161337, 153, "Машиностроительный техникум" },
                    { 1737646, 153, "Медико-фармацевтический колледж" },
                    { 224170, 153, "Медицинский колледж (ХГМК)" },
                    { 59202, 153, "Школа «Аист»" },
                    { 156367, 153, "Школа «Акме»" },
                    { 135014, 153, "Школа «Алые паруса»" },
                    { 116597, 153, "Школа «Дидактос»" },
                    { 197891, 153, "Школа «Знание»" },
                    { 286516, 153, "Школа «Лингвист»" },
                    { 124709, 153, "Школа «Ор-Авнер»" },
                    { 260559, 153, "Школа «Открытие»" },
                    { 1598364, 153, "Школа «Первые шаги»" },
                    { 318269, 153, "Школа «Радость»" },
                    { 125113, 153, "Школа «Родничок»" },
                    { 37616, 153, "Школа «Росна»" },
                    { 81659, 153, "Школа «Талант»" },
                    { 67351, 153, "Школа «Азимут»" },
                    { 289231, 153, "Школа бизнеса при ТОГУ" },
                    { 132265, 153, "Школа дизайна «Мир интерьера»" },
                    { 1351998, 153, "Школа дизайна «Эскалье»" },
                    { 114184, 153, "Школа иностранных языков «ABC»" },
                    { 274123, 153, "Школа иностранных языков «Британика»" },
                    { 166306, 153, "Школа иностранных языков «Райз»" },
                    { 337072, 153, "Школа искусств при ХПШО «Восток»" },
                    { 116628, 153, "Школа парикмахерского искусства «Pivot Point»" },
                    { 101133, 153, "Школа техников ВМФ" },
                    { 288194, 153, "Школа управления «VanaTallinn» при Эстетическом центре ДВГУПС" },
                    { 192078, 153, "Школа эстетического образования" },
                    { 68145, 153, "Школа-интернат для слабослышащих детей" },
                    { 1664206, 153, "Школа-интернат для слепых и слабовидящих детей" },
                    { 134220, 153, "Экономическая гимназия" },
                    { 227346, 153, "Школа восточного танца «Фаридэ»" },
                    { 318645, 153, "Школа «ELC»" },
                    { 156917, 153, "Частная школа с еврейским культурным компонентом" },
                    { 272615, 153, "Центра спортивного танца «Фантазия»" },
                    { 1772028, 153, "Международный финансово-промышленный колледж дружбы народов" },
                    { 1751068, 153, "Международный центр иностранных языков «Инлайн»" },
                    { 255437, 153, "Межшкольный учебный комбинат Кировского района" },
                    { 165723, 153, "Многопрофильный лицей" },
                    { 137956, 153, "Монтажный техникум" },
                    { 152235, 153, "Музыкальная школа «Тополёк»" },
                    { 259861, 153, "Музыкальная школа «Этюд»" },
                    { 203391, 153, "Педагогический колледж" },
                    { 34225, 153, "Педагогический лицей" },
                    { 150747, 153, "Политехнический лицей" },
                    { 164864, 153, "Промышленно-экономический техникум (ХПЭТ, бывш. ХЛТТ)" },
                    { 181279, 153, "Спортивная школа «Скиф»" },
                    { 247548, 153, "Театр-студия «Алый парус»" },
                    { 145316, 153, "Техникум геодезии и картографии (ДВТГиК)" },
                    { 196982, 153, "Техникум железнодорожного транспорта (ХТЖТ)" },
                    { 178782, 153, "Техникум техносферной безопасности и промышленных технологий (бывш. Судостроительный колледж и Строительный техникум)" },
                    { 217975, 153, "Технический колледж" },
                    { 11146, 153, "Технологический колледж" },
                    { 221520, 153, "Торгово-экономический техникум (ХТЭТ, бывш. ХТСТ)" },
                    { 314019, 153, "Учебный центр «Кнауф»" },
                    { 1744215, 153, "Учебный центр «ОлеХаус»" },
                    { 129350, 153, "Учетно-кредитный техникум" },
                    { 143140, 153, "Финансово-экономический колледж (филиал БФЭК)" },
                    { 1763906, 153, "Хабаровская школа переводчиков" },
                    { 1781789, 153, "Хабаровский техникум транспортных технологий" },
                    { 113672, 153, "Хабаровский филиал СПбГУ ГА (Авиационный колледж)" },
                    { 91601, 153, "Хореографическая школа" },
                    { 1744426, 153, "Центр детского творчества «Радуга талантов»" },
                    { 330366, 153, "Центр эстетического воспитания детей (ЦЭВД)" },
                    { 42163, 153, "Школа №76" },
                    { 31060, 153, "Школа №75" },
                    { 55427, 153, "Школа №74" },
                    { 166095, 153, "Школа №73" },
                    { 114654, 153, "Гимназия №6" },
                    { 172742, 153, "Музыкальная школа №6" },
                    { 322168, 153, "Колледж №6" },
                    { 129680, 153, "Школа №7" },
                    { 146872, 153, "Гимназия №7" },
                    { 139142, 153, "Электротехнический лицей №7" },
                    { 120015, 153, "Школа-интернат №7" },
                    { 184228, 153, "Музыкальная школа №7" },
                    { 169318, 153, "Гимназия №8" },
                    { 119592, 153, "Музыкальная школа №8" },
                    { 8282, 153, "Школа №9" },
                    { 93970, 153, "Гимназия №9" },
                    { 192990, 153, "Профессионально-техническое училище №9" },
                    { 1763199, 153, "Профессиональное училище №6" },
                    { 35712, 153, "Школа №10" },
                    { 255356, 153, "Профессиональное училище №10" },
                    { 90723, 153, "Школа №11" },
                    { 24447, 153, "Школа №12" },
                    { 62884, 153, "Школа №13" },
                    { 81995, 153, "Школа №14" },
                    { 113038, 153, "Школа №15" },
                    { 76655, 153, "Архитектурный лицей №15" },
                    { 42255, 153, "Школа №16" },
                    { 268266, 153, "Училище №16" },
                    { 268259, 153, "Школа искусств №16" },
                    { 91762, 153, "Школа №17" },
                    { 177353, 153, "Школа №18" },
                    { 41072, 153, "Школа №19" },
                    { 82598, 153, "Вечерняя школа №10" },
                    { 59378, 153, "Школа №6" },
                    { 704605, 153, "Техникум водного транспорта (ХТВТ, бывш. ПЛ №5)" },
                    { 176802, 153, "Музыкальная школа №5" },
                    { 136114, 153, "Кадетская школа №1 им. Ф. Ф. Ушакова" },
                    { 27398, 153, "Гимназия №1" },
                    { 60463, 153, "Технический лицей №1" },
                    { 127308, 153, "Школа-интернат №1 (ДВЖД)" },
                    { 160055, 153, "Музыкальная школа №1" },
                    { 98360, 153, "Детско-юношеская спортивная школа олимпийского резерва №1" },
                    { 124773, 153, "Детско-юношеская спортивная школа №1" },
                    { 114183, 153, "Художественная школа №1" },
                    { 294529, 153, "Профессионально-техническое училище №1" },
                    { 206012, 153, "Школа №2" },
                    { 61853, 153, "Гимназия №2" },
                    { 46787, 153, "Музыкальная школа №2" },
                    { 127676, 153, "Детско-юношеский клуб физической подготовки №2 (ДЮКФП)" },
                    { 82643, 153, "Школа №3" },
                    { 190437, 153, "Гимназия №3" },
                    { 168153, 153, "Вечерняя школа №3" },
                    { 201676, 153, "Профессионально-техническое училище №3" },
                    { 312472, 153, "Профессиональное училище №3" },
                    { 312463, 153, "Школа искусств №3" },
                    { 72104, 153, "Школа «Успех» (бывш. Школа №4, №8)" },
                    { 43727, 153, "Гимназия №4" },
                    { 94171, 153, "Музыкальная школа №4" },
                    { 1560353, 153, "Детско-юношеская спортивная школа №4" },
                    { 202692, 153, "Профессионально-техническое училище №4" },
                    { 293169, 153, "Школа искусств №4" },
                    { 241008, 153, "Школа №5" },
                    { 14906, 153, "Гимназия №5" },
                    { 193900, 153, "Школа-интернат №5" },
                    { 217340, 153, "Вечерняя школа №5" },
                    { 106221, 153, "Школа №20" },
                    { 185823, 153, "Электротехникум связи (ХЭТС)" },
                    { 221527, 153, "Лицей №20" },
                    { 78808, 153, "Школа №21" },
                    { 49142, 153, "Школа №45" },
                    { 50361, 153, "Школа №46" },
                    { 3103, 153, "Школа №47" },
                    { 97376, 153, "Школа №48" },
                    { 22298, 153, "Школа №49" },
                    { 93357, 153, "Школа №50" },
                    { 169178, 153, "Лицей №50" },
                    { 21815, 153, "Школа №51" },
                    { 23405, 153, "Школа №52" },
                    { 23823, 153, "Школа №53" },
                    { 221608, 153, "Школа №54" },
                    { 208600, 153, "Школа №55" },
                    { 48235, 153, "Школа №56" },
                    { 11338, 153, "Школа №44" },
                    { 19878, 153, "Школа №57" },
                    { 70134, 153, "Школа №59" },
                    { 32115, 153, "Школа №60" },
                    { 54915, 153, "Школа №61" },
                    { 33996, 153, "Школа №62" },
                    { 203443, 153, "Школа №63" },
                    { 77236, 153, "Школа №64" },
                    { 37834, 153, "Школа №65" },
                    { 56354, 153, "Школа №66" },
                    { 21882, 153, "Школа №67" },
                    { 20954, 153, "Школа №68" },
                    { 53323, 153, "Школа №70" },
                    { 34300, 153, "Школа №71" },
                    { 26016, 153, "Школа №72" },
                    { 11902, 153, "Школа №58" },
                    { 209820, 153, "Школа №43" },
                    { 218135, 153, "Школа №42" },
                    { 143156, 153, "Профессиональный коммерческий лицей №41" },
                    { 203845, 153, "Школа №22" },
                    { 41602, 153, "Гимназия №22" },
                    { 287067, 153, "Лицей №22" },
                    { 172190, 153, "Профессионально-техническое училище №22" },
                    { 13168, 153, "Школа №23" },
                    { 14230, 153, "Школа №24" },
                    { 5813, 153, "Школа №25" },
                    { 1264, 153, "Школа №26" },
                    { 26085, 153, "Школа №27" },
                    { 8941, 153, "Школа №28" },
                    { 284543, 153, "Профессиональное училище №28" },
                    { 51253, 153, "Школа №29" },
                    { 154264, 153, "Школа №30" },
                    { 220429, 153, "Профессионально-техническое училище №30" },
                    { 316405, 153, "Профессиональное училище №30" },
                    { 68168, 153, "Школа №31" },
                    { 12455, 153, "Школа №32" },
                    { 703900, 153, "Профессионально-техническое училище №32" },
                    { 32965, 153, "Школа №33" },
                    { 18795, 153, "Школа №34" },
                    { 18051, 153, "Школа №35" },
                    { 17425, 153, "Школа №36" },
                    { 208683, 153, "Лицей №36" },
                    { 253500, 153, "Профессиональное училище №36" },
                    { 168553, 153, "Школа №37" },
                    { 7984, 153, "Школа №38" },
                    { 206193, 153, "Школа №39" },
                    { 31525, 153, "Школа №40" },
                    { 64852, 153, "Школа №41" },
                    { 278008, 153, "Школа искусств №20" },
                    { 226358, 153, "Электротехнический техникум" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1264);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2528);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3103);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5205);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5813);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7984);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8282);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 8941);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11146);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11338);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11902);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12455);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13168);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14230);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 14906);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17425);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18051);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18795);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19878);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20954);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21815);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21882);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22298);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23405);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23823);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23898);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24447);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26016);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26085);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27398);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 27447);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31060);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31525);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 32115);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 32965);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 33996);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34217);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34225);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34300);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 35712);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 37616);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 37834);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 38595);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41072);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41602);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42163);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42255);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43727);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 46787);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 48235);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49142);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 50361);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51253);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 53323);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 54915);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55427);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 56354);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 59202);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 59378);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 60463);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 61853);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 62884);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63589);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64813);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64852);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 65372);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67351);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67533);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68145);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68168);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70096);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70134);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70488);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 72104);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 73623);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 76655);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 77236);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78158);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 78808);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 80492);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81617);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81659);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81995);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 82598);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 82643);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 87632);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 89478);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 90723);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91491);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91601);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91762);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 93357);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 93958);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 93970);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 94171);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97376);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98004);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98360);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98995);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101133);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 106221);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 111726);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113038);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113672);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 114183);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 114184);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 114654);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116597);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 116628);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 119592);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 120015);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 124709);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 124773);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 125113);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127308);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127676);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129350);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 129680);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 132265);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 134220);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 135014);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 136114);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 136796);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 137956);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 139142);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 142671);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 143140);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 143156);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 143556);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 145316);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 145760);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 146872);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 150747);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 152235);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 154264);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 155802);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 155850);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 156367);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 156917);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 157563);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 158769);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 160055);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 161337);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 164864);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165557);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165691);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165723);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 165970);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 166095);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 166306);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168153);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168482);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168553);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169057);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169097);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169178);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169318);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172190);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172742);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 174115);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 176802);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 177353);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 178782);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 180854);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 181005);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 181279);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 184228);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 185823);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 190437);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 192078);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 192990);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 193900);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 194877);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 195015);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 195606);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 196596);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 196982);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 197891);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 201676);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 202692);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203391);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203443);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203454);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 203845);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206012);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206193);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 208600);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 208683);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 209820);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 213385);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217340);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217366);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 217975);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 218135);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 220429);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 221520);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 221527);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 221608);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 224170);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 224350);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 226358);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 227285);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 227346);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 227710);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 237492);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 241008);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 241456);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 247548);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 253500);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 255356);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 255437);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 259861);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 260559);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 268259);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 268266);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 272615);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 274123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 278008);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 284543);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 286516);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 287067);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 288194);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 289231);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 293169);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 294529);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 312463);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 312472);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 314019);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 314171);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 316405);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 318269);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 318270);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 318645);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 320615);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 322168);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 330366);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 337072);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 579782);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 703900);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 704605);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1080594);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1080595);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1351998);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1560353);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1598364);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1664206);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1705601);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1737646);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1744215);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1744426);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1746005);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1749083);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1751068);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1763199);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1763906);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1772028);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1781366);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1781789);
        }
    }
}
