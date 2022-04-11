using System;
using System.Collections.Generic;
using System.Linq;
using UIElementsLib.Core.UI.Element;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base
{
    public abstract class UIHolderBase<TUIHolder> : IUIHolder<TUIHolder> where TUIHolder : IUIElement
    {
        private IList<TUIHolder> holders;



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

        public TUIHolder FindItem(string childObjectName)
        {
            if (childObjectName == null)
                throw new ArgumentNullException(nameof(childObjectName));

            return holders.FirstOrDefault(h => h.ChildObjectName.Equals(childObjectName));
        }
    }
}
