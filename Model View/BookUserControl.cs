using Model;

namespace ModelView
{
    /// <summary>
    /// Класс BookUserControl
    /// </summary>
    public partial class BookUserControl : EditionBaseUserControl
    {
        /// <summary>
        /// Конструктор класса BookUserControl.
        /// </summary>
        public BookUserControl()
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
            Utils.CheckAge(e);
        }

        /// <summary>
        /// Метод для получения объекта Edition с
        /// параметрами введенными из textBox
        /// </summary>
        /// <returns>Объект Edition</returns>
        public override EditionBase GetEdition()
        {
            var book = new Book();

            var actions = new List<Action>()
            {
                () =>
                {
                    book.Author = textBox1.Text;
                },

                () =>
                {
                    book.Name = textBox2.Text;
                },

                () =>
                {
                    book.Type = textBox3.Text;
                },

                () =>
                {
                    book.Place = textBox4.Text;
                },

                () =>
                {
                    book.Publisher = textBox5.Text;
                },

                () =>
                {
                    book.Year = Convert.ToInt32(textBox6.Text);
                },

                () =>
                {
                    book.PageCount = Convert.ToInt32(textBox7.Text);
                },

            };

            InputParameters(actions);

            return book;
        }

        //TODO: remove
        private void BookUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
