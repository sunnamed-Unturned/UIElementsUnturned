using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;

namespace UIElementsUnturned.UIElementsLib.Core.UI.InputFields
{
    /// <summary>
    /// Provides a mechanism for input fields.
    /// </summary>
    public interface IInputField : IUIElement
    {
        /// <summary>
        /// Executes when player enters text in input field.
        /// </summary>
        /// <param name="executor">The player.</param>
        /// <param name="text">The text in inputfield.</param>
        void OnEnterInput(UPlayer executor, string text);
    }
}
