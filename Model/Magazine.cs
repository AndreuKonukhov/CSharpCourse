namespace Model
{
    /// <summary>
    /// Класс описывает журнал
    /// </summary>
    public class Magazine : EditionBase
    {
        /// <summary>
        /// Публикуемая организация.
        /// </summary>
        private string _organization;

        /// <summary>
        /// Тип журнала.
        /// </summary>
        private string _type;

        /// <summary>
		/// Редактор журнала.
		/// </summary>
		private string _editor;

        /// <summary>
        /// Публикуемая организация.
        /// </summary>
        public string Organization
        {
            get => _organization;
            set
            {
                CheckEmpty(value);
                _organization = value;
            }
        }

        /// <summary>
        /// Тип журнала.
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
        /// Редактор журнала.
        /// </summary>
        public string Editor
        {
            get => _editor;
            set
            {
                CheckEmpty(value);
                CheckLanguage(value);
                _editor = value;
            }
        }

        /// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">Наименование.</param>
		/// <param name="type">Тип журнала.</param>
		/// <param name="organization">Публикуемая организация.</param>
		/// <param name="place">Место публикации.</param>
		/// <param name="editor">Редактор.</param>
		/// <param name="year">Год публикации.</param>
		/// <param name="pageCount">Кол-во страниц.</param>
		public Magazine(string name, string type, string organization, string place,
            string editor, int year, int pageCount)
            : base(name, place, year, pageCount)
        {
            Type = type;
            Organization = organization;
            Editor = editor;
        }

        /// <summary>
        /// Конструктор по умолчанию.
        /// </summary>
        protected Magazine()
        {
        }

        /// <summary>
        /// Метод, возращает информацию о журнале.
        /// </summary>
        /// <returns>Информация об издании</returns>
        public override string GetInfo()
        {
            return $"{Name}: {Type} / учредитель {Organization}; " +
                $"ред. {Editor}. - {Place}" +
                $", {Year}. - {PageCount} с.";
        }

    }
}

