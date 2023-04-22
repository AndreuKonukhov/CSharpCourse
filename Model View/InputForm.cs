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
            //
            //#if DEBUG
            //            AddRandomObjectButton.Visible = true;
            //#endif
            //            _comboBoxToUserControl = new Dictionary<string, UserControl>()
            //            {
            //                {"Uniform", uniformMotionUserControl1},
            //                {"Uniformly accelerated", uniformAccelMotionUserControl1},
            //                {"Oscillating", oscilMotionUserControl1}
            //            };
            //
            //            ComboBoxMotionTypes.Items.AddRange(_comboBoxToUserControl.Keys.
            //                ToArray());
            //
            //            // TODO:+ Можно создать базовый класс/интерфейс UserControl
            //            // с методом AddMotion
            //            _comboBoxToMotion = new Dictionary<string, Func<MotionBase>>()
            //            {
            //                {"Uniform", uniformMotionUserControl1.GetMotion},
            //                {"Uniformly accelerated", uniformAccelMotionUserControl1.
            //                    GetMotion},
            //                {"Oscillating", oscilMotionUserControl1.GetMotion}
            //            };
            //
            //            ComboBoxMotionTypes.SelectedIndexChanged +=
            //                ComboBoxMotionTypes_SelectedIndexChanged;
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
    }
}
