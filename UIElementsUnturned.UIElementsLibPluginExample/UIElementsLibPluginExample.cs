using Rocket.Core.Plugins;
using UIElementsLib.Core.UI.Holder.InputField;
using UIElementsLibPluginExample.Configuration;

namespace UIElementsLibPluginExample
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
