using AdvancedBot;
using AdvancedBot.Script;
using AdvancedBot.client;
using AdvancedBot.client.Commands;
using AdvancedBot.client.Packets;
using AdvancedBot.client.Map;
using System;
using System.Linq;
using System.Threading;
using AdvancedBot.Json;
using FastColoredTextBoxNS;

class PluginADVCommand : CommandBase
{
    private bool isToggled;
    private readonly MinecraftClient client;

    public PluginADVCommand(MinecraftClient cli)
        : base(cli, "NomePlugin", "NomePlugin - descrição do plugin.", "plugin")
    {
        isToggled = false;
        client = cli;
    }

    public override CommandResult Run(string alias, string[] args)
    {     

        Toggle();
        if (!isToggled)
        {
            client.PrintToChat("§fNomePlugin: §c§lDesativado§f.");
        }
        else
        {            
            client.PrintToChat("§fNomePlugin: §a§lAtivado§f.");
        }
        return CommandResult.Success;
    }

    public override void Tick()
    {
        if (isToggled) // Execute apenas se ainda não tiver executado
        {
            //Local dos códigos de programação
        }
    }

    private void Toggle()
    {
        isToggled = !isToggled;
    }

}
