using Model;
using System.ComponentModel;
using System.Xml.Serialization;

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
        /// События нажатся кнопки добавления библиотечного издания.
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

        private void SaveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileBrowser = new SaveFileDialog
            {
                Filter = "EditionData (*.andr)|*.andr"
            };

            _ = fileBrowser.ShowDialog();

            var path = fileBrowser.FileName;

            var xmlSerializer = new XmlSerializer
                (typeof(BindingList<EditionBase>));

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            using (var file = File.Create(path))
            {
                xmlSerializer.Serialize(file, EditionDataGridView.DataSource);
                file.Close();
            }
        }

        private void LoadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileBrowser = new OpenFileDialog
            {
                Filter = "EditionData (*.andr)|*.andr"
            };

            _ = fileBrowser.ShowDialog();

            var path = fileBrowser.FileName;

            if (string.IsNullOrEmpty(path))
            {
                return;
            }

            var xmlSerializer = new XmlSerializer
                (typeof(BindingList<EditionBase>));

            using (var file = new StreamReader(path))
            {
                _editionList = (BindingList<EditionBase>)xmlSerializer.
                    Deserialize(file);
            }

            EditionDataGridView.DataSource = _editionList;
        }

        private void FilterButton_Click(object sender, EventArgs e)
        {
            var filter = new FilterForm();

            filter.EditionListMain = _editionList;

            filter.Show();

            filter.MotionListFiltered += (_, args) =>
            {
                EditionDataGridView.DataSource = args.EditionListFiltered;
            };

            filter.Closed += (_, _) =>
            {
                FilterButton.Enabled = true;
            };

            FilterButton.Enabled = false;
        }
    }
}
