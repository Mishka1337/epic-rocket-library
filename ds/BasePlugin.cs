using System.Reflection;
using System.IO;
using System.Drawing;
using System.Linq;
using System;

namespace ds.test.impl
{
    internal abstract class BasePlugin
    {
        public string PluginName => this.GetType().FullName;
        
        public System.Drawing.Image Image {
            get 
            {
                if (this.image != null)
                {
                    return this.image;
                }
                var assembly = typeof(Plugins).Assembly;
                var resourceName = assembly.GetManifestResourceNames()
                                           .SingleOrDefault(str => str.EndsWith(this.PluginName + ".png"));
                if (resourceName == null || resourceName == "")
                {
                    this.image = BasePlugin.DefaultImage;
                    return this.image;
                }
                try 
                {
                    var imageStream = assembly.GetManifestResourceStream(resourceName);
                    this.image = Image.FromStream(imageStream);
                    return this.image;
                }
                catch (Exception)
                {
                    this.image = BasePlugin.DefaultImage;
                    return this.image;
                }

            }
        }

        private System.Drawing.Image image;

        private static System.Drawing.Image defaultImage;
        
        private static System.Drawing.Image DefaultImage
        {
            get
            {
                if (defaultImage != null)
                {
                    return defaultImage;
                }
                var assembly = typeof(Plugins).Assembly;
                var imageStream = assembly.GetManifestResourceStream("ds.resources.default.png");
                defaultImage = Image.FromStream(imageStream);
                return defaultImage;
            }
        }
    }
}