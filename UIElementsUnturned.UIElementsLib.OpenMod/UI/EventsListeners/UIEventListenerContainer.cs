﻿using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.UI.Events;
using System.Threading.Tasks;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.User.Containers;

namespace UIElementsUnturned.UIElementsLib.OpenMod.UI.EventsListeners
{
    public sealed class UIEventListenerContainer : IUIElementsContainer, IEventListener<UnturnedPlayerTextInputtedEvent>, IEventListener<UnturnedPlayerButtonClickedEvent>
    {
        public UIEventListenerContainer()
        {
            InputFieldsHolder = new UIHolder<IInputField>();
            ButtonsHolder = new UIHolder<IButton>();
        }



        public UIHolder<IInputField> InputFieldsHolder { get; }

        public UIHolder<IButton> ButtonsHolder { get; }



        public async Task HandleEventAsync(object sender, UnturnedPlayerButtonClickedEvent @event)
        {
            if (ButtonsHolder.TryGetItemByName(@event.ButtonName, out IButton button))
            {
                button.OnClick(new UPlayer(@event.Player.Player));
            }

            await Task.CompletedTask;
        }

        public async Task HandleEventAsync(object sender, UnturnedPlayerTextInputtedEvent @event)
        {
            if (InputFieldsHolder.TryGetItemByName(@event.TextInputName, out IInputField inputField))
            {
                inputField.OnEnterInput(new UPlayer(@event.Player.Player), @event.Text);
            }

            await Task.CompletedTask;
        }
    }
}