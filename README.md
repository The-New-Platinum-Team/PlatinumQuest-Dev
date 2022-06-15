# PlatinumQuest

[![CircleCI](https://circleci.com/gh/The-New-Platinum-Team/BuildScript/tree/master.svg?style=svg&circle-token=2796eaa02014aa233f951392542a1a0ef6fd21f9)](https://circleci.com/gh/The-New-Platinum-Team/BuildScript/tree/master)

This is the main repository for the public release of the game data and scripts for PQ ([old repository here](https://github.com/PlatinumTeam/PlatinumQuest)).

See [MBExtender](https://github.com/RandomityGuy/MBExtender) for the C++ engine modification source code ([old repository here](https://github.com/PlatinumTeam/MBExtender)).

For new developers this should *not* be downloaded from the GitHub website, but cloned with git (or a git client such as VSCode or GitHub Desktop), which has an interface that lets you easily update it and sync your local files to this repository.

## Running
To run this, you need a copy of the latest game executables. Get them from [PQ Binaries repository](https://github.com/The-New-Platinum-Team/PQBinaries). Copy the files in the platform specific folders to `Marble Blast Platinum` folder. Or, if you want to build the plugins from source, clone and build [MBExtender](https://github.com/The-New-Platinum-Team/MBExtender-Dev) and install it into `Marble Blast Platinum`.

## License
MIT License for all PQ script files and shaders. See the headers of individual files for further details.

Assets are released here but not under any license. Contact us if you want to use them for your own purposes.

## Contributing
While there's no formal CLA, your contributions, if included, will also be released here under the MIT license and included in binary form in the game.

There is no linter for Torque Script, but we do have a coding style used throughout the project. Please try to follow it.
