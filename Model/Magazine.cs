namespace Model
{
    /// <summary>
    /// Класс описывает журнал
    /// </summary>
    public class Magazine: EditionBase
    {
        /// <summary>
        /// Организация публикуемая журнал.
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
        /// Организация публикуемая журнал.
        /// </summary>
        public string Founder
        {
            get => _organization;
            set => _organization = value;
        }

        /// <summary>
        /// Тип журнала
        /// </summary>
        public string Type
        {
            get => _type;
            set
            {

                _type = value;
            }
        }

        /// <summary>
        /// Редактор журнала
        /// </summary>
        public string Editor
        {
            get => _editor;
            set
            {
                CheckEmpty(value);
                CheckLanguage(value);
                _mainEditor = value;
            }
        }

        /// <summary>
		/// Конструктор класса
		/// </summary>
		/// <param name="name">name</param>
		/// <param name="type">type</param>
		/// <param name="founder">founder</param>
		/// <param name="place">Место place</param>
		/// <param name="mainEditor">mainEditor</param>
		/// <param name="year">year</param>
		/// <param name="pageCount">count of pages</param>
		public Magazine(string name, string type, string founder, string place,
            string mainEditor, int year, int pageCount)
            : base(name, place, year, pageCount)
        {
            Type = type;
            Founder = founder;
            Editor = mainEditor;
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        protected Magazine()
        {
        }

        /// <summary>
        /// Information
        /// </summary>
        public override string Info =>
            $"{Name}: {Type} / учредитель {Founder}; ред. {Editor}. - {Place}" +
            $", {Year}. - {PageCount} с.";
    }
}
    }
}
