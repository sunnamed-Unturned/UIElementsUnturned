using System;
using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holders
{
    /// <summary>
    /// Container for UI Elements.
    /// </summary>
    public interface IUIHolder<TUIHolder> where TUIHolder : IUIElement
    {
        /// <summary>
        /// All holders.
        /// </summary>
        IEnumerable<TUIHolder> Holders { get; }

        /// <summary>
        /// Adding new holder.
        /// </summary>
        /// <param name="item">UI Holder for adding.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        void AddNew(TUIHolder item);

        /// <summary>
        /// Adding new holders by calling <see cref="AddNew(TUIHolder)"/>
        /// </summary>
        /// <param name="items">UI Holders for adding.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.InvalidOperationException"></exception>
        void AddNew(IEnumerable<TUIHolder> items);

        /// <summary>
        /// Removing holder.
        /// </summary>
        /// <param name="item">UI Holder for removing.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        void Remove(TUIHolder item);

        /// <summary>
        /// Removing holders by calling <see cref="Remove(TUIHolder)"/>
        /// </summary>
        /// <param name="items">UI Holders for removing.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.InvalidOperationException"></exception>
        void Remove(IEnumerable<TUIHolder> items);

        /// <summary>
        /// Trying to find item safely with <paramref name="predicate"/> by calling <see cref="FindItem(Predicate{TUIHolder})"/>
        /// </summary>
        /// <param name="predicate">Predicate.</param>
        /// <param name="holder">Found UI Holder.</param>
        /// <returns>Success of searching.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        bool TryFindItem(Predicate<TUIHolder> predicate, out TUIHolder holder);

        /// <summary>
        /// Trying to find item safely. 
        /// Working same as <see cref="TryFindItemByName(string, out TUIHolder)"/>, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be used.
        /// </summary>
        /// <param name="childObjectNameString">Child object name string for searching.</param>
        /// <param name="holder">Found UI Holder.</param>
        /// <returns>Success of searching.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        bool TryFindItemByName(IChildObjectNameString childObjectNameString, out TUIHolder holder);

        /// <summary>
        /// Trying to find item safely by calling <see cref="TryFindItemByName(IChildObjectNameString, out TUIHolder)"/>.
        /// </summary>
        /// <param name="childObjectName">Child object name for searching.</param>
        /// <param name="holder">Found UI Holder.</param>
        /// <returns>Success of searching.</returns>
        /// <exception cref="System.ArgumentException"></exception>
        bool TryFindItemByName(string childObjectName, out TUIHolder holder);

        /// <summary>
        /// Searching an item with <paramref name="predicate"/> 
        /// </summary>
        /// <param name="predicate">Predicate.</param>
        /// <returns>Found UI Holder.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        TUIHolder FindItem(Predicate<TUIHolder> predicate);

        /// <summary>
        /// Searching an item.
        /// Working same as <see cref="FindItemByName(string)"/>, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be used.
        /// </summary>
        /// <param name="childObjectNameString">Child object name string for searching.</param>
        /// <returns>Found UI Holder.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        TUIHolder FindItemByName(IChildObjectNameString childObjectNameString);

        /// <summary>
        /// Searching an item by calling <see cref="FindItemByName(IChildObjectNameString)"/>
        /// </summary>
        /// <param name="childObjectName">Child object name for searching.</param>
        /// <returns>Found UI Holder.</returns>
        /// <exception cref="System.ArgumentException"></exception>
        TUIHolder FindItemByName(string childObjectName);
    }
}
