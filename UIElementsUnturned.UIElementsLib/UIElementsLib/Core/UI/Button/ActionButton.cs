using System;
using UIElementsLib.Core.Player;

namespace UIElementsLib.Core.UI.Button
{
    public sealed class ActionButton : IButton
    {
        public string ChildObjectName { get; }

        public Action<UPlayer> OnClickCallback { get; }



        public ActionButton(string childObjectName, Action<UPlayer> onClickCallback)
        {
            if (string.IsNullOrEmpty(childObjectName))
                throw new ArgumentNullException(nameof(childObjectName));

            if (onClickCallback == null)
                throw new ArgumentNullException(nameof(onClickCallback));

            ChildObjectName = childObjectName;
            OnClickCallback = onClickCallback;
        }



        void IButton.OnClick(UPlayer executor)
        {
            OnClickCallback?.Invoke(executor);
        }
    }
}
