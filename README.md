<!-- u250403 -->

<div align="center">

  ![logo](./.github/image/logo/TingenDevDeploy_logo_320x420.png)

  ![BranchWarning](https://img.shields.io/badge/Version-2.0-seagreen?style=for-the-badge)

</div>

# About Tingen-DevDeploy

Tingen DevDeploy simple command-line utility that deploys the ***development branch*** of the ***Tingen-WebService*** repository.

Tingen DevDeploy was created to make deploying quick iterations of the Tingen Web Services for Spectrum Health Systems, so it won't work for other organizations without modification (which is fine, since I'm the only person developing Tingen anyway).

## Version 2.0

This is version 2.0 of Tingen DevDeploy, which is different than v1.x.

The biggest difference is that you can now specify the location of the Tingen-DevDeploy repository, where the staging area is, and where the respository should be deployed.

This means:

* You can deploy specific branches from the GitHub repository, or...
* You can deploy from a repository on your local machine
* You can stage/deploy using mapped drives

# Installation

Since Tingen DevDeploy is a single, portable file, all you need to do to "install" it is:

1. Download the [latest release](https://github.com/spectrum-health-systems/Tingen-DevDeploy/releases)
2. Extract Tingen DevDeploy to a location where it can be executed

# Configuration

The first time Tingen-DevDeploy is executed, it looks for the `devdeploy-config.json file`.

If the `devdeploy-config.json file` doesn't exist, one is created using the default values that will work with any standard installation of the Tingen Web Service.

## Modifying the configuration

More info soon!

# Usage

To use Tingen DevDeploy:

1. Open a command line where you extracted Tingen DevDeploy
2. Type `TingenDevDeploy`

## What Tingen-DevDeploy does

When you execute `TingenDevDeploy.exe`, it:

More info soon!