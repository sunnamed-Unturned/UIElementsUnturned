using UIElementsUnturned.UIElementsLib.Core.UI.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder;
using UIElementsUnturned.UIElementsLib.Core.UI.InputField;

namespace UIElementsUnturned.UIElementsLib.Core.UI.User.Container
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
