using System.Drawing;
using ds.test.impl;

namespace ds.plugins
{
    internal class ModOperator : BasePlugin, IPlugin
    {
        public string Version => "1.0";

        public string Description => 
                "returns the remainder of a division of first value by second. Throws DividedByZeroException when second argument is zero";

        public int Run(int input1, int input2)
        {
            return input1 % input2;
        }
    }
}