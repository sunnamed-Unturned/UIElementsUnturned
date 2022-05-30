namespace UIElementsUnturned.UIElementsLib.Core.UI.Data
{
    /// <summary>
    /// Represents a data with Child object name of gameobject in Unity.
    /// </summary>
    public interface IUIObjectDataContainer
    {
        /// <summary>
        /// Gets the child GameObject name in Unity.
        /// </summary>
        string ChildObjectName { get; }
    }
}
