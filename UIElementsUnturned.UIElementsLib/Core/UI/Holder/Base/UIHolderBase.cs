using System;
using System.Collections.Generic;
using System.Linq;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Element;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base
{
    public abstract class UIHolderBase<TUIHolder> : IUIHolder<TUIHolder> where TUIHolder : IUIElement
    {
        private readonly IList<TUIHolder> holders;



        public virtual IEnumerable<TUIHolder> Holders => holders;



        public UIHolderBase(IEnumerable<TUIHolder> items)
        {
            holders = new List<TUIHolder>();

            if (items != null && items.Any())
                AddNew(items);
        }

        public UIHolderBase() : this(null)
        {
        }



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

        public bool TryFindItem(IChildObjectNameString childObjectNameString, out TUIHolder holder)
        {
            if (childObjectNameString == null)
                throw new ArgumentNullException(nameof(childObjectNameString));

            return (holder = FindItem(childObjectNameString)) != null;
        }

        public bool TryFindItem(string childObjectName, out TUIHolder holder)
        {
            if (string.IsNullOrWhiteSpace(childObjectName))
                throw new ArgumentException(nameof(childObjectName));

            return TryFindItem(new ChildObjectNameString(childObjectName), out holder);
        }

        public TUIHolder FindItem(IChildObjectNameString childObjectNameString)
        {
            if (childObjectNameString == null)
                throw new ArgumentNullException(nameof(childObjectNameString));

            return Holders.FirstOrDefault(h => h.ChildObjectName.Equals(childObjectNameString.Name));
        }

        public TUIHolder FindItem(string childObjectName)
        {
            if (string.IsNullOrWhiteSpace(childObjectName))
                throw new ArgumentException(nameof(childObjectName));

            return FindItem(new ChildObjectNameString(childObjectName));
        }
    }
}
