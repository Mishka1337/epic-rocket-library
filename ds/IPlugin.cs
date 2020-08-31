namespace ds.test.impl
{
    ///<summary>
    ///The plugin interface.
    ///Defines contract that is implemented by each plugin in this assembly.
    ///</summary>
    ///<remarks>
    ///Using this interface, you can get the name, 
    ///version, icon, description of the plugin, 
    ///as well as the method Run that runs plugin function.
    ///</remarks>
    public interface IPlugin
    {
        ///<summary>
        ///Plugin name.
        ///</summary>
        ///<value>
        ///String that contains plugin name, which is 
        ///always specified by the internal class name.
        ///</value>
        string PluginName { get; }
        
        ///<summary>
        ///Plugin version.
        ///</summary>
        ///<value>
        ///String that contains plugin version.
        ///</value>
        string Version { get; }
        
        ///<summary>
        ///Plugin icon.
        ///</summary>
        ///<value>
        ///Image instance, which represents plugin icon.
        ///</value>
        System.Drawing.Image Image { get; }

        ///<summary>
        ///Plugin description.
        ///</summary>
        ///<value>
        ///String, that contains plugin desctription
        ///</value>
        string Description { get; }

        ///<summary>
        ///Performs plugin function
        ///</summary>
        ///<returns>
        ///int value that is result of plugin function
        ///</returns>
        ///<exception cref="System.OverflowException"> SummOperator, MultipicationOperator could throw this 
        ///exception when result value is greater than Int32.MaxValue </exception>
        ///<exception cref="System.DivideByZeroException"> DivOperator, ModOperator could throw this 
        ///exception when secons argument is zero </exception>
        int Run(int input1, int input2);
    }
}