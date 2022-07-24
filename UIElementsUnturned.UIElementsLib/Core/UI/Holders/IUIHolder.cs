using System;
using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holders
{
    /// <summary>
    /// Provides a container for UI Elements.
    /// </summary>
    public interface IUIHolder<TUIHolder> where TUIHolder : IUIElement
    {
        /// <summary>
        /// Gets all existing holders.
        /// </summary>
        IEnumerable<TUIHolder> Holders { get; }

        /// <summary>
        /// Adds the holder to the <see cref="Holders"/>.
        /// </summary>
        /// <param name="item">The item to be added to the <see cref="Holders"/>.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        void Add(TUIHolder item);

        /// <summary>
        /// Adds the all <paramref name="items"/> to the <see cref="Holders"/>.
        /// </summary>
        /// <param name="items">The items to be added to the <see cref="Holders"/>.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.InvalidOperationException"></exception>
        void Add(IEnumerable<TUIHolder> items);

        /// <summary>
        /// Removes the <see cref="TUIHolder"/> with the specified <paramref name="item"/> from the <see cref="Holders"/>.
        /// </summary>
        /// <param name="item">The item to be removed from the <see cref="Holders"/>.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        void Remove(TUIHolder item);

        /// <summary>
        /// Removes the <paramref name="items"/> from the <see cref="Holders"/>.
        /// </summary>
        /// <param name="items">The items to be removed from the <see cref="Holders"/>.</param>
        /// <exception cref="System.ArgumentNullException"></exception>
        /// <exception cref="System.InvalidOperationException"></exception>
        void Remove(IEnumerable<TUIHolder> items);

        /// <summary>
        /// Gets the <paramref name="holder"/> associated with the specified <paramref name="predicate"/>.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <param name="holder">The found UI Holder.</param>
        /// <returns><see langword="true"/> if the <see cref="Holders"/> contains an element with the specified <paramref name="predicate"/>; otherwise, false.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        bool TryGetItem(Predicate<TUIHolder> predicate, out TUIHolder holder);

        /// <summary>
        /// Gets the <paramref name="holder"/> associated with the specified <paramref name="childObjectNameString"/>.
        /// </summary>
        /// <param name="childObjectNameString">The child object name string for searching.</param>
        /// <param name="holder">The found UI Holder.</param>
        /// <returns><see langword="true"/> if the <see cref="Holders"/> contains an element with the specified <paramref name="childObjectNameString"/>; otherwise, false.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        bool TryGetItemByName(IChildObjectNameString childObjectNameString, out TUIHolder holder);

        /// <summary>
        /// Gets the <paramref name="holder"/> associated with the specified <paramref name="childObjectName"/>.
        /// </summary>
        /// <param name="childObjectName">The child object name for searching.</param>
        /// <param name="holder">The found UI Holder.</param>
        /// <returns><see langword="true"/> if the <see cref="Holders"/> contains an element with the specified <paramref name="childObjectName"/>; otherwise, false.</returns>
        /// <exception cref="System.ArgumentException"></exception>
        bool TryGetItemByName(string childObjectName, out TUIHolder holder);

        /// <summary>
        /// Gets the holder associated with the specified <paramref name="predicate"/>.
        /// </summary>
        /// <param name="predicate">The predicate.</param>
        /// <returns>The found UI Holder.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        TUIHolder GetItemOrDefault(Predicate<TUIHolder> predicate);

        /// <summary>
        /// Gets the holder associated with the specified <paramref name="childObjectNameString"/>.
        /// </summary>
        /// <param name="childObjectNameString">The child object name string for searching.</param>
        /// <returns>The found UI Holder.</returns>
        /// <exception cref="System.ArgumentNullException"></exception>
        TUIHolder GetItemByName(IChildObjectNameString childObjectNameString);

        /// <summary>
        /// Gets the holder associated with the specified <paramref name="childObjectName"/>.
        /// </summary>
        /// <param name="childObjectName">The child object name for searching.</param>
        /// <returns>The found UI Holder.</returns>
        /// <exception cref="System.ArgumentException"></exception>
        TUIHolder GetItemByName(string childObjectName);
    }
}
