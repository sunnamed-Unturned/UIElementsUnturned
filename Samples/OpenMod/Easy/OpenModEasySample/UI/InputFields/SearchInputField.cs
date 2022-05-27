using Microsoft.Extensions.Logging;
using OpenMod.API.Users;
using OpenMod.Core.Users;
using OpenMod.Unturned.Users;
using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.Samples.OpenMod.Easy.OpenModEasySample.UI.InputFields
{
    /// <summary>
    /// How to use InputField with RocketMod.
    /// </summary>
    public sealed class SearchInputField : IInputField
    {
        private readonly IUserManager userManager;

        private readonly ILogger logger;



        public SearchInputField(IUserManager userManager, ILogger logger)
        {
            this.userManager = userManager ?? throw new ArgumentNullException(nameof(userManager));
            this.logger = logger ?? throw new ArgumentNullException(nameof(userManager));
        }



        /// <summary>
        /// Equal this property same name of your GameObject as you have in Unity, in simple words your GameObject name. 
        /// </summary>
        public string ChildObjectName => "SearchInputField";



        /// <summary>
        /// Best practice to use it explicitly, but you can use it by default.
        /// </summary>
        /// <param name="executor">Button click executor.</param>
        async void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            IUser user = await userManager.FindUserAsync(
                KnownActorTypes.Player, 
                executor.Player.channel.owner.playerID.steamID.ToString(), 
                UserSearchMode.FindById);

            logger.Log(LogLevel.Debug, "Caller DisplayName: " + user.DisplayName);
            logger.Log(LogLevel.Debug, "User enter text: " + text);

            // How to get UnturnedUser
            UnturnedUser unturnedUser = (UnturnedUser)user;
        }
    }
}
