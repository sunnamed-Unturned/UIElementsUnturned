using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Element;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Button
{
    /// <summary>
    /// Button UI Element.
    /// </summary>
    public interface IButton : IUIElement
    {
        /// <summary>
        /// Executes when player clicks.
        /// </summary>
        /// <param name="executor">Container of a player.</param>
        void OnClick(UPlayer executor);
    }
}
