using System.Collections.Generic;
using UIElementsLib.Core.UI.Element;

namespace UIElementsLib.Core.UI.Holder
{
    /// <summary>
    /// Container for UI Elements.
    /// </summary>
    /// <typeparam name="TUIHolder"></typeparam>
    public interface IUIHolder<TUIHolder> where TUIHolder : IUIElement
    {
        /// <summary>
        /// Returns All holders.
        /// </summary>
        IEnumerable<TUIHolder> Holders { get; }


        /// <summary>
        /// Add new holder.
        /// </summary>
        /// <param name="item">the item</param>
        void AddNew(TUIHolder item);

        /// <summary>
        /// Remove holder.
        /// </summary>
        /// <param name="item"></param>
        void Remove(TUIHolder item);

        /// <summary>
        /// Search an item in list.
        /// </summary>
        /// <param name="childObjectName">search by child object name</param>
        /// <returns>found item</returns>
        TUIHolder FindItem(string childObjectName);
    }
}
