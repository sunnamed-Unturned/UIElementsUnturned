using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base;
using UIElementsUnturned.UIElementsLib.Core.UI.InputField;

namespace UIElementsUnturned.UIElementsLibPluginExample.UI.InputField.Holders
{
    public sealed class InputFieldUIHolder : UIHolderBase<IInputField>
    {
        public InputFieldUIHolder(IEnumerable<IInputField> items) : base(items)
        {
        }

        public InputFieldUIHolder() : this(null)
        {
        }
    }
}
