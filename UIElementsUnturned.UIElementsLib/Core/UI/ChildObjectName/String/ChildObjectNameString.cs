using System;

namespace UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String
{
    public sealed class ChildObjectNameString : IChildObjectNameString
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ChildObjectNameString"/> class.
        /// </summary>
        /// <param name="name">Name of the child object.</param>
        /// <exception cref="ArgumentException"></exception>
        public ChildObjectNameString(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
            {
                throw new ArgumentException(nameof(name));
            }

            Name = name;
        }



        public string Name { get; }
    }
}
