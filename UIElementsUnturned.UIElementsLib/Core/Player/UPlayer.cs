using Rocket.Unturned.Player;
using System;

namespace UIElementsUnturned.UIElementsLib.Core.Player
{
    /// <summary>
    /// Container of a UnturnedPlayer.
    /// </summary>
    public struct UPlayer
    {
        public readonly UnturnedPlayer Player;



        public UPlayer(UnturnedPlayer player)
        {
            if (player is null)
                throw new ArgumentNullException(nameof(player));

            Player = player;
        }

        public UPlayer(SDG.Unturned.Player player)
        {
            if (player is null)
                throw new ArgumentNullException(nameof(player));

            Player = UnturnedPlayer.FromPlayer(player);
        }
    }
}
