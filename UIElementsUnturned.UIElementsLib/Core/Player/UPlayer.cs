using System;

namespace UIElementsUnturned.UIElementsLib.Core.Player
{
    /// <summary>
    /// Container of a <see cref="SDG.Unturned.Player"/>
    /// </summary>
    public struct UPlayer
    {
        public readonly SDG.Unturned.Player Player;



        /// <summary>
        /// Initializes a new instance of the of <see cref="UPlayer"/> class using the specified player.
        /// </summary>
        /// <param name="player">The player.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public UPlayer(SDG.Unturned.Player player)
        {
            Player = player ?? throw new ArgumentNullException(nameof(player));
        }
    }
}
