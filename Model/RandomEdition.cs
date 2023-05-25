namespace Model
{
    /// <summary>
    /// Класс для получения случайных изданий.
    /// </summary>
    public class RandomEdition : EditionFactoryBase
    {
        /// <summary>
        /// Метод для получения случайного экземпляра издания.
        /// </summary>
        /// <param name="editionType">Тип издания.</param>
        /// <returns>Экземпляр случайного издания.</returns>
        /// <exception cref="ArgumentException">Типа издания
        /// не существует.</exception>
        public override EditionBase GetInstance(EditionType editionType)
        {
            const int minYear = -1000;
            const int maxYear = 2023;
            const int maxPage = 75362;

            var tmpYear = GetRandomValue(minYear, maxYear);
            var tmpPageCount = GetRandomValue(1, maxPage);

            string[] authors =
            {
                "Кейдж Д.","Блэйд С.","Лю Кан","Прохоров А.В.",
                "Кац И.М.", "Конухов А.В.", "Соловьёв М.Б."
            };

            string[] names =
            {
                "169 Причин посутипить на программу СО ЕЭС",
                "21 миф о лабах по ООП",
                "Способы повышения стрессоустойчивости при работе с Git",
                "Как не лишиться рассудка из за буквы 'Ё'",
                "Лабораторные по ООП в домашних условиях",
                "Жаренные зеленые помидоры", "История СО ЕЭС",
                "Иновации","Применение ИНС в задаче опредения МДП"
            };

            string[] places =
            {
                "Москва","Томск","Париж","Мюнхен"
            };

            string[] publishers =
            {
                "ТПУ","ТУСУР","МГУ","Феникс",
                "Ювента", "ИНФРА"
            };

            switch (editionType)
            {
                case (EditionType.Book):
                    {
                        string[] typesBook =
                        {
                            "учебное пособие","энциклопедия","эпическая поэма",
                            "роман", "справочник", "биография"
                        };

                        var tmpAuthor = GetRandomString(authors);
                        var tmpName = GetRandomString(names);
                        var tmpType = GetRandomString(typesBook);
                        var tmpPlace = GetRandomString(places);
                        var tmpPublisher = GetRandomString(publishers);

                        Console.WriteLine("1");
                        return new Book
                            (tmpAuthor, tmpName, tmpType, tmpPlace,
                            tmpPublisher, tmpYear, tmpPageCount);
                    }

                case (EditionType.Collection):
                    {
                        string[] namesConference =
                        {
                            "Международная конференция",
                            "Конференция им. Ясникова"
                        };

                        var tmpConference = GetRandomString(namesConference);
                        var tmpName = GetRandomString(names);
                        var tmpPlace = GetRandomString(places);
                        var tmpPublisher = GetRandomString(publishers);
                        Console.WriteLine("2");
                        return new Collection
                            (tmpName, tmpConference, tmpPlace,
                            tmpPublisher, tmpYear, tmpPageCount);
                    }

                case (EditionType.Dissertation):
                    {
                        string[] typesDissertation =
                        {
                            "кандидатская диссертация",
                            "магистерская диссертация",
                            "докторская диссертация"
                        };

                        string[] specializations =
                        {
                            "специальность 13.00.01 'Общая педагогика'",
                            "специальность 13.04.02 'Электроэнергетика и" +
                            " электротехника'",
                            "специальность 9.04.03 Прикладная информатика"
                        };

                        string[] universites =
                        {
                            "ТПУ","ТУСУР","ТГУ","СФУ",
                        };

                        var tmpAuthor = GetRandomString(authors);
                        var tmpName = GetRandomString(names);
                        var tmpType = GetRandomString(typesDissertation);
                        var tmpSpec = GetRandomString(specializations);
                        var tmpPlace = GetRandomString(places);
                        var tmpUniversity = GetRandomString(universites);
                        Console.WriteLine(3);
                        return new Dissertation
                            (tmpAuthor, tmpName, tmpType, tmpSpec, tmpPlace,
                            tmpUniversity, tmpYear, tmpPageCount);
                    }

                case (EditionType.Magazine):
                    {
                        string[] typesMagazine =
                        {
                            "Научный журнал",
                            "Общеобразовательный журнал",
                            "Литературно-художественный журнал"
                        };

                        var tmpName = GetRandomString(names);
                        var tmpType = GetRandomString(typesMagazine);
                        var tmpPublisher = GetRandomString(publishers);
                        var tmpPlace = GetRandomString(places);
                        var tmpEditor = GetRandomString(authors);
                        Console.WriteLine(4);
                        return new Magazine
                            (tmpName, tmpType, tmpPublisher, tmpPlace,
                            tmpEditor, tmpYear, tmpPageCount);
                    }

                default:
                    throw new ArgumentException
                        ("Неизвестный тип издания.");
            }
        }
    }
}
