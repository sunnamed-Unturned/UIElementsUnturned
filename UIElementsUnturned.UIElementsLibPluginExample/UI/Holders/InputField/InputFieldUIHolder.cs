using System.Collections.Generic;
using UIElementsLib.Core.UI.Holder.Base;
using UIElementsLib.Core.UI.InputField;

namespace UIElementsLibPluginExample.UI.InputField.Holders
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
