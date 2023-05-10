using Model;
using System.ComponentModel;

namespace ModelView
{
    /// <summary>
    /// Класс FilterForm
    /// </summary>
    public partial class FilterForm : Form
    {
        /// <summary>
        /// Словарь типов изданий.
        /// </summary>
        private readonly Dictionary<string, Type> _editionTypes = new()
        {
            {nameof(Book), typeof(Book)},
            {nameof(Collection), typeof(Collection)},
            {nameof(Dissertation), typeof(Dissertation)},
            {nameof(Magazine), typeof(Magazine)}
        };

        /// <summary>
        /// Словрь названий типов изданий.
        /// </summary>
        private readonly Dictionary<string, string> _listBoxToEditionType;

        /// <summary>
        /// Обработчик события фильтрации изданий.
        /// </summary>
        private EventHandler<EditionEventArgs> _editionListFiltered;

        /// <summary>
        /// Обработчик события фильтрации изданий.
        /// </summary>
        public EventHandler<EditionEventArgs> EditionListFiltered
        {
            get => _editionListFiltered;
            set => _editionListFiltered = value;
        }

        /// <summary>
        /// Св-во для ссылки на главную форму
        /// </summary>
        public BindingList<EditionBase> EditionListMain { get; set; }

        /// <summary>
        /// Конструктор класса FilterForm.
        /// </summary>
        public FilterForm()
        {
            InitializeComponent();

            _listBoxToEditionType = new Dictionary<string, string>()
            {
                {"Книга", nameof(Book)},
                {"Сборник", nameof(Collection)},
                {"Диссертация", nameof(Dissertation)},
                {"Журнал", nameof(Magazine)},
            };

            EditionTypeCheckedListBox.Items.AddRange
                (_listBoxToEditionType.Keys.ToArray());
        }

        /// <summary>
        /// Событие нажатия кнопки "Применить"
        /// </summary>
        /// <param name="sender">FilterButton</param>
        /// <param name="e">Event argument.</param>
        private void FilterButton_Click(object sender, EventArgs e)
        {
            var textFilteredList = new BindingList<EditionBase>();
            var typeFilteredList = new BindingList<EditionBase>();

            var action = new List<Action<BindingList<EditionBase>>>
            {
                new Action<BindingList<EditionBase>>
                (
                (BindingList<EditionBase> typeFilteredList) =>
                {
                    foreach (var edition in EditionListMain)
                    {
                        foreach (var checkedEdition in
                            EditionTypeCheckedListBox.CheckedItems)
                        {
                            if (edition.GetType() == _editionTypes
                            [_listBoxToEditionType
                            [checkedEdition.ToString()]])
                            {
                                typeFilteredList.Add(edition);
                            }
                        }
                    }
                }),

                new Action<BindingList<EditionBase>>
                (
                (BindingList<EditionBase> typeFilteredList) =>
                {
                    foreach (var edition in typeFilteredList)
                    {
                        if (edition.GetInfo.Contains(textBox.Text))
                        {
                            textFilteredList.Add(edition);
                        }
                    }
                })

            };

            action[0].Invoke(typeFilteredList);
            action[1].Invoke(typeFilteredList);
            var eventArgs = new EditionEventArgs
                (textFilteredList);
            EditionListFiltered?.Invoke(this, eventArgs);
        }
        private void ResetButton_Click(object sender, EventArgs e)
        {
            var eventArgs = new EditionEventArgs(EditionListMain);
            EditionListFiltered?.Invoke(this, eventArgs);
        }
    }
}
