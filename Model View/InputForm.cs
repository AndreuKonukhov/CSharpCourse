
using Model;

namespace ModelView
{
    public partial class InputForm : Form
    {

        /// <summary>
        /// Dictionary of motion user controls.
        /// </summary>
        private readonly Dictionary<string,
            UserControl> _comboBoxToUserControl;

        /// <summary>
        /// Handler to event of adding motion.
        /// </summary>
        private EventHandler<EditionEventArgs> _editionAdded;

        /// <summary>
        /// EventHandler _motionAdded field's property.
        /// </summary>
        public EventHandler<EditionEventArgs> EditionAdded
        {
            get => _editionAdded;
            set => _editionAdded = value;
        }

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
                ComboBoxMotionTypes_SelectedIndexChanged;
        }

        /// <summary>
        /// Click event to check changes in ComboBox.
        /// </summary>
        /// <param name="sender">ComboBoxMotionTypes.</param>
        /// <param name="e">Event argument.</param>
        private void ComboBoxMotionTypes_SelectedIndexChanged
            (object sender, EventArgs e)
        {
            string selectedState = ComboBoxEditionTypes.SelectedItem.
            ToString();

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

        private void OKbutton_Click(object sender, EventArgs e)
        {
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
                        (Exception))
                    {
                        _ = MessageBox.Show
                            ($"Incorrect input parameters.\n" +
                            $"Error: {exception.Message}");
                    }
                    else
                    {
                        throw exception;
                    }
                }
            }

        }

        private void Cancelbutton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Book book1 = new Book("Филиппова А.Г", "История",
                "учебное пособие", "Москва", "Юнион", 2011, 126);
            var eventArgs = new EditionEventArgs(book1);
            EditionAdded?.Invoke(this, eventArgs);
        }
    }
}
