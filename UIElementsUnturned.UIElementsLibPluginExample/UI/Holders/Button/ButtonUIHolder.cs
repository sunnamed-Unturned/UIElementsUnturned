using System.Collections.Generic;
using UIElementsLib.Core.UI.Button;
using UIElementsLib.Core.UI.Holder.Base;

namespace UIElementsLibPluginExample.UI.Holders.Button
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
