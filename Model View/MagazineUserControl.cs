using Model;

namespace ModelView
{
    /// <summary>
    /// Класс MagazineUserControl
    /// </summary>
    public partial class MagazineUserControl : EditionBaseUserControl
    {
        /// <summary>
        /// Конструктор класса MagazineUserControl.
        /// </summary>
        public MagazineUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Событие проверки ввода года кол-ва страниц
        /// </summary>
        private void CountPage_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckPage(e);
        }

        /// <summary>
        /// Событие проверки ввода года издания
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Year_KeyPress(object sender, KeyPressEventArgs e)
        {
            Utils.CheckInput(e);
        }

        /// <summary>
        /// Метод для получения объекта Edition с
        /// параметрами введенными из textBox
        /// </summary>
        /// <returns>Объект Edition</returns>
        public override EditionBase GetEdition()
        {
            var magazine = new Magazine();

            var actions = new List<Action>()
            {
                () =>
                {
                    magazine.Name = textBox1.Text;
                },

                () =>
                {
                    magazine.Type = textBox2.Text;
                },

                () =>
                {
                    magazine.Organization = textBox3.Text;
                },

                () =>
                {
                    magazine.Place = textBox4.Text;
                },

                () =>
                {
                    magazine.Editor = textBox5.Text;
                },

                () =>
                {
                    magazine.Year = Convert.ToInt32(textBox6.Text);
                },

                () =>
                {
                    magazine.PageCount = Convert.ToInt32(textBox7.Text);
                },

            };

            InputParameters(actions);

            return magazine;
        }

        private void MagazineUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
