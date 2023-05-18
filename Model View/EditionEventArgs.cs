using Model;
using System.ComponentModel;

namespace ModelView
{
    //TODO: separate
    /// <summary>
    /// Класс MotionEventArgs.
    /// </summary>
    public class EditionEventArgs : EventArgs
    {
        /// <summary>
        /// Экземпляр библиотечного издания.
        /// </summary>
        public EditionBase Edition { get; private set; }

        /// <summary>
        /// Отфильтрованный список библиотечных изданий.
        /// </summary>
        public BindingList<EditionBase> EditionListFiltered { get; private set; }

        /// <summary>
        /// Конструктор класса EditionEventArgs
        /// </summary>
        /// <param name="edition">Экземпляр класса EditionBase.</param>
        public EditionEventArgs(EditionBase edition)
        {
            Edition = edition;
        }

        /// <summary>
        /// Конструктор класса EditionEventArgs
        /// </summary>
        /// <param name="editionListFiltered">
        /// Отфильтрованный список библиотечных изданий.</param>
        public EditionEventArgs(BindingList<EditionBase> editionListFiltered)
        {
            EditionListFiltered = editionListFiltered;
        }
    }
}
