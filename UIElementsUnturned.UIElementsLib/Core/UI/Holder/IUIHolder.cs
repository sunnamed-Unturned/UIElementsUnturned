using System.Collections.Generic;
using UIElementsLib.Core.UI.Element;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holder
{
    /// <summary>
    /// Container for UI Elements.
    /// </summary>
    /// <typeparam name="TUIHolder">Holder type</typeparam>
    public interface IUIHolder<TUIHolder> where TUIHolder : IUIElement
    {
        /// <summary>
        /// Returns All holders.
        /// </summary>
        IEnumerable<TUIHolder> Holders { get; }

        /// <summary>
        /// Add new holder.
        /// </summary>
        /// <param name="item">UI Holder what you want to add</param>
        void AddNew(TUIHolder item);

        /// <summary>
        /// Remove holder.
        /// </summary>
        /// <param name="item">For removing UI Holder</param>
        void Remove(TUIHolder item);

        /// <summary>
        /// Search an item in list.
        /// </summary>
        /// <param name="childObjectName">Search by child object name</param>
        /// <returns>Found UI Holder</returns>
        TUIHolder FindItem(string childObjectName);
    }
}
