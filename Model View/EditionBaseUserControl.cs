using Model;

namespace ModelView
{
    public abstract partial class EditionBaseUserControl : UserControl
    {
        public abstract EditionBase GetEdition();

        /// <summary>
        /// Wright input parameters in instance.
        /// </summary>
        /// <param name="actions">Action list of parameters.</param>
        public void InputParameters(List<Action> actions)
        {
            foreach (var action in actions)
            {
                action.Invoke();
            }
        }
    }
}
