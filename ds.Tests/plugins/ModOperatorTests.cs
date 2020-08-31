using System;
using Xunit;
using ds.test.impl;

namespace ds.Tests
{
    public class ModOperatorTests
    {
        [Fact]
        public void ModuloOfZero()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.ModOperator");
            Assert.Throws<DivideByZeroException>(() =>plugin.Run(1,0));
        }
    }
}