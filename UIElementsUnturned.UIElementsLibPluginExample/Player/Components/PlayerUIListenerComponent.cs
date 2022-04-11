using Rocket.Unturned.Player;
using SDG.Unturned;
using System.Collections.Generic;
using UIElementsLib.Core.UI.InputField;
using UIElementsUnturned.UIElementsLibPluginExample.UI.Elements.Buttons;
using UIElementsUnturned.UIElementsLibPluginExample.UI.Elements.InputFields;
using UIElementsUnturned.UIElementsLibPluginExample.UI.Holders.Button;
using UIElementsUnturned.UIElementsLibPluginExample.UI.InputField.Holders;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Button;

namespace UIElementsUnturned.UIElementsLibPluginExample.Player.Components
{
    /// <summary>
    /// Example how to subscribe it all holders.
    /// </summary>
    public sealed class PlayerUIListenerComponent : UnturnedPlayerComponent
    {
        private InputFieldUIHolder inputFieldUIHolder;

        private ButtonUIHolder buttonUIHolder;



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
                new CloseUIButton(UIElementsLibPluginExample.Instance.Configuration),
            });

            // Adding new Button, for special tests or fast work you can use ActionButton
            buttonUIHolder.AddNew(new ActionButton(childObjectName: "Testing", onClickCallback: (uPlayer) =>
            {
                // Code
            }));

            // Or like that same with input field
            inputFieldUIHolder.AddNew(new ActionInputField(childObjectName: "MyInputField", onEnterInputCallback: onEnterInputInMyInputFieldCallback));

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



        private void onInputFieldTextCommitted(SDG.Unturned.Player player, string inputField, string text)
        {
            // When player writes something searching for input field and executing it
            inputFieldUIHolder.FindItem(inputField)?.OnEnterInput(new UPlayer(player), text);
        }

        private void onButtonClicked(SDG.Unturned.Player player, string button)
        {
            // When clicks button searching for button and executing it
            buttonUIHolder.FindItem(button)?.OnClick(new UPlayer(player));
        }

        // Called from (MyInputField)
        private void onEnterInputInMyInputFieldCallback(UPlayer uPlayer, string text)
        {

        }
    }
}
