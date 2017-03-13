# MSBuild 15 & PackageReference Bug

There are two projects:

* `ClassLibrary`. A .NET Framework 4.6.1 class library (using the SDK-style
  project type). This library depends on JSON.NET.

* `WpfApp1`. A .NET Framework 4.6.1 WPF app (using the regular MSBuild). The app
  depends on the `ClassLibrary`.

Here is the issue: when I'm using `<PackagReference>` from both projects to
JSON.NET, I can build and run in the IDE, but when I build on the command line,
I get the following error:

> C:\Program Files (x86)\Microsoft Visual Studio\2017\Enterprise\MSBuild\Microsoft\NuGet\15.0\Microsoft.NuGet.targets(197,5):
> error : The project.json is referencing the project 'ClassLibrary\ClassLibrary.csproj',
> but an output path was not specified on an item in the ProjectReferencesCreatingPackages property. [WpfApp1\WpfApp1.csproj]

However, when I'm converting the WPF app's `<PackagReference>` to
`packages.config`, the project builds on both command line and IDE. I can also
build in both environments if I remove the WPF app's dependency on JSON .NET
entirely.

So the root cause seems to be presence of the `<PackagReference>`

## Repro Steps

This repo has three branches:

* `master`. WPF app has no dependency on JSON.NET. Works.
* `packagreference`. WPF app has a dependency on JSON.NET via `<PackagReference>`.
  Broken.
* `packagesconfig`. WPF app has a dependency on JSON.NET via `packages.config`.
  Works.
