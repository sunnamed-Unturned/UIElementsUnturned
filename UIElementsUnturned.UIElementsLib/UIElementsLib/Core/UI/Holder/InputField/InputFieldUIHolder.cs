using System.Collections.Generic;
using UIElementsLib.Core.UI.Holder.Base;
using UIElementsLib.Core.UI.InputField;

namespace UIElementsLib.Core.UI.Holder.InputField
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
