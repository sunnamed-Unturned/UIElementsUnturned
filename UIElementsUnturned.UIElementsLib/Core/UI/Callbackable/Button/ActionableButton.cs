using System;
using UIElementsUnturned.UIElementsLib.Core.Player;
using UIElementsUnturned.UIElementsLib.Core.UI.Button;
using UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String;
using UIElementsUnturned.UIElementsLib.Core.UI.Data;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackable.Button
{
    public sealed class ActionableButton : IActionableUIElement<object, UPlayer>, IButton
    {
        public string ChildObjectName { get; }

        public Action<object, UPlayer> Callback { get; }



        /// <summary>
        /// Constructor of <see cref="ActionableButton"/>.
        /// Working same as another constructor, but parameter <paramref name="childObjectNameString"/> doing visible exactly what needs to be used.
        /// </summary>
        /// <param name="childObjectNameString">Child object name string.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableButton(ChildObjectNameString childObjectNameString, Action<object, UPlayer> callback)
        {
            if (childObjectNameString == null)
                throw new ArgumentNullException(nameof(childObjectNameString));

            ChildObjectName = childObjectNameString.Name;
            Callback = callback ?? throw new ArgumentNullException(nameof(callback));
        }



        /// <summary>
        /// Constructor of <see cref="ActionableButton"/>.
        /// Uses another Constructor.
        /// </summary>
        /// <param name="childObjectName">Child object name.</param>
        /// <param name="callback">Callback.</param>
        /// <exception cref="ArgumentException"></exception>
        /// <exception cref="ArgumentNullException"></exception>
        public ActionableButton(string childObjectName, Action<object, UPlayer> callback) : this(new ChildObjectNameString(childObjectName), callback)
        {
        }



        void IButton.OnClick(UPlayer executor)
        {
            Callback?.Invoke(this, executor);
        }
    }
}
