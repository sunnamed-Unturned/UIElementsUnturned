using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.UIElementsLib.Core.UI.User.Containers
{
    /// <summary>
    /// Provides a container of UI Elements.
    /// </summary>
    public interface IUIElementsContainer
    {
        /// <summary>
        /// Gets the Input Field Holder.
        /// </summary>
        UIHolder<IInputField> InputFieldsHolder { get; }

        /// <summary>
        /// Gets the Buttons Holder.
        /// </summary>
        UIHolder<IButton> ButtonsHolder { get; }
    }
}
