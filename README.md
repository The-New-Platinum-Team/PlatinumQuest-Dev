# PlatinumQuest

[![CircleCI](https://circleci.com/gh/The-New-Platinum-Team/BuildScript/tree/circleci-project-setup.svg?style=svg&circle-token=a2188581bd13ccf275c4a3b19c18c2cb55f2f5e2)](https://circleci.com/gh/The-New-Platinum-Team/BuildScript/tree/circleci-project-setup)

This is the main repository for the public release of the game data and scripts for PQ ([old repository here](https://github.com/PlatinumTeam/PlatinumQuest)).

See [MBExtender](https://github.com/The-New-Platinum-Team/MBExtender-Dev) for the C++ engine modification source code ([old repository here](https://github.com/PlatinumTeam/MBExtender)).

For new developers this should *not* be downloaded from the GitHub website, but cloned with git (or a git client such as VSCode or GitHub Desktop), which has an interface that lets you easily update it and sync your local files to this repository.

## Running
1. Clone this repository through a git client, such as [GitHub Desktop](https://desktop.github.com/) or [VSCode](https://code.visualstudio.com/).
2. Pull the LFS through the command `git lfs pull`
3. Get the copies of the latest game executables from the [PQ Binaries repository](https://github.com/The-New-Platinum-Team/PQBinaries). 
4. Copy the files from the platform specific folders of the PQ Binaries repo to the `Marble Blast Platinum` folder.

If you want to build the plugins from source, clone and build [MBExtender](https://github.com/The-New-Platinum-Team/MBExtender-Dev) and install it into `Marble Blast Platinum`.

## License
MIT License for all PQ script files and shaders. See the headers of individual files for further details.

Assets are released here but not under any license. Contact us if you want to use them for your own purposes.

## Contributing
While there's no formal CLA, your contributions, if included, will also be released here under the MIT license and included in binary form in the game.

There is no linter for Torque Script, but we do have a coding style used throughout the project. Please try to follow it.
