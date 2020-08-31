using System;
using Xunit;
using ds.test.impl;

namespace ds.Tests
{
    public class MultiplicationOperatorTests
    {
        [Fact]
        public void PassingTwoMaxInt32Values()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.MultiplicationOperator");

            Assert.Throws<OverflowException>(() => plugin.Run(Int32.MaxValue,Int32.MaxValue));
        }

        [Fact]
        public void PassingTwoMinInt32Values()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.MultiplicationOperator");

            Assert.Throws<OverflowException>(() => plugin.Run(Int32.MinValue,Int32.MinValue));
        }

        [Fact]
        public void PassingTwoRegularValues()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.MultiplicationOperator");

            var result = plugin.Run(12521, 32);
            var expected = (12521 * 32);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void PassingMaxMinValues()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.MultiplicationOperator");

            Assert.Throws<OverflowException>(() =>plugin.Run(Int32.MinValue,Int32.MaxValue));
        }

        [Fact]
        public void GetMaxValueAsResult()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.MultiplicationOperator");

            var result = plugin.Run(1,2147483647);
            Assert.Equal(Int32.MaxValue, result);
        }

        [Fact]
        public void GetMinValueAsResult()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.MultiplicationOperator");

            var result = plugin.Run(1,-2147483648);
            Assert.Equal(Int32.MinValue, result);
        }
    }
}