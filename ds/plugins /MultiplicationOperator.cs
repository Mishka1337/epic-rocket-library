using System;
using System.Drawing;
using ds.test.impl;

namespace ds.plugins
{
    class MultiplicationOperator : BasePlugin, IPlugin
    {
        
        public string Description 
                => "Returns result of multiplying 2 integers values. Throws OverFlowException when result is out of range of int32";

        public string Version => "1.0";

        public int Run(int input1, int input2)
        {
            if (input1 > Int32.MaxValue / input2 + 1)
                throw new OverflowException("The return value is out of range");
            if (input1 < Int32.MinValue / input2 - 1)
                throw new OverflowException("The return value is out of range"); 
            return input1 * input2;
        }
    }
}