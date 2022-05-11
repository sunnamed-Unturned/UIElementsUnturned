using System;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Arguments
{
    [Serializable]
    public sealed class SerializableEffectArguments : IEffectArguments
    {
        public SerializableEffectArguments(ushort id, short key)
        {
            Id = id;
            Key = key;
        }

        public SerializableEffectArguments()
        {
        }



        public ushort Id { get; set; }

        public short Key { get; set; }
    }
}
