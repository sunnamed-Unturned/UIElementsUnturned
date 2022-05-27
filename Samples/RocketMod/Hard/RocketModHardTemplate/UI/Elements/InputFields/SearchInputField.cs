using Rocket.Unturned.Player;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.Samples.RocketMod.Hard.RocketModHardSample.UI.Elements.InputFields
{
    /// <summary>
    /// One more example, better check CloseUIButton.
    /// </summary>
    public sealed class SearchInputField : IInputField
    {
        public string ChildObjectName => "SearchInputField";



        void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            // executor is unturnedplayer who called it
            // text - the text which player enter in input field

            Rocket.Core.Logging.Logger.Log("Executor Name: " + executor.Player.channel.owner.playerID.characterName);

            // UnturnedPlayer example
            UnturnedPlayer unturnedPlayer = UnturnedPlayer.FromPlayer(executor.Player);

            Rocket.Core.Logging.Logger.Log("Executor Name: " + unturnedPlayer.CharacterName);
            Rocket.Core.Logging.Logger.Log("Wrote in inputfield next text: " + text);
        }
    }
}
