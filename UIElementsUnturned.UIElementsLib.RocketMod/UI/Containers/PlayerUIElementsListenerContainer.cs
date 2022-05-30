using SDG.Unturned;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Containers;
using UIElementsUnturned.UIElementsLib.Core.UI.Holders;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;
using UnityEngine;

namespace UIElementsUnturned.UIElementsLib.RocketMod.UI.Containers
{
    public sealed class PlayerUIElementsListenerContainer : MonoBehaviour, IUIElementsContainer
    {
        public UIHolder<IInputField> InputFieldsHolder { get; private set; }

        public UIHolder<IButton> ButtonsHolder { get; private set; }



        private void Awake()
        {
            InputFieldsHolder = new UIHolder<IInputField>();
            ButtonsHolder = new UIHolder<IButton>();
        }

        private void OnEnable()
        {
            EffectManager.onEffectTextCommitted += onInputFieldTextCommitted;
            EffectManager.onEffectButtonClicked += onButtonClicked;
        }

        private void OnDisable()
        {
            EffectManager.onEffectTextCommitted -= onInputFieldTextCommitted;
            EffectManager.onEffectButtonClicked -= onButtonClicked;
        }



        private void onInputFieldTextCommitted(Player player, string inputField, string text)
        {
            if (InputFieldsHolder.TryGetItemByName(new ChildObjectNameString(inputField), out IInputField holder))
            {
                holder.OnEnterInput(new UPlayer(player), text);
            }
        }

        private void onButtonClicked(Player player, string button)
        {
            if (ButtonsHolder.TryGetItemByName(new ChildObjectNameString(button), out IButton holder))
            {
                holder.OnClick(new UPlayer(player));
            }
        }
    }
}
