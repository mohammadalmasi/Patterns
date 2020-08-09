using State;
using Xunit;

namespace Test
{
    public class State
    {
        [Fact]
        public void Check()
        {
            IPlugin plugin = new Plugin();
            PluginState result = plugin.Start();
            PluginState result1 = plugin.Stop();
            PluginState result2 = plugin.Pause();
        }
    }
}
