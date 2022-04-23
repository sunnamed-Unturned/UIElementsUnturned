using System;
using UIElementsLib.Core.UI.Element;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackable
{
    /// <summary>
    /// Empty Callback for UI Elements.
    /// </summary>
    public interface IActionableUIElement : IUIElement
    {
        Action Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 1 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1> : IUIElement
    {
        Action<TCallbackArgument1> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 2 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 3 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 4 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 5 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 6 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 7 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 8 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 9 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 10 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 11 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 12 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 13 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 14 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13, in TCallbackArgument14> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13, TCallbackArgument14> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 15 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13, in TCallbackArgument14, in TCallbackArgument15> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13, TCallbackArgument14, TCallbackArgument15> Callback { get; }
    }

    /// <summary>
    /// Callback for UI Elements with 16 generic parameters.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13, in TCallbackArgument14, in TCallbackArgument15, in TCallbackArgument16> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13, TCallbackArgument14, TCallbackArgument15, TCallbackArgument16> Callback { get; }
    }
}
