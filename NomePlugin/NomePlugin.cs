using AdvancedBot.client;
using AdvancedBot.Plugins;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PluginADV
{
    public class PluginADV : IPlugin
    {

        PluginADVCommand cmdPlugin;

        public void onClientConnect(MinecraftClient client)
        {
            if (client.CmdManager.GetCommand("plugin") == null)
            {
                cmdPlugin = new PluginADVCommand(client);
                client.CmdManager.Commands.Add(cmdPlugin);
            }

        }

        public void onReceiveChat(string chat, byte pos, MinecraftClient client)
        { }

        public void OnReceivePacket(ReadBuffer pkt, MinecraftClient client)
        { }

        public void onSendChat(string chat, MinecraftClient client)
        { }

        public void OnSendPacket(IPacket packet, MinecraftClient client)
        { }

        public void Tick()
        { }

        public void Unload()
        { }
    }
}
