using Model;

namespace ModelView
{
    /// <summary>
    /// Класс CollectionUserControl
    /// </summary>
    public partial class CollectionUserControl : EditionBaseUserControl
    {
        /// <summary>
        /// Конструктор класса CollectionUserControl.
        /// </summary>
        public CollectionUserControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Метод для получения объекта Edition с
        /// параметрами введенными из textBox
        /// </summary>
        /// <returns>Объект Edition</returns>
        public override EditionBase GetEdition()
        {
            var collection = new Collection();

            var actions = new List<Action>()
            {
                () =>
                {
                    collection.Name = textBox1.Text;
                },

                () =>
                {
                    collection.NameOfConference = textBox2.Text;
                },

                () =>
                {
                    collection.Place = textBox3.Text;
                },

                () =>
                {
                    collection.Publisher = textBox4.Text;
                },

                () =>
                {
                    collection.Year = Convert.ToInt32(textBox5.Text);
                },

                () =>
                {
                    collection.PageCount = Convert.ToInt32(textBox6.Text);
                },

            };

            InputParameters(actions);

            return collection;
        }
    }
}
