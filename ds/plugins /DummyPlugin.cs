using ds.test.impl;

namespace ds.plugins
{
    internal class DummyPlugin : BasePlugin, IPlugin
    {
        public string Version => "-2.0";

        public string Description => "This is dummy plugin, dont use it";

        public int Run(int input1, int input2)
        {
            return input1;
        }
    }
}