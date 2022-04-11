﻿using UIElementsLib.Core.UI.Element;
using UIElementsUnturned.UIElementsLib.Core.Player;

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
        /// <param name="executor">container of a player</param>
        void OnClick(UPlayer executor);
    }
}