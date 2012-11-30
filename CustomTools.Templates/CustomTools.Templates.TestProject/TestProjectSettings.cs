// --------------------------------------------------------------------------------------------------------------------
// <copyright>
// Copyright © 2012 $if$($year$>2012)- $year$ $endif$$registeredorganization$
//
// Email: jim@strategicforge.com
// </copyright> 
// <summary> 
// File: TestProjectSettings.cs
// COMMENT - one line to give a brief idea of what the file does.
// </summary> 
// -------------------------------------------------------------------------------------------------------------------- 

namespace $rootnamespace$ {

    using System;
    using System.Text;
    using System.Collections.Generic;
    using System.Linq;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Optional Class with Test Project-wide initialization and cleanup settings. Use only 1 per test project.
    /// </summary>
	[TestClass]
	public class TestProjectSettings {

        /// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext { get; set; }

		#region Project-wide test attributes
        /// <summary>
        /// Optional initialization code that runs before the first test in an entire test project runs.
        /// </summary>
        /// <param name="TestContext"></param>
        [AssemblyInitialize]
        public static void TestProjectInitialize(TestContext testContext) { 
            // TODO

           // use TestContext.WriteLine(string); to write to the test output stream
        }

        /// <summary>
        /// Optional cleanup code that runs after the final test in an entire test project has run.
        /// </summary>
        [AssemblyCleanup]
        public static void TestProjectCleanup() { 
            // TODO
        }       
        #endregion
	}
}
