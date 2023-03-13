namespace State
{
    class PluginPaused : PluginState
    {
        internal override PluginState Stop() => new PluginStoped();
        internal override PluginState Resume() => new PluginResumed();
    }

    class PluginStoped : PluginState
    {
    }

    class PluginStarted : PluginState
    {
        internal override PluginState Pause() => new PluginPaused();
        internal override PluginState Stop() => new PluginStoped();
        internal override PluginState Start() => new PluginStarted();
    }

    class PluginResumed : PluginState
    {
        internal override PluginState Stop() => new PluginStoped();
        internal override PluginState Pause() => new PluginPaused();
    }

    class PluginFinished : PluginState
    {
        internal override PluginState Finish() => new PluginFinished();
    }

    public abstract class PluginState
    {
        internal virtual PluginState Stop() => throw new NotSupportedException();
        internal virtual PluginState Start() => throw new NotSupportedException();
        internal virtual PluginState Pause() => throw new NotSupportedException();
        internal virtual PluginState Resume() => throw new NotSupportedException();
        internal virtual PluginState Finish() => throw new NotSupportedException();
    }
}
