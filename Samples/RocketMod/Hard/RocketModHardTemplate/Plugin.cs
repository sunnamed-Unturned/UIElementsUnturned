using Rocket.Core.Plugins;
using SDG.Unturned;
using System.Collections.Generic;
using UIElementsUnturned.Samples.Hard.PluginHardSample.Configuration;
using UIElementsUnturned.Samples.RocketMod.Hard.RocketModHardSample.UI.Elements.Buttons;
using UIElementsUnturned.Samples.RocketMod.Hard.RocketModHardSample.UI.Elements.InputFields;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.Samples.RocketMod.Hard.RocketModHardSample
{
    /// <summary>
    /// Example how to use UIElementsLib.
    /// </summary>
    public sealed class Plugin : RocketPlugin<PluginConfiguration>
    {
        private InputFieldUIHolder inputFieldUIHolder;

        private ButtonUIHolder buttonUIHolder;



        public static Plugin Instance { get; private set; }



        protected override void Load()
        {
            // Creating Input Fields holder
            inputFieldUIHolder = new InputFieldUIHolder(items: new List<IInputField>
            {
                new SearchInputField(),
            });

            // Creating Buttons holder
            buttonUIHolder = new ButtonUIHolder(items: new List<IButton>
            {
                new CloseUIButton(configurationAsset: Instance.Configuration),
            });

            // Adding new Button, for special tests or fast work you can use ActionButton
            buttonUIHolder.Add(new ActionableButton(childObjectName: "MyUIObjectName", callback: (data, uPlayer) =>
            {

            }));

            // Or like that same with input field
            inputFieldUIHolder.Add(new ActionableInputField(childObjectName: "MyInputField", callback: onEnterInputInMyInputFieldCallback));

            // Removing input field
            inputFieldUIHolder.Remove(inputFieldUIHolder.GetItemByName("MyInputField"));

            EffectManager.onEffectTextCommitted += onInputFieldTextCommitted;
            EffectManager.onEffectButtonClicked += onButtonClicked;
        }

        protected override void Unload()
        {
            EffectManager.onEffectTextCommitted -= onInputFieldTextCommitted;
            EffectManager.onEffectButtonClicked -= onButtonClicked;
        }



        private void onInputFieldTextCommitted(Player player, string inputField, string text)
        {
            // When player writes something searching for input field and executing it
            if (inputFieldUIHolder.TryGetItemByName(new ChildObjectNameString(inputField), out IInputField holder))
            {
                holder.OnEnterInput(new UPlayer(player), text);
            }
        }

        private void onButtonClicked(Player player, string button)
        {
            // When clicks button searching for button and executing it
            if (buttonUIHolder.TryGetItemByName(new ChildObjectNameString(button), out IButton holder))
            {
                holder.OnClick(new UPlayer(player));
            }
        }

        // Called from (MyInputField)
        private void onEnterInputInMyInputFieldCallback(object caller, UPlayer player, string text)
        {
            // UI Name

            IUIObjectDataContainer dataContainer = (IUIObjectDataContainer)caller;
            string uiName = dataContainer.ChildObjectName;
        }
    }
}
