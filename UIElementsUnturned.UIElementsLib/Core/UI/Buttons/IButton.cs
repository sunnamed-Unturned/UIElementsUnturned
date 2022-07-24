using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Buttons
{
    /// <summary>
    /// Represents a Button UI Element.
    /// </summary>
    public interface IButton : IUIElement
    {
        /// <summary>
        /// Executes when player clicks.
        /// </summary>
        /// <param name="executor">Container of the player.</param>
        void OnClick(UPlayer executor);
    }
}
