using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;

namespace UIElementsUnturned.Samples.Easy.PluginEasySample.UI.Buttons
{
    /// <summary>
    /// Example usage of Button.
    /// </summary>
    public sealed class CloseUIButton : IButton
    {
        /// <summary>
        /// Equal this property same name of your GameObject as you have in Unity, in simple words your GameObject name. 
        /// </summary>
        public string ChildObjectName => "CloseButton";



        /// <summary>
        /// Best practice to use it explicitly, but you can use it by default.
        /// </summary>
        /// <param name="executor"></param>
        void IButton.OnClick(UPlayer executor)
        {
            // Example of using player.
            // executor.Player - this is UnturnedPlayer
        }
    }
}
