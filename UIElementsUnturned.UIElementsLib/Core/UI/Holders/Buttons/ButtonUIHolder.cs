using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders.Base;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holders.Buttons
{
    public sealed class ButtonUIHolder : UIHolderBase<IButton>
    {
        public ButtonUIHolder(IEnumerable<IButton> items) : base(items)
        {
        }

        public ButtonUIHolder() : this(null)
        {
        }
    }
}
