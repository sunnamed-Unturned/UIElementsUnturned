using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.Element;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holder
{
    public sealed class UIHolder<TUIHolder> : UIHolderBase<TUIHolder> where TUIHolder : IUIElement
    {
        public UIHolder(IEnumerable<TUIHolder> items) : base(items)
        {
        }

        public UIHolder() : base()
        {
        }
    }
}
