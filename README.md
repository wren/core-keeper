# What is this for

This is a way to keep mods synced between the server and clients for the game [Core Keeper](https://store.steampowered.com/app/1621690/Core_Keeper/).

## Install

Basically, you just need to:

1. download this repo, and
2. copy the two directories to the correct place on your system.

Downloading the repo can be done via your preferred git interface (`git clone https://github.com/wren/core-keeper.git`
or whatever), or via Github's zip functionality (click on green "Code" button, then "Download ZIP") if you prefer a
more manual approach.

Either way, once the files are on your system, see below for where to put them (it's different for Linux and Windows).

### Linux (including Steam Deck)

For the Steam Deck, you can copy the files via a flash drive, but that can very tedious. And you'll have to redo the
process every time the config is updated.

If you're comfortable with using a terminal and git, I recommend setting up your Steamdeck for SSH, then just running
`git pull` any time you need to update.

(This)[https://shendrick.net/Gaming/2022/05/30/sshonsteamdeck.html] is a great walkthrough of how to enable SSH on your
deck. Once you've done that, you can run a few commands to finish the setup:

#### Auto-magic way

```sh
ssh deck@steamdeck # or however you set it up
mkdir -p ~/repos/core-keeper
git clone https://github.com/wren/core-keeper.git ~/repos/core-keeper
ln -s ~/repos/core-keeper/mods ~/.local/share/Steam/steamapps/common/Core\ Keeper/CoreKeeper_Data/StreamingAssets/Mods
ln -s ~/repos/core-keeper/config "$(find ~/.config/unity3d/Pugstorm/Core\ Keeper/Steam/* -maxdepth 0 -type d | head -1)/mods"
```

After that, this is all that's needed to update to the latest config:

```sh
ssh deck@steamdeck # or however you set it up
cd ~/repos/core-keeper
git pull origin main
```

#### Manual way

1. Download these files (either via git, or via zip)
2. Copy the contents of `mods` to `~/.local/share/Steam/steamapps/common/Core\ Keeper/CoreKeeper_Data/StreamingAssets/Mods`

- Note: you might have to create the `Mods` folder

3. Copy the contents of `config` to `~/.config/unity3d/Pugstorm/Core\ Keeper/Steam/{some number}/mods`

- Note: the `{some number}` varies depending on your Steam ID, but just use the only directory in there that is a string of numbers
- Note: you might have to create the `mods` folder

4. Start the game and confirm that the main menu says something like (4 mods loaded)

### Windows

#### Auto-magic way

TODO: Is there a nice way to make use of `git pull` for this on Windows?

#### Manual Way

1. Download these files (either via git, or via zip)
2. Copy the contents of `mods` to `...\steamapps\common\Core Keeper\CoreKeeper_Data\StreamingAssets/Mods`

- Note: you might have to create the `Mods` folder

3. Copy the contents of `config` to `TODO: where does this go on Windows?`
4. Start the game and confirm that the main menu says something like (4 mods loaded)