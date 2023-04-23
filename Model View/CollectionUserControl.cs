using Model;

namespace ModelView
{
    public partial class CollectionUserControl : EditionBaseUserControl
    {
        public CollectionUserControl()
        {
            InitializeComponent();
        }

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

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return collection;
        }
    }
}
