using System;
using Xunit;
using ds.test.impl;
using System.Linq;
using System.Collections.Generic;

namespace ds.Tests
{
    public class IPluginTests
    {
        [Fact]
        public void PluginImageIsNotNull()
        {
            var plugin = Plugins.GetPlugin("ds.plugins.SummOperator");
                        
            Assert.NotNull(plugin.Image);
        }

        [Fact]
        public void EveryPluginHaveUniqueImage()
        {
            var images = Plugins.GetPluginNames
                        .Select(n => Plugins.GetPlugin(n))
                        .Select(p => p.Image);            
            var imagesCount = images.Count();
            var uniqueImagesCount = images.Distinct().Count();
            
            Assert.Equal(imagesCount, uniqueImagesCount);
        }
    }
    
}