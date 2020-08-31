using System.Collections.Generic;
using System.Linq;
using System;

namespace ds.test.impl
{
    ///<summary>
    ///Main library class that is entry point to the library. 
    ///</summary>
    ///<remarks>
    ///This class encapsulates referencecs to all plugins insances.
    ///Use this class to get the names or count of all plugins
    ///or to get plugin instance by its name.
    ///</remarks>
    public static class Plugins {

        private static IEnumerable<IPlugin> registeredPlugins =>
                                            typeof(Plugins)
                                            .Assembly
                                            .GetTypes()
                                            .Where(t => t.IsClass && !t.IsAbstract && typeof(IPlugin).IsAssignableFrom(t))
                                            .Select(t => (IPlugin) Activator.CreateInstance(t));

        ///<summary>
        ///All plugins names.
        ///</summary>
        ///<value>
        ///Array of strings that contains every plugin name.
        ///</value>   
        public static string[] GetPluginNames => registeredPlugins
                                                .Select(p => p.PluginName)
                                                .ToArray();

        ///<summary>
        ///Number of plugins in library.
        ///</summary>
        ///<value>
        ///Integer value, represents plugins number.
        ///</value>
        public static int PluginCount => registeredPlugins.Count();

        ///<summary>
        ///Get plugin by its name.
        ///</summary>
        ///<returns>
        ///Instance of specified plugin or null.
        ///</returns>
        ///<param name="pluginName">Full name of plugin. Example "ds.plugins.DummyPlugin".</param>
        public static IPlugin GetPlugin(string pluginName) => registeredPlugins
                                                              .FirstOrDefault(p => p.PluginName.Equals(pluginName));
    }
}