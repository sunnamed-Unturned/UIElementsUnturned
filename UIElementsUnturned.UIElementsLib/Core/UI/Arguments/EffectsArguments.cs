namespace UIElementsUnturned.UIElementsLib.Core.UI.Arguments
{
    public sealed class EffectArguments : IEffectArguments
    {
        public ushort Id { get; }

        public short Key { get; }



        public EffectArguments(ushort id, short key)
        {
            Id = id;
            Key = key;
        }
    }
}
