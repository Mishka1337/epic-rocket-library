using System;
using System.Drawing;
using ds.test.impl;

namespace ds.plugins 
{
    class SummOperator : BasePlugin, IPlugin
    {
        public string Description => "Returns summ of 2 integer values. Throws OverFlowException when summ of arguments is greater than Int32.MaxValue";

        public string Version => "1.0";

        public int Run(int input1, int input2)
        {
            if (input1 > (long)Int32.MaxValue - input2)
            {
                throw new OverflowException("The return value is out of range");
            }
            if(input1 < (long)Int32.MinValue - input2)
            {
                throw new OverflowException("The return value is out of range");
            }
            return input1 + input2;
        }
    }
}
