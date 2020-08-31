using System.Drawing;
using ds.test.impl;

namespace ds.plugins
{
    internal class OrdOperator : BasePlugin, IPlugin
    {
        public string Version => "1.0";

        public string Description => 
                    "Returns 1 if first value is greater than second\n 0 if values are equal\n -1 if second value is greater";

        public int Run(int input1, int input2)
        {
            if (input1 > input2)
                return 1;
            else if (input1 < input2)
                return -1;
            else return 0;
        }
    }
}