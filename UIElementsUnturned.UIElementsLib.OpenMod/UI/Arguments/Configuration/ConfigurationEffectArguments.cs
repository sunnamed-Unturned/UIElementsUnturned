using Microsoft.Extensions.Configuration;
using System;
using UIElementsUnturned.UIElementsLib.Core.UI.Arguments;

namespace UIElementsUnturned.UIElementsLib.OpenMod.UI.Arguments.Configuration
{
    public sealed class ConfigurationEffectArguments : IEffectArguments
    {
        private readonly IConfiguration configuration;

        public ConfigurationEffectArguments(IConfiguration configuration, string sectionName)
        {
            if (configuration == null)
            {
                throw new ArgumentNullException(nameof(configuration));
            }

            if (string.IsNullOrWhiteSpace(sectionName))
            {
                throw new ArgumentException(nameof(sectionName));
            }

            this.configuration = configuration.GetSection(sectionName);
        }



        ushort IEffectArguments.Id => configuration.GetValue(nameof(IEffectArguments.Id), default(ushort));

        short IEffectArguments.Key => configuration.GetValue(nameof(IEffectArguments.Key), default(short));
    }
}
