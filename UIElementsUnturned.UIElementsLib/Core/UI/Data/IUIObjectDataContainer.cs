namespace UIElementsUnturned.UIElementsLib.Core.UI.Data
{
    /// <summary>
    /// Describes a simple model of data with Child object name of gameobject in Unity.
    /// </summary>
    public interface IUIObjectDataContainer
    {
        /// <summary>
        /// Child GameObject name in Unity.
        /// </summary>
        string ChildObjectName { get; }
    }
}
