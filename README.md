# FFCG.Leijon.Movies
<img align="right" style="height:90px;width:140px" src="mce7_lg.jpg">

Composable.Monolithic is a framework for [Composability](https://en.wikipedia.org/wiki/Composability) in Software Development available for .NET.

Current version is 1.0, released in 2014.

[TOC]

## Installation

Git clone into your homedirectory via Powershell.

    cd ~
    cd ..
    git clone https://github.com/mlidbom/Composable.Monolithic

Once cloned to a directory, open the project and Build the solution (Ctrl + Shift + B).

> If this does not work you need to put the directory directly into your C: `cd C:\`, since windows does not allow strings longer than 260 Char (windows, please fix). See FAQ.

___
Thereafter you need to create a subdirectory to the Framework, called NuGetFeed. Here we will put the [pakets](https://fsprojects.github.io/Paket/) for NuGet.

    cd C:\
    mkdir NuGetFeed

Now we can run the package script `C:\Composable.Monolith\.buildpaket.ps1`
