namespace Model
{
    /// <summary>
    /// Класс библиотечного издания.
    /// </summary>
    public abstract class EditionBase
    {
        /// <summary>
        /// Имя издания.
        /// </summary>
        private string _name;

        /// <summary>
        /// Место публикации издания.
        /// </summary>
        private string _place;

        /// <summary>
        /// Год публикации издания.
        /// </summary>
        private int _year;

        /// <summary>
        /// Кол-во страниц в издении.
        /// </summary>
        private int _pageCount;

        /// <summary>
        /// Минимальный год публикации издания
        /// </summary>
        protected const int minYear = 1;


        /// <summary>
        /// Имя издания.
        /// </summary>
        public string Name
        {
            get => _name;
            set
            {
                _name = value;
            }
        }

        /// <summary>
        /// Место публикации издания.
        /// </summary>
        public string Place
        {
            get => _place;
            set
            {
                _place = value;
            }
        }

        /// <summary>
        /// Год публикации издания.
        /// </summary>
        public int Year
        {
            get => _year;
            set
            {
                CheckLimitsYear(value);
                _year = value;
            }
        }

        /// <summary>
        /// Кол-во страниц в издaнии.
        /// </summary>
        public int PageCount
        {
            get => _pageCount;
            set
            {
                _pageCount = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        protected EditionBase(string name, string place, int year, int pageCount)
        {
            Name = name;
            Place = place;
            Year = year;
            PageCount = pageCount;
        }


        /// <summary>
        /// Конструктор по умолчания
        /// </summary>
        protected EditionBase()
        { }

        /// <summary>
        /// Проверка года публикации издания
        /// </summary>
        /// <param name="value">Год публикации.</param>
        /// <exception cref="ArgumentException">Неверный диапазон года
        /// публикации </exception>
        private void CheckLimitsYear(int value)
        {
            if (value > DateTime.Now.Year || value < minYear)
            {
                throw new ArgumentException($"Значение года публикации" +
                    $"должно быть в диапазоне " +
                    $"[{minYear} - {DateTime.Now.Year}]");
            }
        }

        /// <summary>
        /// Метод, возвращающий информацию об издании
        /// </summary>
        /// <returns>Информация об издании</returns>
        public abstract string GetInfo();

    }
}
