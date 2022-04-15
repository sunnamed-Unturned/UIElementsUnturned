using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Callbackable.Button;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Button
{
    [Obsolete("Use " + nameof(ActionableButton))]
    public sealed class ActionButton : IButton
    {
        public string ChildObjectName { get; }

        public Action<UPlayer> OnClickCallback { get; }



        public ActionButton(string childObjectName, Action<UPlayer> onClickCallback)
        {
            if (string.IsNullOrEmpty(childObjectName))
                throw new ArgumentNullException(nameof(childObjectName));

            ChildObjectName = childObjectName;
            OnClickCallback = onClickCallback ?? throw new ArgumentNullException(nameof(onClickCallback));
        }



        void IButton.OnClick(UPlayer executor)
        {
            OnClickCallback?.Invoke(executor);
        }
    }
}
