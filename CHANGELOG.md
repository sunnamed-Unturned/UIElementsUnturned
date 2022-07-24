| Versions: |
| - |
| [v3.5.0](#v350) |
| [v3.4.0](#v340) |
| [v3.3.0](#v330) |
| [v1.1.0](#v110) |
| [v1.0.3](#v103) |
| [v1.0.2](#v102) |
| [v1.0.1](#v101) |
| [v1.0.0](#v100) |

---

### v3.5.0:
#### Added:
* Now UIElementsLib is a full Core of a library.
* RocketMod version.

#### Removed:
* PlayerUIElementsListenerContainer and moved to RocketMod version.

#### Changed:
* Documentation.
* Summaries.

### v3.4.0:
#### Added: 
* Create new sample with OpenMod [issue #35](https://github.com/sunnamed434/UIElementsUnturned/issues/35).
* IUIHolder should be a bit refactored [issue #33](https://github.com/sunnamed434/UIElementsUnturned/issues/33).
* Added special suportage for OpenMod.

### v3.3.0:
#### Added: 
* IActionableUIElement new generics [issue #6](https://github.com/sunnamed434/UIElementsUnturned/issues/6).
* IUIHolder add new methods [issue 17](https://github.com/sunnamed434/UIElementsUnturned/issues/17).

#### Fixed:
* IUIHolder not right describes documentation [issue 16](https://github.com/sunnamed434/UIElementsUnturned/issues/16).
* IActionableUIElement does not contain interface with 9 generics  [issue #12](https://github.com/sunnamed434/UIElementsUnturned/issues/12).
* UIHolderBase problems [issue #4](https://github.com/sunnamed434/UIElementsUnturned/issues/4).
* Scatter classes and do it visible in folder, avoid contain it under interface [issue 18](https://github.com/sunnamed434/UIElementsUnturned/issues/18).
* IUIElement and IInputField are have incorrect namespace [issue 19](https://github.com/sunnamed434/UIElementsUnturned/issues/19).

#### Changed: 
* ActionableButton & ActionableInputField.
* PlayerUIElementsListenerContainer.
* UPlayer.
* Actionables accepts object instance instead of IUIObjectDataContainer.
* Everywhere in code updated documentation comments [issue #9](https://github.com/sunnamed434/UIElementsUnturned/issues/9).
* Project migration to .NET Core (lib and plugins still on .NET Framework 4.7.2), made only to simplify work with new C# versions and nuget packages pushes.
* Migrated to C# 9.0.

#### Removed:
* ActionButton & ActionInputField (they were obsolete).

### v1.1.0:
#### Changed: 
* Now lib follow [Semantic Versioning (issue)](https://github.com/sunnamed434/UIElementsUnturned/issues/7).
* Nuget updated.
* Lib version reset from 1.0.3 to v1.1.0.0.

### v.1.0.2:
#### Changed:
* UPlayer constructor accepts only SDG.Unturned.Player. (its makes lib independent from RocketMod)
* Lib independent from RocketMod.

### v1.0.1:
#### Added: 
* PlayerUIElementsListenerContainer as well as IUIElementsContainer (special for easy usage of lib).
* New project with examples how to use lib in simple and fast way.
* Default example
* Fast & simple example.

#### Changed:
* All libraries to the latest versions.
* Documentation.

### v1.0.0:
* First Upload and Release.
