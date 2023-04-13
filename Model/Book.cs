namespace Model
{
    /// <summary>
    /// Класс описывает книгу.
    /// </summary>
    public class Book : EditionBase
    {
        /// <summary>
        /// Автор книги.
        /// </summary>
        private string _author;

        /// <summary>
        /// Издатель книги.
        /// </summary>
        private string _publisher;

        /// <summary>
        /// Тип книги.
        /// </summary>
        private string _type;

        /// <summary>
        /// Автор.
        /// </summary>
        public string Author
        {
            get => _author;
            set
            {
                CheckEmpty(value);
                CheckLanguage(value);
                _author = value;
            }
        }

        /// <summary>
        /// Издатель книги.
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
        /// Тип книги.
        /// </summary>
        public string Type
        {
            get => _type;
            set
            {
                CheckLanguage(value);
                _type = value;
            }
        }

        /// <summary>
        /// Конструктор
        /// </summary>
        /// <param name="author">Автор книги.</param>
        /// <param name="name">Назименование книги.</param>
        /// <param name="type">Тип книги.</param>
        /// <param name="place">Место публикации Книги.</param>
        /// <param name="publisher">Издатель.</param>
        /// <param name="year">Год публикации книги.</param>
        /// <param name="pageCount">Кол-во страниц.</param>
        public Book(string author, string name, string type, string place,
            string publisher, int year, int pageCount)
            : base(name, place, year, pageCount)
        {
            Author = author;
            Type = type;
            Publisher = publisher;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        public Book()
        { }

        /// <summary>
        /// Метод, возращает информацию о книге.
        /// </summary>
        public override string GetInfo()
        {
            string type = string.IsNullOrEmpty(Type)
                ? ""
                : ": " + Type;
            return $"{Author} {Name}{type}. - {Place}: Изд-во {Publisher}" +
                $", {Year}. - {PageCount} с.";
        }
    }
}
