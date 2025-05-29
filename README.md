<!-- u250529 -->

<div align="center">

  ![logo](./.github/image/logo/TingenDevDeploy_logo_320x420.png)

  ![BranchWarning](https://img.shields.io/badge/Version-v2.1-seagreen?style=for-the-badge)

</div>

# About Tingen DevDeploy

Tingen DevDeploy simple command-line utility that makes it easy to deploy the [Tingen Web Service](https://github.com/spectrum-health-systems/tingen-web-service).

## Using Tingen DevDeploy on the hosting server (recommended)

Tingen DevDeploy is intended to be used on the server that hosts the Tingen Web Service.

The Tingen DevDeploy default settings will:

* Archive the existing Tingen Web Service to `C:\Tingen_Data\DevDeploy\Archive`
* Use the the [development branch](https://github.com/spectrum-health-systems/tingen-web-service/tree/development) of the Tingen Web Service respository as a deployment source
* Stage the deployment in the `C:\Tingen_Data\DevDeploy\Stage\`
* Deploy the Tingen Web Service to `C:\Tingen\UAT\`

## Using the Tingen DevDeploy on a local workstation

You can deploy any branch of the Tingen Web Service to any target by modifying the configuration file, but please note that performance may be impacted by a number of factors.

# Installation

Since Tingen DevDeploy is a single, portable file, all you need to do to "install" it is:

1. Download the [latest release](https://github.com/spectrum-health-systems/tingen-dev-deploy/releases)
2. Extract TingenDevDeploy to a location where it can be executed

# Configuration

The first time Tingen DevDeploy is executed, it looks for the `devdeploy-config.json file`.

If the `devdeploy-config.json file` doesn't exist, one is created using the default values that will work with any standard installation of the Tingen Web Service.

## Modifying the configuration

The `devdeploy-config.json file` file contains the following configuration settings:

* ArchivePath  
  The location where the existing Tingen Web Service will be archived.

* Source  
  The location of the Tingen Web Service that will be deployed.

* SourceType  
  The type of source, either a URL or a directory path.

* StagePath  
  The location where the Tingen Web Service is staged for deployment.

* DeployPath  
  The location where the Tingen Web Service is deployed.

### ArchivePath

> Default value: `C:\Tingen_Data\DevDeploy\Archive`

This can be:

* A local directory
* A network share/mapped drive

### Source

> Default value: `https://github.com/spectrum-health-systems/Tingen-WebService/archive/refs/heads/development.zip`

This isn't necessarily a "path", since it can be either a directory or a URL.

If the RepositoryPath is a URL:
* It must point to a ".zip" file<
* It must formatted correctly

If the RepositoryPath is a directory:
* It can be a local directory
* It can be a network share/mapped drive

### SourceType

> Default value: ""

### StagingPath

> Default value: `C:\Tingen_Data\DevDeploy\Stage`

This can be:

* A local directory
* A network share/mapped drive

### Deploy Path

> Default value: `C:\Tingen\UAT`

This can be:

* A local directory
* A network share/mapped drive

# Usage

To use Tingen DevDeploy:

1. Open a command line where you extracted Tingen DevDeploy
2. Type `TingenDevDeploy`
