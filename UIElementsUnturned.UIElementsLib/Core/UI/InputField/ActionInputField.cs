using System;
using UIElementsUnturned.UIElementsLib.Core.Player;

namespace UIElementsLib.Core.UI.InputField
{
    public class ActionInputField : IInputField
    {
        public string ChildObjectName { get; }

        public Action<UPlayer, string> OnEnterInputCallback { get; }



        public ActionInputField(string childObjectName, Action<UPlayer, string> onEnterInputCallback)
        {
            if (string.IsNullOrEmpty(childObjectName))
                throw new ArgumentNullException(nameof(childObjectName));

            if (onEnterInputCallback is null)
                throw new ArgumentNullException(nameof(onEnterInputCallback));

            ChildObjectName = childObjectName;
            OnEnterInputCallback = onEnterInputCallback;
        }



        void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            OnEnterInputCallback?.Invoke(executor, text);
        }
    }
}
