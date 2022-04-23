using System;
using UIElementsLib.Core.UI.InputField;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackable.InputField
{
    public sealed class ActionableInputField : IActionableUIElement<IUIObjectDataContainer, UPlayer, string>, IInputField
    {
        public string ChildObjectName { get; }

        public Action<IUIObjectDataContainer, UPlayer, string> Callback { get; }



        /// <summary>
        /// Constructor of <see cref="ActionableInputField"/>.
        /// Working same as another constructor, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be used.
        /// </summary>
        /// <param name="childObjectNameString">Child object name string.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableInputField(ChildObjectNameString childObjectNameString, Action<IUIObjectDataContainer, UPlayer, string> callback)
        {
            if (childObjectNameString == null)
                throw new ArgumentNullException(nameof(childObjectNameString));

            ChildObjectName = childObjectNameString.Name;
            Callback = callback ?? throw new ArgumentNullException(nameof(callback));
        }



        /// <summary>
        /// Constructor of <see cref="ActionableInputField"/>.
        /// Uses another Constructor.
        /// </summary>
        /// <param name="childObjectName">Child object name.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableInputField(string childObjectName, Action<IUIObjectDataContainer, UPlayer, string> callback) : this(new ChildObjectNameString(childObjectName), callback)
        {
        }



        void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            Callback?.Invoke(this, executor, text);
        }
    }
}
