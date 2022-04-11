﻿using System.Collections.Generic;
using UIElementsLib.Core.UI.InputField;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.Base;

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
