using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders.Base;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holders
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
