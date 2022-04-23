using System.Collections.Generic;
using UIElementsLib.Core.UI.InputField;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base;

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
