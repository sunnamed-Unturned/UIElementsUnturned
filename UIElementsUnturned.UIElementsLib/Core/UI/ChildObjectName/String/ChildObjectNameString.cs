using System;

namespace UIElementsUnturned.UIElementsLib.Core.UI.ChildObjectName.String
{
    public sealed class ChildObjectNameString : IChildObjectNameString
    {
        public ChildObjectNameString(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ArgumentException(nameof(name));

            Name = name;
        }



        public string Name { get; }
    }
}
