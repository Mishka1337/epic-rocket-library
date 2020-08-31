using System;
using Xunit;
using ds.test.impl;

namespace ds.Tests
{
    public class SummOperatorTests
    {
        [Fact]
        public void PassingTwoMaxInt32Values()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.SummOperator");

            Assert.Throws<OverflowException>(() => plugin.Run(Int32.MaxValue,Int32.MaxValue));
        }

        [Fact]
        public void PassingTwoMinInt32Values()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.SummOperator");

            Assert.Throws<OverflowException>(() => plugin.Run(Int32.MinValue,Int32.MinValue));
        }

        [Fact]
        public void PassingTwoRegularValues()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.SummOperator");

            var result = plugin.Run(12521, 908934);
            var expected = (12521 + 908934);
            Assert.Equal(expected, result);
        }
        
        [Fact]
        public void PassingMaxMinValues()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.SummOperator");

            var result = plugin.Run(Int32.MinValue,Int32.MaxValue);
            Assert.Equal(-1, result);
        }

        [Fact]
        public void GetMaxValueAsResult()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.SummOperator");

            var result = plugin.Run(1,2147483646);
            Assert.Equal(Int32.MaxValue, result);
        }

        [Fact]
        public void GetMinValueAsResult()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.SummOperator");

            var result = plugin.Run(-1,-2147483647);
            Assert.Equal(Int32.MinValue, result);
        }
    }
}