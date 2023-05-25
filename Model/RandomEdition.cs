namespace Model
{
    /// <summary>
    /// Class to get random parameters for calculating motion coordinate.
    /// </summary>
    public class RandomEditionFactory : EditionFactoryBase
    {
        /// <summary>
        /// Get the instance of a certain motion.
        /// </summary>
        /// <param name="editionType">Motion type.</param>
        /// <returns>An instance of a certain motion.</returns>
        /// <exception cref="ArgumentException">Only designated motion
        /// types.</exception>
        public override EditionBase GetInstance(EditionType editionType)
        {
            const int minYear = -1000;
            const int maxYear = 2023;
            const int minPage = -1000;
            const int maxPage = 2023;

            var tmpYear = GetRandomValue(minYear, maxYear);
            var tmpPageCount = GetRandomValue(minPage, maxPage);

            string[] authors =
            {
                "Кейдж Д.","Блэйд С.","Лю Кан","Прохоров А.В.",
                "Кац И.М.", "Конухов А.В.", "Соловьёв М.Б."
            };

            string[] names =
            {
                "169 Причин посутипить на СО", "21 миф о СО ЕЭС",
                "Высокие зарплаты в СО - правда или ложь?",
                "Лабораторные по ООП своими руками",
                "Жаренные зеленые помидоры", "История СО ЕЭС",
                "Иновации","Применение ИНС"
            };

            string[] typesBook =
            {
                "учебное пособие","энциклопедия","","эпическая поэма",
                "роман", "справочник", "биография"
            };

            string[] places =
            {
                "Москва","Томск","Париж","Мюнхен"
            };

            string[] publishers =
            {
                "ТПУ","ТУСУР","МГУ","Феникс",
                "Ювента", "ИНФРА-М"
            };



            string[] namesConference =
            {
                "Международная конференция",
                "Конференция им. Ясникова"
            };


            switch (editionType)
            {
                case (EditionType.Book):
                    {
                        var tmpAuthor = GetRandomString(authors);
                        var tmpName = GetRandomString(names);
                        var tmpType = GetRandomString(typesBook);
                        var tmpPlace = GetRandomString(places);
                        var tmpPublisher = GetRandomString(publishers);

                        return new Book
                            (tmpAuthor, tmpName, tmpType, tmpPlace,
                            tmpPublisher, tmpYear, tmpPageCount);
                    }

                case (EditionType.Collection):
                    {
                        var tmpConference = GetRandomString(namesConference);
                        var tmpName = GetRandomString(names);
                        var tmpPlace = GetRandomString(places);
                        var tmpPublisher = GetRandomString(publishers);

                        return new Collection
                            (tmpName, tmpConference, tmpPlace,
                            tmpPublisher, tmpYear, tmpPageCount);
                    }

                case (EditionType.Dissertation):
                    {
                        var tmpAuthor = GetRandomString(authors);
                        var tmpName = GetRandomString(names);
                        var tmpType = GetRandomString(typesBook);
                        var tmpPlace = GetRandomString(places);
                        var tmpPublisher = GetRandomString(publishers);

                        return new Dissertation
                            (tmpAuthor, tmpName, tmpType, tmpPlace,
                            tmpPublisher, tmpYear, tmpPageCount);
                    }

                default:
                    throw new ArgumentException
                        ("Enter only designated motion types.");
            }
        }
    }
}
