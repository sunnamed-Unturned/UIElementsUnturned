using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.UIElementsLib.Core.UI.User.Containers
{
    /// <summary>
    /// Container of UI Elements.
    /// </summary>
    public interface IUIElementsContainer
    {
        /// <summary>
        /// Input Field Holder.
        /// </summary>
        UIHolder<IInputField> InputFieldsHolder { get; }

        /// <summary>
        /// Buttons Holder.
        /// </summary>
        UIHolder<IButton> ButtonsHolder { get; }
    }
}
