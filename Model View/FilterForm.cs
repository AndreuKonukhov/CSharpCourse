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
            {"Книга", typeof(Book)},
            {"Сборник", typeof(Collection)},
            {"Диссертация", typeof(Dissertation)},
            {"Журнал", typeof(Magazine)}
        };

        /// <summary>
        /// Dictionary of motion type names.
        /// </summary>
        private readonly Dictionary<string, string> _listBoxToEditionType;

        /// <summary>
        /// Handler to event of filtering motion.
        /// </summary>
        private EventHandler<EditionEventArgs> _editionListFiltered;

        /// <summary>
        /// EventHandler _motionListFiltered field's property.
        /// </summary>
        public EventHandler<EditionEventArgs> MotionListFiltered
        {
            get => _editionListFiltered;
            set => _editionListFiltered = value;
        }

        /// <summary>
        /// Property for link to MainForm _motionList object.
        /// </summary>
        public BindingList<EditionBase> EditionListMain { get; set; }

        /// <summary>
        /// Filter form instance constructor.
        /// </summary>
        public FilterForm()
        {

            InitializeComponent();

            _listBoxToEditionType = new Dictionary<string, string>()
            {
                {"Книга", "Книга"},
                {"Сборник", "Сборник"},
                {"Диссертация", "Диссертация"},
                {"Журнал", "Журнал"},
            };

            EditionTypeCheckedListBox.Items.AddRange
                (_listBoxToEditionType.Keys.ToArray());
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var valueFilteredList = new BindingList<EditionBase>();
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

            };

            if (EditionTypeCheckedListBox.SelectedItems.Count == 0)
            {
                typeFilteredList = EditionListMain;
                action[0].Invoke(typeFilteredList);
            }
            else
            {
                //action[0].Invoke(typeFilteredList);
                action[0].Invoke(typeFilteredList);
            }

            var eventArgs = new EditionEventArgs
                (valueFilteredList);
            MotionListFiltered?.Invoke(this, eventArgs);


        }
    }
}
