using System;
using Xunit;
using ds.test.impl;

namespace ds.Tests
{
    public class DivOperatorTests
    {
        [Fact]
        public void DivisionByZero()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.DivOperator");
            Assert.Throws<DivideByZeroException>(() => plugin.Run(1,0));
        }
    }
}