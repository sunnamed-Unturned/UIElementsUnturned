using System;
using System.Collections.Generic;
using System.Linq;
using UIElementsLib.Core.UI.Element;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;

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
            {
                foreach (TUIHolder item in items)
                {
                    AddNew(item);
                }
            }
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

        public virtual void Remove(TUIHolder item)
        {
            if (item == null)
                throw new ArgumentNullException(nameof(item));

            if (holders.Contains(item))
                holders.Remove(item);
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
