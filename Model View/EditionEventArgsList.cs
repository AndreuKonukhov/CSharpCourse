using Model;
using System.ComponentModel;

namespace ModelView
{
    /// <summary>
    /// Класс EditionEventArgsList.
    /// </summary>
    public class EditionEventArgsList : EventArgs
    {
        /// <summary>
        /// Отфильтрованный список библиотечных изданий.
        /// </summary>
        public BindingList<EditionBase> EditionListFiltered { get; private set; }

        /// <summary>
        /// Конструктор класса EditionEventArgs
        /// </summary>
        /// <param name="editionListFiltered">
        /// Отфильтрованный список библиотечных изданий.</param>
        public EditionEventArgsList(BindingList<EditionBase> editionListFiltered)
        {
            EditionListFiltered = editionListFiltered;
        }
    }
}

