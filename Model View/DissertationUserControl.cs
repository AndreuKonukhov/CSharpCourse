using Model;

namespace ModelView
{
    public partial class DissertationUserControl : EditionBaseUserControl
    {
        public DissertationUserControl()
        {
            InitializeComponent();
        }

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

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return dissertation;
        }
    }
}
