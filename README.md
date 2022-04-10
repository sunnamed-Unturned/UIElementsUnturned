# UIElementsUnturned
This lib will help you to easy communicate UI in Unturned with Rocket!

# About this library
This is Rocket based library that makes easy listening player UI button clicks and inputfield entering text and more.

# At all how to use it

## Examples
```cs
/// <summary>
    /// Example usage of Button.
    /// </summary>
    public class CloseUIButton : IButton
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
            this.configurationAsset = configurationAsset ?? throw new System.ArgumentNullException(nameof(configurationAsset));
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
```
