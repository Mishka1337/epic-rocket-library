using ds.test.impl;

namespace ds.plugins
{
    internal class LeftBitShift : BasePlugin, IPlugin
    {
        public string Version => "1.0";

        public string Description => 
                    "returns first value shifted on `input2` bits left";

        public int Run(int input1, int input2)
        {
            return input1 << input2;
        }
    }
}