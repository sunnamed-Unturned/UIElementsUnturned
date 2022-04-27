using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base;
using UIElementsUnturned.UIElementsLib.Core.UI.InputField;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Holder.InputField
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
