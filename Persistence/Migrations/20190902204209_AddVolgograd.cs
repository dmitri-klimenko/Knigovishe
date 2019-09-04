using Microsoft.EntityFrameworkCore.Migrations;

namespace Knigosha.Persistence.Migrations
{
    public partial class AddVolgograd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Schools",
                columns: new[] { "Id", "CityId", "Title" },
                values: new object[,]
                {
                    { 53649, 10, "Школа № 1" },
                    { 73799, 10, "Школа № 131" },
                    { 15550, 10, "Школа № 130" },
                    { 18182, 10, "Школа № 129" },
                    { 31170, 10, "Школа № 128" },
                    { 114956, 10, "Школа № 127" },
                    { 75793, 10, "Школа № 126" },
                    { 52686, 10, "Школа № 125" },
                    { 172273, 10, "Школа № 124" },
                    { 15929, 10, "Школа № 132" },
                    { 82454, 10, "Школа № 123" },
                    { 76208, 10, "Школа № 121" },
                    { 48400, 10, "Школа № 120" },
                    { 114575, 10, "Школа № 119" },
                    { 39407, 10, "Школа № 118" },
                    { 54299, 10, "Школа № 117" },
                    { 75709, 10, "Школа № 116" },
                    { 17970, 10, "Школа № 115" },
                    { 28199, 10, "Школа № 113" },
                    { 64632, 10, "Школа № 122" },
                    { 30126, 10, "Школа № 112" },
                    { 20963, 10, "Школа № 133" },
                    { 99209, 10, "Школа № 136" },
                    { 46538, 10, "Газпром колледж Волгоград (Колледж газа и нефти, ВКГН)" },
                    { 98699, 10, "Волгоградский политехнический колледж им. В. И. Вернадского" },
                    { 1782255, 10, "Волгоградский колледж ресторанного сервиса и торговли" },
                    { 1775895, 10, "Волгоградский институт профессионального образования" },
                    { 344233, 10, "Бизнес-гимназия при ВИБ" },
                    { 224706, 10, "Библейский колледж «Новая жизнь»" },
                    { 207063, 10, "Библейская школа «Весть»" },
                    { 51946, 10, "Астраханское речное училище (ВФ АРУ)" },
                    { 45447, 10, "Школа № 134" },
                    { 1776659, 10, "Академический колледж" },
                    { 50228, 10, "Школа № 384" },
                    { 341850, 10, "Детский сад № 365" },
                    { 694071, 10, "Детский сад № 363" },
                    { 277019, 10, "Детский сад № 268" },
                    { 1723809, 10, "Детский сад № 220" },
                    { 216029, 10, "Школа № 141" },
                    { 17929, 10, "Школа № 140" },
                    { 179715, 10, "Школа № 139" },
                    { 1765816, 10, "IT Школа Samsung" },
                    { 260664, 10, "Детский сад № 111" },
                    { 29143, 10, "Школа № 111" },
                    { 21200, 10, "Школа № 110" },
                    { 43828, 10, "Школа № 86" },
                    { 246707, 10, "Школа № 85" },
                    { 10968, 10, "Школа № 84" },
                    { 19603, 10, "Школа № 83" },
                    { 328247, 10, "Школа № 82" },
                    { 45, 10, "Школа № 81" },
                    { 213053, 10, "Школа № 80" },
                    { 86669, 10, "Школа № 79" },
                    { 93662, 10, "Школа № 87" },
                    { 288070, 10, "Школа № 78" },
                    { 101220, 10, "Школа № 76" },
                    { 51525, 10, "Школа № 75" },
                    { 22095, 10, "Школа № 74" },
                    { 44651, 10, "Школа № 73" },
                    { 50834, 10, "Школа № 72" },
                    { 15394, 10, "Школа № 71" },
                    { 64995, 10, "Школа № 70" },
                    { 112196, 10, "Школа № 69" },
                    { 5262, 10, "Школа № 77" },
                    { 6899, 10, "Школа № 88" },
                    { 63508, 10, "Школа № 89" },
                    { 226983, 10, "Школа № 90" },
                    { 13919, 10, "Школа № 109" },
                    { 167846, 10, "Школа № 108" },
                    { 64631, 10, "Школа № 107" },
                    { 190930, 10, "Школа № 106" },
                    { 39869, 10, "Школа № 105" },
                    { 71098, 10, "Школа № 104" },
                    { 278276, 10, "Школа № 103" },
                    { 10605, 10, "Школа № 102" },
                    { 266298, 10, "Школа № 101" },
                    { 53033, 10, "Школа № 100" },
                    { 15451, 10, "Школа № 99 им. дважды Героя Советского Союза А. Г. Кравченко" },
                    { 50676, 10, "Школа № 98" },
                    { 25755, 10, "Школа № 97" },
                    { 21, 10, "Школа № 96" },
                    { 35455, 10, "Школа № 95" },
                    { 31491, 10, "Школа № 94" },
                    { 7818, 10, "Школа № 93" },
                    { 26335, 10, "Школа № 92" },
                    { 81256, 10, "Школа № 91" },
                    { 205724, 10, "Гидромелиоративный техникум" },
                    { 89401, 10, "Школа № 68" },
                    { 198019, 10, "Гимназия «Исток»" },
                    { 159524, 10, "Гимназия художественного эстетического профиля (ГХЭП)" },
                    { 206905, 10, "Частная интегрированная школа (ЧИШ)" },
                    { 148626, 10, "Центральная школа искусств при Институте искусств" },
                    { 1764305, 10, "Центр иностранных языков ВолгГТУ" },
                    { 1659189, 10, "Центр иностранных языков «Reward»" },
                    { 81680, 10, "Химико-технологический техникум (ВХТТ)" },
                    { 76945, 10, "Физико-математическая школа при ВолГУ" },
                    { 190306, 10, "Училище олимпийского резерва (ВУОР)" },
                    { 97014, 10, "Училище искусств им. Серебрякова" },
                    { 206738, 10, "Школа «Благословение»" },
                    { 1514255, 10, "Училище искусств и культуры при ВГИИК" },
                    { 75619, 10, "Торгово-экономический колледж (ВолТЭК)" },
                    { 63535, 10, "Технологический колледж (ВТК)" },
                    { 127907, 10, "Технический колледж" },
                    { 280714, 10, "Техникум туризма и гостиничного сервиса" },
                    { 244656, 10, "Техникум советской торговли" },
                    { 346278, 10, "Техникум связи" },
                    { 1751461, 10, "Техникум нефтяного и газового машиностроения им. Героя советского Союза Николая Сердюкова" },
                    { 1721770, 10, "Техникум кадровых ресурсов (ВПТКР)" },
                    { 283810, 10, "Училище информационных технологий" },
                    { 107177, 10, "Техникум железнодорожного транспорта (ВТЖТ)" },
                    { 184757, 10, "Школа «Вайда»" },
                    { 39585, 10, "Школа «Гармония-Альфа»" },
                    { 138020, 10, "Экономико-технический колледж (ВЭТК)" },
                    { 290117, 10, "Школа хореографического искусства (ДШХИ)" },
                    { 1754854, 10, "Школа кино и телевидения" },
                    { 1720084, 10, "Школа искусств «Воскресение»" },
                    { 172849, 10, "Школа «Янес»" },
                    { 138232, 10, "Школа «Шанс»" },
                    { 344576, 10, "Школа «Созвездие»" },
                    { 66186, 10, "Школа «Родник»" },
                    { 90775, 10, "Школа «Виктория»" },
                    { 256421, 10, "Школа «Развитие»" },
                    { 72631, 10, "Школа «Ор Авнер»" },
                    { 240508, 10, "Школа «Наука» (при ВолГУ)" },
                    { 63348, 10, "Школа «На семи ветрах»" },
                    { 333931, 10, "Школа «Квалитет»" },
                    { 337510, 10, "Школа «Интенсив» (при ВолГТУ)" },
                    { 71579, 10, "Школа «Интеллектуал»" },
                    { 179023, 10, "Школа «Гармония»" },
                    { 58197, 10, "Школа «Гармония-М»" },
                    { 63063, 10, "Школа «Поколение»" },
                    { 330132, 10, "Строительный техникум (ВСТ)" },
                    { 71898, 10, "Социально-педагогический колледж (ВСПК)" },
                    { 188644, 10, "Сельскохозяйственный лицей (ВГСХЛ)" },
                    { 86214, 10, "Колледж профессиональных технологий, экономики и права (ВГКПТЭиП)" },
                    { 192484, 10, "Колледж при ВолГМУ" },
                    { 256945, 10, "Колледж потребительской кооперации (ВКПК)" },
                    { 74710, 10, "Колледж ВМИИ им. Серебрякова" },
                    { 100130, 10, "Колледж ВГИиК" },
                    { 181445, 10, "Колледж бизнеса (ВКБ)" },
                    { 206594, 10, "Колледж Академии бюджета и казначейства (АБиК) МФ РФ" },
                    { 243624, 10, "Колледж «Экономикс»" },
                    { 154940, 10, "Колледж ресторанного бизнеса" },
                    { 1723489, 10, "Кадетский казачий корпус им. К. И. Недорубова" },
                    { 96390, 10, "Индустриальный техникум (ВИТ)" },
                    { 226731, 10, "Духовное епархиальное училище" },
                    { 1705591, 10, "ДОСААФ" },
                    { 1773920, 10, "Дом науки и Техники" },
                    { 155123, 10, "Детско-юношеский центр" },
                    { 199724, 10, "Детско-юношеская спортивная школа олимпийского резерва" },
                    { 334115, 10, "Детский сад «Золотой ключик»" },
                    { 34367, 10, "Детская академия искусств (ДАИ)" },
                    { 206118, 10, "Институт непрерывного образования ВолГАУ (бывш. ВГСХА)" },
                    { 330424, 10, "Колледж управления и новых технологий (ВКУиНТ) им. Ю. А. Гагарина" },
                    { 153335, 10, "Кооперативный техникум" },
                    { 1773914, 10, "Курсы гражданской обороны Волгограда" },
                    { 110081, 10, "Русско-американская школа (РАШ)" },
                    { 156237, 10, "Промышленно-экономический колледж (ВПЭК)" },
                    { 680454, 10, "Поволжский межрегиональный строительный колледж (ВФ ПГМСК)" },
                    { 465189, 10, "Октябрьский лицей" },
                    { 282090, 10, "Нефтехимический вечерний техникум" },
                    { 1778684, 10, "Национальный университет современных технологий" },
                    { 311731, 10, "Музыкальное педагогическое училище" },
                    { 208717, 10, "Музыкальная школа при ВМИИ им. П. А. Серебрякова" },
                    { 290502, 10, "Музыкальная школа при ВГИИК" },
                    { 343340, 10, "Музыкальная школа «Этос»" },
                    { 61702, 10, "Мужской педагогический профессиональный лицей (ВМПЛ)" },
                    { 1463347, 10, "Морская школа РОСТО" },
                    { 283951, 10, "Механический техникум" },
                    { 177575, 10, "Металлургический техникум" },
                    { 179475, 10, "Медико-экологический техникум (ВМЭТ)" },
                    { 161427, 10, "Машиностроительный колледж" },
                    { 379307, 10, "Лицей-интернат «Лидер» (бывш. ВОСХЛ)" },
                    { 19007, 10, "Лицей при ВолгГТУ" },
                    { 225469, 10, "Лесотехнический колледж" },
                    { 194957, 10, "Гимназия «Эврика»" },
                    { 49074, 10, "Школа № 67" },
                    { 91531, 10, "Школа № 66" },
                    { 341837, 10, "Детский сад № 65" },
                    { 12004, 10, "Гимназия № 10" },
                    { 56493, 10, "Школа № 10" },
                    { 68465, 10, "Музыкальная школа № 9" },
                    { 344968, 10, "Школа-интернат № 9" },
                    { 282134, 10, "Лицей № 9 им. заслуженного учителя школы РФ А. Н. Неверова" },
                    { 43905, 10, "Гимназия № 9" },
                    { 54433, 10, "Школа № 9" },
                    { 1782266, 10, "Школа искусств № 8" },
                    { 313521, 10, "Лицей № 10" },
                    { 169599, 10, "Училище № 8" },
                    { 1486428, 10, "Школа-интернат № 8" },
                    { 257934, 10, "Лицей № 8 «Олимпия»" },
                    { 28598, 10, "Гимназия № 8" },
                    { 235741, 10, "Школа № 8" },
                    { 189707, 10, "Школа искусств № 7" },
                    { 68571, 10, "Музыкальная школа № 7" },
                    { 9987, 10, "Школа-интернат № 7" },
                    { 51883, 10, "Лицей № 7" },
                    { 113707, 10, "Музыкальная школа № 8" },
                    { 312656, 10, "Гимназия № 7" },
                    { 163021, 10, "Музыкальная школа № 10" },
                    { 230698, 10, "Профессионально-техническое училище № 10" },
                    { 55882, 10, "Гимназия № 15 (шк. 52)" },
                    { 34861, 10, "Школа № 15" },
                    { 71804, 10, "Музыкальная школа № 14" },
                    { 15942, 10, "Гимназия № 14" },
                    { 123560, 10, "Школа № 14" },
                    { 204311, 10, "Музыкальная школа № 13" },
                    { 4105, 10, "Гимназия № 13" },
                    { 62142, 10, "Школа № 13" },
                    { 70431, 10, "Детско-юношеская спортивная школа № 10" },
                    { 296174, 10, "Школа искусств № 12" },
                    { 12166, 10, "Гимназия № 12" },
                    { 113814, 10, "Школа № 12" },
                    { 715134, 10, "Профессиональное училище № 11" },
                    { 338939, 10, "Школа искусств № 11" },
                    { 58106, 10, "Музыкальная школа № 11" },
                    { 16916, 10, "Лицей № 11 (бывш. Школа № 21)" },
                    { 9397, 10, "Гимназия № 11" },
                    { 59135, 10, "Школа № 11" },
                    { 1127449, 10, "Профессионально-техническое училище № 12" },
                    { 338612, 10, "Школа № 7" },
                    { 1675245, 10, "Профессиональное училище № 6" },
                    { 201362, 10, "Школа искусств № 6" },
                    { 104031, 10, "Школа искусств № 2" },
                    { 80021, 10, "Педагогический колледж № 2" },
                    { 226733, 10, "Художественная школа № 2" },
                    { 163906, 10, "Музыкальная школа № 2" },
                    { 156402, 10, "Школа-интернат № 2" },
                    { 171060, 10, "Лицей № 2" },
                    { 288791, 10, "Гимназия № 2 им. Героя Советского Союза Н. П. Белоусова" },
                    { 235093, 10, "Школа № 2" },
                    { 45430, 10, "Школа № 3" },
                    { 49828, 10, "Школа искусств № 1" },
                    { 123262, 10, "Педагогический колледж № 1" },
                    { 41375, 10, "Художественная школа № 1" },
                    { 250713, 10, "Музыкальная школа № 1" },
                    { 169137, 10, "Школа-интернат № 1" },
                    { 55159, 10, "Лицей № 1" },
                    { 295408, 10, "Гимназия № 1" },
                    { 110080, 10, "Школа «Гармония-1»" },
                    { 742815, 10, "Царицынская школа № 1" },
                    { 263520, 10, "Медицинский колледж (бывш. Медицинский колледж № 1, № 2, № 6, ВОМК)" },
                    { 55870, 10, "Гимназия № 3" },
                    { 240633, 10, "Лицей № 3" },
                    { 236939, 10, "Музыкальная школа № 3" },
                    { 207496, 10, "Музыкальная школа № 6" },
                    { 87762, 10, "Школа-интернат № 6" },
                    { 315631, 10, "Лицей № 6" },
                    { 51728, 10, "Гимназия № 6" },
                    { 47067, 10, "Школа № 6" },
                    { 239803, 10, "Школа искусств № 5" },
                    { 69497, 10, "Художественная школа № 5" },
                    { 21056, 10, "Музыкальная школа № 5" },
                    { 87761, 10, "Вечерняя школа № 5" },
                    { 258608, 10, "Лицей № 5 им. Ю. А. Гагарина" },
                    { 43324, 10, "Гимназия № 5" },
                    { 52647, 10, "Школа № 5" },
                    { 259020, 10, "Школа искусств № 4" },
                    { 74464, 10, "Детско-юношеская спортивная школа № 4" },
                    { 328699, 10, "Лицей № 4" },
                    { 274757, 10, "Гимназия № 4" },
                    { 201903, 10, "Школа № 4" },
                    { 77693, 10, "Школа искусств № 3" },
                    { 218749, 10, "Художественная школа № 3" },
                    { 22082, 10, "Музыкальная школа № 15" },
                    { 11121, 10, "Школа № 16" },
                    { 18708, 10, "Гимназия № 16 (бывш. Школа № 45)" },
                    { 1768668, 10, "Вечерняя школа № 16" },
                    { 185637, 10, "Школа № 46 им. Гвардии Генерал-майора В. А. Глазкова" },
                    { 1488123, 10, "Детский сад № 45 «Ромашка»" },
                    { 18694, 10, "Школа № 44" },
                    { 23799, 10, "Школа № 43" },
                    { 161392, 10, "Школа № 42" },
                    { 218630, 10, "Профессионально-техническое училище № 41" },
                    { 49373, 10, "Школа № 41" },
                    { 21250, 10, "Школа № 40" },
                    { 113235, 10, "Профессиональное училище № 47" },
                    { 1464224, 10, "Техникум железнодорожного транспорта и коммуникаций (бывш. Профессиональное училище № 39)" },
                    { 319815, 10, "Школа искусств № 38" },
                    { 328431, 10, "Училище № 38" },
                    { 47930, 10, "Школа № 38" },
                    { 158530, 10, "Профессионально-техническое училище № 37" },
                    { 44743, 10, "Школа № 37" },
                    { 1563752, 10, "Профессиональное училище № 36" },
                    { 40565, 10, "Школа № 36" },
                    { 24044, 10, "Школа № 35" },
                    { 169462, 10, "Школа № 39" },
                    { 11782, 10, "Школа № 48" },
                    { 46439, 10, "Школа № 49" },
                    { 5216, 10, "Школа № 50" },
                    { 17543, 10, "Школа № 65" },
                    { 52685, 10, "Школа № 64" },
                    { 155036, 10, "Школа № 63" },
                    { 313108, 10, "Профессиональное училище № 62" },
                    { 51687, 10, "Школа № 62" },
                    { 24545, 10, "Школа № 61" },
                    { 242392, 10, "Кулинарное училище № 60" },
                    { 67095, 10, "Школа № 60" },
                    { 87940, 10, "Профессиональный лицей № 59" },
                    { 68624, 10, "Школа № 59" },
                    { 96357, 10, "Школа № 58" },
                    { 6746, 10, "Школа № 57" },
                    { 718, 10, "Школа № 56" },
                    { 86187, 10, "Школа № 55 (Хабаровская ул.)" },
                    { 1777971, 10, "Школа № 55 «Долина знаний»" },
                    { 188237, 10, "Профессионально-техническое училище № 54" },
                    { 42, 10, "Школа № 54" },
                    { 168801, 10, "Школа № 53" },
                    { 56096, 10, "Школа № 51 им. Героя Советского Союза А. М. Числова" },
                    { 204595, 10, "Профессионально-технический колледж (ВПТК, бывш. ПУ 34)" },
                    { 163448, 10, "Энергетический колледж (ВЭК)" },
                    { 24800, 10, "Школа № 34" },
                    { 197107, 10, "Школа № 33" },
                    { 326436, 10, "Гимназия № 24" },
                    { 3088, 10, "Школа № 24" },
                    { 47238, 10, "Школа № 23" },
                    { 256448, 10, "Профессионально-техническое училище № 22" },
                    { 98700, 10, "Школа № 22" },
                    { 1292456, 10, "Профессионально-техническое училище № 21" },
                    { 1745268, 10, "Детско-юношеская спортивная школа № 20" },
                    { 2357, 10, "Школа № 20" },
                    { 97827, 10, "Школа № 25" },
                    { 254567, 10, "Профессионально-техническое училище № 19" },
                    { 169872, 10, "Детско-юношеская спортивная школа № 18" },
                    { 30980, 10, "Школа № 18" },
                    { 218488, 10, "Училище № 17" },
                    { 1716657, 10, "Вечерняя школа № 17" },
                    { 1774617, 10, "Гимназия № 17" },
                    { 54303, 10, "Школа № 17" },
                    { 219664, 10, "Профессионально-техническое училище № 16" },
                    { 259351, 10, "Детско-юношеская спортивная школа № 16" },
                    { 5404, 10, "Школа № 19" },
                    { 243010, 10, "Профессионально-техническое училище № 25" },
                    { 314334, 10, "Школа искусств № 25" },
                    { 83348, 10, "Школа № 26" },
                    { 696715, 10, "Профессионально-техническое училище № 32" },
                    { 81901, 10, "Лицей № 32" },
                    { 1678593, 10, "Школа № 32" },
                    { 974391, 10, "Профессиональное училище № 31" },
                    { 20123, 10, "Школа № 31" },
                    { 277382, 10, "Школа искусств № 30" },
                    { 208375, 10, "Школа № 30" },
                    { 218266, 10, "Училище № 29" },
                    { 22659, 10, "Школа № 29" },
                    { 296002, 10, "Школа искусств № 28" },
                    { 90801, 10, "Техникум водного транспорта им. адмирала флота Н. Д. Сергеева (бывш. ПУ № 28)" },
                    { 205448, 10, "Лицей № 28" },
                    { 44258, 10, "Школа № 28" },
                    { 262496, 10, "Профессиональное училище № 27" },
                    { 210514, 10, "Гимназия № 27" },
                    { 20260, 10, "Школа № 27" },
                    { 1727803, 10, "Профессиональное училище № 26" },
                    { 334764, 10, "Школа искусств № 26" },
                    { 1768667, 10, "Вечерняя школа № 26" },
                    { 184695, 10, "Профессиональное училище № 33" },
                    { 99628, 10, "Юридический лицей" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 718);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 2357);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 3088);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 4105);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5216);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5262);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 5404);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6746);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 6899);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 7818);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9397);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 9987);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10605);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 10968);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11121);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 11782);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12004);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 12166);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 13919);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15394);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15451);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15550);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15929);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 15942);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 16916);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17543);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17929);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 17970);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18182);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18694);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 18708);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19007);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 19603);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20260);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 20963);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21056);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21200);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 21250);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22082);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22095);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 22659);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 23799);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24044);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24545);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 24800);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 25755);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 26335);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28199);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 28598);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 29143);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 30126);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 30980);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31170);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 31491);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34367);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 34861);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 35455);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 39407);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 39585);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 39869);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 40565);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 41375);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43324);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43828);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 43905);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44258);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44651);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 44743);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45430);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 45447);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 46439);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 46538);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 47067);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 47238);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 47930);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 48400);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49074);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49373);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 49828);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 50228);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 50676);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 50834);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51525);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51687);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51728);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51883);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 51946);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 52647);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 52685);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 52686);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 53033);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 53649);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 54299);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 54303);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 54433);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55159);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55870);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 55882);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 56096);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 56493);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 58106);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 58197);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 59135);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 61702);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 62142);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63063);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63348);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63508);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 63535);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64631);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64632);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 64995);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 66186);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 67095);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68465);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68571);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 68624);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 69497);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 70431);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71098);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71579);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71804);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 71898);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 72631);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 73799);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 74464);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 74710);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 75619);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 75709);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 75793);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 76208);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 76945);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 77693);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 80021);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81256);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81680);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 81901);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 82454);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 83348);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 86187);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 86214);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 86669);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 87761);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 87762);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 87940);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 89401);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 90775);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 90801);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 91531);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 93662);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 96357);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 96390);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97014);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 97827);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98699);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 98700);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 99209);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 99628);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 100130);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 101220);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 104031);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 107177);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 110080);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 110081);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 112196);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113235);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113707);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 113814);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 114575);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 114956);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 123262);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 123560);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 127907);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 138020);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 138232);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 148626);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 153335);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 154940);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 155036);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 155123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 156237);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 156402);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 158530);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 159524);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 161392);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 161427);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163021);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163448);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 163906);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 167846);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 168801);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169137);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169462);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169599);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 169872);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 171060);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172273);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 172849);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 177575);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179023);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179475);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 179715);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 181445);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 184695);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 184757);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 185637);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 188237);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 188644);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 189707);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 190306);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 190930);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 192484);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 194957);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 197107);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 198019);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 199724);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 201362);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 201903);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 204311);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 204595);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 205448);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 205724);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206118);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206594);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206738);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 206905);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 207063);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 207496);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 208375);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 208717);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 210514);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 213053);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 216029);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 218266);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 218488);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 218630);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 218749);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 219664);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 224706);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 225469);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 226731);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 226733);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 226983);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 230698);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 235093);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 235741);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 236939);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 239803);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 240508);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 240633);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 242392);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 243010);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 243624);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 244656);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 246707);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 250713);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 254567);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 256421);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 256448);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 256945);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 257934);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 258608);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 259020);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 259351);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 260664);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 262496);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 263520);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 266298);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 274757);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 277019);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 277382);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 278276);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 280714);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 282090);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 282134);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 283810);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 283951);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 288070);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 288791);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 290117);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 290502);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 295408);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 296002);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 296174);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 311731);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 312656);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 313108);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 313521);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 314334);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 315631);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 319815);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 326436);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 328247);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 328431);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 328699);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 330132);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 330424);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 333931);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 334115);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 334764);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 337510);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 338612);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 338939);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 341837);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 341850);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 343340);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 344233);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 344576);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 344968);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 346278);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 379307);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 465189);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 680454);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 694071);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 696715);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 715134);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 742815);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 974391);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1127449);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1292456);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1463347);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1464224);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1486428);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1488123);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1514255);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1563752);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1659189);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1675245);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1678593);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1705591);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1716657);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1720084);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1721770);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1723489);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1723809);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1727803);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1745268);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1751461);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1754854);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1764305);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1765816);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1768667);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1768668);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1773914);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1773920);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1774617);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1775895);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1776659);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1777971);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1778684);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1782255);

            migrationBuilder.DeleteData(
                table: "Schools",
                keyColumn: "Id",
                keyValue: 1782266);
        }
    }
}
