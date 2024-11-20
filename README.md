# TeamCityRestApi

## Overview

The `TeamcityRestConnector` is a F# library designed to interact with the TeamCity REST API. It provides a comprehensive set of functionalities to manage and retrieve information from TeamCity, including projects, builds, users, VCS roots, agents, and more.

## Features

- Retrieve and manage TeamCity projects, builds, users, VCS roots, and agents.
- Trigger and cancel builds.
- Download build artifacts.
- Mute and unmute tests.
- Retrieve build logs and pending changes.
- Authenticate with TeamCity.

## Requirements

- .NET Standard 2.0 or .NET Framework 4.7.2
- F# Compiler
- RestSharp library

## Installation

To use the `TeamcityRestConnector` in your project, you need to add the necessary dependencies. Ensure you have the following packages installed:

- RestSharp

You can install RestSharp via NuGet:

dotnet add package RestSharp


## Usage

### Initialization

To use the `TeamcityRestConnector`, you need to create an instance of the `TeamcityConnector` class by providing an implementation of the `IHttpTeamcityConnector` interface.

open TeamcityRestConnector
let httpConnector = // Your implementation of IHttpTeamcityConnector let teamcityConnector = TeamcityConnector(httpConnector)


### Example: Trigger a Build

let buildConfigId = "YourBuildConfigId" let branch = "YourBranchName" let comment = "Triggering build via API" let parameters = System.Collections.Generic.Dictionary<string, string>() parameters.Add("param1", "value1")
let webUrl, href = teamcityConnector.TriggerTeamcityBuild(config, buildConfigId, branch, comment, parameters) printfn "Build triggered. Web URL: %s, Href: %s" webUrl href

### Example: Download Artifact

let build = // Your TcBuild instance let artifactPath = "path/to/artifact" let outputFilePath = "path/to/output/file" let useDisk = true
teamcityConnector.DownloadArtifact(config, build, artifactPath, outputFilePath, useDisk)


## Contributing

Contributions are welcome! Please feel free to submit a pull request or open an issue to discuss any changes or improvements.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.

## Contact

For any questions or inquiries, please contact the project maintainers.


