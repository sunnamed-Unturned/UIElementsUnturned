using Microsoft.Extensions.Logging;
using OpenMod.API.Users;
using OpenMod.Core.Users;
using OpenMod.Unturned.Users;
using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;

namespace UIElementsUnturned.Samples.OpenMod.Hard.OpenModEasyHard.UI.Buttons
{
    /// <summary>
    /// How to use Button.
    /// </summary>
    public sealed class CloseUIButton : IButton
    {
        private readonly IUserManager userManager;

        private readonly ILogger logger;



        public CloseUIButton(IUserManager userManager, ILogger logger)
        {
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            this.logger = logger ?? throw new ArgumentNullException(nameof(userManager));
        }



        /// <summary>
        /// Equal this property same name of your GameObject as you have in Unity, in simple words your GameObject name. 
        /// </summary>
        public string ChildObjectName => "CloseButton";



        /// <summary>
        /// Best practice to use it explicitly, but you can use it by default.
        /// </summary>
        /// <param name="executor">Button click executor.</param>
        async void IButton.OnClick(UPlayer executor)
        {
            IUser user = await userManager.FindUserAsync(
                KnownActorTypes.Player,
                executor.Player.channel.owner.playerID.steamID.ToString(),
                UserSearchMode.FindById);

            logger.Log(LogLevel.Debug, "Caller DisplayName: " + user.DisplayName);

            // How to get UnturnedUser
            UnturnedUser unturnedUser = (UnturnedUser)user;
        }
    }
}
