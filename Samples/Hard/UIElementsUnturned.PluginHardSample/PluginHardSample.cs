using Rocket.Core.Plugins;
using SDG.Unturned;
using System.Collections.Generic;
using UIElementsUnturned.Samples.Hard.PluginHardSample.Configuration;
using UIElementsUnturned.Samples.Hard.PluginHardSample.UI.Elements.Buttons;
using UIElementsUnturned.Samples.Hard.PluginHardSample.UI.Elements.InputFields;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.Samples.Hard.PluginHardSample
{
    /// <summary>
    /// Example how to use UIElementsLib.
    /// </summary>
    public sealed class PluginHardSample : RocketPlugin<PluginHardSampleConfiguration>
    {
        private InputFieldUIHolder inputFieldUIHolder;

        private ButtonUIHolder buttonUIHolder;



        public static PluginHardSample Instance { get; private set; }



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
            buttonUIHolder.AddNew(new ActionableButton(childObjectName: "MyUIObjectName", callback: (data, uPlayer) =>
            {

            }));

            // Or like that same with input field
            inputFieldUIHolder.AddNew(new ActionableInputField(childObjectName: "MyInputField", callback: onEnterInputInMyInputFieldCallback));

            // Removing input field
            inputFieldUIHolder.Remove(inputFieldUIHolder.FindItemByName("MyInputField"));

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
            if (inputFieldUIHolder.TryFindItemByName(new ChildObjectNameString(inputField), out IInputField holder))
            {
                holder.OnEnterInput(new UPlayer(player), text);
            }
        }

        private void onButtonClicked(Player player, string button)
        {
            // When clicks button searching for button and executing it
            if (buttonUIHolder.TryFindItemByName(new ChildObjectNameString(button), out IButton holder))
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
