using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Buttons;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackables.Buttons
{
    public sealed class ActionableButton : IActionableUIElement<object, UPlayer>, IButton
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ActionableButton"/> class.
        /// <br>Working same as another constructor, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be given and used.</br>
        /// </summary>
        /// <param name="childObjectNameString">Child object name string.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableButton(ChildObjectNameString childObjectNameString, Action<object, UPlayer> callback)
        {
            if (childObjectNameString == null)
            {
                throw new ArgumentNullException(nameof(childObjectNameString));
            }

            if (callback == null)
            {
                throw new ArgumentNullException(nameof(callback));
            }

            ChildObjectName = childObjectNameString.Name;
            Callback = callback;
        }

        /// <summary>
        /// Initializes a new instance of the of <see cref="ActionableButton"/> class.
        /// </summary>
        /// <param name="childObjectName">Child object name.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableButton(string childObjectName, Action<object, UPlayer> callback) : this(new ChildObjectNameString(childObjectName), callback)
        {
        }



        public string ChildObjectName { get; }

        public Action<object, UPlayer> Callback { get; }



        void IButton.OnClick(UPlayer executor)
        {
            Callback?.Invoke(this, executor);
        }
    }
}
