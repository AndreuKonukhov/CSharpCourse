namespace Model
{
    /// <summary>
    /// Класс описывает сборник.
    /// </summary>
    public class Collection : EditionBase
    {
        /// <summary>
        /// Наименование конференции.
        /// </summary>
        private string _nameOfConference;

        /// <summary>
        /// Издатель сборника.
        /// </summary>
        private string _publisher;



        /// <summary>
        /// Наименование конференции.
        /// </summary>
        public string NameOfConference
        {
            get => _nameOfConference;
            set
            {
                CheckEmpty(value);
                _nameOfConference = value;
            }
        }

        /// <summary>
        /// Издатель сборника.
        /// </summary>
        public string Publisher
        {
            get => _publisher;
            set
            {
                CheckEmpty(value);
                _publisher = value;
            }
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Наименование сборника.</param>
        /// <param name="nameOfConference">Наименование конференции.</param>
        /// <param name="place">Место публикации.</param>
        /// <param name="publisher">Издатель сборника.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="pageCount">Кол-во страниц.</param>
        public Collection(string name, string nameOfConference, string place,
            string publisher, int year, int pageCount)
            : base(name, place, year, pageCount)
        {
            NameOfConference = nameOfConference;
            Publisher = publisher;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Collection()
        {
        }

        /// <summary>
        /// Метод, возращает информацию о журнале.
        /// </summary>
        public override string GetInfo()
        {
            return $"{Name}: {NameOfConference}. - {Place}: {Publisher}," +
            $" {Year}. - {PageCount} с.";
        }

    }
}
