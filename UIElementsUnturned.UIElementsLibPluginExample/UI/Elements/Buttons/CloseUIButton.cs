using Rocket.API;
using SDG.Unturned;
using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Button;
using UIElementsUnturned.UIElementsLibPluginExample.Configuration;

namespace UIElementsUnturned.UIElementsLibPluginExample.UI.Elements.Buttons
{
    /// <summary>
    /// Example usage of Button.
    /// </summary>
    public sealed class CloseUIButton : IButton
    {
        /// <summary>
        /// Configuration asset field.
        /// </summary>
        private readonly IAsset<UIElementsLibPluginExampleConfiguration> configurationAsset;



        /// <summary>
        /// Injecting dependencies.
        /// </summary>
        public CloseUIButton(IAsset<UIElementsLibPluginExampleConfiguration> configurationAsset)
        {
            this.configurationAsset = configurationAsset ?? throw new ArgumentNullException(nameof(configurationAsset));
        }



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

            // Clearing our test effect
            EffectManager.askEffectClearByID(this.configurationAsset.Instance.TestEffectArguments.Id, Provider.findTransportConnection(executor.Player.CSteamID));

            // Making player screen not blurry
            executor.Player.Player.setPluginWidgetFlag(EPluginWidgetFlags.Modal, false);
        }
    }
}
