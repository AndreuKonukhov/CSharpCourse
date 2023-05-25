using Model;

namespace ModelView
{
    /// <summary>
    /// Класс DissertationUserControl
    /// </summary>
    public partial class DissertationUserControl : EditionBaseUserControl
    {
        /// <summary>
        /// Конструктор класса DissertationUserControl.
        /// </summary>
        public DissertationUserControl()
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
        /// параметрами введенными из textBox.
        /// </summary>
        /// <returns>Объект Edition</returns>
        public override EditionBase GetEdition()
        {
            var dissertation = new Dissertation();

            var actions = new List<Action>()
            {
                () =>
                {
                    dissertation.Author = textBox1.Text;
                },

                () =>
                {
                    dissertation.Name = textBox2.Text;
                },

                () =>
                {
                    dissertation.Type = textBox3.Text;
                },

                () =>
                {
                    dissertation.Specialization = textBox4.Text;
                },

                () =>
                {
                    dissertation.Place = textBox5.Text;
                },

                () =>
                {
                    dissertation.University = textBox6.Text;
                },

                () =>
                {
                    dissertation.Year = Convert.ToInt32(textBox7.Text);
                },

                () =>
                {
                    dissertation.PageCount = Convert.ToInt32(textBox8.Text);
                },

            };

            InputParameters(actions);

            return dissertation;
        }
    }
}
