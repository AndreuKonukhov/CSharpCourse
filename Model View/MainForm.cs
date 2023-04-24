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
            var source = new BindingSource(_editionList, null);
            EditionDataGridView.DataSource = source;
            EditionDataGridView.Columns[0].AutoSizeMode =
                DataGridViewAutoSizeColumnMode.AllCells;

        }

        /// <summary>
        /// Click event to add an MotionBase object to the list.
        /// </summary>
        /// <param name="sender">AddButton.</param>
        /// <param name="e">Event argument.</param>
        private void AddButton_Click(object sender, EventArgs e)
        {

            var newInputForm = new InputForm();

            newInputForm.Show();

            newInputForm.EditionAdded += (_, args) =>
            {
                _editionList.Add(args.Edition);

                EditionDataGridView.DataSource = _editionList;
            };

            newInputForm.Closed += (_, _) =>
            {
                AddButton.Enabled = true;
            };

            AddButton.Enabled = false;
        }

        private void RemoveButton_Click(object sender, EventArgs e)
        {
            if (EditionDataGridView.SelectedCells.Count != 0)
            {
                // TODO:+ refactor
                foreach (DataGridViewRow row in
                    EditionDataGridView.SelectedRows)
                {
                    _editionList.RemoveAt(row.Index);
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите очистить " +
                "список всех изданий?", "Очистка всех изданий",
                 MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                _editionList.Clear();
            }
        }
    }
}
