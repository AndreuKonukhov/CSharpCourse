namespace Model
{
    /// <summary>
    /// Collection
    /// </summary>
    public class Collection : EditionBase
    {
        /// <summary>
        /// Наименование конференции.
        /// </summary>
        private string _mainEditor;

        /// <summary>
        /// Издатель сборника.
        /// </summary>
        private string _publisher;



        /// <summary>
        /// Наименование конференции.
        /// </summary>
        public string MainEditor
        {
            get => _mainEditor;
            set => _mainEditor = value;
        }

        /// <summary>
        /// Издатель сборника.
        /// </summary>
        public string Publisher
        {
            get => _publisher;
            set => _publisher = value;
        }

        /// <summary>
        /// Конструктор класса.
        /// </summary>
        /// <param name="name">Наименование.</param>
        /// <param name="mainEditor">Главный редактор.</param>
        /// <param name="place">Место публикации.</param>
        /// <param name="publisher">Издатель сборника.</param>
        /// <param name="year">Год издания.</param>
        /// <param name="pageCount">Кол-во страниц.</param>
        public Collection(string name, string mainEditor, string place,
            string publisher, int year, int pageCount)
            : base(name, place, year, pageCount)
        {
            MainEditor = mainEditor;
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
            return $"{Name}: {MainEditor}. - {Place}: {Publisher}," +
            $" {Year}. - {PageCount} с.";
        }

    }
}
