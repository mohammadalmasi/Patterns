namespace State
{
    public interface IPlugin
    {
        PluginState Stop();
        PluginState Start();
        PluginState Pause();
        PluginState Resume();
        PluginState Finish();
    }
}
