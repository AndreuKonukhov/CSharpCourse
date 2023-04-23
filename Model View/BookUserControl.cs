using Model;

namespace ModelView
{
    public partial class BookUserControl : EditionBaseUserControl
    {
        public BookUserControl()
        {
            InitializeComponent();
        }

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

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return book;
        }
    }
}
