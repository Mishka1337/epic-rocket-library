using System;
using ds.test.impl;

namespace ds.plugins
{
    internal class AvrOperator : BasePlugin, IPlugin
    {
        public string Version => "1.0";

        public string Description => "returns rounded average of two values";

        public int Run(int input1, int input2)
        {
            return (int)(((long)input1 + input2) / 2);
        }
    }

}