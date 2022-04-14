using System;

namespace UIElementsUnturned.UIElementsLib.Core.Player
{
    /// <summary>
    /// Container of a SDG.Unturned.Player.
    /// </summary>
    public struct UPlayer
    {
        public readonly SDG.Unturned.Player Player;



        public UPlayer(SDG.Unturned.Player player)
        {
            if (player is null)
                throw new ArgumentNullException(nameof(player));

            Player = player;
        }
    }
}
