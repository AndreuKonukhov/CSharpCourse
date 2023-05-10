using Model;

namespace ModelView
{
    /// <summary>
    /// Класс формы для ввода библиотечного издания.
    /// </summary>
    public partial class InputForm : Form
    {
        /// <summary>
        /// Словарь объектов UserControl.
        /// </summary>
        private readonly Dictionary<string,
            UserControl> _comboBoxToUserControl;

        /// <summary>
        /// Обработчик события добавления библиотечного издания.
        /// </summary>
        private EventHandler<EditionEventArgs> _editionAdded;

        /// <summary>
        /// Обработчик события добавления библиотечного издания.
        /// </summary>
        public EventHandler<EditionEventArgs> EditionAdded
        {
            get => _editionAdded;
            set => _editionAdded = value;
        }


        /// <summary>
        /// Конструктор класса InputForm.
        /// </summary>
        public InputForm()
        {
            InitializeComponent();

            string[] motionTypes = { "Книга", "Сборник",
                "Диссертация", "Журнал" };

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {motionTypes[0], bookUserControl1},
                {motionTypes[1], collectionUserControl1},
                {motionTypes[2], dissertationUserControl1},
                {motionTypes[3], magazineUserControl1}
            };

            ComboBoxEditionTypes.Items.AddRange(motionTypes);

            ComboBoxEditionTypes.SelectedIndexChanged +=
                ComboBoxEditionTypes_SelectedIndexChanged;
        }

        /// <summary>
        /// Событие выбора типа библиотечного издания в выпадающем списке.
        /// </summary>
        private void ComboBoxEditionTypes_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            string selectedState = ComboBoxEditionTypes.SelectedItem.
            ToString();

            //Перебор всех UserControl,
            //Отображение выбранного и скрытие остальных.
            foreach (var (editionType, userControl) in
                _comboBoxToUserControl)
            {
                userControl.Visible = false;
                if (selectedState == editionType)
                {
                    userControl.Visible = true;
                }
            }
        }

        /// <summary>
        /// Событие нажатия кнопки OK.
        /// </summary>
        private void OKbutton_Click(object sender, EventArgs e)
        {
            //Проверка на пустое значение в ComboBox.
            if (string.IsNullOrEmpty(ComboBoxEditionTypes.Text))
            {
                Close();
            }
            else
            {
                try
                {
                    var chosenEdition =
                        ComboBoxEditionTypes.SelectedItem.ToString();
                    var chosenMotionControl =
                        _comboBoxToUserControl[chosenEdition];
                    var eventArgs = new EditionEventArgs
                        (((EditionBaseUserControl)chosenMotionControl).
                        GetEdition());
                    EditionAdded?.Invoke(this, eventArgs);
                }
                catch (Exception exception)
                {
                    if (exception.GetType() == typeof
                        (ArgumentOutOfRangeException) ||
                        exception.GetType() == typeof
                        (ArgumentException) ||
                        exception.GetType() == typeof
                        (Exception) ||
                        exception.GetType() == typeof
                        (System.FormatException))
                    {
                        _ = MessageBox.Show
                            ($"Некоректный ввод.\n" +
                            $"Ошибка: {exception.Message}");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }

        }

        /// <summary>
        /// Событие нажатия кнопки "Отмена"
        /// </summary>
        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

#if DEBUG
        /// <summary>
        /// Событие нажатия кнопки.
        /// </summary>
        private void Button1_Click(object sender, EventArgs e)
        {
            Book book = new Book("Филиппова А.Г", "История",
                "учебное пособие", "Москва", "Юнион", 2011, 126);
            var eventArgs = new EditionEventArgs(book);
            EditionAdded?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Событие нажатия кнопки.
        /// </summary>
        private void Button2_Click(object sender, EventArgs e)
        {
            Collection collection = new Collection(
                "Инновации", "Международная конференция",
                "Москва", "Московский Государственный Унверститет",
                2012, 58);
            var eventArgs = new EditionEventArgs(collection);
            EditionAdded?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Событие нажатия кнопки.
        /// </summary>
        private void Button3_Click(object sender, EventArgs e)
        {
            Dissertation dissertation = new Dissertation(
                "Филиппова А.Г", "Название диссертации",
                "диссертация на соискание ученой степени",
                "специальность 13.00.01 'Общая педагогика'",
                "Москва", "Кузбасская государственная педагогическая академия",
                2000, 255);
            var eventArgs = new EditionEventArgs(dissertation);
            EditionAdded?.Invoke(this, eventArgs);
        }

        /// <summary>
        /// Событие нажатия кнопки.
        /// </summary>
        private void Button4_Click(object sender, EventArgs e)
        {
            Magazine magazine = new Magazine("Вопросы", "Научный журнал",
                "ООО 'Редация'", "Москва", "А.А. Искендеров", 2011, 518);
            var eventArgs = new EditionEventArgs(magazine);
            EditionAdded?.Invoke(this, eventArgs);
        }
    }
}
#endif
