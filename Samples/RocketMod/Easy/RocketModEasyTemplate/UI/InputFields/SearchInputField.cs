using Rocket.Unturned.Player;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.Samples.RocketMod.Easy.RocketModEasySample.UI.InputFields
{
    /// <summary>
    /// How to use InputField with RocketMod.
    /// </summary>
    public sealed class SearchInputField : IInputField
    {
        /// <summary>
        /// Equal this property same name of your GameObject as you have in Unity, in simple words your GameObject name. 
        /// </summary>
        public string ChildObjectName => "SearchInputField";



        /// <summary>
        /// Best practice to use it explicitly, but you can use it by default.
        /// </summary>
        /// <param name="executor">Button click executor.</param>
        void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            // executor is UnturnedPlayer - who called it
            // text - the text which player wrote in the input field

            Rocket.Core.Logging.Logger.Log("Executor Character Name: " + executor.Player.channel.owner.playerID.characterName);

            // How to get the UnturnedPlayer
            UnturnedPlayer unturnedPlayer = UnturnedPlayer.FromPlayer(executor.Player);

            Rocket.Core.Logging.Logger.Log("Executor Character Name: " + unturnedPlayer.CharacterName);
            Rocket.Core.Logging.Logger.Log("Wrote in input field next text: " + text);
        }
    }
}
