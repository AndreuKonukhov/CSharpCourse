namespace Model
{
    /// <summary>
    /// Thesis
    /// </summary>
    public class Dissertation : EditionBase
    {
        /// <summary>
        /// Главный автор
        /// </summary>
        private string _author;

        /// <summary>
        /// Главный автор
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
        /// Specialization
        /// </summary>
        private string _specialization;

        /// <summary>
        /// Specialization
        /// </summary>
        public string Specialization
        {
            get => _specialization;
            set => _specialization = CheckEmpty(value);
        }

        /// <summary>
        /// University
        /// </summary>
        private string _university;

        /// <summary>
        /// Type
        /// </summary>
        private string _type;

        /// <summary>
        /// Type
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
        /// University
        /// </summary>
        public string University
        {
            get => _university;
            set => _university = CheckEmpty(value);
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="author">Автор</param>
        /// <param name="name">Название</param>
        /// <param name="type">Тип</param>
        /// <param name="specialization">Специализация исследования</param>
        /// <param name="place">Место издания</param>
        /// <param name="university">Университет</param>
        /// <param name="year">Год издания</param>
        /// <param name="pageLimits">Количество страниц</param>
        public Dissertation(string author, string name, string type, string specialization, string place,
            string university, int year, int pageCount)
            : base(name, place, year, pageCount)
        {
            Author = author;
            Type = type;
            Specialization = specialization;
            University = university;
        }

        /// <summary>
        /// Конструктор класса для сериализации
        /// </summary>
        public Dissertation()
        {
        }

        /// <summary>
        /// Info
        /// </summary>
        public override string Info
        {
            get
            {
                return $"{Author}. {Name}: {Specialization}: {Type} ; {University}. - {Place}" +
                $", {Year}. - {PageCount} с.";
            }
        }
    }
}
