using System;
using Xunit;
using ds.test.impl;

namespace ds.Tests
{
    public class AvrOperatorTests
    {
        [Fact]
        public void PassingTwoMaxInt32Values()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.AvrOperator");

            var result = plugin.Run(Int32.MaxValue,Int32.MaxValue);
            Assert.Equal(Int32.MaxValue, result);
        }

        [Fact]
        public void PassingTwoMinInt32Values()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.AvrOperator");

            var result = plugin.Run(Int32.MinValue,Int32.MinValue);
            Assert.Equal(Int32.MinValue, result);
        }

        [Fact]
        public void PassingTwoRegularValues()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.AvrOperator");

            var result = plugin.Run(12521, 908934);
            var expected = (12521 + 908934) / 2;
            Assert.Equal(expected, result);
        }
        [Fact]
        public void PassingMaxMinValues()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.AvrOperator");

            var result = plugin.Run(Int32.MinValue,Int32.MaxValue);
            Assert.Equal(0, result);
        }
    }
}