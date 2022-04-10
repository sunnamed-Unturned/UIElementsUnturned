using Rocket.API;
using UIElementsLib.Core.UI.Arguments;

namespace UIElementsLibPluginExample.Configuration
{
    public sealed class UIElementsLibPluginExampleConfiguration : IRocketPluginConfiguration
    {
        /// <summary>
        /// Best practice to use your effects.
        /// </summary>
        public SerializableEffectArguments TestEffectArguments;



        public void LoadDefaults()
        {
            // Creating it.
            // Your effect id, and key.
            TestEffectArguments = new SerializableEffectArguments(id: 4500, key: 600);
        }
    }
}
