namespace Model
{
    /// <summary>
    /// Базовый класс EditionFactoryBase.
    /// </summary>
    public abstract class EditionFactoryBase
    {
        /// <summary>
        /// Получение экземпляра издания.
        /// </summary>
        /// <param name="editionType">Тип библиотечного издания.</param>
        /// <returns>Экземпляр класса EditionBase.</returns>
        public abstract EditionBase GetInstance(EditionType editionType);

        /// <summary>
        /// Метод возвращающий случайную строку из массива.
        /// </summary>
        /// <param name="author">Массив из строк</param>
        /// <returns>Случайная строка.</returns>
        public string GetRandomString(string[] author)
        {
            var random = new Random();
            string randomAuthor = author[random.Next(author.Length)];
            return randomAuthor;
        }

        /// <summary>
        /// Метод возвращает случайное число в указанном диапазоне.
        /// </summary>
        /// <param name="minValue">Минимальное число.</param>
        /// <param name="maxValue">Максимальное число</param>
        /// <returns>Случайное число.</returns>
        public int GetRandomValue(int minValue, int maxValue)
        {
            var rnd = new Random();
            var tmpValue = rnd.Next(minValue, maxValue);
            return tmpValue;
        }
    }
}
