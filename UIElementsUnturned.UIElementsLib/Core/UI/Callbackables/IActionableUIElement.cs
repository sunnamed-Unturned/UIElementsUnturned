using System;
using UIElementsUnturned.UIElementsLib.Core.UI.Elements;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackables
{
    /// <summary>
    /// Encapsulates a a method that has no parameters and does not return a value;
    /// </summary>
    public interface IActionableUIElement : IUIElement
    {
        Action Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has a single parameter and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1> : IUIElement
    {
        Action<TCallbackArgument1> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has two parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has three parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has four parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has five parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has six parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has seven parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has eight parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has nine parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has 10 parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has 11 parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has 12 parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has 13 parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has 14 parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13, in TCallbackArgument14> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13, TCallbackArgument14> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has 15 parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13, in TCallbackArgument14, in TCallbackArgument15> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13, TCallbackArgument14, TCallbackArgument15> Callback { get; }
    }

    /// <summary>
    /// Encapsulates a method that has 16 parameters and does not return a value.
    /// </summary>
    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10, in TCallbackArgument11, in TCallbackArgument12, in TCallbackArgument13, in TCallbackArgument14, in TCallbackArgument15, in TCallbackArgument16> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10, TCallbackArgument11, TCallbackArgument12, TCallbackArgument13, TCallbackArgument14, TCallbackArgument15, TCallbackArgument16> Callback { get; }
    }
}
