using Model;

namespace ModelView
{
    /// <summary>
    /// Абстрактный класс EditionBaseUserControl
    /// </summary>
    public abstract partial class EditionBaseUserControl : UserControl
    {
        /// <summary>
        /// Абстрактный метод для получения экземпляра класса 
        /// Edition c параметрами введеными в textbox
        /// </summary>
        /// <returns>ОЭкземпляр  Edition</returns>
        public abstract EditionBase GetEdition();

        /// <summary>
        /// Запись параметров из textbox
        /// в экземпляр класса.
        /// </summary>
        /// <param name="actions">Список из Action.</param>
        public void InputParameters(List<Action> actions)
        {
            foreach (var action in actions)
            {
                action.Invoke();
            }
        }
    }
}
