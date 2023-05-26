using Model;

namespace ModelView
{
    /// <summary>
    /// Класс EditionEventArgs.
    /// </summary>
    public class EditionEventArgs : EventArgs
    {
        /// <summary>
        /// Экземпляр библиотечного издания.
        /// </summary>
        public EditionBase Edition { get; private set; }

        /// <summary>
        /// Конструктор класса EditionEventArgs
        /// </summary>
        /// <param name="edition">Экземпляр класса EditionBase.</param>
        public EditionEventArgs(EditionBase edition)
        {
            Edition = edition;
        }
    }
}
