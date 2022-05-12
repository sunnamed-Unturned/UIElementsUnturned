| Versions: |
| - |
| [v3.3.0](#v330) |
| [v1.1.0](#v110) |
| [v1.0.3](#v103) |
| [v1.0.2](#v102) |
| [v1.0.1](#v101) |
| [v1.0.0](#v100) |

---

### v3.3.0:
* Fixed IActionableUIElement does not contain interface with 9 generics  [issue #12](https://github.com/sunnamed434/UIElementsUnturned/issues/12).
* Fixed UIHolderBase problems [issue #4](https://github.com/sunnamed434/UIElementsUnturned/issues/4).
* Added IActionableUIElement new generics [issue #6](https://github.com/sunnamed434/UIElementsUnturned/issues/6).
* Removed ActionButton & ActionInputField (they were obsolete).
* Updated ActionableButton & ActionableInputField.
* Updated PlayerUIElementsListenerContainer.
* Changed UPlayer.
* Added ChildObjectNameString. 
* Fixed IUIHolder not right describes documentation [issue 16](https://github.com/sunnamed434/UIElementsUnturned/issues/16).
* Added IUIHolder add new methods [issue 17](https://github.com/sunnamed434/UIElementsUnturned/issues/17).
* Fixed Scatter classes and do it visible in folder, avoid contain it under interface [issue 18](https://github.com/sunnamed434/UIElementsUnturned/issues/18).
* Fixed IUIElement and IInputField are have incorrect namespace [issue 19](https://github.com/sunnamed434/UIElementsUnturned/issues/19).
* Everywhere in code updated documentation comments [issue #9](https://github.com/sunnamed434/UIElementsUnturned/issues/9).
* Now Actionables accepts object instance instead of IUIObjectDataContainer.
* Project migration to .NET Core (lib and plugins still on .NET Framework 4.7.2), made only to simplify work with new C# versions and nuget packages pushes.
* Migrated to C# 9.0.

### v1.1.0:

* Now lib follow [Semantic Versioning (issue)](https://github.com/sunnamed434/UIElementsUnturned/issues/7).
* Nuget updated.
* Lib version reset from 1.0.3 to v1.1.0.0.

---

[!] Here is old versions, please see upper versions.

### v.1.0.2:
* Now UPlayer constructor accepts only SDG.Unturned.Player. (its makes lib independent from RocketMod)
* Now lib independent from RocketMod.

### v1.0.1:

* Updated all libraries to the latest versions
* Added PlayerUIElementsListenerContainer as well as IUIElementsContainer (special for easy usage of lib)
* Added new project with examples how to use lib in simple and fast way
* Updated documentation
* Added Default example
* Added Fast & simple example

### v1.0.0:

* Upload and Release
