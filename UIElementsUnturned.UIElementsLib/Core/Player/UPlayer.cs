using System;

namespace UIElementsUnturned.UIElementsLib.Core.Player
{
    /// <summary>
    /// Container of a SDG.Unturned.Player.
    /// </summary>
    public struct UPlayer
    {
        public readonly SDG.Unturned.Player Player;



        /// <summary>
        /// Constructor of <see cref="UPlayer"/>
        /// </summary>
        /// <param name="player"></param>
        /// <exception cref="ArgumentNullException"></exception>
        public UPlayer(SDG.Unturned.Player player)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
        }
    }
}
