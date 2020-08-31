using ds.test.impl;

namespace ds.plugins
{
    internal class BitwiseXor : BasePlugin, IPlugin
    {
        public string Version => "1.0";

        public string Description =>
                    "returns result of bitwise xor over first and second values";

        public int Run(int input1, int input2)
        {
            return input1 ^ input2;
        }
    }
}