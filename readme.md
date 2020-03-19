# HOWTO Include files from Nuget package into project output

This repo shows how to solve a situation when you need to have specific files from a Nuget package in yout project output.

## Key takeout

Switch Visual Studio output to Normal in settings and observe the message and file copying events in the Output window.
To understand the difference and performance impact, edit the ```src\Framework\packages\MePackage.1.0.0\build\MeTarget.targets``` and observe the changes.

## Nuget package

Use the nuspec file located in the project src/Framework/MePackage.
Create a new package with

    nuget.exe pack MePackage.nuspec

Add to you local Nuget feed (mine at ```D:\.nuget```)

    nuget.exe add MePackage.1.0.0.nupkg -source D:\.nuget

## packages.config

When using packages.config, add an explicit reference to the target file from the Nuget package:

    <Import Project="..\packages\MePackage.1.0.0\build\MeTarget.targets" Condition="Exists('..\packages\MePackage.1.0.0\build\MeTarget.targets')" />

## PackageReference

The target file from package ```build``` folder is not included by default into the netcore project.
Since the package is not restored to a specfic location, I'm not sure how to add a target file to csproj.
