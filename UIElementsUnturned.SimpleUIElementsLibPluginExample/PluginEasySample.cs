using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using UIElementsUnturned.Samples.Easy.PluginEasySample.UI.Buttons;
using UIElementsUnturned.Samples.Easy.PluginEasySample.UI.InputFields;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;
using UIElementsUnturned.UIElementsLib.Core.UI.User.Containers.Components;

namespace UIElementsUnturned.Samples.Easy.PluginEasySample
{
    /// <summary>
    /// Example easiest way how to use UIElementsLib.
    /// </summary>
    public sealed class PluginEasySample : RocketPlugin
    {
        public static PluginEasySample Instance { get; private set; }



        protected override void Load()
        {
            Instance = this;

            // Way how to use it fast and simple
            PlayerUIElementsListenerContainer container = TryAddComponent<PlayerUIElementsListenerContainer>();

            // Or instead of TryAddComponent use gameobject.AddComponent
            // PlayerUIElementsListenerContainer container = gameObject.AddComponent<PlayerUIElementsListenerContainer>();

            // Adding button in Buttons Holder
            container.ButtonsHolder.AddNew(new CloseUIButton());

            // Adding input field in Input Fields Holder
            container.InputFieldsHolder.AddNew(new SearchInputField());

            // Simple way how to add button without creating any classes in the project
            container.ButtonsHolder.AddNew(new ActionableButton(childObjectName: "MyButton", callback: (data, uPlayer) =>
            {

            }));

            container.ButtonsHolder.AddNew(new ActionableButton(childObjectName: "MyUI", callback: onMyUIButtonClicked));

            // Simple way how to add input field without creating any classes in the project
            container.InputFieldsHolder.AddNew(new ActionableInputField(childObjectName: "MyUIObject", callback: (data, uPlayer, text) =>
            {

            }));

            container.InputFieldsHolder.AddNew(new ActionableInputField(childObjectName: "MyUITest", callback: onEnterInputInMyUIObjectInputField));
        }



        // MyUI
        private void onMyUIButtonClicked(object caller, UPlayer player)
        {
            // How to get UnturnedPlayer

            UnturnedPlayer unturnedPlayer = UnturnedPlayer.FromPlayer(player.Player);
        }

        // MyUIObject
        private void onEnterInputInMyUIObjectInputField(object caller, UPlayer player, string text)
        {
            // How to get UnturnedPlayer
            UnturnedPlayer unturnedPlayer = UnturnedPlayer.FromPlayer(player.Player);

            IUIObjectDataContainer dataContainer = (IUIObjectDataContainer)caller;
            string uiName = dataContainer.ChildObjectName;

            Rocket.Core.Logging.Logger.Log("The text: " + text);
        }
    }
}
