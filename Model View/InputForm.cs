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
            string selectedState = ComboBoxEditionTypes.SelectedItem.ToString();

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
                    var tmpExceptionType = exception.GetType();
                    if (tmpExceptionType == typeof(ArgumentOutOfRangeException)
                        || tmpExceptionType == typeof(ArgumentException)
                        || tmpExceptionType == typeof(Exception)
                        || tmpExceptionType == typeof(FormatException))
                    {
                        _ = MessageBox.Show
                            ($"Некоректный ввод.\n" +
                            $"Ошибка: {exception.Message}");
                    }
                    else
                    {
                        throw;
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
        /// Событие добавление случайного издания при нажатии кнопки
        /// </summary>
        private void AddRandomEditionButton_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            var editionTypes = new Dictionary<int, EditionType>
            {
                {0, EditionType.Book},
                {1, EditionType.Collection},
                {2, EditionType.Dissertation},
                {3, EditionType.Magazine}
            };
            var randomType = rnd.Next(editionTypes.Count);
            var randomEdition = new RandomEdition()
                    .GetInstance(editionTypes[randomType]);

            var eventArgs = new EditionEventArgs(randomEdition);
            EditionAdded?.Invoke(this, eventArgs);
        }
    }
}
#endif
