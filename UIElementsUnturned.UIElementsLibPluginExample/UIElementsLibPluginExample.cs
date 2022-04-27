using Rocket.Core.Plugins;
using SDG.Unturned;
using System.Collections.Generic;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackable.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackable.InputField;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.Holder.InputField;
using UIElementsUnturned.UIElementsLib.Core.UI.InputField;
using UIElementsUnturned.UIElementsLibPluginExample.Configuration;
using UIElementsUnturned.UIElementsLibPluginExample.UI.Elements.Buttons;
using UIElementsUnturned.UIElementsLibPluginExample.UI.Elements.InputFields;

namespace UIElementsUnturned.UIElementsLibPluginExample
{
    /// <summary>
    /// Example how to use UIElementsLib.
    /// </summary>
    public sealed class UIElementsLibPluginExample : RocketPlugin<UIElementsLibPluginExampleConfiguration>
    {
        private InputFieldUIHolder inputFieldUIHolder;

        private ButtonUIHolder buttonUIHolder;



        public static UIElementsLibPluginExample Instance { get; private set; }



        protected override void Load()
        {
            Instance = this;

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
            inputFieldUIHolder.Remove(inputFieldUIHolder.FindItem("MyInputField"));

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
            inputFieldUIHolder.FindItem(inputField)?
                .OnEnterInput(new UPlayer(player), text);
        }

        private void onButtonClicked(Player player, string button)
        {
            // When clicks button searching for button and executing it
            buttonUIHolder.FindItem(button)?
                .OnClick(new UPlayer(player));
        }

        // Called from (MyInputField)
        private void onEnterInputInMyInputFieldCallback(IUIObjectDataContainer data, UPlayer player, string text)
        {
            // UI Name
            string uiName = data.ChildObjectName;
        }
    }
}
