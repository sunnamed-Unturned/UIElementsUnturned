using Microsoft.Extensions.DependencyInjection;
using OpenMod.API.Ioc;
using UIElementsUnturned.UIElementsLib.Core.UI.User.Containers;

namespace UIElementsUnturned.UIElementsLib.OpenMod.UI.EventsListeners
{
    [Service]
    public interface IUIElementsContainerAccessor
    {
        IUIElementsContainer Instance { get; }
    }

    [ServiceImplementation(Lifetime = ServiceLifetime.Singleton)]
    public class UIElementsContainerAccessor : IUIElementsContainerAccessor
    {
        public UIElementsContainerAccessor()
        {
            Instance = new UIEventListenerContainer();
        }

        public IUIElementsContainer Instance { get; }
    }
}