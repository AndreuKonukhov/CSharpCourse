using Model;
using System.ComponentModel;

namespace ModelView
{
    /// <summary>
    /// Class MotionEventArgs.
    /// </summary>
    public class EditionEventArgs : EventArgs
    {
        /// <summary>
        /// Motion.
        /// </summary>
        public EditionBase Edition { get; private set; }

        /// <summary>
        /// Constructor of event MotionEventArgs class with MotionBase.
        /// </summary>
        /// <param name="motion">Motion.</param>
        public EditionEventArgs(EditionBase edition)
        {
            Edition = edition;
        }

        /// <summary>
        /// Filtered motion list.
        /// </summary>
        public BindingList<EditionBase> EditionListFiltered { get; private set; }

        /// <summary>
        /// Constructor of event MotionEventArgs class with filtered motion list.
        /// </summary>
        /// <param name="motionListFiltered">Filtered motion list.</param>
        public EditionEventArgs(BindingList<EditionBase> editionListFiltered)
        {
            EditionListFiltered = editionListFiltered;
        }
    }
}
