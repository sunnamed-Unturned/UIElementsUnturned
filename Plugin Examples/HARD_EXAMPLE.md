## Example how use lib by Hard

[Full Example Project](https://github.com/sunnamed434/UIElementsUnturned/tree/main/UIElementsUnturned.UIElementsLibPluginExample)

```cs
/// <summary>
/// Example how to use UIElementsLib
/// </summary>
public sealed class UIElementsLibPluginExample : RocketPlugin<UIElementsLibPluginExampleConfiguration>
{
    private InputFieldUIHolder inputFieldUIHolder;

    private ButtonUIHolder buttonUIHolder;



    public static UIElementsLibPluginExample Instance { get; private set; }



    protected override void Load()
    {
        // Creating Input Fields holder
        inputFieldUIHolder = new InputFieldUIHolder(items: new List<IInputField>
        {
            new SearchInputField(),
        });

        // Creating Buttons holder
        buttonUIHolder = new ButtonUIHolder(items: new List<IButton>
        {
            new CloseUIButton(configurationAsset: Instance.Configuration),
        });

        // Adding new Button, for special tests or fast work you can use ActionButton
        buttonUIHolder.AddNew(new ActionableButton(childObjectName: "MyUIObjectName", callback: (data, uPlayer) =>
        {

        }));

        // Or like that same with input field
        inputFieldUIHolder.AddNew(new ActionableInputField(childObjectName: "MyInputField", callback: onEnterInputInMyInputFieldCallback));

        // Removing input field
        inputFieldUIHolder.Remove(inputFieldUIHolder.FindItem("MyInputField"));

        EffectManager.onEffectTextCommitted += onInputFieldTextCommitted;
        EffectManager.onEffectButtonClicked += onButtonClicked;
    }

    protected override void Unload()
    {
        EffectManager.onEffectTextCommitted -= onInputFieldTextCommitted;
        EffectManager.onEffectButtonClicked -= onButtonClicked;
    }



    private void onInputFieldTextCommitted(Player player, string inputField, string text)
    {
        // When player writes something searching for input field and executing it
        inputFieldUIHolder.FindItem(inputField)?
            .OnEnterInput(new UPlayer(player), text);
    }

    private void onButtonClicked(Player player, string button)
    {
        // When clicks button searching for button and executing it
        buttonUIHolder.FindItem(button)?
            .OnClick(new UPlayer(player));
    }

    // Called from (MyInputField)
    private void onEnterInputInMyInputFieldCallback(IUIObjectDataContainer data, UPlayer player, string text)
    {
        // UI Name
        string uiName = data.ChildObjectName;
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

### Example of using Button
```cs
/// <summary>
/// Example usage of Button.
/// </summary>
public sealed class CloseUIButton : IButton
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
    void IButton.OnClick(UPlayer executor)
    {
        // Example of using player.
        // executor.Player - this is SDG.Unturned.Player

        // Clearing our test effect
        EffectManager.askEffectClearByID(
            this.configurationAsset.Instance.TestEffectArguments.Id, 
            Provider.findTransportConnection(executor.Player.channel.owner.playerID.steamID));

        // Making player screen not blurry
        executor.Player.setPluginWidgetFlag(EPluginWidgetFlags.Modal, false);

        // How to get UnturnedPlayer
        UnturnedPlayer unturnedPlayer = UnturnedPlayer.FromPlayer(executor.Player);

        // Clearing our test effect using UnturnedPlayer
        EffectManager.askEffectClearByID(
            this.configurationAsset.Instance.TestEffectArguments.Id, 
            Provider.findTransportConnection(unturnedPlayer.CSteamID));

        // Making player screen not blurry using UnturnedPlayer
        unturnedPlayer.Player.setPluginWidgetFlag(EPluginWidgetFlags.Modal, false);
    }
}
```

### Example of using InputField
```cs
/// <summary>
/// One more example, better check CloseUIButton.
/// </summary>
public sealed class SearchInputField : IInputField
{
    public string ChildObjectName => "SearchInputField";



    void IInputField.OnEnterInput(UPlayer executor, string text)
    {
        // executor is unturnedplayer who called it
        // text - the text which player enter in input field

        Rocket.Core.Logging.Logger.Log("Executor Name: " + executor.Player.channel.owner.playerID.characterName);

        // UnturnedPlayer example
        UnturnedPlayer unturnedPlayer = UnturnedPlayer.FromPlayer(executor.Player);

        Rocket.Core.Logging.Logger.Log("Executor Name: " + unturnedPlayer.CharacterName);
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

### Easiest way
[Another example](https://github.com/sunnamed434/UIElementsUnturned/blob/main/Plugin%20Examples/FAST%26SIMPLE_EXAMPLE.md)
