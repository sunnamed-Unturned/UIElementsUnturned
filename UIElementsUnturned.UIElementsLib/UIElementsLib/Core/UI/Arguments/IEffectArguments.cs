using System;

namespace UIElementsLib.Core.UI.Arguments
{
    /// <summary>
    /// Model of Effect Arguments.
    /// </summary>
    public interface IEffectArguments
    {
        /// <summary>
        /// Effect id.
        /// </summary>
        ushort Id { get; }

        /// <summary>
        /// Effect key.
        /// </summary>
        short Key { get; }
    }

    public class EffectArguments : IEffectArguments
    {
        public ushort Id { get; }

        public short Key { get; }



        public EffectArguments(ushort id, short key)
        {
            Id = id;
            Key = key;
        }
    }

    [Serializable]
    public class SerializableEffectArguments : IEffectArguments
    {
        public ushort Id { get; set; }

        public short Key { get; set; }



        public SerializableEffectArguments(ushort id, short key)
        {
            Id = id;
            Key = key;
        }

        public SerializableEffectArguments()
        {

        }
    }
}
