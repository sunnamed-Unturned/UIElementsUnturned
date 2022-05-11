namespace UIElementsUnturned.UIElementsLib.Core.UI.Arguments
{
    public sealed class EffectArguments : IEffectArguments
    {
        public EffectArguments(ushort id, short key)
        {
            Id = id;
            Key = key;
        }



        public ushort Id { get; }

        public short Key { get; }
    }
}
