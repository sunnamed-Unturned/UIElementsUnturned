using Rocket.Core.Plugins;
using Rocket.Unturned.Player;
using UIElementsLib.Core.UI.InputField;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.User.Container.Component;
using UIElementsUnturned.UIElementsLibPluginExample.Configuration;
using UIElementsUnturned.UIElementsLibPluginExample.UI.Elements.Buttons;
using UIElementsUnturned.UIElementsLibPluginExample.UI.Elements.InputFields;

namespace UIElementsUnturned.UIElementsLibPluginExample
{
    /// <summary>
    /// Example how to use UIElementsLib
    /// </summary>
    public sealed class UIElementsLibPluginExample : RocketPlugin<UIElementsLibPluginExampleConfiguration>
    {
        // Examples by next namespaces
        // UI.Elements
        // Player.Components.PlayerUIListenerComponent

        public static UIElementsLibPluginExample Instance { get; private set; }



        protected override void Load()
        {
            Instance = this;
        }
    }
}
