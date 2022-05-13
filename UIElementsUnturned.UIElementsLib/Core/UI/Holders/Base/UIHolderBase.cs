using System;
using System.Collections.Generic;
using System.Linq;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holders.Base
{
    public abstract class UIHolderBase<TUIHolder> : IUIHolder<TUIHolder> where TUIHolder : IUIElement
    {
        private readonly IList<TUIHolder> holders;



        public UIHolderBase(IEnumerable<TUIHolder> items)
        {
            holders = new List<TUIHolder>();

            if (items != null && items.Any())
                AddNew(items);
        }

        public UIHolderBase() : this(null)
        {
        }



        public virtual IEnumerable<TUIHolder> Holders => holders;



        public virtual void AddNew(TUIHolder item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            holders.Add(item);
        }

        public void AddNew(IEnumerable<TUIHolder> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            if (items.Any() == false)
                throw new InvalidOperationException(nameof(items));

            foreach (TUIHolder holder in items)
                AddNew(holder);
        }

        public virtual void Remove(TUIHolder item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (holders.Contains(item))
                holders.Remove(item);
        }

        public void Remove(IEnumerable<TUIHolder> items)
        {
            if (items == null)
                throw new ArgumentNullException(nameof(items));

            if (items.Any() == false)
                throw new InvalidOperationException(nameof(items));

            foreach (TUIHolder holder in items)
                Remove(holder);
        }

        public bool TryFindItem(Predicate<TUIHolder> predicate, out TUIHolder holder)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            return (holder = FindItem(predicate)) != null;
        }

        public bool TryFindItemByName(IChildObjectNameString childObjectNameString, out TUIHolder holder)
        {
            if (childObjectNameString == null)
                throw new ArgumentNullException(nameof(childObjectNameString));

            return (holder = FindItemByName(childObjectNameString)) != null;
        }

        public bool TryFindItemByName(string childObjectName, out TUIHolder holder)
        {
            if (string.IsNullOrWhiteSpace(childObjectName))
                throw new ArgumentException(nameof(childObjectName));

            return TryFindItemByName(new ChildObjectNameString(childObjectName), out holder);
        }

        public TUIHolder FindItem(Predicate<TUIHolder> predicate)
        {
            if (predicate == null)
                throw new ArgumentNullException(nameof(predicate));

            foreach (TUIHolder item in holders)
                if (predicate.Invoke(item))
                    return item;

            return default(TUIHolder);
        }

        public TUIHolder FindItemByName(IChildObjectNameString childObjectNameString)
        {
            if (childObjectNameString == null)
                throw new ArgumentNullException(nameof(childObjectNameString));

            return FindItem(p => string.Equals(p.ChildObjectName, childObjectNameString.Name));
        }

        public TUIHolder FindItemByName(string childObjectName)
        {
            if (string.IsNullOrWhiteSpace(childObjectName))
                throw new ArgumentException(nameof(childObjectName));

            return FindItemByName(new ChildObjectNameString(childObjectName));
        }
    }
}
