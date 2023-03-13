using State;

namespace Tests
{
    [TestClass]
    public class State
    {
        [TestMethod]
        public void Check()
        {
            IPlugin plugin = new Plugin();
            PluginState result = plugin.Start();
            PluginState result1 = plugin.Stop();
            PluginState result2 = plugin.Pause();
        }
    }
}
