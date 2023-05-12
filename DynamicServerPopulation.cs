using System.Linq;
using Oxide.Core.Plugins;
using Oxide.Core.Libraries.Covalence;

namespace Oxide.Plugins
{
    [Info("DynamicServerPopulation", "Hades.VIP", "1.0.0")]
    class DynamicServerPopulation : CovalencePlugin
    {
        void Loaded()
        {
            ConVar.Server.maxplayers = players.Connected.Count() + 1;
            Puts("DynamicServerPopulation plugin loaded. Maximum server population set to " + ConVar.Server.maxplayers);
        }

        void OnUserConnected(IPlayer player)
        {
            ConVar.Server.maxplayers = players.Connected.Count() + 1;
            Puts("User connected. Maximum server population increased to " + ConVar.Server.maxplayers);
        }

        void OnUserDisconnected(IPlayer player)
        {
            ConVar.Server.maxplayers = players.Connected.Count() + 1;
            Puts("User disconnected. Maximum server population decreased to " + ConVar.Server.maxplayers);
        }
    }
}
