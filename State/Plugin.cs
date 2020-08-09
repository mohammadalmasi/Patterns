namespace State
{
    public class Plugin : IPlugin
    {
        PluginState State { get; set; }

        public Plugin()
        {
            State = new PluginStarted();
        }
        public PluginState Stop()
        {
            return State.Stop();
        }
        public PluginState Start()
        {
            return State;
        }
        public PluginState Pause()
        {
            //if (State is PluginStarted)
            //    State = State.Pause();

            //else if (State is PluginResumed)
            //    State = new PluginResumed().Pause();

            return new PluginPaused().Pause();
        }
        public PluginState Resume()
        {
            return new PluginResumed().Resume();
        }
        public PluginState Finish()
        {
            return new PluginFinished().Finish();
        }
    }
}
