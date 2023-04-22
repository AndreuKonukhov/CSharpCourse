using Model;
using System.ComponentModel;

namespace ModelView
{
    public partial class MainForm : Form
    {
        /// <summary>
        /// Список библиотечных изданий.
        /// </summary>
        /// 
        private static BindingList<EditionBase> _editionList = new();

        public MainForm()
        {
            InitializeComponent();
            EditionDataGridView.DataSource = _editionList;
        }

        /// <summary>
        /// Click event to add an MotionBase object to the list.
        /// </summary>
        /// <param name="sender">AddButton.</param>
        /// <param name="e">Event argument.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {

            var newObject = new InputForm(_editionList);

            newObject.Show();

            newObject.Closed += (_, _) =>
            {
                AddButton.Enabled = true;
            };

            AddButton.Enabled = false;
        }
    }
}
