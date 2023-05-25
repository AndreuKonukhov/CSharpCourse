using System;

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
        /// Метод возвращающий случайного автора издания.
        /// </summary>
        /// <returns>ФИО автора издания.</returns>
        public string GetRandomString(string[] author)
        {
            var random = new Random();
            string randomAuthor = author[random.Next(author.Length)];
            return randomAuthor;
        }

        public string GetRandomAuthor()
        {
            var random = new Random();
            string[] author =
            {
                "Прохоров А.В.", "Кац И.М.", "Конухов А.В.", "Соловьёв М.Б."
            };
            string randomAuthor = author[random.Next(author.Length)];
            return randomAuthor;
        }


        /// <summary>
        /// Get random value.
        /// </summary>
        /// <param name="maxValue">Max value.</param>
        /// <param name="onlyPositive">Input True to get positive value
        /// for sure.</param>
        /// <returns>A positive/negative value.</returns>
        public double GetRandomValue(int maxValue, bool onlyPositive)
        {
            var rnd = new Random();
            var plusMinus = rnd.Next(2);
            var tmpValue = plusMinus == 0
                ? Math.Round(rnd.NextDouble() * maxValue, 2)
                : -Math.Round(rnd.NextDouble() * maxValue, 2);

            if (onlyPositive)
            {
                tmpValue = Math.Abs(tmpValue);
            }

            return tmpValue;
        }
    }
}
