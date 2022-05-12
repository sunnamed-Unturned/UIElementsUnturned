using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders.Base;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.Samples.Hard.PluginHardSample.UI.Holders.InputFields
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
