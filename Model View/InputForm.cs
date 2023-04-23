using Model;
using System.ComponentModel;

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
        /// Dictionary of motion instances.
        /// </summary>
        private readonly Dictionary<string,
            Func<EditionBase>> _comboBoxToEdition;

        /// <summary>
        /// Field for link to MainForm _motionList object.
        /// </summary>
        private BindingList<EditionBase> _editionListMain;

        public InputForm(BindingList<EditionBase> editionList)
        {
            InitializeComponent();

            _editionListMain = editionList;

            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            {
                {"Книга", bookUserControl1},
                {"Сборник", collectionUserControl1},
                {"Диссертация", dissertationUserControl1},
                {"Журнал", magazineUserControl1}
            };

            ComboBoxEditionTypes.Items.AddRange(_comboBoxToUserControl.Keys.
                ToArray());

            _comboBoxToEdition = new Dictionary<string, Func<EditionBase>>()
            {
                {"Книга", bookUserControl1.GetEdition},
                {"Сборник", collectionUserControl1.GetEdition},
                {"Диссертация", dissertationUserControl1.GetEdition},
                {"Журнал", magazineUserControl1.GetEdition}

            };

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
        private void InputForm_Load(object sender, EventArgs e)
        {

        }

        private void OKbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ComboBoxEditionTypes.Text.ToString()))
            {
                Close();
            }
            else
            {
                foreach (var editionType in _comboBoxToEdition)
                {
                    if (ComboBoxEditionTypes.SelectedItem.ToString() ==
                        editionType.Key)
                    {
                        try
                        {
                            _editionListMain.Add(editionType.Value.
                                Invoke());
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
                                    ($"Неверно введены данные.\n" +
                                    $"Ошибка: {exception.Message}");
                            }
                            else
                            {
                                throw exception;
                            }
                        }
                    }
                }
            }

        }
    }
}
