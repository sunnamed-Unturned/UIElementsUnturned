using OpenMod.API.Eventing;
using OpenMod.Unturned.Players.UI.Events;
using System.Threading.Tasks;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;
using UIElementsUnturned.UIElementsLib.Core.UI.User.Containers;

namespace UIElementsUnturned.UIElementsLib.OpenMod.UI.EventsListeners
{
    public class UIEventsListener : IEventListener<UnturnedPlayerTextInputtedEvent>, IEventListener<UnturnedPlayerButtonClickedEvent>
    {
        private readonly IUIElementsContainer container;

        public UIEventsListener(IUIElementsContainerAccessor uiElementsContainerAccessor)
        {
            container = uiElementsContainerAccessor.Instance;
        }


        Task IEventListener<UnturnedPlayerTextInputtedEvent>.HandleEventAsync(object sender, UnturnedPlayerTextInputtedEvent @event)
        {
            if (container.InputFieldsHolder.TryGetItemByName(@event.TextInputName, out IInputField inputFiend))
            {
                inputFiend.OnEnterInput(new UPlayer(@event.Player.Player), @event.Text);
            }

            return Task.CompletedTask;
        }

        Task IEventListener<UnturnedPlayerButtonClickedEvent>.HandleEventAsync(object sender, UnturnedPlayerButtonClickedEvent @event)
        {
            if (container.ButtonsHolder.TryGetItemByName(@event.ButtonName, out IButton button))
            {
                button.OnClick(new UPlayer(@event.Player.Player));
            }

            return Task.CompletedTask;
        }
    }
}