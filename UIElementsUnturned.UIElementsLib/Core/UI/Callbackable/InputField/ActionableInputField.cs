using System;
using UIElementsLib.Core.UI.InputField;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackable.InputField
{
    public sealed class ActionableInputField : IActionableUIElement<IUIObjectDataContainer, UPlayer, string>, IInputField
    {
        public string ChildObjectName { get; }

        public Action<IUIObjectDataContainer, UPlayer, string> Callback { get; }



        public ActionableInputField(string childObjectName, Action<IUIObjectDataContainer, UPlayer, string> callback)
        {
            if (string.IsNullOrEmpty(childObjectName))
                throw new ArgumentNullException(nameof(childObjectName));

            ChildObjectName = childObjectName;
            Callback = callback ?? throw new ArgumentNullException(nameof(callback));
        }



        void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            Callback?.Invoke(this, executor, text);
        }
    }
}
