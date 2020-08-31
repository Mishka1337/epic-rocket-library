using System;
using Xunit;
using ds.test.impl;

namespace ds.Tests
{
    public class PluginsTests
    {
        [Fact]
        public void PassingNullGetPlugin()
        {
            IPlugin plugin = Plugins.GetPlugin(null);

            Assert.Null(plugin);
        }

        [Fact]
        public void GettingUnexistingPlugin()
        {
            IPlugin plugin = Plugins.GetPlugin("gibberish");

            Assert.Null(plugin);
        }
        [Fact]
        public void PassingEmptyStrinGetPlugin()
        {
            IPlugin plugin = Plugins.GetPlugin("");

            Assert.Null(plugin);
        }

        [Fact]
        public void PluginsCountIsGreaterThenZero()
        {
            int i = Plugins.PluginCount;

            Assert.True(i > 0);
        }

        [Fact]
        public void ExactPluginCount()
        {
            int i = Plugins.PluginCount;

            Assert.Equal(12,i);
        }

        [Fact]
        public void PluginsNamesIsNotNull()
        {
            string[] names = Plugins.GetPluginNames;

            Assert.NotNull(names);
        }
    }
}
