using Dalamud.IoC;
using Dalamud.Plugin;
using Dalamud.Plugin.Services;

namespace MinimalPlugin;

public class Plugin : IDalamudPlugin
{
    internal static Plugin Instance = null!;
    
    [PluginService] internal static IDalamudPluginInterface PluginInterface { get; private set; } = null!;
    [PluginService] internal static ICommandManager CommandManager { get; private set; } = null!;

    public Plugin()
    {
        Instance = this;
    }

    public void Dispose()
    {
    }
}