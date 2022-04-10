using Rocket.Unturned.Player;
using SDG.Unturned;
using System.Collections.Generic;
using UIElementsLib.Core.Player;
using UIElementsLib.Core.UI.Button;
using UIElementsLib.Core.UI.Holder.Button;
using UIElementsLib.Core.UI.Holder.InputField;
using UIElementsLib.Core.UI.InputField;
using UIElementsLibPluginExample.UI.Elements.Buttons;
using UIElementsLibPluginExample.UI.Elements.InputFields;

namespace UIElementsLibPluginExample.Player.Components
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
            inputFieldUIHolder = new InputFieldUIHolder(new List<IInputField>()
            {
                new SearchInputField(),
            });
            buttonUIHolder = new ButtonUIHolder(new List<IButton>
            {
                new CloseUIButton(UIElementsLibPluginExample.Instance.Configuration),
            });

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
            inputFieldUIHolder.FindItem(inputField)?.OnEnterInput(new UPlayer(player), text);
        }

        private void onButtonClicked(SDG.Unturned.Player player, string button)
        {
            buttonUIHolder.FindItem(button)?.OnClick(new UPlayer(player));
        }
    }
}
