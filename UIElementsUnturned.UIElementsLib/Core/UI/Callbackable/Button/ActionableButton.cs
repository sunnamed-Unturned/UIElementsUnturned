using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackable.Button
{
    public sealed class ActionableButton : IActionableUIElement<IUIObjectDataContainer, UPlayer>, IButton
    {
        public string ChildObjectName { get; }

        public Action<IUIObjectDataContainer, UPlayer> Callback { get; }



        public ActionableButton(string childObjectName, Action<IUIObjectDataContainer, UPlayer> callback)
        {
            if (string.IsNullOrEmpty(childObjectName))
                throw new ArgumentNullException(nameof(childObjectName));

            ChildObjectName = childObjectName;
            Callback = callback ?? throw new ArgumentNullException(nameof(callback));
        }



        void IButton.OnClick(UPlayer executor)
        {
            Callback?.Invoke(this, executor);
        }
    }
}
