using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holder.Button
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
