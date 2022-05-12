using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;

namespace UIElementsUnturned.UIElementsLib.Core.UI.InputFields
{
    /// <summary>
    /// InputField UI Element.
    /// </summary>
    public interface IInputField : IUIElement
    {
        /// <summary>
        /// Executes when player input text.
        /// </summary>
        /// <param name="executor">Container of a player.</param>
        /// <param name="text">Written text in inputfield.</param>
        void OnEnterInput(UPlayer executor, string text);
    }
}
