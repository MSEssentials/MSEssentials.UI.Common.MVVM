<p align="center"><img src=".gitea/readme/icon.png"/></p>

<h1 align="center">SimpleToolkit.MVVM</h1>

<h3 align="center"><b>Set of helpers, class extensions, UI controls used in my other C# projects</b></h3>

<p align="center">SimpleToolkit is package of useful classes, helpers, extensions and UI controls, I use in my C# projects. MVVM subpackage contains models and helper classes for implementing MVVM architecture.</p>

---

## Informations

> [!Important]
> **For Github users:**
>
> This is only mirror repository. All changes are first uploaded to the repository <a href="https://repos.mateuszskoczek.com/SimpleToolkit/SimpleToolkit.MVVM">here</a>. Releases are also published on original repository. However, Github repository handles issues and pull requests for better accessibility.

## NuGet registry status

<table>
    <tr>
        <th>
            Subpackage
        </th>
        <th>
            Status
        </th>
    </tr>
    <tr>
        <td>
            <b>SimpleToolkit.MVVM</b>
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.mvvm/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.MVVM?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
    <tr>
        <th colspan=2>
            Other subpackages
        </th>
    </tr>
    <tr>
        <td>
            SimpleToolkit.Extensions
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.extensions/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.Extensions?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
    <tr>
        <td>
            SimpleToolkit.Attributes
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.attributes/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.Attributes?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
    <tr>
        <td>
            SimpleToolkit.UI.Models
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.ui.models/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.UI.Models?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
    <tr>
        <td>
            SimpleToolkit.UI.WinUI.Behaviors
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.ui.winui.behaviors/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.UI.WinUI.Behaviors?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
    <tr>
        <td>
            SimpleToolkit.UI.WinUI.Converters
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.ui.winui.converters/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.UI.WinUI.Converters?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
    <tr>
        <td>
            SimpleToolkit.UI.WinUI.Controls
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.ui.winui.controls/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.UI.WinUI.Controls?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
    <tr>
        <td>
            SimpleToolkit.UI.WinUI.Helpers
        </td>
        <td>
            <a href="https://repos.mateuszskoczek.com/SimpleToolkit/-/packages/nuget/simpletoolkit.ui.winui.helpers/"><img src="https://img.shields.io/gitea/v/release/SimpleToolkit/SimpleToolkit.UI.WinUI.Helpers?gitea_url=https%3A%2F%2Frepos.mateuszskoczek.com%2F&display_name=release&label=nuget"></a>
        </td>
    </tr>
</table>

## Features

- **ObservableKeyValuePair** - observable version of KeyValuePair
- **ObservableDictionary** - observable version of Dictionary

## Installation and usage

To download package from organization package registry, you have to add new NuGet package source. You will need access details, which you can obtain by contacting the repository owner. You can also download .nupkg file from repository Releases page.

**CLI:**

```
dotnet nuget add source --name SimpleToolkit --username <username> --password <password> https://repos.mateuszskoczek.com/api/packages/SimpleToolkit/nuget/index.json
dotnet add package --source SimpleToolikt SimpleToolkit.MVVM
```

**Package reference in .csproj file:**

```
<PackageReference Include="SimpleToolkit.MVVM" Version="<version>" />
```

## Attribution and contribution

This project is open source on MIT License, so you can just copy and upload again to your repository. But according to the license, you must include information about the original author. You can find license <a href="https://repos.mateuszskoczek.com/SimpleToolkit/SimpleToolkit.MVVM/src/branch/main/LICENSE">here</a>.

However, the preferred way to contribute would be to propose improvements in a pull request, through issues, or through other means of communication.

**Other sources:**

- Icon by <a href="icons8.com">Icons8</a>