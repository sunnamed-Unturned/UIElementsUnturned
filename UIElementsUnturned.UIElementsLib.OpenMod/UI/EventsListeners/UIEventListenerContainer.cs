using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.UI.Events;
using System.Threading.Tasks;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.User.Containers;

namespace UIElementsUnturned.UIElementsLib.OpenMod.UI.EventsListeners
{
    /// <summary>
    /// Provides a UI events listener for UI Holders.
    /// </summary>
    public sealed class UIEventListenerContainer : IUIElementsContainer, IEventListener<UnturnedPlayerTextInputtedEvent>, IEventListener<UnturnedPlayerButtonClickedEvent>
    {
        public UIEventListenerContainer()
        {
            InputFieldsHolder = new UIHolder<IInputField>();
            ButtonsHolder = new UIHolder<IButton>();
        }



        public UIHolder<IInputField> InputFieldsHolder { get; }

        public UIHolder<IButton> ButtonsHolder { get; }



        Task IEventListener<UnturnedPlayerTextInputtedEvent>.HandleEventAsync(object sender, UnturnedPlayerTextInputtedEvent @event)
        {
            if (InputFieldsHolder.TryGetItemByName(@event.TextInputName, out IInputField inputField))
            {
                inputField.OnEnterInput(new UPlayer(@event.Player.Player), @event.Text);
            }

            return Task.CompletedTask;
        }

        Task IEventListener<UnturnedPlayerButtonClickedEvent>.HandleEventAsync(object sender, UnturnedPlayerButtonClickedEvent @event)
        {
            if (ButtonsHolder.TryGetItemByName(@event.ButtonName, out IButton button))
            {
                button.OnClick(new UPlayer(@event.Player.Player));
            }

            return Task.CompletedTask;
        }
    }
}
