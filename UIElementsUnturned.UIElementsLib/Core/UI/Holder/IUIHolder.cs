using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Element;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holder
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
        /// Trying to find item safely. 
        /// Working same as <see cref="TryFindItem(string, out TUIHolder)"/>, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be used.
        /// </summary>
        /// <param name="childObjectNameString">Child object name string for searching.</param>
        /// <param name="holder">Found UI Holder.</param>
        /// <returns>Success of searching.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        bool TryFindItem(IChildObjectNameString childObjectNameString, out TUIHolder holder);

        /// <summary>
        /// Trying to find item safely by calling <see cref="TryFindItem(IChildObjectNameString, out TUIHolder)"/>.
        /// </summary>
        /// <param name="childObjectName">Child object name for searching.</param>
        /// <param name="holder">Found UI Holder.</param>
        /// <returns>Success of searching.</returns>
        /// <exception cref="System.ArgumentException"></exception>
        bool TryFindItem(string childObjectName, out TUIHolder holder);

        /// <summary>
        /// Searching an item.
        /// Working same as <see cref="FindItem(string)"/>, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be used.
        /// </summary>
        /// <param name="childObjectNameString">Child object name string for searching.</param>
        /// <returns>Found UI Holder.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        TUIHolder FindItem(IChildObjectNameString childObjectNameString);

        /// <summary>
        /// Searching an item by calling <see cref="FindItem(IChildObjectNameString)"/>
        /// </summary>
        /// <param name="childObjectName">Child object name for searching.</param>
        /// <returns>Found UI Holder.</returns>
        /// <exception cref="System.ArgumentException"></exception>
        TUIHolder FindItem(string childObjectName);
    }
}
