using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.InputFields;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.InputFields
{
    public sealed class ActionableInputField : IActionableUIElement<object, UPlayer, string>, IInputField
    {
        /// <summary>
        /// Initializes a new instance of the of <see cref="ActionableInputField"/> class.
        /// <br>Working same as another constructor, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be given and used.</br>
        /// </summary>
        /// <param name="childObjectNameString">Child object name string.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableInputField(ChildObjectNameString childObjectNameString, Action<object, UPlayer, string> callback)
        {
            if (childObjectNameString == null)
                throw new ArgumentNullException(nameof(childObjectNameString));

            if (callback == null)
                throw new ArgumentNullException(nameof(callback));

            ChildObjectName = childObjectNameString.Name;
            Callback = callback;
        }

        /// <summary>
        /// Initializes a new instance of the of <see cref="ActionableInputField"/> class.
        /// </summary>
        /// <param name="childObjectName">Child object name.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableInputField(string childObjectName, Action<object, UPlayer, string> callback) : this(new ChildObjectNameString(childObjectName), callback)
        {
        }



        public string ChildObjectName { get; }

        public Action<object, UPlayer, string> Callback { get; }



        void IInputField.OnEnterInput(UPlayer executor, string text)
        {
            Callback?.Invoke(this, executor, text);
        }
    }
}
