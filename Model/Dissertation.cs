namespace Model
{
    /// <summary>
    /// Класс, описывающий диссертацию
    /// </summary>
    public class Dissertation : EditionBase
    {
        /// <summary>
        /// Автор.
        /// </summary>
        private string _author;

        /// <summary>
        /// Специализация исследования.
        /// </summary>
        private string _specialization;

        /// <summary>
        /// Университет.
        /// </summary>
        private string _university;

        /// <summary>
        /// Тип.
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
        /// Специализация исследования.
        /// </summary>
        public string Specialization
        {
            get => _specialization;
            set
            {
                CheckEmpty(value);
                _specialization = value;
            }
        }

        /// <summary>
        /// Тип.
        /// </summary>
        public string Type
        {
            get => _type;
            set
            {
                CheckEmpty(value);
                CheckLanguage(value);
                _type = value;
            }

        }

        /// <summary>
        /// Университет.
        /// </summary>
        public string University
        {
            get => _university;
            set
            {
                CheckLanguage(value);
                _university = value;
            }
        }

        /// <summary>
        /// Тип издания.
        /// </summary>
        public override string EditionType
        {
            get
            {
                return "Диссертация";
            }
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="author">Автор.</param>
        /// <param name="name">Название.</param>
        /// <param name="type">Тип.</param>
        /// <param name="specialization">Специализация исследования.</param>
        /// <param name="place">Место публикации издания.</param>
        /// <param name="university">Университет.</param>
        /// <param name="year">Год публикации издания.</param>
        /// <param name="pageCount">Количество страниц.</param>
        public Dissertation(string author, string name, string type,
            string specialization, string place,
            string university, int year, int pageCount)
            : base(name, place, year, pageCount)
        {
            Author = author;
            Type = type;
            Specialization = specialization;
            University = university;
        }


        /// <summary>
        /// Конструктор по умолчанию
        /// </summary>
        public Dissertation()
        {
        }

        /// <summary>
        /// Метод, возращает информацию о диссертации.
        /// </summary>
        /// <returns>Информация об издании</returns>
        public override string GetInfo =>
            $"{Author}. {Name}: {Specialization}: {Type} ;" +
            $" {University}. - {Place}" +
            $", {Year}. - {PageCount} с.";

    }
}
