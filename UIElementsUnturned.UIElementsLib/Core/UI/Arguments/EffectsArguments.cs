namespace UIElementsUnturned.UIElementsLib.Core.UI.Arguments
{
    public sealed class EffectArguments : IEffectArguments
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EffectArguments"/> class.
        /// </summary>
        /// <param name="id">An effect id.</param>
        /// <param name="key">An effect key.</param>
        public EffectArguments(ushort id, short key)
        {
            Id = id;
            Key = key;
        }



        public ushort Id { get; }

        public short Key { get; }
    }
}
