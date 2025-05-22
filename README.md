<!-- u250403 -->

<div align="center">

  ![logo](./.github/image/logo/TingenDevDeploy_logo_320x420.png)

  ![BranchWarning](https://img.shields.io/badge/Version-v2.0.0.rc1.250522-seagreen?style=for-the-badge)

</div>

# About Tingen-DevDeploy

Tingen DevDeploy simple command-line utility that makes it easy/fast to deploy testing versions of the Tingen Web Service.

## Version 2.0

This is **version 2.0** of Tingen DevDeploy, which is different than v1.x.

The biggest difference is that you can now specify:

* Where the Tingen Web Service repository is located
* Where the Tingen Web Service deployment will be staged
* Where the Tingen Web Service is deployed

This means:

* You can deploy specific branches from the GitHub repository
* You can deploy from a repository on your local machine
* You can stage/deploy using mapped drives

## Requirements

Tingen DevDeploy requires the [Tingen-Lieutenant project](https://github.com/spectrum-health-systems/tingen-lieutenant).

# Installation

Since Tingen DevDeploy is a single, portable file, all you need to do to "install" it is:

1. Download the [latest release](https://github.com/spectrum-health-systems/tingen-dev-deploy/releases)
2. Extract TingenDevDeploy to a location where it can be executed

# Configuration

The first time Tingen DevDeploy is executed, it looks for the `devdeploy-config.json file`.

If the `devdeploy-config.json file` doesn't exist, one is created using the default values that will work with any standard installation of the Tingen Web Service.

## Modifying the configuration

More info soon!

# Usage

To use Tingen DevDeploy:

1. Open a command line where you extracted Tingen DevDeploy
2. Type `TingenDevDeploy`

## What Tingen-DevDeploy does

When you execute `TingenDevDeploy`, it:

More info soon!