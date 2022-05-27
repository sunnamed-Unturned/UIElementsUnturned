using Rocket.API;
using UIElementsUnturned.UIElementsLib.Core.UI.Arguments;

namespace UIElementsUnturned.Samples.Hard.PluginHardSample.Configuration
{
    public sealed class PluginConfiguration : IRocketPluginConfiguration
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
