using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using UIElementsUnturned.Samples.RocketMod.Easy.RocketModEasySample.UI.Buttons;
using UIElementsUnturned.Samples.RocketMod.Easy.RocketModEasySample.UI.InputFields;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;
using UIElementsUnturned.UIElementsLib.Core.UI.User.Containers.Components;

namespace UIElementsUnturned.Samples.RocketMod.Easy.RocketModEasySample
{
    /// <summary>
    /// Easy way how to use UIElementLib with RocketMod.
    /// </summary>
    public sealed class Plugin : RocketPlugin
    {
        public static Plugin Instance { get; private set; }



        protected override void Load()
        {
            Instance = this;

            // Way how to use it fast and simple
            PlayerUIElementsListenerContainer container = TryAddComponent<PlayerUIElementsListenerContainer>();

            // Or instead of TryAddComponent use gameobject.AddComponent
            // PlayerUIElementsListenerContainer container = gameObject.AddComponent<PlayerUIElementsListenerContainer>();

            // Adding button in Buttons Holder
            container.ButtonsHolder.Add(new CloseUIButton());

            // Adding input field in Input Fields Holder
            container.InputFieldsHolder.Add(new SearchInputField());

            // Simple way how to add button without creating any classes in the project
            container.ButtonsHolder.Add(new ActionableButton(childObjectName: "MyButton", callback: (data, uPlayer) =>
            {

            }));

            container.ButtonsHolder.Add(new ActionableButton(childObjectName: "MyUI", callback: onMyUIButtonClicked));

            // Simple way how to add input field without creating any classes in the project
            container.InputFieldsHolder.Add(new ActionableInputField(childObjectName: "MyUIObject", callback: (data, uPlayer, text) =>
            {

            }));

            container.InputFieldsHolder.Add(new ActionableInputField(childObjectName: "MyUITest", callback: onEnterInputInMyUIObjectInputField));
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
