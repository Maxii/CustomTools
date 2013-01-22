// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 - 2013 Strategic Forge
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: Reflector.cs
// Simple C# reflector, great for examining Assemblies.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace CustomTools.Reflector {

    using System;
    using System.Collections;
    using System.IO;
    using System.Reflection;

    [AttributeUsage(AttributeTargets.All)]
    public class MyAttribute : Attribute {
        private string myName;
        public MyAttribute(string name) {
            myName = name;
        }
        public string Name {
            get {
                return myName;
            }
        }
    }

    /// <summary>
    /// Simple C# reflector, great for examining Assemblies. 
    /// 
    /// Usage: right click .dll file and select the AnalyzeDll batch file, or run CustomTool's 
    /// PromptToAnalyzeDll batch file and paste the path to the .dll at the prompt. Either way
    /// opens a command line window with the analysis layed out.
    /// </summary>
    public class Reflector {

        public static int Main(string[] args) {
            if (!File.Exists(args[0])) {
                Console.WriteLine("Could not find file \"{0}\"", args[0]);
                return 1;
            }

            Console.WriteLine("Listing contents of assembly \"{0}\"", args[0]);

            // Open the assembly and iterate over all the principal types:

            Assembly a = Assembly.LoadFrom(args[0]);
            Type[] types = a.GetTypes();
            foreach (Type t in types) {
                Console.WriteLine("{0}: {1}\n", t.MemberType, t);

                // Iterate over all the members:
                MemberInfo[] mbrInfoArray = t.GetMembers();
                foreach (MemberInfo mbrInfo in mbrInfoArray) {
                    Object[] attrs = mbrInfo.GetCustomAttributes(false);
                    if (attrs.Length > 0) {
                        foreach (object o in attrs)
                            Console.WriteLine("   [{0}]\n", o);
                    }
                    Console.WriteLine("   {0}: {1}\n", mbrInfo.MemberType, mbrInfo);
                }
            }

            Console.WriteLine("{0} types found\n", types.Length);
            return 0;
        }
    }
}
