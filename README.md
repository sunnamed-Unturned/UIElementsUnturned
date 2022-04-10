# UIElementsUnturned
This lib will help you to easy communicate UI in Unturned with Rocket!

## About this library
This is Rocket based library that makes easy listening player UI button clicks and inputfield entering text and more.

## Examples
### Plugin
```cs
/// <summary>
/// Example how to use UIElementsLib
/// </summary>
public sealed class UIElementsLibPluginExample : RocketPlugin<UIElementsLibPluginExampleConfiguration>
{
    // Examples by next namespaces
    // UI.Elements
    // Player.Components.PlayerUIListenerComponent

    public static UIElementsLibPluginExample Instance { get; private set; }



    protected override void Load()
    {
        Instance = this;
    }
}
```
### Configuration
```cs
public sealed class UIElementsLibPluginExampleConfiguration : IRocketPluginConfiguration
{
    /// <summary>
    /// Best practice to use your effects.
    /// </summary>
    public SerializableEffectArguments TestEffectArguments;



    public void LoadDefaults()
    {
        // Creating it.
        // Your effect id, and key.
        TestEffectArguments = new SerializableEffectArguments(id: 4500, key: 600);
    }
}
```
### UI Listener Component the Heart of it
```cs
/// <summary>
/// Example how to subscribe it all holders.
/// </summary>
public sealed class PlayerUIListenerComponent : UnturnedPlayerComponent
{
    private InputFieldUIHolder inputFieldUIHolder;

    private ButtonUIHolder buttonUIHolder;



    protected override void Load()
    {
        inputFieldUIHolder = new InputFieldUIHolder(new List<IInputField>()
        {
            new SearchInputField(),
        });
        buttonUIHolder = new ButtonUIHolder(new List<IButton>
        {
            new CloseUIButton(UIElementsLibPluginExample.Instance.Configuration),
        });

        EffectManager.onEffectTextCommitted += onInputFieldTextCommitted;
        EffectManager.onEffectButtonClicked += onButtonClicked;
    }

    protected override void Unload()
    {
        EffectManager.onEffectTextCommitted -= onInputFieldTextCommitted;
        EffectManager.onEffectButtonClicked -= onButtonClicked;
    }



    private void onInputFieldTextCommitted(SDG.Unturned.Player player, string inputField, string text)
    {
        inputFieldUIHolder.FindItem(inputField)?.OnEnterInput(new UPlayer(player), text);
    }

    private void onButtonClicked(SDG.Unturned.Player player, string button)
    {
        buttonUIHolder.FindItem(button)?.OnClick(new UPlayer(player));
    }
}
```
### Example of using Button
```cs
/// <summary>
/// Example usage of Button.
/// </summary>
public class CloseUIButton : IButton
{
    /// <summary>
    /// Configuration asset field.
    /// </summary>
    private readonly IAsset<UIElementsLibPluginExampleConfiguration> configurationAsset;



    /// <summary>
    /// Injecting dependencies.
    /// </summary>
    public CloseUIButton(IAsset<UIElementsLibPluginExampleConfiguration> configurationAsset)
    {
        this.configurationAsset = configurationAsset ?? throw new ArgumentNullException(nameof(configurationAsset));
    }



    /// <summary>
    /// Equal this property same name of your GameObject as you have in Unity, in simple words your GameObject name. 
    /// </summary>
    public string ChildObjectName => "CloseButton";



    /// <summary>
    /// Best practice to use it explicitly, but you can use it by default.
    /// </summary>
    /// <param name="executor"></param>
    void IButton.OnClick(UPlayer executor)
    {
        // Example of using player.
        // executor.Player - this is UnturnedPlayer

        // Clearing our test effect
            

        // Making player screen not blurry
        executor.Player.Player.setPluginWidgetFlag(EPluginWidgetFlags.Modal, false);
    }
}
```
### Example of using InputField
```cs
// <summary>
/// One more example, better check CloseUIButton.
/// </summary>
public sealed class SearchInputField : IInputField
{
    public string ChildObjectName => "SearchInputField";



    void IInputField.OnEnterInput(UPlayer executor, string text)
    {
        // executor is unturnedplayer who called it
        // text - the text which player enter in input field

        Rocket.Core.Logging.Logger.Log("Executor Name: " + executor.Player.CharacterName);
        Rocket.Core.Logging.Logger.Log("Wrote in inputfield next text: " + text);
    }
}
```
### Button Holder
```cs
public sealed class ButtonUIHolder : UIHolderBase<IButton>
{
    public ButtonUIHolder(IEnumerable<IButton> items) : base(items)
    {
    }

    public ButtonUIHolder() : this(null)
    {
    }
}
```

### InputField Holder
```cs
public sealed class InputFieldUIHolder : UIHolderBase<IInputField>
{
    public InputFieldUIHolder(IEnumerable<IInputField> items) : base(items)
    {
    }

    public InputFieldUIHolder() : this(null)
    {
    }
}
```
