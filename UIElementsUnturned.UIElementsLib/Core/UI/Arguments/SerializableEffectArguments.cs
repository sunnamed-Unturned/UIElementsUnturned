using System;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Arguments
{
    [Serializable]
    public sealed class SerializableEffectArguments : IEffectArguments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableEffectArguments"/> class.
        /// </summary>
        /// <param name="id">An effect id.</param>
        /// <param name="key">An effect key.</param>
        public SerializableEffectArguments(ushort id, short key)
        {
            Id = id;
            Key = key;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SerializableEffectArguments"/> class.
        /// </summary>
        public SerializableEffectArguments()
        {
        }



        public ushort Id { get; set; }

        public short Key { get; set; }
    }
}
