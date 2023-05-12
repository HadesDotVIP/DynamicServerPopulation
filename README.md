# DynamicServerPopulation Plugin Documentation

## Description
The DynamicServerPopulation is a plugin for Rust servers that uses the Oxide modding framework. Its purpose is to dynamically adjust the maximum server population based on the current number of connected players, ensuring that there is always room for one more player to connect.

## Installation
1. Download the `DynamicServerPopulation.cs` file.
2. Place the file in your server's `oxide/plugins` directory.
3. Restart your server or load the plugin via the Oxide console.

## Usage
Once installed, the plugin automatically adjusts the `server.maxplayers` value to match the current number of connected players + 1. For example, if there are 10 players currently connected to the server, `server.maxplayers` will be set to 11.

The plugin logs all changes to `server.maxplayers` to the server console. You can view these logs to see when players connect or disconnect and how `server.maxplayers` is adjusted in response.

## Functions

### Loaded()
This function is automatically called when the plugin is first loaded. It initializes the `playerCount` variable to the current number of players on the server and sets `server.maxplayers` to `playerCount + 1`.

### OnPlayerConnected(IPlayer player)
This function is automatically called whenever a player connects to the server. It increments `playerCount` by one and sets `server.maxplayers` to `playerCount + 1`.

### OnPlayerDisconnected(IPlayer player)
This function is automatically called whenever a player disconnects from the server. It decrements `playerCount` by one and sets `server.maxplayers` to `playerCount + 1`.

## Limitations
This plugin does not check for admin permissions or reserved slots. All players are treated equally, regardless of their status or permissions. If you have reserved slots or other special considerations, you may need to modify the plugin or use it in conjunction with other plugins to achieve the desired behavior.

## Support
If you encounter any issues while using this plugin, please contact the author via the Oxide modding community. Contributions to improve or expand this plugin are also welcome.
