using System.ComponentModel;
using System.Text.RegularExpressions;
using System.Xml.Serialization;

namespace Model
{
    /// <summary>
    /// Класс библиотечного издания.
    /// </summary>
    [XmlInclude(typeof(Book))]
    [XmlInclude(typeof(Collection))]
    [XmlInclude(typeof(Dissertation))]
    [XmlInclude(typeof(Magazine))]
    public abstract class EditionBase
    {
        /// <summary>
        /// Наименование издания.
        /// </summary>
        private string _name;

        /// <summary>
        /// Место публикации.
        /// </summary>
        private string _place;

        /// <summary>
        /// Год публикации.
        /// </summary>
        private int _year;

        /// <summary>
        /// Кол-во страниц в издании.
        /// </summary>
        private int _pageCount;

        /// <summary>
        /// Минимальный год публикации издания.
        /// </summary>
        protected const int minYear = -1378;

        /// <summary>
        /// Наименование издания.
        /// </summary>
        [Browsable(false)]
        public string Name
        {
            get => _name;
            set
            {
                CheckEmpty(value);
                _name = value;
            }
        }

        /// <summary>
        /// Место публикации издания.
        /// </summary>
        [Browsable(false)]
        public string Place
        {
            get => _place;
            set
            {
                CheckEmpty(value);
                _place = value;
            }
        }

        /// <summary>
        /// Год публикации издания.
        /// </summary>
        [Browsable(false)]
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
        [Browsable(false)]
        public int PageCount
        {
            get => _pageCount;
            set
            {
                _pageCount = value;
            }
        }

        /// <summary>
        /// Тип библиотечного издания
        /// </summary>
        [DisplayName("Тип издания")]
        public abstract string EditionType { get; }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        protected EditionBase(string name, string place, int year, int pageCount)
        {
            Name = name;
            Place = place;
            Year = year;
            PageCount = pageCount;
        }

        /// <summary>
        /// Конструктор по умолчания.
        /// </summary>
        protected EditionBase()
        { }

        /// <summary>
        /// Проверка года публикации издания.
        /// </summary>
        /// <param name="value">Год публикации.</param>
        /// <exception cref="ArgumentException">Неверный диапазон года
        /// публикации </exception>
        private void CheckLimitsYear(int value)
        {
            if (value > DateTime.Now.Year || value < minYear)
            {
                throw new ArgumentException($"Значение года публикации " +
                    $"должно находится в диапазоне " +
                    $"[{minYear} - {DateTime.Now.Year}]");
            }
        }

        /// <summary>
        /// Метод, проверяющий на Null и Empty.
        /// </summary>
        /// <param name="value">Строка для проверки</param>
        /// <returns>Если проверка пройдена,
        /// то возвращается входное значение.</returns>
        /// <exception cref="ArgumentException">
        /// Строка не должна быть пустой.</exception>
        protected void CheckEmpty(string value)
        {
            if (string.IsNullOrEmpty(value))
            {
                throw new ArgumentException("Строка не должна быть пустой!");
            }
        }

        /// <summary>
        /// Метод проверяет значение на язык.
        /// </summary>
        /// <param name="value">Строка для проверки</param>
        /// <returns>Если проверка пройдена,
        /// то возвращается входное значение.</returns>
        /// <exception cref="Exception"></exception>
        protected void CheckLanguage(string value)
        {
            var regex = new Regex(@"^([-'.,a-zA-Z\s]|[-'ё.,а-яА-Я\s])*$");
            if (!regex.IsMatch(value))
            {
                throw new Exception("Строка должна быть только на " +
                                    "Английском или Русском языке");
            }
        }

        /// <summary>
        /// Метод, возвращающий информацию об издании
        /// </summary>
        /// <returns>Информация об издании</returns>
        [DisplayName("Информация об издании")]
        public abstract string GetInfo { get; }
    }
}
