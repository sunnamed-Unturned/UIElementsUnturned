using System;
using UIElementsLib.Core.UI.Element;

namespace UIElementsUnturned.UIElementsLib.Core.UI.Callbackable
{
    public interface IActionableUIElement : IUIElement
    {
        Action Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1> : IUIElement
    {
        Action<TCallbackArgument1> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8> Callback { get; }
    }

    public interface IActionableUIElement<in TCallbackArgument1, in TCallbackArgument2, in TCallbackArgument3, in TCallbackArgument4, in TCallbackArgument5, in TCallbackArgument6, in TCallbackArgument7, in TCallbackArgument8, in TCallbackArgument9, in TCallbackArgument10> : IUIElement
    {
        Action<TCallbackArgument1, TCallbackArgument2, TCallbackArgument3, TCallbackArgument4, TCallbackArgument5, TCallbackArgument6, TCallbackArgument7, TCallbackArgument8, TCallbackArgument9, TCallbackArgument10> Callback { get; }
    }
}
