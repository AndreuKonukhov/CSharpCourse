using Model;

namespace ModelView
{
    public partial class MagazineUserControl : EditionBaseUserControl
    {
        public MagazineUserControl()
        {
            InitializeComponent();
        }

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

            foreach (var action in actions)
            {
                action.Invoke();
            }

            return magazine;
        }
    }
}
